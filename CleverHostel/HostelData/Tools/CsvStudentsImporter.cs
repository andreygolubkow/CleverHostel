using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using CsvHelper;

using HostelData.Model.Document;
using HostelData.Model.Enums;
using HostelData.Model.Student;

namespace HostelData.Tools
{
    public class CsvStudentsImporter
    {
        private char _separator = ',';
        private char _quote = '"';
        private string _fileName;
        private string _male;
        private string _female;

        public CsvStudentsImporter(string fileName, char separator,string maleDeterminant, string femaleDetarminant)
        {
            _separator = separator;
            _fileName = fileName;
            _male = maleDeterminant;
            _female = femaleDetarminant;

        }

        //ФИО;Комната;Группа;Пол;Номер телефона
        public List<Student> ImportStudents(bool skipFirstLine)
        {
            var list = new List<Student>();
            var skip = skipFirstLine;
            foreach (var line in Parse(_fileName, Encoding.Default))
            {
                if ( skip )
                {
                    skip = false;
                    continue;
                }
                var student = new Student
                              {
                                  Name = line[0],
                                  Room = Convert.ToInt32(line[1]),
                                  Group = new Model.Student.Group()
                                          {
                                              Num = line[2]
                                          },
                                  Sex = line[3] == _female ? Sex.Female : Sex.Male,
                                  PhoneNumber = line[4],
                                  Documents = new List<Document>()
                              };
                list.Add(student);
            }
            return list;
        }



        public IEnumerable<string> ReadLines(string fileName, Encoding enc)
        {
            using (var sr = new StreamReader(fileName, enc))
                while (sr.Peek() >= 0)
                    yield return sr.ReadLine();
        }

        public static char AutoDetectSeparator(string fileName, Encoding enc)
        {
            fileName = fileName.Split(';')[0];
            using (StreamReader sr = new StreamReader(fileName, enc))
                while (sr.Peek() >= 0)
                {
                    var s = sr.ReadLine();
                    //если есть табуляции - скорее всего это и есть разделитель
                    if (s.Contains("\t")) return '\t';
                    //считаем число запятых и точек с запятыми
                    int semicolonCount = 0;
                    int commaCount = 0;
                    foreach (char c in s)
                        if (c == ';') semicolonCount++;
                        else
                        if (c == ',') commaCount++;
                    //точек с запятыми больше чем запятых
                    if (semicolonCount > commaCount) return ';';
                    return ',';
                }

            return ',';
        }

        public IEnumerable<List<string>> Parse(string fileName, Encoding enc)
        {
            foreach (var line in Parse(ReadLines(fileName, enc)))
                yield return line;
        }

        public IEnumerable<List<string>> Parse(IEnumerable<string> lines)
        {
            var e = lines.GetEnumerator();
            while (e.MoveNext())
                yield return ParseLine(e);
        }

        private List<string> ParseLine(IEnumerator<string> e)
        {
            var items = new List<string>();
            foreach (string token in GetToken(e))
                items.Add(token);
            return items;
        }

        private IEnumerable<string> GetToken(IEnumerator<string> e)
        {
            string token = "";
            State state = State.outQuote;

            again:
            foreach (char c in e.Current)
                switch (state)
                {
                    case State.outQuote:
                        if (c == _separator)
                        {
                            yield return token;
                            token = "";
                        }
                        else
                        if (c == _quote)
                            state = State.inQuote;
                        else
                            token += c;
                        break;
                    case State.inQuote:
                        if (c == _quote)
                            state = State.mayBeOutQuote;
                        else
                            token += c;
                        break;
                    case State.mayBeOutQuote:
                        if (c == _quote)
                        {
                            //кавычки внутри кавычек
                            state = State.inQuote;
                            token += c;
                        }
                        else
                        {
                            state = State.outQuote;
                            goto case State.outQuote;
                        }
                        break;
                }

            //разрыв строки внутри кавычек
            if (state == State.inQuote && e.MoveNext())
            {
                token += Environment.NewLine;
                goto again;
            }

            yield return token;
        }

        enum State { outQuote, inQuote, mayBeOutQuote }
    }
}

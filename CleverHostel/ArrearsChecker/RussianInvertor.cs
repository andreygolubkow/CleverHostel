using System.Collections.Generic;
using System.Text;

namespace ArrearsChecker
{
    public static class RussianInvertor
    {
        private static Dictionary<char,char> _engToRusDictionary = new Dictionary<char, char>()
                                                            {
                                                                    {'q','й'},
                                                                    {'w','ц'},
                                                                    {'e','у'},
                                                                    {'r','к'},
                                                                    {'t','е'},
                                                                    {'y','н'},
                                                                    {'u','г'},
                                                                    {'i','ш'},
                                                                    {'o','щ'},
                                                                    {'p','з'},
                                                                    {'[','х'},
                                                                    {']','ъ'},
                                                                    {'a','ф'},
                                                                    {'s','ы'},
                                                                    {'d','в'},
                                                                    {'f','а'},
                                                                    {'g','п'},
                                                                    {'h','р'},
                                                                    {'j','о'},
                                                                    {'k','л'},
                                                                    {'l','д'},
                                                                    {';','ж'},
                                                                    {'\'','э'},
                                                                    {'z','я'},
                                                                    {'x','ч'},
                                                                    {'c','с'},
                                                                    {'v','м'},
                                                                    {'b','и'},
                                                                    {'n','т'},
                                                                    {'m','ь'},
                                                                    {',','б'},
                                                                    {'.','ю'}
                                                            };

        public static string TryCorrectEn(this string str)
        {
            var builder = new StringBuilder();
            foreach (char c in str)
            {
                if ( _engToRusDictionary.ContainsKey(c) )
                {
                    builder.Append(_engToRusDictionary[c]);
                    continue;
                }

                builder.Append(c);
            }

            return builder.ToString();
        }
    }
}

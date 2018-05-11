namespace ArrearsCollector
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.selectPvzButton = new System.Windows.Forms.Button();
            this.selectBugdetFileButton = new System.Windows.Forms.Button();
            this.selectHostelFileButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.saveArrearsFileButton = new System.Windows.Forms.Button();
            this.saveUnknownFileButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.selectHostelFileButton);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.selectBugdetFileButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.selectPvzButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 191);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Исходные файлы";
            // 
            // selectPvzButton
            // 
            this.selectPvzButton.Location = new System.Drawing.Point(6, 50);
            this.selectPvzButton.Name = "selectPvzButton";
            this.selectPvzButton.Size = new System.Drawing.Size(75, 23);
            this.selectPvzButton.TabIndex = 1;
            this.selectPvzButton.Text = "Выбрать файл";
            this.selectPvzButton.UseVisualStyleBackColor = true;
            this.selectPvzButton.Click += new System.EventHandler(this.selectPvzButton_Click);
            // 
            // selectBugdetFileButton
            // 
            this.selectBugdetFileButton.Location = new System.Drawing.Point(6, 105);
            this.selectBugdetFileButton.Name = "selectBugdetFileButton";
            this.selectBugdetFileButton.Size = new System.Drawing.Size(75, 23);
            this.selectBugdetFileButton.TabIndex = 2;
            this.selectBugdetFileButton.Text = "Выбрать";
            this.selectBugdetFileButton.UseVisualStyleBackColor = true;
            this.selectBugdetFileButton.Click += new System.EventHandler(this.selectBugdetFileButton_Click);
            // 
            // selectHostelFileButton
            // 
            this.selectHostelFileButton.Location = new System.Drawing.Point(6, 160);
            this.selectHostelFileButton.Name = "selectHostelFileButton";
            this.selectHostelFileButton.Size = new System.Drawing.Size(75, 23);
            this.selectHostelFileButton.TabIndex = 3;
            this.selectHostelFileButton.Text = "Выбрать";
            this.selectHostelFileButton.UseVisualStyleBackColor = true;
            this.selectHostelFileButton.Click += new System.EventHandler(this.selectHostelFileButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Файл долгов ПВЗ.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Формат: ФИО \\t Долг";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Файл долгов бюджетников";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "ФИО \\t Группа \\t Статус \\t Сумма";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Файл проживающих";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Формат: ФИО \\t Комната \\t Группа";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.logTextBox);
            this.groupBox2.Location = new System.Drawing.Point(218, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(236, 191);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Лог";
            // 
            // logTextBox
            // 
            this.logTextBox.Location = new System.Drawing.Point(6, 16);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.Size = new System.Drawing.Size(224, 169);
            this.logTextBox.TabIndex = 0;
            // 
            // saveArrearsFileButton
            // 
            this.saveArrearsFileButton.Location = new System.Drawing.Point(460, 12);
            this.saveArrearsFileButton.Name = "saveArrearsFileButton";
            this.saveArrearsFileButton.Size = new System.Drawing.Size(203, 23);
            this.saveArrearsFileButton.TabIndex = 2;
            this.saveArrearsFileButton.Text = "Сохранить файл долгов";
            this.saveArrearsFileButton.UseVisualStyleBackColor = true;
            this.saveArrearsFileButton.Click += new System.EventHandler(this.saveArrearsFileButton_Click);
            // 
            // saveUnknownFileButton
            // 
            this.saveUnknownFileButton.Location = new System.Drawing.Point(460, 41);
            this.saveUnknownFileButton.Name = "saveUnknownFileButton";
            this.saveUnknownFileButton.Size = new System.Drawing.Size(203, 23);
            this.saveUnknownFileButton.TabIndex = 3;
            this.saveUnknownFileButton.Text = "Сохранить нераспознанные данные";
            this.saveUnknownFileButton.UseVisualStyleBackColor = true;
            this.saveUnknownFileButton.Click += new System.EventHandler(this.saveUnknownFileButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "\"tsv|*.tsv";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "tsv";
            this.saveFileDialog.Filter = "\"tsv|*.tsv";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 209);
            this.Controls.Add(this.saveUnknownFileButton);
            this.Controls.Add(this.saveArrearsFileButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.Text = "ArrearsCollector";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button selectPvzButton;
        private System.Windows.Forms.Button selectBugdetFileButton;
        private System.Windows.Forms.Button selectHostelFileButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox logTextBox;
        private System.Windows.Forms.Button saveArrearsFileButton;
        private System.Windows.Forms.Button saveUnknownFileButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}


namespace ClHsWinFormsApp
{
    partial class ImportStudentsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportStudentsForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ImportButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.delimitterTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.femaleTextBox = new System.Windows.Forms.TextBox();
            this.maleTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.skipFirstString = new System.Windows.Forms.CheckBox();
            this.selectSourceButton = new System.Windows.Forms.Button();
            this.sourceFileTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ImportButton);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.selectSourceButton);
            this.groupBox1.Controls.Add(this.sourceFileTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 201);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Импорт из CVS";
            // 
            // ImportButton
            // 
            this.ImportButton.Location = new System.Drawing.Point(325, 169);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(75, 23);
            this.ImportButton.TabIndex = 4;
            this.ImportButton.Text = "Импорт";
            this.ImportButton.UseVisualStyleBackColor = true;
            this.ImportButton.Click += new System.EventHandler(this.ImportButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.delimitterTextBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.femaleTextBox);
            this.groupBox2.Controls.Add(this.maleTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.skipFirstString);
            this.groupBox2.Location = new System.Drawing.Point(9, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(391, 101);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Настройки";
            // 
            // delimitterTextBox
            // 
            this.delimitterTextBox.Location = new System.Drawing.Point(270, 68);
            this.delimitterTextBox.Name = "delimitterTextBox";
            this.delimitterTextBox.Size = new System.Drawing.Size(70, 20);
            this.delimitterTextBox.TabIndex = 7;
            this.delimitterTextBox.Text = ";";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(267, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Разделитель";
            // 
            // femaleTextBox
            // 
            this.femaleTextBox.Location = new System.Drawing.Point(141, 68);
            this.femaleTextBox.Name = "femaleTextBox";
            this.femaleTextBox.Size = new System.Drawing.Size(51, 20);
            this.femaleTextBox.TabIndex = 5;
            this.femaleTextBox.Text = "Ж";
            // 
            // maleTextBox
            // 
            this.maleTextBox.Location = new System.Drawing.Point(11, 68);
            this.maleTextBox.Name = "maleTextBox";
            this.maleTextBox.Size = new System.Drawing.Size(50, 20);
            this.maleTextBox.TabIndex = 4;
            this.maleTextBox.Text = "М";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Женский";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Мужской";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пол";
            // 
            // skipFirstString
            // 
            this.skipFirstString.AutoSize = true;
            this.skipFirstString.Location = new System.Drawing.Point(11, 19);
            this.skipFirstString.Name = "skipFirstString";
            this.skipFirstString.Size = new System.Drawing.Size(162, 17);
            this.skipFirstString.TabIndex = 0;
            this.skipFirstString.Text = "Пропустить первую строку";
            this.skipFirstString.UseVisualStyleBackColor = true;
            // 
            // selectSourceButton
            // 
            this.selectSourceButton.Location = new System.Drawing.Point(279, 39);
            this.selectSourceButton.Name = "selectSourceButton";
            this.selectSourceButton.Size = new System.Drawing.Size(121, 23);
            this.selectSourceButton.TabIndex = 2;
            this.selectSourceButton.Text = "Выбрать источник";
            this.selectSourceButton.UseVisualStyleBackColor = true;
            this.selectSourceButton.Click += new System.EventHandler(this.selectSourceButton_Click);
            // 
            // sourceFileTextBox
            // 
            this.sourceFileTextBox.Location = new System.Drawing.Point(106, 13);
            this.sourceFileTextBox.Name = "sourceFileTextBox";
            this.sourceFileTextBox.Size = new System.Drawing.Size(294, 20);
            this.sourceFileTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Путь к источнику";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(398, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Порядок столбцов для импорта: ФИО Комната Группа Пол Номер телефона";
            // 
            // ImportStudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 239);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ImportStudentsForm";
            this.Text = "Импорт студентов";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox delimitterTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox femaleTextBox;
        private System.Windows.Forms.TextBox maleTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox skipFirstString;
        private System.Windows.Forms.Button selectSourceButton;
        private System.Windows.Forms.TextBox sourceFileTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}
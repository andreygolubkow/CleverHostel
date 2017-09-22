namespace ClHsWinFormsApp
{
    partial class AddPunishmentDocumentForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPunishmentDocumentForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addByRoomButton = new System.Windows.Forms.Button();
            this.removeSelectedStudent = new System.Windows.Forms.Button();
            this.addStudentButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.selectedStudentGroup = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.selectedStudentRoom = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addStudentComboBox = new System.Windows.Forms.ComboBox();
            this.addStudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pointsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentsGridViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addStudentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsGridViewBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addByRoomButton);
            this.groupBox1.Controls.Add(this.removeSelectedStudent);
            this.groupBox1.Controls.Add(this.addStudentButton);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.studentsGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 267);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Студенты";
            // 
            // addByRoomButton
            // 
            this.addByRoomButton.Location = new System.Drawing.Point(162, 233);
            this.addByRoomButton.Name = "addByRoomButton";
            this.addByRoomButton.Size = new System.Drawing.Size(111, 23);
            this.addByRoomButton.TabIndex = 5;
            this.addByRoomButton.Text = "Добавить комнату";
            this.addByRoomButton.UseVisualStyleBackColor = true;
            this.addByRoomButton.Click += new System.EventHandler(this.addByRoomButton_Click);
            // 
            // removeSelectedStudent
            // 
            this.removeSelectedStudent.Location = new System.Drawing.Point(6, 233);
            this.removeSelectedStudent.Name = "removeSelectedStudent";
            this.removeSelectedStudent.Size = new System.Drawing.Size(68, 23);
            this.removeSelectedStudent.TabIndex = 4;
            this.removeSelectedStudent.Text = "Удалить";
            this.removeSelectedStudent.UseVisualStyleBackColor = true;
            this.removeSelectedStudent.Click += new System.EventHandler(this.removeSelectedStudent_Click);
            // 
            // addStudentButton
            // 
            this.addStudentButton.Location = new System.Drawing.Point(277, 233);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(118, 23);
            this.addStudentButton.TabIndex = 3;
            this.addStudentButton.Text = "Добавить в список";
            this.addStudentButton.UseVisualStyleBackColor = true;
            this.addStudentButton.Click += new System.EventHandler(this.addStudentButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.selectedStudentGroup);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.selectedStudentRoom);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.addStudentComboBox);
            this.groupBox2.Location = new System.Drawing.Point(6, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(389, 67);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Добавить студента";
            // 
            // selectedStudentGroup
            // 
            this.selectedStudentGroup.AutoSize = true;
            this.selectedStudentGroup.Location = new System.Drawing.Point(248, 43);
            this.selectedStudentGroup.Name = "selectedStudentGroup";
            this.selectedStudentGroup.Size = new System.Drawing.Size(19, 13);
            this.selectedStudentGroup.TabIndex = 5;
            this.selectedStudentGroup.Text = "----";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Группа";
            // 
            // selectedStudentRoom
            // 
            this.selectedStudentRoom.AutoSize = true;
            this.selectedStudentRoom.Location = new System.Drawing.Point(63, 43);
            this.selectedStudentRoom.Name = "selectedStudentRoom";
            this.selectedStudentRoom.Size = new System.Drawing.Size(25, 13);
            this.selectedStudentRoom.TabIndex = 3;
            this.selectedStudentRoom.Text = "------";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Комната";
            // 
            // addStudentComboBox
            // 
            this.addStudentComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.addStudentComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.addStudentComboBox.DataSource = this.addStudentBindingSource;
            this.addStudentComboBox.DisplayMember = "Name";
            this.addStudentComboBox.FormattingEnabled = true;
            this.addStudentComboBox.Location = new System.Drawing.Point(6, 19);
            this.addStudentComboBox.Name = "addStudentComboBox";
            this.addStudentComboBox.Size = new System.Drawing.Size(377, 21);
            this.addStudentComboBox.TabIndex = 1;
            this.addStudentComboBox.ValueMember = "Id";
            // 
            // addStudentBindingSource
            // 
            this.addStudentBindingSource.DataSource = typeof(HostelData.Model.Student.Student);
            this.addStudentBindingSource.CurrentChanged += new System.EventHandler(this.addStudentBindingSource_CurrentChanged);
            // 
            // studentsGridView
            // 
            this.studentsGridView.AllowUserToAddRows = false;
            this.studentsGridView.AllowUserToDeleteRows = false;
            this.studentsGridView.AllowUserToResizeRows = false;
            this.studentsGridView.AutoGenerateColumns = false;
            this.studentsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.roomDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.groupDataGridViewTextBoxColumn,
            this.documentsDataGridViewTextBoxColumn,
            this.pointsDataGridViewTextBoxColumn});
            this.studentsGridView.DataSource = this.studentsGridViewBindingSource;
            this.studentsGridView.Location = new System.Drawing.Point(6, 19);
            this.studentsGridView.Name = "studentsGridView";
            this.studentsGridView.ReadOnly = true;
            this.studentsGridView.RowHeadersVisible = false;
            this.studentsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.studentsGridView.Size = new System.Drawing.Size(389, 135);
            this.studentsGridView.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 250;
            // 
            // roomDataGridViewTextBoxColumn
            // 
            this.roomDataGridViewTextBoxColumn.DataPropertyName = "Room";
            this.roomDataGridViewTextBoxColumn.HeaderText = "Комната";
            this.roomDataGridViewTextBoxColumn.Name = "roomDataGridViewTextBoxColumn";
            this.roomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "Sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "Sex";
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            this.sexDataGridViewTextBoxColumn.ReadOnly = true;
            this.sexDataGridViewTextBoxColumn.Visible = false;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.phoneNumberDataGridViewTextBoxColumn.Visible = false;
            // 
            // groupDataGridViewTextBoxColumn
            // 
            this.groupDataGridViewTextBoxColumn.DataPropertyName = "Group";
            this.groupDataGridViewTextBoxColumn.HeaderText = "Group";
            this.groupDataGridViewTextBoxColumn.Name = "groupDataGridViewTextBoxColumn";
            this.groupDataGridViewTextBoxColumn.ReadOnly = true;
            this.groupDataGridViewTextBoxColumn.Visible = false;
            // 
            // documentsDataGridViewTextBoxColumn
            // 
            this.documentsDataGridViewTextBoxColumn.DataPropertyName = "Documents";
            this.documentsDataGridViewTextBoxColumn.HeaderText = "Documents";
            this.documentsDataGridViewTextBoxColumn.Name = "documentsDataGridViewTextBoxColumn";
            this.documentsDataGridViewTextBoxColumn.ReadOnly = true;
            this.documentsDataGridViewTextBoxColumn.Visible = false;
            // 
            // pointsDataGridViewTextBoxColumn
            // 
            this.pointsDataGridViewTextBoxColumn.DataPropertyName = "Points";
            this.pointsDataGridViewTextBoxColumn.HeaderText = "Points";
            this.pointsDataGridViewTextBoxColumn.Name = "pointsDataGridViewTextBoxColumn";
            this.pointsDataGridViewTextBoxColumn.ReadOnly = true;
            this.pointsDataGridViewTextBoxColumn.Visible = false;
            // 
            // studentsGridViewBindingSource
            // 
            this.studentsGridViewBindingSource.DataSource = typeof(HostelData.Model.Student.Student);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox2);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Location = new System.Drawing.Point(419, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(237, 227);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Взыскание";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 32);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(224, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Дата";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Баллы (отрицательное число)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(224, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Комментарии";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 110);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(224, 20);
            this.textBox2.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 195);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(224, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Заявитель";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Вердикт";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(6, 148);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(224, 21);
            this.comboBox2.TabIndex = 9;
            // 
            // AddPunishmentDocumentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 288);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddPunishmentDocumentForm";
            this.Text = "Добавить взыскание";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addStudentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsGridViewBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addByRoomButton;
        private System.Windows.Forms.Button removeSelectedStudent;
        private System.Windows.Forms.Button addStudentButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label selectedStudentGroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label selectedStudentRoom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox addStudentComboBox;
        private System.Windows.Forms.DataGridView studentsGridView;
        private System.Windows.Forms.BindingSource addStudentBindingSource;
        private System.Windows.Forms.BindingSource studentsGridViewBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pointsDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}
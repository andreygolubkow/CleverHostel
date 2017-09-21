namespace ClHsWinFormsApp
{
    partial class AddPromotionDocumentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPromotionDocumentForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.studentsGridView = new System.Windows.Forms.DataGridView();
            this.studentsGridViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pointsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addStudentComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.addStudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.selectedStudentRoom = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.selectedStudentGroup = new System.Windows.Forms.Label();
            this.addStudentButton = new System.Windows.Forms.Button();
            this.removeSelectedStudent = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.pointsTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.commentsTextBox = new System.Windows.Forms.TextBox();
            this.applicantComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.applicantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addByRoomButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsGridViewBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addStudentBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.applicantBindingSource)).BeginInit();
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
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Студенты";
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
            this.studentsGridView.RowHeadersVisible = false;
            this.studentsGridView.Size = new System.Drawing.Size(389, 135);
            this.studentsGridView.TabIndex = 0;
            // 
            // studentsGridViewBindingSource
            // 
            this.studentsGridViewBindingSource.DataSource = typeof(HostelData.Model.Student.Student);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 250;
            // 
            // roomDataGridViewTextBoxColumn
            // 
            this.roomDataGridViewTextBoxColumn.DataPropertyName = "Room";
            this.roomDataGridViewTextBoxColumn.HeaderText = "Комната";
            this.roomDataGridViewTextBoxColumn.Name = "roomDataGridViewTextBoxColumn";
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "Sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "Sex";
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            this.sexDataGridViewTextBoxColumn.Visible = false;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.Visible = false;
            // 
            // groupDataGridViewTextBoxColumn
            // 
            this.groupDataGridViewTextBoxColumn.DataPropertyName = "Group";
            this.groupDataGridViewTextBoxColumn.HeaderText = "Group";
            this.groupDataGridViewTextBoxColumn.Name = "groupDataGridViewTextBoxColumn";
            this.groupDataGridViewTextBoxColumn.Visible = false;
            // 
            // documentsDataGridViewTextBoxColumn
            // 
            this.documentsDataGridViewTextBoxColumn.DataPropertyName = "Documents";
            this.documentsDataGridViewTextBoxColumn.HeaderText = "Documents";
            this.documentsDataGridViewTextBoxColumn.Name = "documentsDataGridViewTextBoxColumn";
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
            // addStudentBindingSource
            // 
            this.addStudentBindingSource.DataSource = typeof(HostelData.Model.Student.Student);
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
            // selectedStudentRoom
            // 
            this.selectedStudentRoom.AutoSize = true;
            this.selectedStudentRoom.Location = new System.Drawing.Point(63, 43);
            this.selectedStudentRoom.Name = "selectedStudentRoom";
            this.selectedStudentRoom.Size = new System.Drawing.Size(25, 13);
            this.selectedStudentRoom.TabIndex = 3;
            this.selectedStudentRoom.Text = "------";
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
            // selectedStudentGroup
            // 
            this.selectedStudentGroup.AutoSize = true;
            this.selectedStudentGroup.Location = new System.Drawing.Point(248, 43);
            this.selectedStudentGroup.Name = "selectedStudentGroup";
            this.selectedStudentGroup.Size = new System.Drawing.Size(19, 13);
            this.selectedStudentGroup.TabIndex = 5;
            this.selectedStudentGroup.Text = "----";
            // 
            // addStudentButton
            // 
            this.addStudentButton.Location = new System.Drawing.Point(277, 233);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(118, 23);
            this.addStudentButton.TabIndex = 3;
            this.addStudentButton.Text = "Добавить в список";
            this.addStudentButton.UseVisualStyleBackColor = true;
            // 
            // removeSelectedStudent
            // 
            this.removeSelectedStudent.Location = new System.Drawing.Point(6, 233);
            this.removeSelectedStudent.Name = "removeSelectedStudent";
            this.removeSelectedStudent.Size = new System.Drawing.Size(68, 23);
            this.removeSelectedStudent.TabIndex = 4;
            this.removeSelectedStudent.Text = "Удалить";
            this.removeSelectedStudent.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.applicantComboBox);
            this.groupBox3.Controls.Add(this.commentsTextBox);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.datePicker);
            this.groupBox3.Controls.Add(this.pointsTextBox);
            this.groupBox3.Controls.Add(this.nameTextBox);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(419, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(236, 234);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Поощрение";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Название";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Баллы";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(9, 35);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(221, 20);
            this.nameTextBox.TabIndex = 2;
            // 
            // pointsTextBox
            // 
            this.pointsTextBox.Location = new System.Drawing.Point(9, 74);
            this.pointsTextBox.Name = "pointsTextBox";
            this.pointsTextBox.Size = new System.Drawing.Size(221, 20);
            this.pointsTextBox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(548, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(9, 113);
            this.datePicker.MinDate = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(221, 20);
            this.datePicker.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Дата";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Комментарии";
            // 
            // commentsTextBox
            // 
            this.commentsTextBox.Location = new System.Drawing.Point(9, 152);
            this.commentsTextBox.Name = "commentsTextBox";
            this.commentsTextBox.Size = new System.Drawing.Size(221, 20);
            this.commentsTextBox.TabIndex = 7;
            // 
            // applicantComboBox
            // 
            this.applicantComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.applicantComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.applicantComboBox.DataSource = this.applicantBindingSource;
            this.applicantComboBox.DisplayMember = "Name";
            this.applicantComboBox.FormattingEnabled = true;
            this.applicantComboBox.Location = new System.Drawing.Point(6, 203);
            this.applicantComboBox.Name = "applicantComboBox";
            this.applicantComboBox.Size = new System.Drawing.Size(221, 21);
            this.applicantComboBox.TabIndex = 8;
            this.applicantComboBox.ValueMember = "Id";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Заявитель";
            // 
            // applicantBindingSource
            // 
            this.applicantBindingSource.DataSource = typeof(HostelData.Model.Student.Applicant);
            // 
            // addByRoomButton
            // 
            this.addByRoomButton.Location = new System.Drawing.Point(162, 233);
            this.addByRoomButton.Name = "addByRoomButton";
            this.addByRoomButton.Size = new System.Drawing.Size(111, 23);
            this.addByRoomButton.TabIndex = 5;
            this.addByRoomButton.Text = "Добавить комнату";
            this.addByRoomButton.UseVisualStyleBackColor = true;
            // 
            // AddPromotionDocumentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 285);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddPromotionDocumentForm";
            this.Text = "Добавить поощрение";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsGridViewBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addStudentBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.applicantBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView studentsGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox addStudentComboBox;
        private System.Windows.Forms.BindingSource addStudentBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pointsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource studentsGridViewBindingSource;
        private System.Windows.Forms.Button removeSelectedStudent;
        private System.Windows.Forms.Button addStudentButton;
        private System.Windows.Forms.Label selectedStudentGroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label selectedStudentRoom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox pointsTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.TextBox commentsTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox applicantComboBox;
        private System.Windows.Forms.BindingSource applicantBindingSource;
        private System.Windows.Forms.Button addByRoomButton;
    }
}
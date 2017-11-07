namespace ClHsWinFormsApp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.baseMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDocumentMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPromotionManuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPunishmentMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.applicantsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsSubmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudentMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importStudentsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findStudentTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.findRoomTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.studentsGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pointsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baseMenuItem,
            this.serviceMenuItem,
            this.findStudentTextBox,
            this.findRoomTextBox});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(618, 27);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // baseMenuItem
            // 
            this.baseMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDocumentMenuItem,
            this.toolStripSeparator1,
            this.applicantsMenuItem,
            this.studentsSubmenu});
            this.baseMenuItem.Name = "baseMenuItem";
            this.baseMenuItem.Size = new System.Drawing.Size(43, 23);
            this.baseMenuItem.Text = "База";
            // 
            // addDocumentMenuItem
            // 
            this.addDocumentMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPromotionManuItem,
            this.addPunishmentMenuItem});
            this.addDocumentMenuItem.Name = "addDocumentMenuItem";
            this.addDocumentMenuItem.Size = new System.Drawing.Size(181, 22);
            this.addDocumentMenuItem.Text = "Добавить документ";
            // 
            // addPromotionManuItem
            // 
            this.addPromotionManuItem.Name = "addPromotionManuItem";
            this.addPromotionManuItem.Size = new System.Drawing.Size(141, 22);
            this.addPromotionManuItem.Text = "Поощрение";
            this.addPromotionManuItem.Click += new System.EventHandler(this.addPromotionManuItem_Click);
            // 
            // addPunishmentMenuItem
            // 
            this.addPunishmentMenuItem.Name = "addPunishmentMenuItem";
            this.addPunishmentMenuItem.Size = new System.Drawing.Size(141, 22);
            this.addPunishmentMenuItem.Text = "Взыскание";
            this.addPunishmentMenuItem.Click += new System.EventHandler(this.addPunishmentMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // applicantsMenuItem
            // 
            this.applicantsMenuItem.Name = "applicantsMenuItem";
            this.applicantsMenuItem.Size = new System.Drawing.Size(181, 22);
            this.applicantsMenuItem.Text = "Заявители";
            this.applicantsMenuItem.Click += new System.EventHandler(this.applicantsMenuItem_Click);
            // 
            // studentsSubmenu
            // 
            this.studentsSubmenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStudentMenuItem});
            this.studentsSubmenu.Name = "studentsSubmenu";
            this.studentsSubmenu.Size = new System.Drawing.Size(181, 22);
            this.studentsSubmenu.Text = "Студенты";
            // 
            // addStudentMenuItem
            // 
            this.addStudentMenuItem.Name = "addStudentMenuItem";
            this.addStudentMenuItem.Size = new System.Drawing.Size(126, 22);
            this.addStudentMenuItem.Text = "Добавить";
            this.addStudentMenuItem.Click += new System.EventHandler(this.addStudentMenuItem_Click);
            // 
            // serviceMenuItem
            // 
            this.serviceMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importStudentsMenuItem,
            this.settingsMenuItem});
            this.serviceMenuItem.Name = "serviceMenuItem";
            this.serviceMenuItem.Size = new System.Drawing.Size(59, 23);
            this.serviceMenuItem.Text = "Сервис";
            // 
            // importStudentsMenuItem
            // 
            this.importStudentsMenuItem.Name = "importStudentsMenuItem";
            this.importStudentsMenuItem.Size = new System.Drawing.Size(175, 22);
            this.importStudentsMenuItem.Text = "Импорт студентов";
            this.importStudentsMenuItem.Click += new System.EventHandler(this.importStudentsMenuItem_Click);
            // 
            // settingsMenuItem
            // 
            this.settingsMenuItem.Name = "settingsMenuItem";
            this.settingsMenuItem.Size = new System.Drawing.Size(175, 22);
            this.settingsMenuItem.Text = "Настройки";
            this.settingsMenuItem.Click += new System.EventHandler(this.settingsMenuItem_Click);
            // 
            // findStudentTextBox
            // 
            this.findStudentTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.findStudentTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.findStudentTextBox.AutoToolTip = true;
            this.findStudentTextBox.Name = "findStudentTextBox";
            this.findStudentTextBox.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.findStudentTextBox.Size = new System.Drawing.Size(200, 23);
            this.findStudentTextBox.ToolTipText = "Поиск по ФИО";
            this.findStudentTextBox.TextChanged += new System.EventHandler(this.FindStudentTextBoxTextChanged);
            // 
            // findRoomTextBox
            // 
            this.findRoomTextBox.Name = "findRoomTextBox";
            this.findRoomTextBox.Size = new System.Drawing.Size(100, 23);
            this.findRoomTextBox.TextChanged += new System.EventHandler(this.findRoomTextBox_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.studentsGridView);
            this.groupBox1.Location = new System.Drawing.Point(0, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(606, 259);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "База данных";
            // 
            // studentsGridView
            // 
            this.studentsGridView.AllowUserToAddRows = false;
            this.studentsGridView.AllowUserToDeleteRows = false;
            this.studentsGridView.AllowUserToOrderColumns = true;
            this.studentsGridView.AllowUserToResizeRows = false;
            this.studentsGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.studentsGridView.AutoGenerateColumns = false;
            this.studentsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.studentsGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.studentsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.roomDataGridViewTextBoxColumn,
            this.groupDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.documentsDataGridViewTextBoxColumn,
            this.pointsDataGridViewTextBoxColumn});
            this.studentsGridView.DataSource = this.studentBindingSource;
            this.studentsGridView.Location = new System.Drawing.Point(6, 19);
            this.studentsGridView.Name = "studentsGridView";
            this.studentsGridView.ReadOnly = true;
            this.studentsGridView.RowHeadersVisible = false;
            this.studentsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.studentsGridView.Size = new System.Drawing.Size(594, 234);
            this.studentsGridView.TabIndex = 0;
            this.studentsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentsGridView_CellContentClick);
            this.studentsGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentsGridView_CellDoubleClick);
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
            // 
            // roomDataGridViewTextBoxColumn
            // 
            this.roomDataGridViewTextBoxColumn.DataPropertyName = "Room";
            this.roomDataGridViewTextBoxColumn.HeaderText = "Комната";
            this.roomDataGridViewTextBoxColumn.Name = "roomDataGridViewTextBoxColumn";
            this.roomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // groupDataGridViewTextBoxColumn
            // 
            this.groupDataGridViewTextBoxColumn.DataPropertyName = "Group";
            this.groupDataGridViewTextBoxColumn.HeaderText = "Группа";
            this.groupDataGridViewTextBoxColumn.Name = "groupDataGridViewTextBoxColumn";
            this.groupDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "Sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "Пол";
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            this.sexDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "Номер телефона";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // documentsDataGridViewTextBoxColumn
            // 
            this.documentsDataGridViewTextBoxColumn.DataPropertyName = "Documents";
            this.documentsDataGridViewTextBoxColumn.HeaderText = "Документы";
            this.documentsDataGridViewTextBoxColumn.Name = "documentsDataGridViewTextBoxColumn";
            this.documentsDataGridViewTextBoxColumn.ReadOnly = true;
            this.documentsDataGridViewTextBoxColumn.Visible = false;
            // 
            // pointsDataGridViewTextBoxColumn
            // 
            this.pointsDataGridViewTextBoxColumn.DataPropertyName = "Points";
            this.pointsDataGridViewTextBoxColumn.HeaderText = "Баллы";
            this.pointsDataGridViewTextBoxColumn.Name = "pointsDataGridViewTextBoxColumn";
            this.pointsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(HostelData.Model.Student.Student);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 298);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.Text = "АИС Студенческий совет";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView studentsGridView;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pointsDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem baseMenuItem;
        private System.Windows.Forms.ToolStripTextBox findStudentTextBox;
        private System.Windows.Forms.ToolStripMenuItem serviceMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importStudentsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDocumentMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPromotionManuItem;
        private System.Windows.Forms.ToolStripMenuItem addPunishmentMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox findRoomTextBox;
        private System.Windows.Forms.ToolStripMenuItem applicantsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsSubmenu;
        private System.Windows.Forms.ToolStripMenuItem addStudentMenuItem;
    }
}


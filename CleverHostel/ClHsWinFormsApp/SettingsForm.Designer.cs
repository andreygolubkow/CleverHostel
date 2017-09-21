namespace ClHsWinFormsApp
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataBaseTextBox = new System.Windows.Forms.TextBox();
            this.selectDataBasePath = new System.Windows.Forms.Button();
            this.dataBaseFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.saveConnectionStringButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saveConnectionStringButton);
            this.groupBox1.Controls.Add(this.selectDataBasePath);
            this.groupBox1.Controls.Add(this.dataBaseTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 90);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "База данных";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Строка подключения";
            // 
            // dataBaseTextBox
            // 
            this.dataBaseTextBox.Location = new System.Drawing.Point(9, 32);
            this.dataBaseTextBox.Name = "dataBaseTextBox";
            this.dataBaseTextBox.Size = new System.Drawing.Size(275, 20);
            this.dataBaseTextBox.TabIndex = 1;
            // 
            // selectDataBasePath
            // 
            this.selectDataBasePath.Location = new System.Drawing.Point(174, 58);
            this.selectDataBasePath.Name = "selectDataBasePath";
            this.selectDataBasePath.Size = new System.Drawing.Size(110, 23);
            this.selectDataBasePath.TabIndex = 2;
            this.selectDataBasePath.Text = "Выбрать файл";
            this.selectDataBasePath.UseVisualStyleBackColor = true;
            this.selectDataBasePath.Click += new System.EventHandler(this.selectDataBasePath_Click);
            // 
            // saveConnectionStringButton
            // 
            this.saveConnectionStringButton.Location = new System.Drawing.Point(96, 58);
            this.saveConnectionStringButton.Name = "saveConnectionStringButton";
            this.saveConnectionStringButton.Size = new System.Drawing.Size(72, 23);
            this.saveConnectionStringButton.TabIndex = 3;
            this.saveConnectionStringButton.Text = "Сохранить";
            this.saveConnectionStringButton.UseVisualStyleBackColor = true;
            this.saveConnectionStringButton.Click += new System.EventHandler(this.saveConnectionStringButton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 109);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.Text = "Настройки";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button selectDataBasePath;
        private System.Windows.Forms.TextBox dataBaseTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog dataBaseFolderBrowserDialog;
        private System.Windows.Forms.Button saveConnectionStringButton;
    }
}
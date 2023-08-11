namespace HomeWork_Algebra
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            selectFileButton = new Button();
            CheckKeysButton = new Button();
            selectedFileTextBox = new TextBox();
            UploadKeysFromDB = new Button();
            DBFilePath = new Button();
            DBPathTextBox = new TextBox();
            SuspendLayout();
            // 
            // selectFileButton
            // 
            selectFileButton.Location = new Point(216, 130);
            selectFileButton.Name = "selectFileButton";
            selectFileButton.Size = new Size(171, 33);
            selectFileButton.TabIndex = 0;
            selectFileButton.Text = "ChooseFileToCheck";
            selectFileButton.UseVisualStyleBackColor = true;
            selectFileButton.Click += SelectFileButton_Click;
            // 
            // CheckKeysButton
            // 
            CheckKeysButton.Location = new Point(216, 72);
            CheckKeysButton.Name = "CheckKeysButton";
            CheckKeysButton.Size = new Size(171, 33);
            CheckKeysButton.TabIndex = 1;
            CheckKeysButton.Text = "CheckKeys";
            CheckKeysButton.UseVisualStyleBackColor = true;
            CheckKeysButton.Click += CheckKeysButton_Click;
            // 
            // selectedFileTextBox
            // 
            selectedFileTextBox.Location = new Point(216, 179);
            selectedFileTextBox.Name = "selectedFileTextBox";
            selectedFileTextBox.Size = new Size(171, 23);
            selectedFileTextBox.TabIndex = 2;
            // 
            // UploadKeysFromDB
            // 
            UploadKeysFromDB.Location = new Point(12, 72);
            UploadKeysFromDB.Name = "UploadKeysFromDB";
            UploadKeysFromDB.Size = new Size(171, 33);
            UploadKeysFromDB.TabIndex = 3;
            UploadKeysFromDB.Text = "UploadKeysFromDB";
            UploadKeysFromDB.UseVisualStyleBackColor = true;
            UploadKeysFromDB.Click += UploadKeysFromDB_Click;
            // 
            // DBFilePath
            // 
            DBFilePath.Location = new Point(12, 130);
            DBFilePath.Name = "DBFilePath";
            DBFilePath.Size = new Size(171, 33);
            DBFilePath.TabIndex = 4;
            DBFilePath.Text = "ChooseFileToUpload";
            DBFilePath.UseVisualStyleBackColor = true;
            DBFilePath.Click += DBFilePath_Click;
            // 
            // DBPathTextBox
            // 
            DBPathTextBox.Location = new Point(12, 179);
            DBPathTextBox.Name = "DBPathTextBox";
            DBPathTextBox.Size = new Size(171, 23);
            DBPathTextBox.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 252);
            Controls.Add(DBPathTextBox);
            Controls.Add(DBFilePath);
            Controls.Add(UploadKeysFromDB);
            Controls.Add(selectedFileTextBox);
            Controls.Add(CheckKeysButton);
            Controls.Add(selectFileButton);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button selectFileButton;
        private Button CheckKeysButton;
        private TextBox selectedFileTextBox;
        private Button UploadKeysFromDB;
        private Button DBFilePath;
        private TextBox DBPathTextBox;
    }
}
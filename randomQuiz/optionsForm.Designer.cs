namespace randomQuiz
{
    partial class OptionsForm
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
            this.questionNumTitleLabel = new System.Windows.Forms.Label();
            this.questionNumTypeComboBox = new System.Windows.Forms.ComboBox();
            this.questionNumText = new System.Windows.Forms.TextBox();
            this.questionsTitle = new System.Windows.Forms.Label();
            this.quizTypeTitleLabel = new System.Windows.Forms.Label();
            this.configDifinitionButton = new System.Windows.Forms.Button();
            this.debugLabel = new System.Windows.Forms.Label();
            this.questionTypeComboBox = new System.Windows.Forms.ComboBox();
            this.excelFilePathLabel = new System.Windows.Forms.Label();
            this.excelFilePathTextBox = new System.Windows.Forms.TextBox();
            this.pictureFolderPath = new System.Windows.Forms.Label();
            this.pictureFolderPathTextbox = new System.Windows.Forms.TextBox();
            this.questioningPattern = new System.Windows.Forms.Label();
            this.questioningPatternComboBox = new System.Windows.Forms.ComboBox();
            this.questioningIndexLabel = new System.Windows.Forms.Label();
            this.questioningIndexTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // questionNumTitleLabel
            // 
            this.questionNumTitleLabel.AutoSize = true;
            this.questionNumTitleLabel.Location = new System.Drawing.Point(42, 44);
            this.questionNumTitleLabel.Name = "questionNumTitleLabel";
            this.questionNumTitleLabel.Size = new System.Drawing.Size(89, 19);
            this.questionNumTitleLabel.TabIndex = 0;
            this.questionNumTitleLabel.Text = "問題数設定";
            // 
            // questionNumTypeComboBox
            // 
            this.questionNumTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.questionNumTypeComboBox.FormattingEnabled = true;
            this.questionNumTypeComboBox.Items.AddRange(new object[] {
            "１．すべて",
            "２．詳細設定"});
            this.questionNumTypeComboBox.Location = new System.Drawing.Point(133, 82);
            this.questionNumTypeComboBox.Name = "questionNumTypeComboBox";
            this.questionNumTypeComboBox.Size = new System.Drawing.Size(355, 27);
            this.questionNumTypeComboBox.TabIndex = 1;
            this.questionNumTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // questionNumText
            // 
            this.questionNumText.Location = new System.Drawing.Point(133, 127);
            this.questionNumText.Name = "questionNumText";
            this.questionNumText.Size = new System.Drawing.Size(159, 27);
            this.questionNumText.TabIndex = 2;
            // 
            // questionsTitle
            // 
            this.questionsTitle.AutoSize = true;
            this.questionsTitle.Location = new System.Drawing.Point(310, 135);
            this.questionsTitle.Name = "questionsTitle";
            this.questionsTitle.Size = new System.Drawing.Size(25, 19);
            this.questionsTitle.TabIndex = 3;
            this.questionsTitle.Text = "問";
            // 
            // quizTypeTitleLabel
            // 
            this.quizTypeTitleLabel.AutoSize = true;
            this.quizTypeTitleLabel.Location = new System.Drawing.Point(42, 173);
            this.quizTypeTitleLabel.Name = "quizTypeTitleLabel";
            this.quizTypeTitleLabel.Size = new System.Drawing.Size(122, 19);
            this.quizTypeTitleLabel.TabIndex = 4;
            this.quizTypeTitleLabel.Text = "クイズ形式の選択";
            // 
            // configDifinitionButton
            // 
            this.configDifinitionButton.Location = new System.Drawing.Point(556, 536);
            this.configDifinitionButton.Name = "configDifinitionButton";
            this.configDifinitionButton.Size = new System.Drawing.Size(255, 56);
            this.configDifinitionButton.TabIndex = 6;
            this.configDifinitionButton.Text = "設定値の保存";
            this.configDifinitionButton.UseVisualStyleBackColor = true;
            this.configDifinitionButton.Click += new System.EventHandler(this.ConfigDifinitionButton_Click);
            // 
            // debugLabel
            // 
            this.debugLabel.AutoSize = true;
            this.debugLabel.Location = new System.Drawing.Point(42, 536);
            this.debugLabel.Name = "debugLabel";
            this.debugLabel.Size = new System.Drawing.Size(61, 19);
            this.debugLabel.TabIndex = 7;
            this.debugLabel.Text = "debug：";
            // 
            // questionTypeComboBox
            // 
            this.questionTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.questionTypeComboBox.FormattingEnabled = true;
            this.questionTypeComboBox.Items.AddRange(new object[] {
            "１．自由回答方式",
            "２．YES/NO方式",
            "３．3択形式",
            "４．入力なし方式"});
            this.questionTypeComboBox.Location = new System.Drawing.Point(133, 208);
            this.questionTypeComboBox.Name = "questionTypeComboBox";
            this.questionTypeComboBox.Size = new System.Drawing.Size(355, 27);
            this.questionTypeComboBox.TabIndex = 9;
            this.questionTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.QuestionTypeComboBox_SelectedIndexChanged);
            // 
            // excelFilePathLabel
            // 
            this.excelFilePathLabel.AutoSize = true;
            this.excelFilePathLabel.Location = new System.Drawing.Point(45, 274);
            this.excelFilePathLabel.Name = "excelFilePathLabel";
            this.excelFilePathLabel.Size = new System.Drawing.Size(173, 19);
            this.excelFilePathLabel.TabIndex = 10;
            this.excelFilePathLabel.Text = "Excelファイルのファイルパス";
            this.excelFilePathLabel.Click += new System.EventHandler(this.Label1_Click);
            // 
            // excelFilePathTextBox
            // 
            this.excelFilePathTextBox.Location = new System.Drawing.Point(133, 299);
            this.excelFilePathTextBox.Name = "excelFilePathTextBox";
            this.excelFilePathTextBox.Size = new System.Drawing.Size(618, 27);
            this.excelFilePathTextBox.TabIndex = 11;
            this.excelFilePathTextBox.Text = "名簿ファイルのファイルパスを入力";
            // 
            // pictureFolderPath
            // 
            this.pictureFolderPath.AutoSize = true;
            this.pictureFolderPath.Location = new System.Drawing.Point(45, 343);
            this.pictureFolderPath.Name = "pictureFolderPath";
            this.pictureFolderPath.Size = new System.Drawing.Size(171, 19);
            this.pictureFolderPath.TabIndex = 12;
            this.pictureFolderPath.Text = "画像ファイルのフォルダパス";
            // 
            // pictureFolderPathTextbox
            // 
            this.pictureFolderPathTextbox.Location = new System.Drawing.Point(133, 368);
            this.pictureFolderPathTextbox.Name = "pictureFolderPathTextbox";
            this.pictureFolderPathTextbox.Size = new System.Drawing.Size(618, 27);
            this.pictureFolderPathTextbox.TabIndex = 13;
            this.pictureFolderPathTextbox.Text = "画像ファイルのフォルダパスを入力";
            // 
            // questioningPattern
            // 
            this.questioningPattern.AutoSize = true;
            this.questioningPattern.Location = new System.Drawing.Point(45, 409);
            this.questioningPattern.Name = "questioningPattern";
            this.questioningPattern.Size = new System.Drawing.Size(90, 19);
            this.questioningPattern.TabIndex = 14;
            this.questioningPattern.Text = "出題パターン";
            // 
            // questioningPatternComboBox
            // 
            this.questioningPatternComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.questioningPatternComboBox.FormattingEnabled = true;
            this.questioningPatternComboBox.Items.AddRange(new object[] {
            "１．上から順番に出題",
            "２．ランダムに出題"});
            this.questioningPatternComboBox.Location = new System.Drawing.Point(133, 435);
            this.questioningPatternComboBox.Name = "questioningPatternComboBox";
            this.questioningPatternComboBox.Size = new System.Drawing.Size(355, 27);
            this.questioningPatternComboBox.TabIndex = 15;
            // 
            // questioningIndexLabel
            // 
            this.questioningIndexLabel.AutoSize = true;
            this.questioningIndexLabel.Location = new System.Drawing.Point(384, 135);
            this.questioningIndexLabel.Name = "questioningIndexLabel";
            this.questioningIndexLabel.Size = new System.Drawing.Size(155, 19);
            this.questioningIndexLabel.TabIndex = 16;
            this.questioningIndexLabel.Text = "何番目から開始する？";
            // 
            // questioningIndexTextBox
            // 
            this.questioningIndexTextBox.Location = new System.Drawing.Point(546, 135);
            this.questioningIndexTextBox.Name = "questioningIndexTextBox";
            this.questioningIndexTextBox.Size = new System.Drawing.Size(100, 27);
            this.questioningIndexTextBox.TabIndex = 17;
            // 
            // OptionsForm
            // 
            this.ClientSize = new System.Drawing.Size(845, 622);
            this.Controls.Add(this.questioningIndexTextBox);
            this.Controls.Add(this.questioningIndexLabel);
            this.Controls.Add(this.questioningPatternComboBox);
            this.Controls.Add(this.questioningPattern);
            this.Controls.Add(this.pictureFolderPathTextbox);
            this.Controls.Add(this.pictureFolderPath);
            this.Controls.Add(this.excelFilePathTextBox);
            this.Controls.Add(this.excelFilePathLabel);
            this.Controls.Add(this.questionTypeComboBox);
            this.Controls.Add(this.debugLabel);
            this.Controls.Add(this.configDifinitionButton);
            this.Controls.Add(this.quizTypeTitleLabel);
            this.Controls.Add(this.questionsTitle);
            this.Controls.Add(this.questionNumText);
            this.Controls.Add(this.questionNumTypeComboBox);
            this.Controls.Add(this.questionNumTitleLabel);
            this.Name = "OptionsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label questionNumTitleLabel;
        private System.Windows.Forms.ComboBox questionNumTypeComboBox;
        private System.Windows.Forms.TextBox questionNumText;
        private System.Windows.Forms.Label questionsTitle;
        private System.Windows.Forms.Label quizTypeTitleLabel;
        private System.Windows.Forms.Button configDifinitionButton;
        private System.Windows.Forms.Label debugLabel;
        private System.Windows.Forms.ComboBox questionTypeComboBox;
        private System.Windows.Forms.Label excelFilePathLabel;
        private System.Windows.Forms.TextBox excelFilePathTextBox;
        private System.Windows.Forms.Label pictureFolderPath;
        private System.Windows.Forms.TextBox pictureFolderPathTextbox;
        private System.Windows.Forms.Label questioningPattern;
        private System.Windows.Forms.ComboBox questioningPatternComboBox;
        private System.Windows.Forms.Label questioningIndexLabel;
        private System.Windows.Forms.TextBox questioningIndexTextBox;
    }
}
namespace randomQuiz
{
    partial class ContentsForm
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.debugLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.questionLabel = new System.Windows.Forms.Label();
            this.answerLabel = new System.Windows.Forms.Label();
            this.answerButton = new System.Windows.Forms.Button();
            this.rightAnswerTitle = new System.Windows.Forms.Label();
            this.rightAnswerTextBox = new System.Windows.Forms.TextBox();
            this.rightAnswerAssistLabel = new System.Windows.Forms.Label();
            this.collectAnswerLabel = new System.Windows.Forms.Label();
            this.mistakeAnswerLabel = new System.Windows.Forms.Label();
            this.nextQuestionButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(146, 35);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(699, 417);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // debugLabel
            // 
            this.debugLabel.AutoSize = true;
            this.debugLabel.Location = new System.Drawing.Point(15, 589);
            this.debugLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.debugLabel.Name = "debugLabel";
            this.debugLabel.Size = new System.Drawing.Size(41, 12);
            this.debugLabel.TabIndex = 5;
            this.debugLabel.Text = "debug：";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(146, 502);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(251, 33);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "回答を記入";
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Location = new System.Drawing.Point(144, 464);
            this.questionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(178, 12);
            this.questionLabel.TabIndex = 7;
            this.questionLabel.Text = "Q：この人のお名前はなんでしょうか？";
            // 
            // answerLabel
            // 
            this.answerLabel.AutoSize = true;
            this.answerLabel.Location = new System.Drawing.Point(144, 484);
            this.answerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(43, 12);
            this.answerLabel.TabIndex = 8;
            this.answerLabel.Text = "A：回答";
            // 
            // answerButton
            // 
            this.answerButton.Location = new System.Drawing.Point(146, 549);
            this.answerButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.answerButton.Name = "answerButton";
            this.answerButton.Size = new System.Drawing.Size(97, 28);
            this.answerButton.TabIndex = 9;
            this.answerButton.Text = "回答！";
            this.answerButton.UseVisualStyleBackColor = true;
            this.answerButton.Click += new System.EventHandler(this.AnswerButton_Click);
            this.answerButton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.AnswerButton_KeyUp);
            // 
            // rightAnswerTitle
            // 
            this.rightAnswerTitle.AutoSize = true;
            this.rightAnswerTitle.Location = new System.Drawing.Point(507, 549);
            this.rightAnswerTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rightAnswerTitle.Name = "rightAnswerTitle";
            this.rightAnswerTitle.Size = new System.Drawing.Size(39, 12);
            this.rightAnswerTitle.TabIndex = 10;
            this.rightAnswerTitle.Text = "正解は";
            this.rightAnswerTitle.Visible = false;
            // 
            // rightAnswerTextBox
            // 
            this.rightAnswerTextBox.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightAnswerTextBox.Location = new System.Drawing.Point(510, 572);
            this.rightAnswerTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rightAnswerTextBox.Name = "rightAnswerTextBox";
            this.rightAnswerTextBox.Size = new System.Drawing.Size(248, 33);
            this.rightAnswerTextBox.TabIndex = 11;
            this.rightAnswerTextBox.Visible = false;
            // 
            // rightAnswerAssistLabel
            // 
            this.rightAnswerAssistLabel.AutoSize = true;
            this.rightAnswerAssistLabel.Location = new System.Drawing.Point(761, 589);
            this.rightAnswerAssistLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rightAnswerAssistLabel.Name = "rightAnswerAssistLabel";
            this.rightAnswerAssistLabel.Size = new System.Drawing.Size(71, 12);
            this.rightAnswerAssistLabel.TabIndex = 12;
            this.rightAnswerAssistLabel.Text = "さん　でした！";
            this.rightAnswerAssistLabel.Visible = false;
            // 
            // collectAnswerLabel
            // 
            this.collectAnswerLabel.AutoSize = true;
            this.collectAnswerLabel.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.collectAnswerLabel.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.collectAnswerLabel.Location = new System.Drawing.Point(471, 493);
            this.collectAnswerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.collectAnswerLabel.Name = "collectAnswerLabel";
            this.collectAnswerLabel.Size = new System.Drawing.Size(145, 39);
            this.collectAnswerLabel.TabIndex = 13;
            this.collectAnswerLabel.Text = "正解！！";
            this.collectAnswerLabel.Visible = false;
            // 
            // mistakeAnswerLabel
            // 
            this.mistakeAnswerLabel.AutoSize = true;
            this.mistakeAnswerLabel.BackColor = System.Drawing.Color.LightYellow;
            this.mistakeAnswerLabel.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mistakeAnswerLabel.Location = new System.Drawing.Point(674, 493);
            this.mistakeAnswerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mistakeAnswerLabel.Name = "mistakeAnswerLabel";
            this.mistakeAnswerLabel.Size = new System.Drawing.Size(145, 39);
            this.mistakeAnswerLabel.TabIndex = 14;
            this.mistakeAnswerLabel.Text = "不正解！";
            this.mistakeAnswerLabel.Visible = false;
            // 
            // nextQuestionButton
            // 
            this.nextQuestionButton.Location = new System.Drawing.Point(849, 589);
            this.nextQuestionButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nextQuestionButton.Name = "nextQuestionButton";
            this.nextQuestionButton.Size = new System.Drawing.Size(116, 35);
            this.nextQuestionButton.TabIndex = 15;
            this.nextQuestionButton.Text = "次の問題へ進む";
            this.nextQuestionButton.UseVisualStyleBackColor = true;
            this.nextQuestionButton.Click += new System.EventHandler(this.NextQuestionButton_Click);
            // 
            // ContentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1126, 716);
            this.Controls.Add(this.nextQuestionButton);
            this.Controls.Add(this.mistakeAnswerLabel);
            this.Controls.Add(this.collectAnswerLabel);
            this.Controls.Add(this.rightAnswerAssistLabel);
            this.Controls.Add(this.rightAnswerTextBox);
            this.Controls.Add(this.rightAnswerTitle);
            this.Controls.Add(this.answerButton);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.debugLabel);
            this.Controls.Add(this.pictureBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "ContentsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "「顔と名前」一致クイズ コンテンツ画面";
            this.Load += new System.EventHandler(this.ContentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label debugLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Label answerLabel;
        private System.Windows.Forms.Button answerButton;
        private System.Windows.Forms.Label rightAnswerTitle;
        private System.Windows.Forms.TextBox rightAnswerTextBox;
        private System.Windows.Forms.Label rightAnswerAssistLabel;
        private System.Windows.Forms.Label collectAnswerLabel;
        private System.Windows.Forms.Label mistakeAnswerLabel;
        private System.Windows.Forms.Button nextQuestionButton;
    }
}
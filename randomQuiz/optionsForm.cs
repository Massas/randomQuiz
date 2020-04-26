// <copyright file="optionsForm.cs" company="kj">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace randomQuiz
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class OptionsForm : Form
    {
        private string debugMsg = "debug：";

        /// <summary>
        /// Initializes a new instance of the <see cref="OptionsForm"/> class.
        /// </summary>
        public OptionsForm()
        {
            this.InitializeComponent();

            // 設定値の読み込み
            this.questionNumTypeComboBox.Text = Properties.Settings.Default.question_num_type;
            this.questionNumText.Text = Properties.Settings.Default.question_num;
            this.questionTypeComboBox.Text = Properties.Settings.Default.question_type;
            this.excelFilePathTextBox.Text = Properties.Settings.Default.excel_filepath;
            this.pictureFolderPathTextbox.Text = Properties.Settings.Default.picture_folderpath;
            this.questioningPatternComboBox.Text = Properties.Settings.Default.questioning_pattern;
            this.questioningIndexTextBox.Text = "0";
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.debugLabel.Text = this.debugMsg + "comboBox1_SelectedIndexChanged() START";
            if (this.questionNumTypeComboBox.Text != "２．詳細設定")
            {
                this.questionNumText.Text = string.Empty;
            }
        }

        private void QuestionTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.debugLabel.Text = this.debugMsg + "questionTypeComboBox_SelectedIndexChanged() START";
        }

        private void ConfigDifinitionButton_Click(object sender, EventArgs e)
        {
            this.debugLabel.Text = this.debugMsg + "configDifinitionButton_Click() START";

            // 設定値の上書き
            Properties.Settings.Default.question_num_type = this.questionNumTypeComboBox.Text;

            // 詳細設定の場合のみ、問題数を書き込む
            if (this.questionNumTypeComboBox.Text == "２．詳細設定")
            {
                Properties.Settings.Default.question_num = this.questionNumText.Text;
            }

            Properties.Settings.Default.question_type = this.questionTypeComboBox.Text;
            Properties.Settings.Default.excel_filepath = this.excelFilePathTextBox.Text;
            Properties.Settings.Default.picture_folderpath = this.pictureFolderPathTextbox.Text;
            Properties.Settings.Default.questioning_pattern = this.questioningPatternComboBox.Text;
            Properties.Settings.Default.questioning_index = int.Parse(this.questioningIndexTextBox.Text);

            this.Close();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
        }
    }
}

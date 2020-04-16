using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace randomQuiz
{
    public partial class OptionsForm : Form
    {

        String debugMsg = "debug：";

        public OptionsForm()
        {
            InitializeComponent();
            //設定値の読み込み
            questionNumTypeComboBox.Text = Properties.Settings.Default.question_num_type;
            questionNumText.Text = Properties.Settings.Default.question_num;
            questionTypeComboBox.Text = Properties.Settings.Default.question_type;
            excelFilePathTextBox.Text = Properties.Settings.Default.excel_filepath;
            pictureFolderPathTextbox.Text = Properties.Settings.Default.picture_folderpath;
            questioningPatternComboBox.Text = Properties.Settings.Default.questioning_pattern;
            questioningIndexTextBox.Text = "0";

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            debugLabel.Text = debugMsg + "comboBox1_SelectedIndexChanged() START";
            if (questionNumTypeComboBox.Text != "２．詳細設定")
            {
                questionNumText.Text = "";
            }
        }

        private void QuestionTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            debugLabel.Text = debugMsg + "questionTypeComboBox_SelectedIndexChanged() START";
        }

        private void ConfigDifinitionButton_Click(object sender, EventArgs e)
        {
            debugLabel.Text = debugMsg + "configDifinitionButton_Click() START";

            //設定値の上書き
            Properties.Settings.Default.question_num_type = questionNumTypeComboBox.Text;
            //詳細設定の場合のみ、問題数を書き込む
            if(questionNumTypeComboBox.Text == "２．詳細設定")
            {
                Properties.Settings.Default.question_num = questionNumText.Text;
            }

            Properties.Settings.Default.question_type = questionTypeComboBox.Text;
            Properties.Settings.Default.excel_filepath = excelFilePathTextBox.Text;
            Properties.Settings.Default.picture_folderpath = pictureFolderPathTextbox.Text;
            Properties.Settings.Default.questioning_pattern = questioningPatternComboBox.Text;
            Properties.Settings.Default.questioning_index = int.Parse(questioningIndexTextBox.Text);

            this.Close();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
        }
    }
}

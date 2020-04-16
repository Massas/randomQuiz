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
    public partial class MainForm : Form
    {
        String debugMsg = "debug：";

        public MainForm()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            debugLabel.Text = debugMsg +"Start Buttun Clicked!!";
            //コンテンツ画面の起動
            StartContents();
        }

        private void OptionButton_Click(object sender, EventArgs e)
        {
            debugLabel.Text = debugMsg + "Option Button Clicked!!";
            //設定画面の起動
            OpenSettings();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            debugLabel.Text = debugMsg + "Exit Button Clicked!!";
            //アプリケーションを終了させる
            this.Close();
        }

        private void StartContents()
        {
            debugLabel.Text = debugMsg + "StartContents() START";
            ContentsForm contentsForm = new ContentsForm();
            contentsForm.Show();
        }

        private void OpenSettings()
        {
            debugLabel.Text = debugMsg + "OpenSettings() START";
            OptionsForm optionsForm = new OptionsForm();
            optionsForm.Show();
        }
    }
}

// <copyright file="main.cs" company="kj">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

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
        private string debugMsg = "debug：";

        public MainForm()
        {
            this.InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            this.debugLabel.Text = this.debugMsg + "Start Buttun Clicked!!";

            // コンテンツ画面の起動
            this.StartContents();
        }

        private void OptionButton_Click(object sender, EventArgs e)
        {
            this.debugLabel.Text = this.debugMsg + "Option Button Clicked!!";

            // 設定画面の起動
            this.OpenSettings();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.debugLabel.Text = this.debugMsg + "Exit Button Clicked!!";

            // アプリケーションを終了させる
            this.Close();
        }

        private void StartContents()
        {
            this.debugLabel.Text = this.debugMsg + "StartContents() START";
            ContentsForm contentsForm = new ContentsForm();
            contentsForm.Show();
        }

        private void OpenSettings()
        {
            this.debugLabel.Text = this.debugMsg + "OpenSettings() START";
            OptionsForm optionsForm = new OptionsForm();
            optionsForm.Show();
        }
    }
}

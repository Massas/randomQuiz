// <copyright file="contentsForm.cs" company="kj">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace randomQuiz
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using ClosedXML.Excel;

    // 追加定義
    using Microsoft.Office.Interop.Excel;
    using NAudio;

    public partial class ContentsForm : Form
    {
        private string debugMsg = "debug：";

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentsForm"/> class.
        /// </summary>
        public ContentsForm()
        {
            this.InitializeComponent();
        }

        private void ContentsForm_Load(object sender, EventArgs e)
        {
            this.debugLabel.Text = this.debugMsg + "ContentsForm_Load() START";

            // コンテンツ画面のメイン関数
            this.ContentsStart();
        }

        // コンテンツ画面のメイン関数
        private void ContentsStart()
        {
            this.debugLabel.Text = this.debugMsg + "ContentsStart() START";

            // 画面の初期化する関数
            this.ScreenUpdate_Initial();

            // 回答モードにより画面の描画を変える関数
            this.ScreenUpdate_ContentsType();

            // 設定値を読みだす
            string pictureFolderPath = Properties.Settings.Default.picture_folderpath;

            // エクセルファイルからデータを読み出しメモリ上の配列にマッピングする関数
            string[,] arr = this.ExtractExcelByClosedXML();

            // 設定値から何番目の顔写真から始めるか設定する
            int inputNum = Properties.Settings.Default.questioning_index;

            // 表示する顔写真を決定する関数
            this.PickupPicture(arr, out string pictureFile, inputNum, out int indexNum);

            if (pictureFile == "終了")
            {
                this.debugLabel.Text = this.debugMsg + "ContentsStart() 終了";

                // アプリケーションを終了させる
                this.Close();
                Environment.Exit(0);
            }

            string pictureFullPath = pictureFolderPath + "\\" + pictureFile;

            // 正解を決定する関数
            string rightName = this.DecideRightAnswer(arr, pictureFile);

            // 出題される顔写真が決まった時点で、正答を画面上に設定して、Unvisibleにしておく
            this.rightAnswerTextBox.Text = rightName;

            // 顔写真を表示する関数
            this.ResizeAndDisplay(pictureFullPath);
        }

        // 2つの戻り値を返す
        // 問題として表示する画像を選択する関数
        // 第一引数：正解の名前と画像ファイル名を持った配列
        // 第二引数：画像ファイル名(戻り値)
        // 第三引数：配列の何番目の要素から始めるか指定する値
        // 第四引数：出題する配列の要素番号(戻り値)
        private void PickupPicture(string[,] array, out string picName, int inputNum, out int indexNum)
        {
            picName = string.Empty;

            // ヘッダーを避ける
            indexNum = ++inputNum;

            // 配列の要素数を取得する
            int fullIndexNum = array.GetLength(0);

            if (Properties.Settings.Default.questioning_pattern == "１．上から順番に出題")
            {
                if (indexNum < fullIndexNum)
                {
                    // 上から順番に出題する
                    picName = array[indexNum, 1];
                }
                else
                {
                    this.debugLabel.Text = this.debugMsg + "PickupPicture() 上から順番に出題：end";
                    picName = "終了";

                    // アプリケーションを終了させる
                    this.Close();
                    Environment.Exit(0);
                }

                // indexNumをApp.configに設定する
                Properties.Settings.Default.questioning_index = indexNum;
            }
            else
            {
                // ランダムに選出する
                int randumNum = this.GetRandomNum(fullIndexNum);
                picName = array[randumNum, 1];

                // indexNumをApp.configに設定する
                Properties.Settings.Default.questioning_index = randumNum;
            }
        }

        // ランダムに数値を生成する関数
        // 第一引数：配列の要素数
        // 戻り値：ランダムに生成した整数
        private int GetRandomNum(int fullIndexNum)
        {
            Random random = new System.Random();
            int randomNum = random.Next(1, fullIndexNum - 1);
            return randomNum;
        }

        // PictureBoxに画像をリサイズしてから表示する関数
        // 第一引数：PictureBoxに表示する画像のフルパス
        private void ResizeAndDisplay(string filePath)
        {
            this.debugLabel.Text = this.debugMsg + "ResizeAndDisplay() START";

            Bitmap bmp = new Bitmap(filePath);

            int resizeWidrh = 500;
            int resizeHeight = (int)(bmp.Height * ((double)resizeWidrh / (double)bmp.Height));

            Bitmap resizeBmp = new Bitmap(resizeWidrh, resizeHeight);
            Graphics graphic = Graphics.FromImage(resizeBmp);
            graphic.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            graphic.DrawImage(bmp, 0, 0, resizeWidrh, resizeHeight);

            // リソースの解放
            graphic.Dispose();
            bmp.Dispose();

            // 画面上に表示する
            this.pictureBox.Image = resizeBmp;
        }

        // 回答ボタンクリック関数
        private void AnswerButton_Click(object sender, EventArgs e)
        {
            this.debugLabel.Text = this.debugMsg + "AnswerButton_Click() START";

            // 答え合わせを行う
            this.CheckingAnswer();
        }

        // 答え合わせを行う関数
        private void CheckingAnswer()
        {
            this.debugLabel.Text = this.debugMsg + "CheckingAnswer() START";

            // 回答を正答と比較する
            if (this.textBox1.Text == this.rightAnswerTextBox.Text)
            {
                this.debugLabel.Text = this.debugMsg + "AnswerButton_Click() 正解！";
                this.ScreenUpdate_RightAnswer();
            }
            else
            {
                this.debugLabel.Text = this.debugMsg + "AnswerButton_Click() 不正解！";
                this.ScreenUpdate_MistakeAnswer();
            }
        }

        // キーが押された場合の処理を実行する関数
        // Lキー：入力なし方式で正解の場合の入力
        // Kキー：入力なし方式で不正解の場合の入力
        private void AnswerButton_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.L)
            {
                this.debugLabel.Text = this.debugMsg + "AnswerButton_KeyUp() 正解！";

                // 正解音を鳴らす
                // this.PlayCorrectAnswer();

                // 正解なので、正解の時用の画面更新関数を実行する
                this.ScreenUpdate_RightAnswer();

                // 正解音を停止する
                // StopCorrectAnswer();
            }
            else if (e.KeyData == Keys.K)
            {
                this.debugLabel.Text = this.debugMsg + "AnswerButton_KeyUp() 不正解！";

                // 不正解音を鳴らす
                // this.PlayWrongAnswer();

                // 不正解なので、不正解の時用の画面更新関数を実行する
                this.ScreenUpdate_MistakeAnswer();

                // 不正解音を停止する
                // StopWrongAnswer();
            }
        }

        // ClosedXMLを使ってエクセルファイルの内容を配列にマッピングする関数
        // 戻り値：2次元配列
        private string[,] ExtractExcelByClosedXML()
        {
            string filePath = Properties.Settings.Default.excel_filepath;

            XLWorkbook workbook = new XLWorkbook(filePath);

            // 1番目のシートをワークシートに設定する
            IXLWorksheet worksheet = workbook.Worksheet(1);

            long lastRow = worksheet.LastRowUsed().RowNumber();
            long lastCol = worksheet.LastColumnUsed().ColumnNumber();
            long arrayRow = 0;
            long arrayCol = 0;

            var firstCell = worksheet.FirstCellUsed();
            var lastCell = worksheet.LastCellUsed();

            // 2次元配列を宣言
            string[,] array = new string[lastRow, lastCol];

            // 行数分ループ
            for (int lastRowCount = 1; lastRowCount <= lastRow; lastRowCount++)
            {
                // 列数分ループ
                for (int lastColCount = 1; lastColCount <= lastCol; lastColCount++)
                {
                    var xLCellValue = worksheet.Cell(lastRowCount, lastColCount);
                    array[arrayRow, arrayCol] = xLCellValue.Value.ToString();

                    arrayCol++;
                }

                arrayRow++;
                arrayCol = 0;
            }

            return array;
        }

        // 表示された画像に対して正解の名前を設定する関数
        // 第一引数：正解の名前と画像ファイル名を持った配列
        // 第二引数：コンテンツ画面に表示されている画像ファイル名
        // 戻り値：正解の名前
        private string DecideRightAnswer(string[,] arr, string pictureFile)
        {
            string rightName = null;

            int arrayLength = arr.GetLength(0);

            for (int indexNum = 0; indexNum < arrayLength; indexNum++)
            {
                if (arr[indexNum, 1] == pictureFile)
                {
                    rightName = arr[indexNum, 0];
                    break;
                }
            }

            return rightName;
        }

        // 次の問題へ進むボタンがクリックされた時の関数
        // 画面を初期化して、再度コンテンツを開始する
        private void NextQuestionButton_Click(object sender, EventArgs e)
        {
            this.ScreenUpdate_Initial();
            this.ContentsStart();
        }

        // コンテンツ画面の初期化関数
        private void ScreenUpdate_Initial()
        {
            this.debugLabel.Text = this.debugMsg + "ScreenUpdate_Initial() START";

            this.textBox1.Text = string.Empty;

            // 正解
            this.collectAnswerLabel.Visible = false;
            this.rightAnswerTitle.Visible = false;
            this.rightAnswerTextBox.Visible = false;
            this.rightAnswerAssistLabel.Visible = false;

            // 不正解
            this.mistakeAnswerLabel.Visible = false;
            this.rightAnswerTitle.Visible = false;
            this.rightAnswerTextBox.Visible = false;
            this.rightAnswerAssistLabel.Visible = false;

            // 画面のフォーカスを回答ボタンに与える
            this.answerButton.Focus();
        }

        // 回答方式に合わせて画面を更新する処理
        private void ScreenUpdate_ContentsType()
        {
            // 回答方式の設定値を読み出す
            string questionType = Properties.Settings.Default.question_type;

            switch (questionType)
            {
                case "１．自由回答方式":
                    this.ScreenUpdate_free();
                    break;
                case "２．YES/NO方式":
                    this.ScreenUpdate_free();
                    break;
                case "３．3択形式":
                    this.ScreenUpdate_free();
                    break;
                case "４．入力なし方式":
                    this.ScreenUpdate_noneInput();
                    break;
            }
        }

        // 回答が正解だった際のコンテンツ画面更新関数
        private void ScreenUpdate_RightAnswer()
        {
            this.debugLabel.Text = this.debugMsg + "ScreenUpdate_RightAnswer() START";

            // 不正解
            this.mistakeAnswerLabel.Visible = false;

            // 正解
            if (Properties.Settings.Default.question_type != "４．入力なし方式")
            {
                this.collectAnswerLabel.Visible = true;
            }
            else
            {
                this.collectAnswerLabel.Visible = false;
            }

            this.rightAnswerTitle.Visible = true;
            this.rightAnswerTextBox.Visible = true;
            this.rightAnswerAssistLabel.Visible = true;

            // 次の問題へボタンにフォーカスを与える
            this.nextQuestionButton.Focus();
        }

        // 回答が不正解だった際のコンテンツ画面更新関数
        private void ScreenUpdate_MistakeAnswer()
        {
            this.debugLabel.Text = this.debugMsg + "ScreenUpdate_MistakeAnswer() START";

            // 正解
            this.collectAnswerLabel.Visible = false;

            // 不正解
            if (Properties.Settings.Default.question_type != "４．入力なし方式")
            {
                this.mistakeAnswerLabel.Visible = true;
            }
            else
            {
                this.mistakeAnswerLabel.Visible = false;
            }

            this.rightAnswerTitle.Visible = true;
            this.rightAnswerTextBox.Visible = true;
            this.rightAnswerAssistLabel.Visible = true;

            // 次の問題へボタンにフォーカスを与える
            this.nextQuestionButton.Focus();
        }

        // SmallBasicを使用してMP3の再生を行う関数(正解音)
        private void PlayCorrectAnswer()
        {
            this.debugLabel.Text = this.debugMsg + "PlayCorrectAnswer() START";

            Microsoft.SmallBasic.Library.Sound.Play("Quiz-Correct_Answer02-1.mp3");
        }

        // SmallBasicを使用してMP3の停止を行う関数(正解音)
        private void StopCorrectAnswer()
        {
            this.debugLabel.Text = this.debugMsg + "StopCorrectAnswer() START";

            Microsoft.SmallBasic.Library.Sound.Stop("Quiz-Correct_Answer02-1.mp3");
        }

        // SmallBasicを使用してMP3の再生を行う関数(不正解音)
        private void PlayWrongAnswer()
        {
            this.debugLabel.Text = this.debugMsg + "PlayWrongAnswer() START";

            Microsoft.SmallBasic.Library.Sound.Play("Quiz-Wrong_Buzzer02-1.mp3");
        }

        // SmallBasicを使用してMP3の停止を行う関数(不正解音)
        private void StopWrongAnswer()
        {
            this.debugLabel.Text = this.debugMsg + "StopWrongAnswer() START";

            Microsoft.SmallBasic.Library.Sound.Stop("Quiz-Wrong_Buzzer02-1.mp3");
        }

        // 回答方式が"自由回答方式"の場合に画面を更新する関数
        private void ScreenUpdate_free()
        {
            this.debugLabel.Text = this.debugMsg + "ScreenUpdate_free() START";
        }

        // 回答方式が"入力なし方式"の場合に画面を更新する関数
        private void ScreenUpdate_noneInput()
        {
            this.debugLabel.Text = this.debugMsg + "ScreenUpdate_noneInput() START";
            this.answerLabel.Visible = false;
            this.textBox1.Visible = false;
            this.answerButton.Text = "正解を見る！";
        }

        // 画像を表示するPictureBoxがクリックされた時の関数
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.debugLabel.Text = this.debugMsg + "PictureBox1_Click() START";
        }

        // 回答用のテキストボックスの入力値が変わった際の関数
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            this.debugLabel.Text = this.debugMsg + "TextBox1_TextChanged() START";
        }
    }
}

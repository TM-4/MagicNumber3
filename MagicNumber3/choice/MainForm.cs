using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagicNumber3
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// フィールド
        /// </summary>
        int num = 0;
        int clickCount = 0;

        /// <summary>
        /// ロードイベント
        /// カーソルをテキストボックスにあわせる
        /// </summary>
        private void MainForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("このアプリはエンターキーで決定ボタンを押下できるので\nマウスを使わずにご利用いただけます");
            MessageBox.Show("どんな数字も最後には３になってしまいます\n怪しいポイントでトリックを見破ってみましょう！");
            ActiveControl = enterNum;
        }

        /// <summary>
        /// エンターキーで決定ボタンを押せる 
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            AcceptButton = btnDecision;
        }

        /// <summary>
        /// 決定ボタンを押したときの処理
        /// </summary>
        #region BtnDecisionClicked
        public void BtnDecisionClicked(object sender, EventArgs e)
        {
            clickCount++;

            switch (clickCount)
            {
                case 1:
                    firstNum.Text = enterNum.Text;
                    text.Text = "その選んだ数字である" + enterNum.Text + "に5を掛けた数字を入力してください";
                    SwitchEvent();
                    num *= 5;

                    //logに保存
                    Logger logger = new Logger();
                    logger.SaveNumberToCSV(firstNum.Text);
                    break;

                case 2:
                    if (num == Int32.Parse(enterNum.Text))
                    {
                        text.Text = "その数字に2を掛けた数字を入力してください";
                        SwitchEvent();
                        num *= 2;
                    }
                    else
                    {
                        MissNumber();
                    }
                    break;

                case 3:
                    if (num == Int32.Parse(enterNum.Text))
                    {
                        text.Text = "最初の数字で割ってください";
                        SwitchEvent();
                        num = num / Int32.Parse(firstNum.Text);
                    }
                    else
                    {
                        MissNumber();
                    }
                    break;

                case 4:
                    if (num == Int32.Parse(enterNum.Text))
                    {
                        MessageBox.Show("７を引いてください");
                        MessageBox.Show("３になりましたね？");
                        Close();
                    }
                    else
                    {
                        MissNumber();
                    }
                    break;
            }
        }
        #endregion

        /// <summary>
        /// 入力ミスの際の処理
        /// </summary>
        #region MissNumber
        private void MissNumber()
        {
            MessageBox.Show("正しい数値を入力してください");
            clickCount--;
            enterNum.Text = "";
            ActiveControl = enterNum;
        }
        #endregion

        /// <summary>
        /// switch毎の毎回の処理
        /// </summary>
        #region SwitchEvent
        private void SwitchEvent()
        {
            num = Int32.Parse(enterNum.Text);
            lblEnterNum.Text = num.ToString();
            enterNum.Text = "";
            ActiveControl = enterNum;
        }
        #endregion

        /// <summary>
        /// トリックを指摘するボタンの処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region BtnPointOutClicked
        private void BtnPointOutClicked(object sender, EventArgs e)
        {
            if (clickCount == 3)
            {
                MessageBox.Show("トリックの正体は？");

                ///PointOutForm を表示
                PointOutForm pointOutForm = new PointOutForm();
                pointOutForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("ここではありません");
            }
        }
        #endregion
    }
}

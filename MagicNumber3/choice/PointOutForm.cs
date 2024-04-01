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
    public partial class PointOutForm : Form
    {
        public PointOutForm()
        {
            InitializeComponent();
        }

        private void BtnPointOutSelect1Clicked(object sender, EventArgs e)
        {
            MessageBox.Show("違いますよ！");
        }

        private void BtnPointOutSelect2Clicked(object sender, EventArgs e)
        {
            MessageBox.Show("正解です");
            MessageBox.Show("最初の数字で割るとどんな数字でも必ず10になりますね！");
            MessageBox.Show("お疲れ様でした！");
            Close();
        }

        private void BtnPointOutSelect3Clicked(object sender, EventArgs e)
        {
            MessageBox.Show("違いますよ！");
        }
    }
}

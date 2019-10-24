using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketMachine
{
    /// <summary>
    /// 電子マネーで支払い後
    /// </summary>
    public partial class AfterPurchase_EleMoney : Form
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public AfterPurchase_EleMoney()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 読み込み時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AfterPurchase_EleMoney_Load(object sender, EventArgs e)
        {
            BalanceMoney.Text = contents.ElectronicMoneyNum.ElectronicalMoneyNum.ToString();
        }

        /// <summary>
        /// トップページへ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TopButton_Click(object sender, EventArgs e)
        {
            Top top = new Top();
            contents.Format format = new contents.Format();
            format.SeceneChange(this, top);
        }

        /// <summary>
        /// アプリケーションの×ボタン対策
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Proto_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

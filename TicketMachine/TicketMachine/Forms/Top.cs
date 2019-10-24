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
    /// トップページ(巡回する際はここに戻す)
    /// </summary>
    public partial class Top : Form
    {
        contents.Format format = new contents.Format();
        public Top()
        {
            //初期ページのため
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }
        
        /// <summary>
        /// 購入ページへ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BuyButton_Click(object sender, EventArgs e)
        {
            HowToBuy howToBuy = new HowToBuy();
            format.SeceneChange(this, howToBuy);
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

        private void Top_Load(object sender, EventArgs e)
        {

        }
    }
}

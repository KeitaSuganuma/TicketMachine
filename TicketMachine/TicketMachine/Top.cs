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
        public Top()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }
        
        /// <summary>
        /// 購入する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BuyButton_Click(object sender, EventArgs e)
        {
            HowToBuy howToBuy = new HowToBuy();
            contents.Format format = new contents.Format();

            format.SeceneChange(this, howToBuy);
        }
        

        private void Proto_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}

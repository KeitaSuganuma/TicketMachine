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
    public partial class ElectronicMoney : Form
    {
        bool isClick = false;
        public ElectronicMoney()
        {
            InitializeComponent();
        }

        private void ElectronicMoney_Load(object sender, EventArgs e)
        {

        }

        private void Proto_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// 使用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectButton_Click(object sender, EventArgs e)
        {
            BalanceMoney.Text = contents.ElectronicMoneyNum.ElectronicalMoneyNum.ToString();
            isClick = true;
        }

        /// <summary>
        /// 購入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PurchaseButton_Click(object sender, EventArgs e)
        {
            if (isClick==true&&contents.ElectronicMoneyNum.ElectronicalMoneyNum >= 124)
            {
                contents.ElectronicMoneyNum.ElectronicalMoneyNum -= 124;
                AfterPurchase_EleMoney afterPurchase = new AfterPurchase_EleMoney();
                contents.Format format = new contents.Format();
                format.SeceneChange(this, afterPurchase);
            }
        }
    }
}

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
    public partial class HowToBuy : Form
    {
        contents.Format format = new contents.Format();
        public HowToBuy()
        {
            this.FormClosing += Proto_FormClosing;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = this.Electronic_Money;
        }

        /// <summary>
        /// お金
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Money_Click(object sender, EventArgs e)
        {
            Money money = new Money();
            format.SeceneChange(this, money);
        }

        /// <summary>
        /// 電子マネーで
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Electronic_Money_Click(object sender, EventArgs e)
        {
            ElectronicMoney electronicMoney = new ElectronicMoney();
            format.SeceneChange(this, electronicMoney);
        }

        private void Proto_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

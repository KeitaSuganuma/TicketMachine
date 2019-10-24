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
    public partial class AfterPurchase_EleMoney : Form
    {
        public AfterPurchase_EleMoney()
        {
            InitializeComponent();
        }

        private void AfterPurchase_EleMoney_Load(object sender, EventArgs e)
        {
            BalanceMoney.Text = contents.ElectronicMoneyNum.ElectronicalMoneyNum.ToString();
        }


        private void Proto_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void TopButton_Click(object sender, EventArgs e)
        {
            Top top = new Top();
            contents.Format format = new contents.Format();
            format.SeceneChange(this, top);
        }
    }
}

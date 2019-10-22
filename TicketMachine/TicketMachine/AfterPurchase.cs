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
    public partial class AfterPurchase : Form
    {
        private int ChangeTenThousand;
        private int ChangeFiveThousand;
        private int ChangeOneThousand;
        private int ChangeFiveHandred;
        private int ChangeOneHandred;
        private int ChangeFifty;
        private int ChangeTen;

        public AfterPurchase()
        {
            this.FormClosing += Proto_FormClosing;
            InitializeComponent();
        }

        private void AfterPurchase_Load(object sender, EventArgs e)
        {
            MoneyBalance();

            contents.MoneyNum.TenNum += ChangeTen;
            contents.MoneyNum.FiftyNum += ChangeFifty;
            contents.MoneyNum.OneHundredNum += ChangeOneHandred;
            contents.MoneyNum.FiveHundredNum += ChangeFiveHandred;
            contents.MoneyNum.OneThousandNum += ChangeOneThousand;
            contents.MoneyNum.FiveThousandNum += ChangeFiveThousand;
            contents.MoneyNum.TenThousandNum += ChangeTenThousand;

            //残った
            TenNum.Text = contents.MoneyNum.TenNum.ToString();
            FiftyNum.Text = contents.MoneyNum.FiftyNum.ToString();
            OneHundred.Text = contents.MoneyNum.OneHundredNum.ToString();
            FiveHundred.Text = contents.MoneyNum.FiveHundredNum.ToString();
            OneThousand.Text = contents.MoneyNum.OneThousandNum.ToString();
            FiveThousand.Text = contents.MoneyNum.FiveThousandNum.ToString();
            TenThousand.Text = contents.MoneyNum.TenThousandNum.ToString();

            //使用した
            UseTen.Text = contents.MoneyNum.UseTen.ToString();
            UseFifty.Text = contents.MoneyNum.UseFifty.ToString();
            UseOneHundred.Text = contents.MoneyNum.UseOneHundred.ToString();
            UseFiveHundred.Text = contents.MoneyNum.UseFiveHundred.ToString();
            UseOneThousand.Text = contents.MoneyNum.UseOneThousand.ToString();
            UseFiveThousand.Text = contents.MoneyNum.UseFiveThousand.ToString();
            UseTenThousand.Text = contents.MoneyNum.UseTenThousand.ToString();

            //お釣り
            Balance.Text = (Money.sum - 130).ToString();

            test.Text = ChangeTenThousand + "/" + ChangeFiveThousand + "/" + ChangeOneThousand +
                "/" + ChangeFiveHandred + "/" + ChangeOneHandred + "/" + ChangeFifty + "/" + ChangeTen;
        }

        private void Proto_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Top_Click(object sender, EventArgs e)
        {
            Top top = new Top();
            contents.Format format = new contents.Format();

            format.SeceneChange(this, top);
        }

        public void MoneyBalance()
        {
            int sum = Money.sum - 130;
            ChangeTenThousand = sum / 10000;
            sum %= 10000;
            ChangeFiveThousand = sum / 5000;
            sum %= 5000;
            ChangeOneThousand = sum / 1000;
            sum %= 1000;
            ChangeFiveHandred = sum / 500;
            sum %= 500;
            ChangeOneHandred = sum / 100;
            sum %= 100;
            ChangeFifty = sum / 50;
            sum %= 50;
            ChangeTen = sum / 10;
        }
    }
}

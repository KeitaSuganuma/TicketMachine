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
    public partial class Money : Form
    {
        contents.MoneyNum moneyNum = new contents.MoneyNum();
        public static int sum = 0;

        int tenNum = 0;
        int fiftyNum = 0;
        int oneHundredNum = 0;
        int fiveHundredNum = 0;
        int oneThousandNum = 0;
        int fiveThousandNum = 0;
        int tenThousandNum = 0;

        public Money()
        {
            this.FormClosing += Proto_FormClosing;
            InitializeComponent();
        }


        private void Money_Load(object sender, EventArgs e)
        {
            moneyNum.AddItems(TenThousand, contents.MoneyNum.TenThousandNum);
            moneyNum.AddItems(FiveThousand, contents.MoneyNum.FiveThousandNum);
            moneyNum.AddItems(OneThousand, contents.MoneyNum.OneThousandNum);
            moneyNum.AddItems(FiveHundred, contents.MoneyNum.FiveHundredNum);
            moneyNum.AddItems(OneHundred, contents.MoneyNum.OneHundredNum);
            moneyNum.AddItems(Fifty, contents.MoneyNum.FiftyNum);
            moneyNum.AddItems(Ten, contents.MoneyNum.TenNum);
        }

        private void Proto_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void TenThousand_SelectedItemChanged(object sender, EventArgs e)
        {
            int num = int.Parse(TenThousand.Text);
            tenThousandNum = num * 10000;

            MoneySum();
        }

        private void FiveThousand_SelectedItemChanged(object sender, EventArgs e)
        {
            int num = int.Parse(FiveThousand.Text);
            fiveThousandNum = num * 5000;

            MoneySum();
        }

        private void OneThousand_SelectedItemChanged(object sender, EventArgs e)
        {
            int num = int.Parse(OneThousand.Text);
            oneThousandNum = num * 1000;

            MoneySum();
        }

        private void FiveHundred_SelectedItemChanged(object sender, EventArgs e)
        {
            int num = int.Parse(FiveHundred.Text);
            fiveHundredNum = num * 500;

            MoneySum();
        }

        private void OneHundred_SelectedItemChanged(object sender, EventArgs e)
        {
            int num = int.Parse(OneHundred.Text);
            oneHundredNum = num * 100;

            MoneySum();
        }

        private void Fifty_SelectedItemChanged(object sender, EventArgs e)
        {
            int num = int.Parse(Fifty.Text);
            fiftyNum = num * 50;

            MoneySum();
        }

        private void Ten_SelectedItemChanged(object sender, EventArgs e)
        {
            int num = int.Parse(Ten.Text);
            tenNum = num * 10;

            MoneySum();
        }

        /// <summary>
        /// 合計
        /// </summary>
        private void MoneySum()
        {
            sum = tenNum + fiftyNum + oneHundredNum + fiveHundredNum +
                    oneThousandNum + fiveThousandNum + tenThousandNum;
            SumMoney.Text = sum.ToString();
        }

        /// <summary>
        /// 購入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PurchaseButton_Click(object sender, EventArgs e)
        {
            if (sum >= 130)
            {
                //セッター　投入数
                contents.MoneyNum.UseTenThousand = int.Parse(TenThousand.Text);
                contents.MoneyNum.UseFiveThousand = int.Parse(FiveThousand.Text);
                contents.MoneyNum.UseOneThousand = int.Parse(OneThousand.Text);
                contents.MoneyNum.UseFiveHundred = int.Parse(FiveHundred.Text);
                contents.MoneyNum.UseOneHundred = int.Parse(OneHundred.Text);
                contents.MoneyNum.UseFifty = int.Parse(Fifty.Text);
                contents.MoneyNum.UseTen = int.Parse(Ten.Text);

                //セッター　投入数分を減らす
                contents.MoneyNum.TenNum -= contents.MoneyNum.UseTen;
                contents.MoneyNum.FiftyNum -= contents.MoneyNum.UseFifty;
                contents.MoneyNum.OneHundredNum -= contents.MoneyNum.UseOneHundred;
                contents.MoneyNum.FiveHundredNum -= contents.MoneyNum.UseFiveHundred;
                contents.MoneyNum.OneThousandNum -= contents.MoneyNum.UseOneThousand;
                contents.MoneyNum.FiveThousandNum -= contents.MoneyNum.UseFiveThousand; ;
                contents.MoneyNum.TenThousandNum -= contents.MoneyNum.UseTenThousand;

                AfterPurchase afterPurchase = new AfterPurchase();
                contents.Format format = new contents.Format();
                format.SeceneChange(this, afterPurchase);
            }
        }
    }
}

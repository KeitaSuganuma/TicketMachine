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
    /// お金で支払い
    /// </summary>
    public partial class Money : Form
    {
        //すべての合計値
        public static int sum = 0;
        contents.Format format = new contents.Format();
        contents.MoneyNum moneyNum = new contents.MoneyNum();

        //個々の合計＝＝＝＝＝＝＝＝＝＝＝＝＝
        int tenNum = 0;
        int fiftyNum = 0;
        int oneHundredNum = 0;
        int fiveHundredNum = 0;
        int oneThousandNum = 0;
        int fiveThousandNum = 0;
        int tenThousandNum = 0;
        //＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Money()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 読み込み時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Money_Load(object sender, EventArgs e)
        {
            sum = 0;

            //アイテム追加＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝
            format.AddItems(TenThousand, contents.MoneyNum.TenThousandNum);
            format.AddItems(FiveThousand, contents.MoneyNum.FiveThousandNum);
            format.AddItems(OneThousand, contents.MoneyNum.OneThousandNum);
            format.AddItems(FiveHundred, contents.MoneyNum.FiveHundredNum);
            format.AddItems(OneHundred, contents.MoneyNum.OneHundredNum);
            format.AddItems(Fifty, contents.MoneyNum.FiftyNum);
            format.AddItems(Ten, contents.MoneyNum.TenNum);
            //＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝
        }

        /// <summary>
        /// 一万円
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TenThousand_SelectedItemChanged(object sender, EventArgs e)
        {
            int num = int.Parse(TenThousand.Text);
            tenThousandNum = num * 10000;

            MoneySum();
        }

        /// <summary>
        /// 五千円
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FiveThousand_SelectedItemChanged(object sender, EventArgs e)
        {
            int num = int.Parse(FiveThousand.Text);
            fiveThousandNum = num * 5000;

            MoneySum();
        }

        /// <summary>
        /// 千円
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OneThousand_SelectedItemChanged(object sender, EventArgs e)
        {
            int num = int.Parse(OneThousand.Text);
            oneThousandNum = num * 1000;

            MoneySum();
        }

        /// <summary>
        /// 五百円
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FiveHundred_SelectedItemChanged(object sender, EventArgs e)
        {
            int num = int.Parse(FiveHundred.Text);
            fiveHundredNum = num * 500;

            MoneySum();
        }

        /// <summary>
        /// 百円
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OneHundred_SelectedItemChanged(object sender, EventArgs e)
        {
            int num = int.Parse(OneHundred.Text);
            oneHundredNum = num * 100;

            MoneySum();
        }

        /// <summary>
        /// 五十円
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Fifty_SelectedItemChanged(object sender, EventArgs e)
        {
            int num = int.Parse(Fifty.Text);
            fiftyNum = num * 50;

            MoneySum();
        }

        /// <summary>
        /// 十円
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            if (sum >= contents.TicketPrice.MoneyPrice)
            {
                //使用した各金種の数を代入
                contents.MoneyNum.UseTenThousand = int.Parse(TenThousand.Text);
                contents.MoneyNum.UseFiveThousand = int.Parse(FiveThousand.Text);
                contents.MoneyNum.UseOneThousand = int.Parse(OneThousand.Text);
                contents.MoneyNum.UseFiveHundred = int.Parse(FiveHundred.Text);
                contents.MoneyNum.UseOneHundred = int.Parse(OneHundred.Text);
                contents.MoneyNum.UseFifty = int.Parse(Fifty.Text);
                contents.MoneyNum.UseTen = int.Parse(Ten.Text);

                //持っている各金種から数減らす
                contents.MoneyNum.TenNum -= contents.MoneyNum.UseTen;
                contents.MoneyNum.FiftyNum -= contents.MoneyNum.UseFifty;
                contents.MoneyNum.OneHundredNum -= contents.MoneyNum.UseOneHundred;
                contents.MoneyNum.FiveHundredNum -= contents.MoneyNum.UseFiveHundred;
                contents.MoneyNum.OneThousandNum -= contents.MoneyNum.UseOneThousand;
                contents.MoneyNum.FiveThousandNum -= contents.MoneyNum.UseFiveThousand; ;
                contents.MoneyNum.TenThousandNum -= contents.MoneyNum.UseTenThousand;

                AfterPurchase_Money afterPurchase = new AfterPurchase_Money();
                contents.Format format = new contents.Format();
                format.SeceneChange(this, afterPurchase);
            }
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

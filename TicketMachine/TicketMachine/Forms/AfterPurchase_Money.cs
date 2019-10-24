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
    /// お金で支払い後
    /// </summary>
    public partial class AfterPurchase_Money : Form
    {
        contents.Format format = new contents.Format();
        //個々のおつり＝＝＝＝＝＝＝＝＝＝＝＝＝
        private int ChangeTenThousandNum = 0;
        private int ChangeFiveThousandNum = 0;
        private int ChangeOneThousandNum = 0;
        private int ChangeFiveHandredNum = 0;
        private int ChangeOneHandredNum = 0;
        private int ChangeFiftyNum = 0;
        private int ChangeTenNum = 0;
        //＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public AfterPurchase_Money()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 読み込み時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AfterPurchase_Load(object sender, EventArgs e)
        {
            //お釣り計算
            MoneyBalance();
            
            //各おつりを持っている各金種へ追加
            contents.MoneyNum.TenNum += ChangeTenNum;
            contents.MoneyNum.FiftyNum += ChangeFiftyNum;
            contents.MoneyNum.OneHundredNum += ChangeOneHandredNum;
            contents.MoneyNum.FiveHundredNum += ChangeFiveHandredNum;
            contents.MoneyNum.OneThousandNum += ChangeOneThousandNum;
            contents.MoneyNum.FiveThousandNum += ChangeFiveThousandNum;
            contents.MoneyNum.TenThousandNum += ChangeTenThousandNum;

            //使用した
            Label[] ListUseMoneyLabel = { UseTen, UseFifty, UseOneHundred, UseFiveHundred, UseOneThousand, UseFiveThousand, UseTenThousand };
            int[] ListUseMoneyNum = { contents.MoneyNum.UseTen, contents.MoneyNum.UseFifty, contents.MoneyNum.UseOneHundred, contents.MoneyNum.UseFiveHundred, contents.MoneyNum.UseOneThousand, contents.MoneyNum.UseFiveThousand, contents.MoneyNum.UseTenThousand };
            format.ToText("使用数 : ", ListUseMoneyLabel, ListUseMoneyNum);

            //残り一覧
            Label[] ListMoneyLabel = { TenNum, FiftyNum, OneHundred, FiveHundred, OneThousand, FiveThousand, TenThousand };
            int[] ListMoneyNum = { contents.MoneyNum.TenNum, contents.MoneyNum.FiftyNum, contents.MoneyNum.OneHundredNum, contents.MoneyNum.FiveHundredNum, contents.MoneyNum.OneThousandNum, contents.MoneyNum.FiveThousandNum, contents.MoneyNum.TenThousandNum };
            format.ToText("残り : ", ListMoneyLabel, ListMoneyNum);

            //おつり個別
            Label[] ListChangeMoneyLabel = { ChangeTen, ChangeFifty, ChangeOneHundred, ChangeFiveHundred, ChangeOneThousand, ChangeFiveThousand, ChangeTenThousand };
            int[] ListChangeMoneyNum = { ChangeTenNum,ChangeFiftyNum,ChangeOneHandredNum,ChangeFiveHandredNum,ChangeOneThousandNum,ChangeFiveThousandNum,ChangeTenThousandNum};
            format.ToText("おつり : ", ListChangeMoneyLabel, ListChangeMoneyNum);

            //お釣り合計
            Balance.Text = (Money.sum - contents.TicketPrice.MoneyPrice).ToString();
        }

        /// <summary>
        /// トップページへ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Top_Click(object sender, EventArgs e)
        {
            Top top = new Top();
            contents.Format format = new contents.Format();
            format.SeceneChange(this, top);
        }

        /// <summary>
        /// お釣り計算
        /// </summary>
        public void MoneyBalance()
        {
            int sum = 0;
            sum = Money.sum - 130;
            ChangeTenThousandNum = sum / 10000; 
            sum %= 10000;
            ChangeFiveThousandNum = sum / 5000;
            sum %= 5000;
            ChangeOneThousandNum = sum / 1000;
            sum %= 1000;
            ChangeFiveHandredNum = sum / 500;
            sum %= 500;
            ChangeOneHandredNum = sum / 100;
            sum %= 100;
            ChangeFiftyNum = sum / 50;
            sum %= 50;
            ChangeTenNum = sum / 10;
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

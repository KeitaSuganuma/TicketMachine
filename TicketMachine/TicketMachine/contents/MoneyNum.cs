using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TicketMachine.contents
{
    class MoneyNum
    {
        private static int tenThousand = 1;
        private static int fiveThousand = 1;
        private static int oneThousand = 1;
        private static int fiveHundred = 1;
        private static int oneHundred = 2;
        private static int fifty = 3;
        private static int ten = 15;


        /// <summary>
        /// １万円
        /// </summary>
        public static int TenThousandNum
        {
            get { return tenThousand; }
            set { if (tenThousand > 0) { tenThousand = value; } }
        }

        /// <summary>
        /// 使用した一万円
        /// </summary>
        public static int UseTenThousand{ get; set; }

        /// <summary>
        /// ５千円
        /// </summary>
        public static int FiveThousandNum
        {
            get { return fiveThousand; }
            set { if (fiveThousand > 0) { fiveThousand = value; } }
        }

        /// <summary>
        /// 使用した五千円
        /// </summary>
        public static int UseFiveThousand { get; set; }

        /// <summary>
        /// １千円
        /// </summary>
        public static int OneThousandNum
        {
            get { return oneThousand; }
            set { if (oneThousand > 0) { oneThousand = value; } }
        }

        /// <summary>
        /// 使用した１千円
        /// </summary>
        public static int UseOneThousand { get; set; }

        /// <summary>
        ///　５００円
        /// </summary>
        public static int FiveHundredNum
        {
            get { return fiveHundred; }
            set { if (fiveHundred > 0) { fiveHundred = value; } }
        }
        /// <summary>
        /// 使用した500円
        /// </summary>
        public static int UseFiveHundred { get; set; }

        /// <summary>
        /// １００円
        /// </summary>
        public static int OneHundredNum
        {
            get { return oneHundred; }
            set { if (oneHundred > 0) { oneHundred = value; } }
        }

        /// <summary>
        /// 使用した100円
        /// </summary>
        public static int UseOneHundred { get; set; }

        /// <summary>
        /// ５０円
        /// </summary>
        public static int FiftyNum
        {
            get { return fifty; }
            set { if (fifty > 0) { fifty = value; } }
        }

        /// <summary>
        /// 使用した50円
        /// </summary>
        public static int UseFifty { get; set; }

        /// <summary>
        /// １０円
        /// </summary>
        public static int TenNum
        {
            get { return ten; }
            set { if (ten > 0) { ten = value; } }
        }

        /// <summary>
        /// 使用した10円
        /// </summary>
        public static int UseTen { get; set; }

        /// <summary>
        ///　アイテムの大きさ分を追加
        /// </summary>
        /// <param name="domain"></param>
        /// <param name="numLange"></param>
        public void AddItems(DomainUpDown domain,int numLange)
        {
            for(int i = 0; i <= numLange; i++) { domain.Items.Add(i); }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TicketMachine.contents
{
    /// <summary>
    /// お金
    /// </summary>
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
        /// 持っている１万円
        /// </summary>
        public static int TenThousandNum
        {
            get { return tenThousand; }
            set { if (tenThousand >= 0) { tenThousand = value; } }
        }

        /// <summary>
        /// 使用した一万円
        /// </summary>
        public static int UseTenThousand { get; set; }

        //===============================================================

        /// <summary>
        /// 持っている５千円
        /// </summary>
        public static int FiveThousandNum
        {
            get { return fiveThousand; }
            set { if (fiveThousand >= 0) { fiveThousand = value; } }
        }

        /// <summary>
        /// 使用した五千円
        /// </summary>
        public static int UseFiveThousand { get; set; }


        //===============================================================

        /// <summary>
        /// 持っている１千円
        /// </summary>
        public static int OneThousandNum
        {
            get { return oneThousand; }
            set { if (oneThousand >= 0) { oneThousand = value; } }
        }

        /// <summary>
        /// 使用した１千円
        /// </summary>
        public static int UseOneThousand { get; set; }

        //===============================================================

        /// <summary>
        ///　持っている５００円
        /// </summary>
        public static int FiveHundredNum
        {
            get { return fiveHundred; }
            set { if (fiveHundred >= 0) { fiveHundred = value; } }
        }
        /// <summary>
        /// 使用した500円
        /// </summary>
        public static int UseFiveHundred { get; set; }

        //===============================================================

        /// <summary>
        /// 持っている１００円
        /// </summary>
        public static int OneHundredNum
        {
            get { return oneHundred; }
            set { if (oneHundred >= 0) { oneHundred = value; } }
        }

        /// <summary>
        /// 使用した100円
        /// </summary>
        public static int UseOneHundred { get; set; }


        //===============================================================

        /// <summary>
        /// 持っている５０円
        /// </summary>
        public static int FiftyNum
        {
            get { return fifty; }
            set { if (fifty >= 0) { fifty = value; } }
        }

        /// <summary>
        /// 使用した50円
        /// </summary>
        public static int UseFifty { get; set; }


        //===============================================================

        /// <summary>
        /// 持っている１０円
        /// </summary>
        public static int TenNum
        {
            get { return ten; }
            set { if (ten >= 0) { ten = value; } }
        }

        /// <summary>
        /// 使用した10円
        /// </summary>
        public static int UseTen { get; set; }

        //===============================================================
       
    }
}

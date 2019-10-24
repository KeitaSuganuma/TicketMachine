using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketMachine.contents
{
    /// <summary>
    /// 電子マネー
    /// </summary>
    class ElectronicMoneyNum
    {
        private static int electronicalMoney = 1000;

        /// <summary>
        /// 電子マネー残高
        /// </summary>
        public static int ElectronicalMoneyNum
        {
            get { return electronicalMoney; }
            set { if (electronicalMoney >= 0) { electronicalMoney = value; } }
        }
    }
}

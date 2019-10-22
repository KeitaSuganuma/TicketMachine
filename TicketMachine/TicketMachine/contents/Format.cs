using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketMachine.contents
{
    class Format
    {
        /// <summary>
        /// シーンを変える(フォームの切り替え)
        /// </summary>
        /// <param name="beforeForm"></param>
        /// <param name="afterForm"></param>
        public void SeceneChange(Form beforeForm, Form afterForm)
        {
            afterForm.StartPosition = FormStartPosition.CenterScreen;
            afterForm.Show();

            beforeForm.Hide();
        }
    }
}

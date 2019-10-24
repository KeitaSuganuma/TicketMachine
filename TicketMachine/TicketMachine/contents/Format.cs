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

        /// <summary>
        /// ラベルに該当のINT書き込み
        /// </summary>
        /// <param name="title"></param>
        /// <param name="labels"></param>
        /// <param name="nums"></param>
        public void ToText(String title, Label[] labels, int[] nums)
        {
            for (int i = 0; i < labels.Length; i++)
            {
                labels[i].Text = title + nums[i].ToString();
            }
        }
    }
}

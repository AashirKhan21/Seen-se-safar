using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seensesafar
{
    class MainClass
    {
        // Method For Showing Message Box instead of using default method of Message box we create
        // method where we just pass the caption, message, and type

        public static DialogResult MSGBox(string msg, string caption, string type)
        {
            if (type == "Success") // If the message result is success we return this
            {
                return MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else  // If the message result is error then return this
            {
                return MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

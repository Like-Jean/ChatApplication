using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApplicationClient
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            HideOnStartupApplicationContext context = new HideOnStartupApplicationContext(new base_form());
            Application.Run(context);
            //chat_form charWin = new chat_form();
            //charWin.ShowDialog();
        }
    }
}

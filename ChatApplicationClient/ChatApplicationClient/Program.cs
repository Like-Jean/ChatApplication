﻿using System;
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
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> e3a5133b9bac634b9919edc1ccf1a605f8ea649a
            HideOnStartupApplicationContext context = new HideOnStartupApplicationContext(new base_form());
            Application.Run(context);
            //chat_form charWin = new chat_form();
            //charWin.ShowDialog();
<<<<<<< HEAD
=======
=======
            Application.Run(new login_form());
>>>>>>> 6b058e11aa29a6d6a129e2630e7899d0ae2a8fc3
>>>>>>> e3a5133b9bac634b9919edc1ccf1a605f8ea649a
        }
    }
}

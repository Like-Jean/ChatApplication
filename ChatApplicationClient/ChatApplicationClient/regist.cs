using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApplicationClient
{
    public partial class regist : Form
    {
        public regist()
        {
            InitializeComponent();
            //form1.client.addText += new Net.addTextDel(showMsgBox);
        }

        private void regist_bnt_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            Message.Message msg = new Message.Message("0", name_txt.Text);
            msg = new Message.Message("1", password_txt.Text);
=======
<<<<<<< HEAD
            Message.Message msg = new Message.Message("0", name_txt.Text);
            msg = new Message.Message("1", password_txt.Text);
=======
            Net.Message msg = new Net.Message("0", name_txt.Text);
            msg = new Net.Message("1", password_txt.Text);
>>>>>>> 6b058e11aa29a6d6a129e2630e7899d0ae2a8fc3
>>>>>>> e3a5133b9bac634b9919edc1ccf1a605f8ea649a
        }

       
        /// <summary>
       
        /// </summary>
        /// <param name="userName"></param>
        public void showMsgBox(string msg)
        {
            MessageBox.Show(msg);
        }
    }
}

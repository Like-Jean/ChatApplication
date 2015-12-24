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
            Message.Message msg = new Message.Message("0", name_txt.Text);
            msg = new Message.Message("1", password_txt.Text);
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

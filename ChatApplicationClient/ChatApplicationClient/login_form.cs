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
    public partial class login_form : Form
    {

        public chat_form form1;
        private regist regist_form;

        public login_form()
        {
            InitializeComponent();
            form1 = new chat_form();
            form1.client.addTextEvent += new Net.addTextDel(showMsgBox);
            form1.client.loginToSysEvent += new Net.loginToSysDel(loginToSys);
        }

        private void label1_Click(object sender, EventArgs e) {}

        private void regist_btn_Click(object sender, EventArgs e)
        {
            regist_form = new regist();
            regist_form.Visible = true;
            //Net.Message msg = new Net.Message("0", name_txt.Text);
            //regist_form.client.sendMessage(msg);
            //msg = new Net.Message("1", password_txt.Text);
            //regist_form.client.sendMessage(msg);
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            Net.Message msg = new Net.Message("2", name_txt.Text);
            form1.client.sendMessage(msg);
            msg = new Net.Message("3", password_txt.Text);
            form1.client.sendMessage(msg);
        }
        public void showMsgBox(object sender,EventArgs e,string msg)
        {
            MessageBox.Show(msg);
        }
        public void loginToSys(object sender, EventArgs e)
        {
            form1.Visible = true;
            form1.startConnect();
        }
    }
}

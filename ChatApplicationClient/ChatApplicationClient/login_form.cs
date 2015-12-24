using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

<<<<<<< HEAD
public delegate void login_sendMessageDel(object sender, EventArgs e, Message.Message msg);
namespace ChatApplicationClient
{
    public partial class login_window : Form
    {
        public event login_sendMessageDel login_sendMessageEvent;
        protected virtual void sendMsg(EventArgs e, Message.Message msg)
        {
            login_sendMessageDel temp = login_sendMessageEvent; //MulticastDelegate一个委托链表
            //通知所有已订阅事件的对象
            if (temp != null)
                temp(this, e, msg); //通过事件NewMail(一种特殊的委托)逐一回调客户端的方法

        }
        public login_window()
        {
            InitializeComponent();
            this.Show();
=======
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
>>>>>>> 6b058e11aa29a6d6a129e2630e7899d0ae2a8fc3
        }

        private void label1_Click(object sender, EventArgs e) {}

        private void regist_btn_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            EventArgs myEvent = new EventArgs();
            Message.Message msg = new Message.Message("0", name_txt.Text);
            sendMsg(myEvent, msg);
            msg = new Message.Message("1", password_txt.Text);
            sendMsg(myEvent, msg);
=======
            regist_form = new regist();
            regist_form.Visible = true;
            //Net.Message msg = new Net.Message("0", name_txt.Text);
            //regist_form.client.sendMessage(msg);
            //msg = new Net.Message("1", password_txt.Text);
            //regist_form.client.sendMessage(msg);
>>>>>>> 6b058e11aa29a6d6a129e2630e7899d0ae2a8fc3
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            EventArgs myEvent = new EventArgs();
            Message.Message msg = new Message.Message("2", name_txt.Text);
            sendMsg(myEvent, msg);
            msg = new Message.Message("3", password_txt.Text);
            sendMsg(myEvent, msg);
        }

=======
            Net.Message msg = new Net.Message("2", name_txt.Text);
            form1.client.sendMessage(msg);
            msg = new Net.Message("3", password_txt.Text);
            form1.client.sendMessage(msg);
        }
>>>>>>> 6b058e11aa29a6d6a129e2630e7899d0ae2a8fc3
        public void showMsgBox(object sender,EventArgs e,string msg)
        {
            MessageBox.Show(msg);
        }
<<<<<<< HEAD

        private delegate void closeFormDel();
        public void closeForm()
        {
            if (this.InvokeRequired)
            {
                closeFormDel d = new closeFormDel(closeForm);
                this.Invoke(d);
            }
            else
            {
                this.Visible = false;
            }
        }
      
=======
        public void loginToSys(object sender, EventArgs e)
        {
            form1.Visible = true;
            form1.startConnect();
        }
>>>>>>> 6b058e11aa29a6d6a129e2630e7899d0ae2a8fc3
    }
}

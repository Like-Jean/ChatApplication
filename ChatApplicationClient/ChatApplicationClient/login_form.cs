using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }

        private void label1_Click(object sender, EventArgs e) {}

        private void regist_btn_Click(object sender, EventArgs e)
        {
            EventArgs myEvent = new EventArgs();
            Message.Message msg = new Message.Message("0", name_txt.Text);
            sendMsg(myEvent, msg);
            msg = new Message.Message("1", password_txt.Text);
            sendMsg(myEvent, msg);
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            EventArgs myEvent = new EventArgs();
            Message.Message msg = new Message.Message("2", name_txt.Text);
            sendMsg(myEvent, msg);
            msg = new Message.Message("3", password_txt.Text);
            sendMsg(myEvent, msg);
        }

        public void showMsgBox(object sender,EventArgs e,string msg)
        {
            MessageBox.Show(msg);
        }

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
      
    }
}

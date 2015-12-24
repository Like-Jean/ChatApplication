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
    public partial class base_form : Form
    {
        private login_window login;
        private chat_form chat;
        private int port;   //端口
        private bool isExit = false;
        public Client.ClientGestTopics client;
        private static bool isLog = false;

        public delegate void isLoginedDel(object sender, EventArgs e);
        public event isLoginedDel isLoginedEvent;
       
       
        //property,when loginState changed, trigger the showCahat function and show chat win
        public bool loginState
        {
            get { return isLog; }
            set
            {
                isLog = value;
                if (isLog==true)
                {
                    EventArgs ev = new EventArgs();
                    showChat(this,ev);
                }
                
            }
        }

        public base_form()
        {
            InitializeComponent();
            client = new Client.ClientGestTopics("visitor");
            client.setServer();
            startConnect();
            login = new login_window();
            chat = new chat_form();
            chat.Visible = false;

            client.showMsgEvent += new Net.showMsgDel(login.showMsgBox);
            login.login_sendMessageEvent += new login_sendMessageDel(sendMsg);
            client.loginToSysEvent += new Net.loginToSysDel(loginToSys);
            isLoginedEvent += new isLoginedDel(showChatForm);
        }

        private void base_form_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        public void startConnect()
        {
            client.connect();
        }
        private void sendMsg(object sender, EventArgs e, Message.Message msg)
        {
            client.sendMessage(msg);
        }

        private void showChat(object sender, EventArgs e)
        {
            isLoginedDel temp=isLoginedEvent; 
            if (temp != null)
            {
                temp(this, e);
            }
        }

        private void showChatForm(object sender, EventArgs e)
        {
            try
            {
                if (chat.InvokeRequired)
                {
                    isLoginedDel d = showChatForm;
                    chat.Invoke(d, new object[] { sender, e });
                }
                else
                {
                    chat.Visible = true;
                    chat.chat_sendMsgEvent += new chat_sendMsgDel(sendMsg);
                    client.addTextEvent += new Net.addTextDel(chat.AddTalkMessage);
                    client.getTopicEvent += new Net.getTopicDel(chat.addTopicToList);
                }
                //chatForm.startConnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //when client login,close loginForm and show chatform
        public void loginToSys(object sender, EventArgs e)
        {
            try
            {
                login.closeForm();
                loginState = true;
                client.listTopics();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ChatApplicationClient
{
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> e3a5133b9bac634b9919edc1ccf1a605f8ea649a
    public delegate void chat_sendMsgDel(object sender, EventArgs e,Message.Message msg);
    public delegate void showChatDel(object sender, EventArgs e);
    public partial class chat_form : Form
    {
        private List<TabPage> topicRoom;
        private List<ListBox> topicText;

        public event chat_sendMsgDel chat_sendMsgEvent;
        protected virtual void sendMsg(EventArgs e, Message.Message msg)
        {
            chat_sendMsgDel temp = chat_sendMsgEvent; //MulticastDelegate一个委托链表
            //通知所有已订阅事件的对象
            if (temp != null)
                temp(this, e, msg); //通过事件NewMail(一种特殊的委托)逐一回调客户端的方法

        }
<<<<<<< HEAD
=======
=======
    
    public partial class chat_form : Form
    {
        //private string ServerIP; //IP
        private int port;   //端口
        private bool isExit = false;
        public Net.TCPClient client;
       // public login login_form;
>>>>>>> 6b058e11aa29a6d6a129e2630e7899d0ae2a8fc3
>>>>>>> e3a5133b9bac634b9919edc1ccf1a605f8ea649a
        
        
        public chat_form()
        {
            InitializeComponent();
<<<<<<< HEAD
            tabPage1.Text = "Welcome";
=======
<<<<<<< HEAD
            tabPage1.Text = "Welcom";
>>>>>>> e3a5133b9bac634b9919edc1ccf1a605f8ea649a

            topicRoom = new List<TabPage>();
            topicText = new List<ListBox>();

            this.Show();
           
        }
        
        private delegate void AddTalkMessageDelegate(object sender,EventArgs e,string t,string message);
        
        public void AddTalkMessage(object sender,EventArgs e,string t,string message)
        {
            for (int i = 0; i < topicRoom.Count; i++)
            {
                if (topicRoom[i].Text.Equals(t))
                {
                    if (topicText[i].InvokeRequired)
                    {
                        AddTalkMessageDelegate d = new AddTalkMessageDelegate(AddTalkMessage);
                        topicText[i].Invoke(d, new object[] { sender, e,t, message });
                    }
                    else
                    {
                        topicText[i].Items.Add(message);
                        topicText[i].SelectedIndex = topicText[i].Items.Count - 1;
                        topicText[i].ClearSelected();
                    }
                }
            }
        }
      
<<<<<<< HEAD
=======
=======
            this.Visible = false;
            client = new Net.TCPClient("visitor");
            this.topic_list.View = View.List;
            client.setServer();
            startConnect();
            client.addTextEvent += new Net.addTextDel(AddTalkMessage);
            client.getTopicEvent += new Net.getTopicDel(addTopicToList);
            
        }

        public void startConnect()
        {
            client.connect();
        }

        private delegate void AddTalkMessageDelegate(object sender,EventArgs e,string message);
        /// <summary>
        /// 在聊天对话框（txt_Message）中追加聊天信息
        /// </summary>
        /// <param name="message"></param>
        public void AddTalkMessage(object sender,EventArgs e,string message)
        {
            if (client_recieve.InvokeRequired)
            {
                AddTalkMessageDelegate d = new AddTalkMessageDelegate(AddTalkMessage);
                client_recieve.Invoke(d, new object[] { message });
            }
            else
            {
                client_recieve.AppendText(message + Environment.NewLine);
                client_recieve.ScrollToCaret();
            }
        }

>>>>>>> 6b058e11aa29a6d6a129e2630e7899d0ae2a8fc3
>>>>>>> e3a5133b9bac634b9919edc1ccf1a605f8ea649a
        private void label1_Click(object sender, EventArgs e)
        {

        }
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> e3a5133b9bac634b9919edc1ccf1a605f8ea649a
        //send msg
        private void send_btn_Click(object sender, EventArgs e)
        {
            string txt=client_send.Text;
            Message.Message msg = new Message.Message("talk,"+tabBox.SelectedTab.Text,txt);
            EventArgs ev=new EventArgs ();
            sendMsg(ev, msg);
            client_send.Text = "";
        }

        private void client_recieve_TextChanged(object sender, EventArgs e)
<<<<<<< HEAD
=======
=======

        private void label1_Click_1(object sender, EventArgs e)
>>>>>>> 6b058e11aa29a6d6a129e2630e7899d0ae2a8fc3
>>>>>>> e3a5133b9bac634b9919edc1ccf1a605f8ea649a
        {

        }

<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> e3a5133b9bac634b9919edc1ccf1a605f8ea649a
        private delegate void addTopicToListDelegate(object sender, EventArgs e, string message);

        public void addTopicToList(object sender, EventArgs e, string message)
        {
            
            if (this.topic_list.InvokeRequired)
            {
                addTopicToListDelegate d = new addTopicToListDelegate(addTopicToList);
                this.topic_list.Invoke(d, new object[] { sender, e, message });
            }
            else
            {
                this.topic_list.View = View.List;
                this.topic_list.BeginUpdate();
                ListViewItem lvi = new ListViewItem();
                lvi.Text = message;
                lvi.Tag = message;
                this.topic_list.Items.Add(lvi);
                this.topic_list.EndUpdate();
            }
        }

        private void topic_list_DoubleClick(object sender, EventArgs e)
        {
            String selectedTopic = topic_list.SelectedItems[0].Text.ToString();
            TabPage tabPage1 = new TabPage(selectedTopic);
            ListBox lb = new ListBox();
            lb.Dock = DockStyle.Fill;
            topicText.Add(lb);
            tabPage1.Controls.Add(topicText.Find(delegate(ListBox box)
            {
                return box.Equals(lb);
            }));
            tabBox.SelectedTab = tabPage1;
            topicRoom.Add(tabPage1);
            tabBox.Controls.Add(topicRoom.Find(delegate(TabPage page)
            {
                return page.Text.Equals(selectedTopic);
            }));

            Message.Message msg=new Message.Message("in,"+selectedTopic,"");
            EventArgs ev = new EventArgs();
            sendMsg(ev,msg);
        }

        private void client_send_TextChanged(object sender, EventArgs e)
        {

        }

      
<<<<<<< HEAD
=======
=======
        private void send_btn_Click(object sender, EventArgs e)
        {
            string txt=client_send.Text;
            Net.Message msg = new Net.Message("5",txt);
            client.sendMessage(msg);
        }

        private void client_recieve_TextChanged(object sender, EventArgs e)
        {

        }

        private void addTopicToList(object sender,EventArgs e,string txt)
        {
            

          //  this.topic_list.SmallImageList = this.imageList1;

            this.topic_list.BeginUpdate();
            ListViewItem lvi = new ListViewItem();
            lvi.Text = txt;
            this.topic_list.Items.Add(lvi);
            this.topic_list.EndUpdate();
        }
>>>>>>> 6b058e11aa29a6d6a129e2630e7899d0ae2a8fc3
>>>>>>> e3a5133b9bac634b9919edc1ccf1a605f8ea649a
    }
}

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
    
    public partial class chat_form : Form
    {
        //private string ServerIP; //IP
        private int port;   //端口
        private bool isExit = false;
        public Net.TCPClient client;
       // public login login_form;
        
        
        public chat_form()
        {
            InitializeComponent();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

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
    }
}

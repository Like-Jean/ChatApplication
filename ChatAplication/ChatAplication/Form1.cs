using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;

using ChatAplication.Authentificate;

namespace ChatAplication
{
    public partial class Form1 : Form
    {
        
        AuthentificationManager am;
        Server.ServerGestTopics server;
        Server.ServerChatRoom chatroom;
        Net.TCPServer tcp;
        //Server.ServerChatRoom server_chatroom;

        public Form1()
        {
            InitializeComponent();
            server_recv.HorizontalScrollbar = true;
           // server = new Server.ServerGestTopics();
           
            chatroom = new Server.ServerChatRoom("default");
            
           // btn_Stop.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            // myListener = new TcpListener(IPAddress.Parse(ServerIP), port);
           // myListener.Start();
            server = new Server.ServerGestTopics();
            server.addTextEvent += new Net.addTextDel(AddItemToListBox);
            server.startServer();
           // AddItemToListBox(string.Format("开始在{0}:{1}监听客户连接", server.getIP(), server.getPort().ToString()));
            
            //创建一个线程监客户端连接请求
          //  Thread myThread = new Thread(ListenClientConnect);
         //   myThread.Start();
            start_btn.Enabled = false;
           // btn_Stop.Enabled = true;
        }

       /* public void authentifyUser(string login,string pass)
        {
            Authentificate.Authentificate.AuthentificationManager am = new Authentificate.Authentificate.Authentification(); ;
            if (am.authentify(login,pass)) AddItemToListBox(login + " is authentified!");
            else AddItemToListBox(login + " authentify fail!");
        }*/

        public delegate void AddItemToListBoxDelegate(object sender, EventArgs e, string str);
        
        /// <summary>
        /// 在ListBox中追加状态信息
        /// </summary>
        /// <param name="str">要追加的信息</param>

       


        public void AddItemToListBox(object sender,EventArgs e, string str)
        {
            if (server_recv.InvokeRequired)
            {
                AddItemToListBoxDelegate d = AddItemToListBox;
                server_recv.Invoke(d, str);
            }
            else
            {
                server_recv.Items.Add(str);
                server_recv.SelectedIndex = server_recv.Items.Count - 1;
                server_recv.ClearSelected();
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
}

       
}


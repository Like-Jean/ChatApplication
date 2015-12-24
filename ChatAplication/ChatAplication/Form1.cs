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

<<<<<<< HEAD
//using Chat;
=======
using ChatAplication.Authentificate;
>>>>>>> 6b058e11aa29a6d6a129e2630e7899d0ae2a8fc3

namespace ChatAplication
{
    public partial class Form1 : Form
    {
<<<<<<< HEAD

        Authentificate.Authentificate.AuthentificationManager am;
        List<Server.ServerGestTopics> servers;
        List<Server.ServerChatRoom> chatroom;
        Server.TCPGestTopics topicManager;
=======
        
        AuthentificationManager am;
        Server.ServerGestTopics server;
        Server.ServerChatRoom chatroom;
        Net.TCPServer tcp;
        //Server.ServerChatRoom server_chatroom;
>>>>>>> 6b058e11aa29a6d6a129e2630e7899d0ae2a8fc3

        public Form1()
        {
            InitializeComponent();
            server_recv.HorizontalScrollbar = true;
<<<<<<< HEAD
            stop_bnt.Enabled = false;

            chatroom = new List<Server.ServerChatRoom>();
            servers = new List<Server.ServerGestTopics>();
            topicManager = new Server.TCPGestTopics();

            topicManager.getTopicEvent += new Server.getTopicDel(listTopicToServer);
            addATopic("default");
            
=======
           // server = new Server.ServerGestTopics();
           
            chatroom = new Server.ServerChatRoom("default");
            
           // btn_Stop.Enabled = false;
>>>>>>> 6b058e11aa29a6d6a129e2630e7899d0ae2a8fc3
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
<<<<<<< HEAD
        }

        //click start button
        private void button1_Click(object sender, EventArgs e)
        {
            addAClient();
            start_btn.Enabled = false;
            stop_bnt.Enabled = true;
        }

        //start a server
        private void addAClient()
        {
            Server.ServerGestTopics server = new Server.ServerGestTopics();
            server.addTextEvent += new Net.addTextDel(AddItemToListBox);
            server.showMsgEvent += new Server.showMsgDel(showMsgBox);
            server.clientInEvent += new Server.clientInDel(clientIsIn);
            server.distributeEvent += new Server.distributeDel(distributeMsg);
            server.listTopicEvent += new Server.listTopicDel(listTopicToClient);
            topicManager.sendTopicEvent += new Server.sendTopicDel(listTopicToClient);
            topicManager.sendNewTopicEvent += new Server.sendNewTopicDel(listNewTopicToClient);
            server.addAServerEvent += new Server.addAServerDel(addAServer);
            server.startServer();
        }

        private void addAServer(object sender, EventArgs e)
        {
            try
            {
                servers.Add((Server.ServerGestTopics)sender);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listNewTopicToClient(object sender, EventArgs e, Message.Message msg)
        {
            try
            {
                msg.data = topicManager.topics[topicManager.topics.Count-1];
                for (int j = 0; j < servers.Count; j++)//send the new topic to server handling a client
                {
                    if (servers[j].client != null)
                        servers[j].sendMessage(msg);
                    }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listTopicToClient(object sender, EventArgs e,Message.Message msg)
        {
            try
            {
                for (int i = 0; i < topicManager.topics.Count; i++)
                {
                    msg.data = topicManager.topics[i];
                   /* for (int j = 0; j < servers.Count; j++)
                    {
                        if(servers[j].client!=null)
                            servers[j].sendMessage(msg);
                    }*/
                    if (((Server.ServerGestTopics)sender).client != null)
                        ((Server.ServerGestTopics)sender).sendMessage(msg);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public delegate void listTopicToServerDelegate(object sender, EventArgs e, string msg);
        private void listTopicToServer(object sender, EventArgs e, string msg)
        {
            if (server_topicList .InvokeRequired)
            {
                AddItemToListBoxDelegate d = AddItemToListBox;
                server_topicList.Invoke(d, new object[] { sender, e, msg });
            }
            else
            {
                this.server_topicList.View = View.List;
                this.server_topicList.BeginUpdate();
                ListViewItem lvi = new ListViewItem();
                lvi.Text = msg;
                lvi.Tag = msg;
                this.server_topicList.Items.Add(lvi);
                this.server_topicList.EndUpdate();
            }
        }
       

        public delegate void AddItemToListBoxDelegate(object sender, EventArgs e, string str);
        public void AddItemToListBox(object sender, EventArgs e, string str)
=======
           
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
>>>>>>> 6b058e11aa29a6d6a129e2630e7899d0ae2a8fc3
        {
            if (server_recv.InvokeRequired)
            {
                AddItemToListBoxDelegate d = AddItemToListBox;
<<<<<<< HEAD
                server_recv.Invoke(d, new object[] { sender,e, str });
=======
                server_recv.Invoke(d, str);
>>>>>>> 6b058e11aa29a6d6a129e2630e7899d0ae2a8fc3
            }
            else
            {
                server_recv.Items.Add(str);
                server_recv.SelectedIndex = server_recv.Items.Count - 1;
                server_recv.ClearSelected();
            }
        }


<<<<<<< HEAD
        public void showMsgBox(object sender, EventArgs e, string msg)
        {
            MessageBox.Show(msg);
        }


        public void clientIsIn(object sender, EventArgs e, Message.Message msg)
        {
            try
            {
                chatroom.Find(delegate(Server.ServerChatRoom room)//trigger the operation when client in
                {
                    return room.chatroomTopic.Equals(msg.head.Split(',')[1]);
                }).handleMsg(msg,((Server.ServerGestTopics)sender).client );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        public void distributeMsg(object sender, EventArgs e, Message.Message msg,string room)
        {
           chatroom.Find(delegate(Server.ServerChatRoom serverroom)//find the objective chatroom and send msg to every chatter in this room
            {
                return serverroom.chatroomTopic.Equals(room);
            }).handleMsg(msg, ((Server.ServerGestTopics)sender).client);
        }

        private void button2_Click(object sender, EventArgs e)
        {

=======
        private void button2_Click(object sender, EventArgs e)
        {
           
>>>>>>> 6b058e11aa29a6d6a129e2630e7899d0ae2a8fc3
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
<<<<<<< HEAD
           // topicManager.createTopic(add_text.Text);
            addATopic(add_text.Text);
            add_text.Text = "";
            
        }

        //when a topic is added,create a new topic in topicManager and add a relative chatroom at the sametime
        private void addATopic(string topic)
        {
            topicManager.createTopic(topic);
            chatroom.Add(new Server.ServerChatRoom(topic));
        }

        private delegate void addTopicToListDelegate(object sender, EventArgs e, string message);
        public void addTopicToList(object sender, EventArgs e, string message)
        {

            if (this.server_topicList.InvokeRequired)
            {
                addTopicToListDelegate d = new addTopicToListDelegate(addTopicToList);
                this.server_topicList.Invoke(d, new object[] { sender, e, message });
            }
            else
            {
                this.server_topicList.View = View.List;
                this.server_topicList.BeginUpdate();
                ListViewItem lvi = new ListViewItem();
                lvi.Text = message;
                lvi.Tag = message;
                this.server_topicList.Items.Add(lvi);
                this.server_topicList.EndUpdate();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }


=======

        }
}

       
>>>>>>> 6b058e11aa29a6d6a129e2630e7899d0ae2a8fc3
}


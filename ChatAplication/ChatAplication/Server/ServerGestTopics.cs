using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net;
using System.Net.Sockets;

using ChatAplication.Authentificate;
using ChatAplication.Net;

namespace ChatAplication.Server
{
    public class ServerGestTopics : TCPServer
    {

        public override void gereClient(TcpClient comm)
        {
            client = new ChatAplication.user(comm);
            Thread threadReceive = new Thread(this.getMessage);
            threadReceive.Start(client);
            //Authentificate.Authentificate.Authentification.loginUser.Add(client);
        }
        public void startServer()
        {
            mode = "waitClient";
            am = new Authentification();
            dorun = true;
            port = 8885;
            waitSock = new TcpListener(IPAddress.Parse(serverIP), port);
            waitSock.Start();
            EventArgs e = new EventArgs();
            addText(e, "start server");

            // mode = "treatClient";
            //创建一个线程监客户端连接请求
            Thread myThread = new Thread(run);
            myThread.Start();
            //start_btn.Enabled = false;
            // btn_Stop.Enabled = true;
        }
        public void stopServer() { }

        public override void getMessage(object userState)
        {
            byte[] requestbuffer = new byte[1024];
            Net.Message msg = new Net.Message("", "");
            ChatAplication.user client = (ChatAplication.user)userState;

            while (true)// (mode.Equals("treatClient")) //(isNormalExit == false)
            {
                //string receiveString = null;

                //EventArgs e=new EventArgs ();
                //addText(e,"recieveing txt..");
                // try
                {
                    //从网络流中读出字符串，此方法会自动判断字符串长度前缀
                    //receiveString = client.sr.ReadLine();
                    //}
                    //try
                    //{
                    //从网络流中读出字符串，此方法会自动判断字符串长度前缀

                    if (client.sr.Read(requestbuffer, 0, 1024) > 0)
                    {
                        msg = (Net.Message)deserializeStream(requestbuffer);
                        handleMsg(msg);
                    }
                }

                /*catch (Exception)
                {
                    /* if (isNormalExit == false)
                     {
                         AddItemToListBox(string.Format("与[{0}]失去联系，已终止接收该用户信息", client.Client.RemoteEndPoint));
                         RemoveUser(user);
                     }
                    //break;
                }*/
            }
            // AddItemToListBox(string.Format("来自[{0}]：{1}", user.client.Client.RemoteEndPoint, receiveString));
            // string[] splitString = receiveString.Split(',');


            // }
        }
        public override void handleMsg(Net.Message msg)
        {
            EventArgs e = new EventArgs();
            switch (msg.head)
            {
                case "0":
                    client.loginName = msg.data;
                    break;
                case "1":
                    if (am.addUser(client.loginName, msg.data))
                    {
                        msg.data = "registe successfully,welcome!" + client.loginName;
                        addText(e, client.loginName + " is regist!");
                        msg.head = "11";
                        sendMessage(msg);
                    }
                    else
                    {
                        msg.data = "this name is already used";
                        msg.head = "10";
                        sendMessage(msg);
                    }
                    break;
                case "2":
                    client.loginName = msg.data;
                    break;
                case "3":
                    if (am.authentify(client.loginName, msg.data))
                    {
                        msg.data = "login successfully,welcome!" + client.loginName;
                        addText(e, client.loginName + " is login!");
                        msg.head = "31";
                        sendMessage(msg);
                    }
                    else
                    {
                        msg.data = "fail to login,username or password is wrong";
                        msg.head = "30";
                        sendMessage(msg);
                    }
                    break;
                case "4":
                    am.removeUser(msg.data);
                    //sendMessage(msg);//tell user who out
                    break;
                case "talk":
                    sendMessage(msg);
                    break;
                // default:
                //AddItemToListBox("什么意思啊：" + receiveString);

            }
        }
        public override void sendMessage(Net.Message msg)
        {
            //StreamWriter sout = new StreamWriter(msg.data);
            //sout.AutoFlush = true;\
            switch (msg.head)
            {
                case "11":
                case "10":
                case "31":
                case "30":
                    client.sw.Write(serializeStream(msg));
                    client.sw.Flush();
                    break;
            }


        }
    }
}

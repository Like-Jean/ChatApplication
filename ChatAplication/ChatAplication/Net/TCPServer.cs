using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Net;
using System.Linq;
using System.Text;
using System.Threading;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

using ChatAplication.Authentificate;

namespace ChatAplication.Net
{
    public delegate void addTextDel(object sender, EventArgs e, string txt);
    public abstract class TCPServer : MessageConnection
    {
        public TcpClient commSocket;
        public TcpListener waitSock;
        public string mode;
        public bool dorun;
        public int port;
        public string serverIP = "127.0.0.1";
        public ChatAplication.user client;

        public AuthentificationManager am;
        public abstract void gereClient(TcpClient comm);
        //public abstract void handleMsg(Message msg,string ssin);
        public int getPort() { return port; }
        public string getIP() { return serverIP; }

        public event addTextDel addTextEvent;
        protected virtual void addText(EventArgs e, string txt)
        {
            addTextDel temp = addTextEvent; //MulticastDelegate一个委托链表
            //通知所有已订阅事件的对象
            if (temp != null)
                temp(this, e, txt); //通过事件NewMail(一种特殊的委托)逐一回调客户端的方法

        }

        static public byte[] serializeStream(Message obj)
        {
            BinaryFormatter binaryF = new BinaryFormatter();
            MemoryStream ms = new MemoryStream();
            binaryF.Serialize(ms, obj);
            ms.Seek(0, SeekOrigin.Begin);
            byte[] buffer = new byte[(int)ms.Length];
            ms.Read(buffer, 0, buffer.Length);
            ms.Close();
            return buffer;
        }
        static public Message deserializeStream(byte[] buffer)
        {
            BinaryFormatter binaryF = new BinaryFormatter();
            MemoryStream ms = new MemoryStream(buffer, 0, buffer.Length, false);
            Message pag = new Message("", "");
            pag = (Message)binaryF.Deserialize(ms);
            ms.Close();
            return pag;
        }

        public void run()
        {
            if (mode.Equals("treatClient"))
            {
                //commSocket = null;                
                gereClient(commSocket);
            }
            else
            {
                while (dorun)
                {
                    try
                    {
                        commSocket = waitSock.AcceptTcpClient();
                        //每接收一个客户端连接，就创建一个对应的线程循环接收该客户端发来的信息；
                        TCPServer myClone = (TCPServer)this.MemberwiseClone();
                        myClone.mode = "treatClient";
                        Thread th0 = new Thread(new ThreadStart(myClone.run));
                        th0.Start();
                    }
                    catch (Exception e)
                    {
                        //当单击‘停止监听’或者退出此窗体时 AcceptTcpClient() 会产生异常
                        //因此可以利用此异常退出循环
                        System.Console.WriteLine(e);
                        // e.StackTrace;
                    }
                }

            }
        }
        public abstract void sendMessage(Message msg);
        public abstract void getMessage(object userState);
        public abstract void handleMsg(Message msg);

    }
}

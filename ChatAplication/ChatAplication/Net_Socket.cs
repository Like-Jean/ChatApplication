using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Threading;
using System.Net;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using Message;
/*-----------0=registName;-----return "00" registName exist;--------return"01" registName is validated
 * ----------1=registPas;-----return "10" set password error;--------return"11" regist sucessfully
 * ----------2=loginName;-----return "20" registName not exist;--------return"21" registName is validated
 * ----------3=loginPass;-----return "30" password error;--------return"31" login sucessfully
 * ----------4=logout;
 * ---------
 * */
namespace Net
{
    
    public interface MessageConnection
    {
         void getMessage(object userstate);
         void sendMessage(Message.Message msg);
    }

    public delegate void addTextDel(object sender, EventArgs e, string txt);//sent event to form to add text to listbox
    //for the connection part.TCP protocol to conncet with client
    public abstract class TCPServer : MessageConnection
    {
        public TcpClient commSocket;
        public TcpListener waitSock;
        public string mode;
        public bool dorun;
        public int port;
        public string serverIP = "127.0.0.1";
        public ChatAplication.user client;//telling specifically which client is connecting with this server thread
        public Authentificate.Authentificate.AuthentificationManager am;
        //public abstract void handleMsg(Message msg,string ssin);
        public int getPort() { return port; }
        public string getIP() { return serverIP; }
        public abstract void gereClient(TcpClient comm);
        public abstract void sendMessage(Message.Message msg);
        public abstract void getMessage(object userState);

        public event addTextDel addTextEvent;
        protected virtual void addText(EventArgs e, string txt)
        {
            addTextDel temp = addTextEvent; //MulticastDelegate一个委托链表
            //通知所有已订阅事件的对象
            if (temp != null)
                temp(this, e, txt); //通过事件NewMail(一种特殊的委托)逐一回调客户端的方法

        }

        public void run()
        {
            if (mode.Equals("treatClient"))
            {
                gereClient(commSocket);
            }
            else
            {
                while (dorun)
                {
                    try
                    {
                        commSocket = waitSock.AcceptTcpClient();
                        //when recieve a client connect request,create a thread to treat the client
                        TCPServer myClone = (TCPServer)this.MemberwiseClone();
                        myClone.mode = "treatClient";
                        Thread th0 = new Thread(new ThreadStart(myClone.run));
                        th0.Start();
                    }
                    catch (Exception e)
                    {
                        //当单击‘停止监听’或者退出此窗体时 AcceptTcpClient() 会产生异常
                        //因此可以利用此异常退出循环
                        EventArgs evt = new EventArgs();
                        addText(evt, "the client exit");
                        System.Console.WriteLine(e);
                        // e.StackTrace;
                    }
                }

            }
        }

        static public byte[] serializeStream(Message.Message obj)
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
        static public Message.Message deserializeStream(byte[] buffer)
        {
            BinaryFormatter binaryF = new BinaryFormatter();
            MemoryStream ms = new MemoryStream(buffer, 0, buffer.Length, false);
            Message.Message pag = new Message.Message("", "");
            pag = (Message.Message)binaryF.Deserialize(ms);
            ms.Close();
            return pag;
        }

     
       
        //public abstract void handleMsg(Message.Message msg); 
       
    }
}

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
using System.Windows.Forms;
//0=registName;1=registPas;2=loginName;3=loginPass;4=logout
namespace Net
{
    [Serializable]
    public class Message
    {
        public string head;
        public string data;
        public Message(string h,string d)
        {
            head=h;
            data=d;
        }
       
    }

    interface MessageConnection
    {
        void getMessage();
        void sendMessage(Message msg);
    }

    public delegate void addTextDel(object sender, EventArgs e, string txt);
    public delegate void showMsgDel(object sender, EventArgs e, string txt);
    public delegate void loginToSysDel(object sender, EventArgs e);
    public delegate void getTopicDel(object sender, EventArgs e, string txt);
  
    public class TCPClient : MessageConnection
    {
        private TcpClient sock;
        int port;
        public string loginName;
       // string mode;
        private BinaryReader sr;
        private BinaryWriter sw;

        public event addTextDel addTextEvent;
        public event showMsgDel showMsgEvent;
        public event loginToSysDel loginToSysEvent;
        public event getTopicDel getTopicEvent;

        protected virtual void addText(EventArgs e, string txt)
        {
            addTextDel temp = addTextEvent; //MulticastDelegate一个委托链表
            //通知所有已订阅事件的对象
            if (temp != null)
                temp(this, e, txt); //通过事件NewMail(一种特殊的委托)逐一回调客户端的方法

        }

        protected virtual void showMsg(EventArgs e, string txt)
        {
            showMsgDel temp = showMsgEvent; //MulticastDelegate一个委托链表
            //通知所有已订阅事件的对象
            if (temp != null)
                temp(this, e, txt); //通过事件NewMail(一种特殊的委托)逐一回调客户端的方法

        }

        protected virtual void loginToSys(EventArgs e)
        {
            loginToSysDel temp = loginToSysEvent; //MulticastDelegate一个委托链表
            //通知所有已订阅事件的对象
            if (temp != null)
                temp(this, e); //通过事件NewMail(一种特殊的委托)逐一回调客户端的方法

        }
        protected virtual void getTopic(EventArgs e, string txt)
        {
            getTopicDel temp = getTopicEvent; //MulticastDelegate一个委托链表
            //通知所有已订阅事件的对象
            if (temp != null)
                temp(this, e,txt); //通过事件NewMail(一种特殊的委托)逐一回调客户端的方法

        }

        public TCPClient(string name) { loginName = name; }
        public void setServer()
        {
            port = 8885;
            sock = new TcpClient();
        }
        public void connect()
        {
            sock.Connect(IPAddress.Parse("127.0.0.1"),port);
            //
            //client.Connect(IPAddress.Parse(ServerIP), port);
            //获取网络流
            NetworkStream networkStream = sock.GetStream();
            //将网络流作为二进制读写对象
            sr = new BinaryReader(networkStream);
            sw = new BinaryWriter(networkStream);
            //sendMessage("Login," + txt_UserName.Text);
            Thread threadReceive = new Thread(new ThreadStart(getMessage));
            threadReceive.IsBackground = true;
            threadReceive.Start();
        }
        public void getMessage()
        {
            Message msg = new Message (" ","  ");
            byte[] requestbuffer = new byte[1024];
            while (true)
            {
                if (sr.Read(requestbuffer, 0, 1024) > 0)
                {
                    msg = (Net.Message)deserializeStream(requestbuffer);

                    EventArgs e = new EventArgs();

                    switch (msg.head)
                    {
                        case "00":
                        case "10":

                            showMsg(e, msg.data);
                            break;
                        case "11":
                            // form.login_form.regist_form.Close();
                            showMsg(e, msg.data);
                            break;
                        case "20":
                        case "30":
                            showMsg(e, msg.data);
                            break;
                        case "31":
                            loginToSys(e);
                            showMsg(e, msg.data);
                            break;
                        case "getTopics":
                            getTopic(e, msg.data);
                            break;

                    }
                    addText(e, msg.data);
                }
            }
        }

        public void sendMessage(Message msg)
        {
            byte[] requestbuffer = new byte[1024];
            requestbuffer=serializeStream(msg);
            sw.Write(requestbuffer,0,requestbuffer.Length);
            sw.Flush();
            
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
            pag=(Message)binaryF.Deserialize(ms);
            ms.Close();
            return pag;
        }

        
    }

}

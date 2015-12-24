using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Threading;
using System.Net.Sockets;

namespace Server
{
    public delegate void listTopicDel(object sender, EventArgs e, Message.Message msg);//list topic in client when he logined
    public delegate void showMsgDel(object sender, EventArgs e, string txt);//show messagebox
    public delegate void clientInDel(object sender, EventArgs e, Message.Message msg );//inform that client is in,then operate on chatroom
    public delegate void distributeDel(object sender, EventArgs e, Message.Message msg,string room);//distribute msg to clients
    public delegate void addAServerDel(object sender, EventArgs e);//when a client in ,add a server to handle it
    class ServerGestTopics : Net.TCPServer
    {
        public event addAServerDel addAServerEvent;
        protected virtual void addAServer(EventArgs e)
        {
            addAServerDel temp = addAServerEvent; //MulticastDelegate一个委托链表
            //通知所有已订阅事件的对象
            if (temp != null)
                temp(this, e); //通过事件NewMail(一种特殊的委托)逐一回调客户端的方法

        }
         public event showMsgDel showMsgEvent;
        protected virtual void showMsg(EventArgs e, string txt)
        {
            showMsgDel temp = showMsgEvent; //MulticastDelegate一个委托链表
            //通知所有已订阅事件的对象
            if (temp != null)
                temp(this, e, txt); //通过事件NewMail(一种特殊的委托)逐一回调客户端的方法

        }
        public event listTopicDel listTopicEvent;
        protected virtual void listTopic(EventArgs e, Message.Message msg)
        {
            listTopicDel temp = listTopicEvent; //MulticastDelegate一个委托链表
            //通知所有已订阅事件的对象
            if (temp != null)
                temp(this, e,msg); //通过事件NewMail(一种特殊的委托)逐一回调客户端的方法

        }
        public event clientInDel clientInEvent;
        protected virtual void clientIn(EventArgs e, Message.Message msg)
        {
            clientInDel temp = clientInEvent; //MulticastDelegate一个委托链表
            //通知所有已订阅事件的对象
            if (temp != null)
                temp(this, e, msg); //通过事件NewMail(一种特殊的委托)逐一回调客户端的方法

        }
        public event distributeDel distributeEvent;
        protected virtual void distribute(EventArgs e, Message.Message msg, string room)
        {
            distributeDel temp = distributeEvent; //MulticastDelegate一个委托链表
            //通知所有已订阅事件的对象
            if (temp != null)
                temp(this, e, msg,room); //通过事件NewMail(一种特殊的委托)逐一回调客户端的方法

        }


        public ServerGestTopics()
        {
            //topicManager = new TCPGestTopics();
        }

        public override void gereClient(TcpClient comm)
        {
            client = new ChatAplication.user(comm);
            EventArgs ev=new EventArgs();
            addAServer(ev);
            Thread threadReceive = new Thread(this.getMessage);
            threadReceive.Start(client);
            //Authentificate.Authentificate.Authentification.loginUser.Add(client);
        }

        public void startServer()
        {
            mode = "waitClient";
            am = new Authentificate.Authentificate.Authentification();
            dorun = true;
            port = 8885;
            waitSock = new TcpListener(IPAddress.Parse(serverIP), port);
            waitSock.Start();
            EventArgs e = new EventArgs();
            addText(e,"start server");
            Thread myThread = new Thread(run);
            myThread.Start();
           
        }

        public void stopServer() { }

        public override void getMessage(object userState)
        {
            byte[] requestbuffer = new byte[1024];
            Message.Message msg = new Message.Message("", "");
            ChatAplication.user client = (ChatAplication.user)userState;
            
            while(true)// (mode.Equals("treatClient")) //(isNormalExit == false)
            {
                try
                {
                    if (client.sr.Read(requestbuffer, 0, 1024) > 0)
                    {
                        msg = (Message.Message)deserializeStream(requestbuffer);
                        handleMsg(msg);
                    }
                }
                catch (Exception ex)
                {
                    EventArgs e = new EventArgs();
                    showMsg(e, ex.Message);
                }
            }
        }

        public void handleMsg(Message.Message msg)
        {
            try
            {
                EventArgs e = new EventArgs();
                string head = msg.head.Split(',')[0];//sometimes head will be ("talk,chatroomTopic")
                switch (head)//if it's sucessful,will and"1"in the end of head,or "0" when fail
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
                    case "talk"://client talk in chatroom
                        distribute(e, msg, msg.head.Split(',')[1]);
                        break;
                    case "getTopics"://client get topics form server
                        listTopic(e,msg);
                        break;
                    case "in"://inform that chatter is in
                        clientIn(e, msg);
                        break;
                }
            }
            catch (Exception e)
            {
                EventArgs ev = new EventArgs();
                showMsg(ev, e.Message);
            }
        }
        public override void sendMessage(Message.Message msg)
        {
            string head=msg.head.Split(',')[0];
            switch (head)
            {
                case "11":
                case "10":
                case "31":
                case "30":
                case "getTopics":
                case "talk":
                case "in":
                    byte[] requestbuffer = new byte[1024];
                    requestbuffer = serializeStream(msg);
                    client.sw.Write(requestbuffer, 0, requestbuffer.Length);
                    client.sw.Flush();
                    break;
               

            }


        }
    }

    public delegate void getTopicDel(object sender, EventArgs e, string topic);//if server add a topic refresh the list
    public delegate void sendTopicDel(object sender, EventArgs e, Message.Message msg);//send topics to client when client initiate
    public delegate void sendNewTopicDel(object sender, EventArgs e, Message.Message msg);//send new topic to client
    public class TCPGestTopics : Chat.Chat.TextGestTopics
    {
       // static int nextPort;
        public event getTopicDel getTopicEvent;
        protected virtual void getTopic(EventArgs e, string topic)
        {
            getTopicDel temp = getTopicEvent; //MulticastDelegate一个委托链表
            //通知所有已订阅事件的对象
            if (temp != null)
                temp(this, e, topic); //通过事件NewMail(一种特殊的委托)逐一回调客户端的方法

        }
        public event sendTopicDel sendTopicEvent;
        protected virtual void sendTopic(EventArgs e, Message.Message msg)
        {
            sendTopicDel temp = sendTopicEvent; //MulticastDelegate一个委托链表
            //通知所有已订阅事件的对象
            if (temp != null)
                temp(this, e, msg); //通过事件NewMail(一种特殊的委托)逐一回调客户端的方法

        }
        public event sendNewTopicDel sendNewTopicEvent;
        protected virtual void sendNewTopic(EventArgs e, Message.Message msg)
        {
            sendNewTopicDel temp = sendNewTopicEvent; //MulticastDelegate一个委托链表
            //通知所有已订阅事件的对象
            if (temp != null)
                temp(this, e, msg); //通过事件NewMail(一种特殊的委托)逐一回调客户端的方法

        }

        public TCPGestTopics(){}
       
        public new void createTopic(String topic)
        {
            base.createTopic(topic);
            listToPics(topic);
        }

        public void listToPics(String topic)
        {
            EventArgs e = new EventArgs();
            Message.Message msg = new Message.Message("getTopics", topic);
            getTopic(e, topic);
            sendNewTopic(e, msg);
        }

    }

    //to manage chatroom operation with net
    class ServerChatRoom : Net.TCPServer
    {
        public List<ChatAplication.user> roomUser;
        public String chatroomTopic ;
        Chat.Chat.TextChatroom chatroom;


        public ServerChatRoom(string rn)
        {
            chatroomTopic = rn;
            chatroom = new Chat.Chat.TextChatroom(rn);
            roomUser = new List<ChatAplication.user>();
        }

        public void join(Chat.Chat.Chatter chatter)
        {
            chatroom.join(chatter);
            for (int i = 0; i < chatroom.roomChatter.Count; i++)
                if (chatroom.roomChatter[i].Equals(chatter)) return;
            roomUser.Add(client);
            EventArgs e = new EventArgs();
            Message.Message msg=new Message.Message("in",chatter.getUserName() + "join the chatroom\"" + chatroomTopic + "\"");
            addText(e,msg.data);
            sendMessage(msg);
        }

        public void post(String mes, ChatAplication.user chatter)
	    {
           
	    }

        public override void gereClient(TcpClient comm)
        {/*
            ChatAplication.user user = new ChatAplication.user(comm);
            roomChatter.Add(user);
            Thread threadReceive = new Thread(this.getMessage);
            threadReceive.Start(user);*/
            // Authentificate.Authentificate.Authentification.loginUser.Add(user);
        }

        public override void sendMessage(Message.Message msg)
        {
            byte[] requestbuffer = new byte[1024];
            requestbuffer = serializeStream(msg);
            for (int i = 0; i < roomUser.Count; i++)
            {
                roomUser[i].sw.Write(requestbuffer, 0, requestbuffer.Length);
                roomUser[i].sw.Flush();
            }
        }
        public  override void getMessage(object userState)
        {
            ChatAplication.user user = (ChatAplication.user)userState;
            Message.Message msg;
            byte[] requestbuffer = new byte[1024];
            if (client.sr.Read(requestbuffer, 0, 1024) > 0)
            {
                msg = (Message.Message)deserializeStream(requestbuffer);
                //msg = deserializeStream(commSocket.GetStream());
                handleMsg(msg,user);
            }
        }
        public void exit(Chat.Chat.Chatter chatter) 
        {
            chatroom.exit(chatter);
            roomUser.Remove(client);
        }
        public void handleMsg(Message.Message msg,ChatAplication.user u)
        {
            EventArgs e = new EventArgs();
            Chat.Chat.Chatter chatter;
            string head = msg.head.Split(',')[0];
            try
            {
                switch (head)
                {
                    case "in":
                        chatter = new Chat.Chat.TextChatter(u.loginName);
                        join(chatter);
                        msg.data = u.loginName + " is in";
                        roomUser.Add(u);
                        break;
                    case "talk":
                        string content = msg.data;
                        msg.data = u.loginName + " : " + content;
                        break;
                    case "exit":
                        chatter = new Chat.Chat.TextChatter(u.loginName);
                        this.exit(chatter);
                        msg.data = u.loginName + " is out";
                        break;
                    default:
                        addText(e, "client trigger a undefined event!");
                        break;
                }
            }
            catch 
            {
                
            }
            sendMessage(msg);
           
        }
    }
}
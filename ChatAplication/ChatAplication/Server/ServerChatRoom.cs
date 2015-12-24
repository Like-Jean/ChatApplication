using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net;
using System.Net.Sockets;

using ChatAplication.Net;
using ChatAplication.Chat;

namespace ChatAplication.Server
{
    public class ServerChatRoom : TCPServer, Chatroom
    {
        string roomName;
        List<ChatAplication.user> roomChatter;

        String chatroomTopic;


        public void join(ChatAplication.user chatter)
        {
            roomChatter.Add(chatter);
        }
        public void post(String mes, ChatAplication.user chatter)
        {
            //Net.Message msg=new Net.Message("talk") 
            //sendMessage(
        }

        public ServerChatRoom(string rn)
        {
            roomName = rn;
            roomChatter = new List<ChatAplication.user>();
        }
        public override void gereClient(TcpClient comm)
        {
            ChatAplication.user user = new ChatAplication.user(comm);
            roomChatter.Add(user);
            Thread threadReceive = new Thread(this.getMessage);
            threadReceive.Start(user);
            // Authentificate.Authentificate.Authentification.loginUser.Add(user);
        }
        public override void sendMessage(Net.Message msg)
        {
            client.sw.Write(serializeStream(msg));
            client.sw.Flush();
        }
        public override void getMessage(object userState)
        {
            ChatAplication.user user = (ChatAplication.user)userState;
            Net.Message msg;
            byte[] requestbuffer = new byte[1024];
            if (client.sr.Read(requestbuffer, 0, 1024) > 0)
            {
                msg = (Net.Message)deserializeStream(requestbuffer);
                //msg = deserializeStream(commSocket.GetStream());
                handleMsg(msg);
            }
        }
        public override void handleMsg(Net.Message msg)
        {
            EventArgs e = new EventArgs();
            switch (msg.head)
            {
                case "in":
                    join(client);
                    msg.data = client.loginName + " is in";
                    break;
                case "talk":
                    string content = msg.data;
                    msg.data = client.loginName + " : " + content;
                    break;
                case "exit":
                    msg.data = client.loginName + " is out";
                    break;
                default:
                    addText(e, "client trigger a undefined event!");
                    break;
            }
            for (int i = 0; i < roomChatter.Count; i++)
            {
                roomChatter[i].sw.Write(serializeStream(msg));
                roomChatter[i].sw.Flush();
                //AddItemToListBox("To " + user.loginName + ":" + message);
            }
        }
    }
}

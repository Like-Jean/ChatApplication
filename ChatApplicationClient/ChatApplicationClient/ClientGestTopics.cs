using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
<<<<<<< HEAD
    public class ClientGestTopics:Net.TCPClient,Chat.Chat.TopicManager
    {
        List<string> topics;
        Chat.Chat.TextGestTopics gt;
        public ClientGestTopics(string name) : base(name) 
        {
           topics = new List<string>();
           //listTopics();
        }
        public void createTopic(String topic)
        {
           topics.Add(topic);
        }
	    public void listTopics()
	    {
            Message.Message msg = new Message.Message("getTopics", "");
            sendMessage(msg);
	     }
        public Chat.Chat.Chatroom joinTopic(String topic)
	    {
            return gt.joinTopic(topic);
	    }
=======
    class ClientGestTopics:Net.TCPClient,Chat.Chat.TopicManager
    {
        List<string> topics;
       public ClientGestTopics(string name) : base(name) 
       {
           topics = new List<string>();
           listTopics();
       }
       public void createTopic(String topic)
       {
           topics.Add(topic);
       }
	public void listTopics()
	{
        Net.Message msg=new Net.Message("getTopics","");
        sendMessage(msg);
	}
	public Chat.Chat.Chatroom joinTopic(String topic)
	{
        Chat.Chat.Chatroom cr = new Chat.Chat.TextChatroom(topic);
		return cr;
	}
>>>>>>> 6b058e11aa29a6d6a129e2630e7899d0ae2a8fc3

    }
}

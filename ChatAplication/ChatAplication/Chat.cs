using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//this part is used to mangage the chat part(room,topic,chatter),nothing to do with the connection
namespace Chat
{
    public class Chat
    {
        //manage the chatroom operation
        public interface Chatroom
        {
            void join(Chatter chatter);
            void post(String mes, Chatter chatter);
            void exit(Chatter chatter);
        }

        public class TextChatroom : Chatroom
        {

            public String chatroomTopic;
            public List<Chatter> roomChatter;

            public TextChatroom(String topic)
            {
                chatroomTopic = topic;
                roomChatter = new List<Chatter>();
            }

            public void join(Chatter chatter)
            {
                for (int i = 0; i < roomChatter.Count; i++)
                    if (roomChatter[i].Equals(chatter)) return;
                roomChatter.Add(chatter);
            }

            public void post(String mes, Chatter chatter)//not be used in really processe
            {
                //System.Console.WriteLine(chatter.getUserName()+":"+mes);
            }

            public void exit(Chatter chatter)
            {
                roomChatter.Remove(chatter);
            }
        }
        //manage the chatter(who has begin or is going to begin his talk),not the user.
        public interface Chatter
        {
            void setUserName(String name);
            String getUserName();

        }

        public class TextChatter : Chatter
        {
            String userName;

            public void setUserName(String name)
            {
                userName = name;
            }
            public TextChatter(String name)
            {
                setUserName(name);
            }
            public String getUserName()
            {
                return userName;
            }
        }
        //manage the topic
        public interface TopicManager
        {
            void createTopic(String topic);
            void listTopics();
            Chatroom joinTopic(String topic);
        }
        
        public class TextGestTopics:TopicManager {

            public List<string> topics;
         public TextGestTopics()
         {
             topics = new List<string>();
         }
         public void createTopic(String topic)
         {
             topics.Add(topic);
         }
         public void listTopics()
         {
             /*System.Console.WriteLine("the opened topics are:");
             for(int i=0;i<topics.Count;i++)
             {
                 System.Console.WriteLine(topicName[i]);
             }*/
         }
         public Chatroom joinTopic(String topic)
         {
             Chatroom cr=new TextChatroom(topic);
             return cr;
         }

     }
    }
}

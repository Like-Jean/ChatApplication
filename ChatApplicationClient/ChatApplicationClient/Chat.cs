using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat
{
<<<<<<< HEAD
    public class Chat
=======
<<<<<<< HEAD
    public class Chat
=======
    class Chat
>>>>>>> 6b058e11aa29a6d6a129e2630e7899d0ae2a8fc3
>>>>>>> e3a5133b9bac634b9919edc1ccf1a605f8ea649a
    {
        public interface Chatroom
        {

            void join(Chatter chatter);
            void post(String mes, Chatter chatter);
        }
        public interface Chatter
        {
            void setUserName(String name);
            String getUserName();

        }
        public interface TopicManager
        {

            void createTopic(String topic);
            void listTopics();
            Chatroom joinTopic(String topic);
        }
<<<<<<< HEAD

=======
<<<<<<< HEAD

=======
>>>>>>> 6b058e11aa29a6d6a129e2630e7899d0ae2a8fc3
>>>>>>> e3a5133b9bac634b9919edc1ccf1a605f8ea649a
        public class TextChatroom :Chatroom{

	String chatroomTopic ;
	Chatter[] roomChatter;
	static int chatterNumber;
	public TextChatroom(String topic)
	{
		chatroomTopic=topic;
		roomChatter=new TextChatter[10];
		chatterNumber=0;
	}
	public void join(Chatter chatter)
	{
		for(int i=0;i<chatterNumber;i++)
			if(roomChatter[i].Equals(chatter))return;
        System.Console.WriteLine(chatter.getUserName() + " has join the chatroom\"" + chatroomTopic + "\"");
		roomChatter[chatterNumber++]=chatter;
	}
	public void post(String mes,Chatter chatter)
	{
		System.Console.WriteLine(chatter.getUserName()+":"+mes);
	}
}
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> e3a5133b9bac634b9919edc1ccf1a605f8ea649a
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
        public class TextGestTopics : TopicManager
        {
<<<<<<< HEAD
=======
=======
        public class TextChatter:Chatter {

	String userName;
	public void setUserName(String name)
	{
		userName=name;
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
        public class TextGestTopics:TopicManager {
>>>>>>> 6b058e11aa29a6d6a129e2630e7899d0ae2a8fc3
>>>>>>> e3a5133b9bac634b9919edc1ccf1a605f8ea649a

            String[] topicName;//use xml to manage the topic name
            static int topicNumber;
            public TextGestTopics()
            {
                if (topicName == null)
                    topicName = new String[10];
                topicNumber = 0;
            }
            public void createTopic(String topic)
            {
                topicName[topicNumber++] = topic;
            }
            public void listTopics()
            {
                System.Console.WriteLine("the opened topics are:");
                for (int i = 0; i < topicNumber; i++)
                {
                    System.Console.WriteLine(topicName[i]);
                }
            }
            public Chatroom joinTopic(String topic)
            {
                Chatroom cr = new TextChatroom(topic);
                return cr;
            }

<<<<<<< HEAD
        }
=======
<<<<<<< HEAD
        }
=======
}
     

        /*static void main(String[] args) { 
		  Chatter bob = new TextChatter ("Bob"); 
		  Chatter joe = new TextChatter ("Joe"); 
		  TopicManager gt = new TextGestTopics();   
		  gt.createTopic("java"); 
		  gt.createTopic("UML"); 
		  gt.listTopics(); 
		  gt.createTopic("jeux"); 
		  gt.listTopics(); 
		  Chatroom cr = gt.joinTopic("jeux"); 
		  cr.join(bob); 
		  cr.post("Je suis seul ou quoi ?",bob); 
		  cr.join(joe); 
		  cr.post("Tiens, salut Joe !",bob); 
		  cr.post("Toi aussi tu chat sur les forums de jeuxpendant les TP, Bob?",joe); 
		 } */
>>>>>>> 6b058e11aa29a6d6a129e2630e7899d0ae2a8fc3
>>>>>>> e3a5133b9bac634b9919edc1ccf1a605f8ea649a
    }
}

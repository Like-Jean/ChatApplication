using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat
{
    class Chat
    {
        
        
        
        /*     public class TextChatroom :Chatroom{

         String chatroomTopic ;
         Chatter[] roomChatter;
         static int chatterNumber;
         public TextChatroom(String topic)
         {
             chatroomTopic=topic;
             roomChatter=new TextChatter[10];
             chatterNumber=0;
         }
         public void join(ChatAplication.user chatter)
         {
             for(int i=0;i<chatterNumber;i++)
                 if(roomChatter[i].Equals(chatter))return;
             System.Console.WriteLine(chatter.getUserName() + " has join the chatroom\"" + chatroomTopic + "\"");
             roomChatter[chatterNumber++]=chatter;
         }
         public void post(String mes, ChatAplication.user chatter)
         {
             System.Console.WriteLine(chatter.getUserName()+":"+mes);
         }
     }
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
	
         String[] topicName;//use xml to manage the topic name
         static int topicNumber;
         public TextGestTopics()
         {
             if(topicName==null)
                 topicName=new String[10];
             topicNumber=0;
         }
         public void createTopic(String topic)
         {
             topicName[topicNumber++]=topic;
         }
         public void listTopics()
         {
             System.Console.WriteLine("the opened topics are:");
             for(int i=0;i<topicNumber;i++)
             {
                 System.Console.WriteLine(topicName[i]);
             }
         }
         public Chatroom joinTopic(String topic)
         {
             Chatroom cr=new TextChatroom(topic);
             return cr;
         }

     }*/


        /* static void main(String[] args) { 
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
    }
}

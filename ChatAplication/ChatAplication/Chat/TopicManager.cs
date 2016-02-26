using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatAplication.Chat
{
    public interface TopicManager
    {

        void createTopic(String topic);
        void listTopics();
        Chatroom joinTopic(String topic);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatAplication.Chat
{
    public interface Chatroom
    {

        void join(ChatAplication.user chatter);
        void post(String mes, ChatAplication.user chatter);
    }
}

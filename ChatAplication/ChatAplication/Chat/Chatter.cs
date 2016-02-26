using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatAplication.Chat
{
    public interface Chatter
    {
        void setUserName(String name);
        String getUserName();

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatAplication.Net
{
    public interface MessageConnection
    {
        void getMessage(object userstate);
        void sendMessage(Message msg);
    }
}

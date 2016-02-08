using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Message
{
    [Serializable]
    public class Message
    {
        public string head;
        public string data;
        public Message(string h, string d)
        {
            head = h;
            data = d;
        }
    }
}

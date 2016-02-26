using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatAplication.Exceptions
{
    public class AuthentificationException : Exception
    {
        public String login;
        public AuthentificationException(String l)
        {
            login = l;
        }
    }
}

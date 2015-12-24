using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatAplication.Exceptions
{
    public class UserUnknownException : AuthentificationException
    {

        public UserUnknownException(String l)
            : base(l)
        {
            //super(l);
            // TODO Auto-generated constructor stub
        }

    }
}

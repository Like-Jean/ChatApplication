using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatAplication.Exceptions
{
    public class WrongPasswordException : AuthentificationException
    {

        public WrongPasswordException(String l)
            : base(l)
        {
            //super(l);
            // TODO Auto-generated constructor stub
        }

    }
}

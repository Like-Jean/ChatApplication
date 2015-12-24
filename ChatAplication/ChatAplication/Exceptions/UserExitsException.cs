using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatAplication.Exceptions
{
    public class UserExitsException : AuthentificationException
    {

        public UserExitsException(String l)
            : base(l)
        {
            //base(l);
            // TODO Auto-generated constructor stub
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatAplication.Authentificate
{
    public interface AuthentificationManager
    {
        bool addUser(String login, String password);
        void removeUser(String login);
        bool authentify(String login, String password);
        void load(String path);
        void save(String path);
    }
}

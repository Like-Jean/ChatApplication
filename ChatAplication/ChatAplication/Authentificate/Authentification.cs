using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ChatAplication.Authentificate
{
    public class Authentification : AuthentificationManager
    {

        //  public static int loginNumber=0;
        public static List<ChatAplication.user> loginUser;
        public Authentification()
        {
            //  loginNumber=0;
            loginUser = new List<ChatAplication.user>();
        }

        public bool addUser(String login, String password)
        {
            ChatAplication.user _user = new ChatAplication.user(login, password);
            ChatAplication.user curU = loginUser.Find(delegate(ChatAplication.user user)
            {
                return user.loginName.Equals(login);
            });
            if (curU == null)
            {
                loginUser.Add(_user);
                return true;
            }
            else return false;

        }

        public void removeUser(String login)
        {
            int curN = loginUser.FindIndex(delegate(ChatAplication.user user)
                {

                    return user.loginName.Equals(login);
                });

            if (curN >= 0) loginUser.RemoveAt(curN);

        }

        public bool authentify(String login, String password)
        {
            ChatAplication.user curU;
            curU = loginUser.Find(delegate(ChatAplication.user user)
            {
                return user.loginName.Equals(login);
            });
            if (curU != null) { return true; }
            else return false;
        }
        public void load(String path)
        {
            //Deserialization of String Object
            loginUser.Clear();
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream readstream = new FileStream("./users.txt", FileMode.Open, FileAccess.Read,
            FileShare.Read);
            loginUser = (List<ChatAplication.user>)formatter.Deserialize(readstream);

            readstream.Close();
            //Console.WriteLine(readdata);
            // Console.ReadLine();
        }
        public void save(String path)
        {

            FileStream stream = new FileStream("./users.txt", FileMode.Create, FileAccess.Write,
            FileShare.None);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, loginUser);
            stream.Close();
            loginUser.Clear();
        }
    }
}

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
<<<<<<< HEAD
using System.Data.SQLite;
=======
>>>>>>> e3a5133b9bac634b9919edc1ccf1a605f8ea649a

//to manage the user(name,passwor,states..) like a database manager
namespace Authentificate
{
    public class Authentificate
    {
        public interface AuthentificationManager
        {
             bool addUser(String login, String password);
             void removeUser(String login);
             bool authentify(String login, String password);
             void load(String path);
             void save(String path);
        }

        public class Authentification : AuthentificationManager
        {
            public static List<ChatAplication.user> loginUser;//save the user of this system
<<<<<<< HEAD
            private UserModel um = new UserModel();
            public Authentification()
            {
                loginUser = new List<ChatAplication.user>();
                um.createTable();
=======
            public Authentification()
            {
                loginUser = new List<ChatAplication.user>();
>>>>>>> e3a5133b9bac634b9919edc1ccf1a605f8ea649a
            }

            public bool addUser(String login, String password)
            {
                ChatAplication.user _user = new ChatAplication.user(login, password);
<<<<<<< HEAD
                
                //if the userName has already registed,return false
                
                if (!um.find(login))
                {
                    um.insertIntoDatabase(login,password);
=======
                ChatAplication.user curU = loginUser.Find(delegate(ChatAplication.user user)//if the userName has already registed,return false
                {
                    return user.loginName.Equals(login);
                });
                if (curU == null)
                {
                    loginUser.Add(_user);
>>>>>>> e3a5133b9bac634b9919edc1ccf1a605f8ea649a
                    return true;
                }
                else return false;

            }

            public void removeUser(String login)
            {
<<<<<<< HEAD
                um.deleteFromDatabase(login);
=======
                int curN = loginUser.FindIndex(delegate(ChatAplication.user user)
                    {

                        return user.loginName.Equals(login);
                    });

                if (curN >= 0) loginUser.RemoveAt(curN);
>>>>>>> e3a5133b9bac634b9919edc1ccf1a605f8ea649a

            }

            public bool authentify(String login, String password)
            {
<<<<<<< HEAD
                if(um.find(login))
                {
                    String correctPassword = um.readPasswordFromDatabase(login);
                    if(correctPassword.Equals(password))
                    {
                        return true;
                    }

                    else return false;
                }
                
=======
                ChatAplication.user curU;
                curU = loginUser.Find(delegate(ChatAplication.user user)//if the user has already login,return false
                {
                    return user.loginName.Equals(login);
                });
                if (curU != null) { return true; }
>>>>>>> e3a5133b9bac634b9919edc1ccf1a605f8ea649a
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
        class AuthentificationException : Exception
        {
            public String login;
            public AuthentificationException(String l)
            {
                login = l;
            }
        }

        class UserExitsException : AuthentificationException
        {

            public UserExitsException(String l)
                : base(l)
            {
                //base(l);
                // TODO Auto-generated constructor stub
            }

        }


        class UserUnknownException : AuthentificationException
        {

            public UserUnknownException(String l)
                : base(l)
            {
                //super(l);
                // TODO Auto-generated constructor stub
            }

        }

        class WrongPasswordException : AuthentificationException
        {

            public WrongPasswordException(String l)
                : base(l)
            {
                //super(l);
                // TODO Auto-generated constructor stub
            }

        }
    }
       
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.IO;

namespace ChatAplication
{
<<<<<<< HEAD
    //class user,to store information of user
=======
>>>>>>> 6b058e11aa29a6d6a129e2630e7899d0ae2a8fc3
    [Serializable]
    public class user
    {
        
<<<<<<< HEAD
        public TcpClient client { get; private set; }//the user's TcpClient
        public BinaryReader sr { get; private set; }// to read stream
        public BinaryWriter sw { get; private set; }//to write stream
        public string loginName { get; set; }//name
        public String loginPassword;//password
        public bool isAuthentification;//wether it's authentification

        public user()
            {
                loginName = "visitor";
=======
        public TcpClient client { get; private set; }
        public BinaryReader sr { get; private set; }
        public BinaryWriter sw { get; private set; }
        public string loginName { get; set; }
        public String loginPassword;
        public bool isAuthentification;

        public user()
            {
                // loginName = "initial";
>>>>>>> 6b058e11aa29a6d6a129e2630e7899d0ae2a8fc3
                loginPassword = "";
                isAuthentification = false;
            }
            public user(String login, String pass)
            {
                loginName = login;
                loginPassword = pass;
                isAuthentification = false;
            }
            
        public user(TcpClient client)
        {
<<<<<<< HEAD
            loginName = "visitor";
=======
>>>>>>> 6b058e11aa29a6d6a129e2630e7899d0ae2a8fc3
            this.client = client;
            NetworkStream networkStream = client.GetStream();
            sr = new BinaryReader(networkStream);
            sw = new BinaryWriter(networkStream);
            
        }
        public void Close()
        {
            sr.Close();
            sw.Close();
            client.Close();
        }

        }
 
}

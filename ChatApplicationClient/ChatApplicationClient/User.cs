using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.IO;

namespace ChatAplication
{
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> e3a5133b9bac634b9919edc1ccf1a605f8ea649a

    class user
    {
       
       
<<<<<<< HEAD
=======
=======
    [Serializable]
    class user
    {
       
        public TcpClient client { get; private set; }
        public BinaryReader br { get; private set; }
        public BinaryWriter bw { get; private set; }
        public String loginName;
            /*public String loginName
            {
                get { return loginName; }
                set { loginName = value; }
            }*/
            public String loginPassword;
            public bool isAuthentification;
            public user()
            {
                // loginName = "initial";
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
            this.client = client;
            NetworkStream networkStream = client.GetStream();
            br = new BinaryReader(networkStream);
            bw = new BinaryWriter(networkStream);
            
        }
        public void Close()
        {
            br.Close();
            bw.Close();
            client.Close();
        }

>>>>>>> 6b058e11aa29a6d6a129e2630e7899d0ae2a8fc3
>>>>>>> e3a5133b9bac634b9919edc1ccf1a605f8ea649a
        }
 
}

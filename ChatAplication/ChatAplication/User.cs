using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.IO;

namespace ChatAplication
{
    //class user,to store information of user
    [Serializable]
    public class user
    {
        
        public TcpClient client { get; private set; }//the user's TcpClient
        public BinaryReader sr { get; private set; }// to read stream
        public BinaryWriter sw { get; private set; }//to write stream
        public string loginName { get; set; }//name
        public String loginPassword;//password
        public bool isAuthentification;//wether it's authentification

        public user()
            {
                loginName = "visitor";
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
            loginName = "visitor";
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.IO;

namespace ChatAplication
{
    [Serializable]
    public class user
    {
        
        public TcpClient client { get; private set; }
        public BinaryReader sr { get; private set; }
        public BinaryWriter sw { get; private set; }
        public string loginName { get; set; }
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

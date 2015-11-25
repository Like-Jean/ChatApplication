using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.IO;

namespace ChatAplication
{
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

        }
 
}

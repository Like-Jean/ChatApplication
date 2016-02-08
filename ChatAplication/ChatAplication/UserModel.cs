using System;
using System.Data.SQLite;
using System.Text;

namespace Authentificate
{
    public class UserModel
    {
        public static SQLiteConnection getDatabase()
        {
            SQLiteConnection conn = null;

            string dbPath = "Data Source =" + Environment.CurrentDirectory + "/user.db";
            conn = new SQLiteConnection(dbPath);//创建数据库实例，指定文件位置 
            return conn;
        }

        public void createTable()
        {
            SQLiteConnection conn = getDatabase();

            conn.Open();//打开数据库，若文件不存在会自动创建  

            string sql = "CREATE TABLE IF NOT EXISTS userTable(id integer primary key,User text,Password text);";//建表语句  
            SQLiteCommand cmdCreateTable = new SQLiteCommand(sql, conn);
            cmdCreateTable.ExecuteNonQuery();//如果表不存在，创建数据表 
            conn.Close();
        }

        public void insertIntoDatabase(string user, string password)
        {
            SQLiteConnection conn = getDatabase();
            conn.Open();
            SQLiteCommand cmdInsert = new SQLiteCommand(conn);
            cmdInsert.CommandText = "INSERT INTO userTable(User,Password) VALUES('" + user + "','" + password + "');";//插入数据  
            cmdInsert.ExecuteNonQuery();
            conn.Close();
        }

        public void deleteFromDatabase(string user)
        {
            SQLiteConnection conn = getDatabase();
            conn.Open();
            string sql = "delete from userTable where User='" + user + "';";
            SQLiteCommand cmdInsert = new SQLiteCommand(conn);
            cmdInsert.CommandText = sql;  
            cmdInsert.ExecuteNonQuery();
            conn.Close();
        }

        public bool find(string user)
        {
            SQLiteConnection conn = getDatabase();
            conn.Open();//打开数据库，若文件不存在会自动创建  
            string sql = "select password from userTable where User='" + user + "';";
            SQLiteCommand cmdQ = new SQLiteCommand(sql, conn);
            SQLiteDataReader reader = cmdQ.ExecuteReader();

            if(reader.Read())
            {
                conn.Close();
                return true;
            }
            else 
            {
                conn.Close();
                return false;
            }
        }
        public String readPasswordFromDatabase(string user)
        {
            SQLiteConnection conn = getDatabase();
            conn.Open();//打开数据库，若文件不存在会自动创建  
            string sql = "select password from userTable where User='" + user + "';";
            SQLiteCommand cmdQ = new SQLiteCommand(sql, conn);
            SQLiteDataReader reader = cmdQ.ExecuteReader();

            String password = null;
            while (reader.Read())
            {
                //id = reader.GetInt32(0);
                password = reader.GetString(0);
                //………………
            }
            conn.Close();

            return password;
            // Console.ReadKey(); 
        }
    }
}
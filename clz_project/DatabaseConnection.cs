using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;


namespace clz_project
{
    public class DatabaseConnection
    {
        public static MySqlConnection Conn()
        {
            string constr = "SERVER=localhost;DATABASE=fifth;UID=root;PASSWORD=;";
            MySqlConnection conn=new MySqlConnection(constr);
            conn.Open();
            return conn;
        }

    }
}
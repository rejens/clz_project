using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace clz_project
{
    public partial class login : System.Web.UI.Page
    {
        MySqlConnection conn;
        protected void Page_Load(object sender, EventArgs e)
        {
            conn = DatabaseConnection.Conn();


        }

        protected void SignIn(object sender, EventArgs e)
        {
            string user = username.Text;
            string pass=password.Text;

           // string sql = "insert into users (username,password) values(@user,@pass)";
            string sql = "select * from users where username=@user and password=@pass";
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@user", user);
                cmd.Parameters.AddWithValue("@pass", pass);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count > 0)
                {
                    Session["loggedIn"] = true;
                    Response.Redirect("/Default.aspx");

                }
                else
                {

                    
                }
            }
        }
    }
}
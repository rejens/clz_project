using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace clz_project
{
    public partial class AddStudent : System.Web.UI.Page
    {
        MySqlConnection conn;


        protected void Page_Load(object sender, EventArgs e)
        {

            conn = DatabaseConnection.Conn();

        }

        protected void add_student(object sender, EventArgs e)
        {
            string id = Id.Text;
            string name=Name.Text;
            string address=Address.Text;    
            string faculty= Faculty.Text;

            string sql = "insert into students (id,name,address,faculty) values (@id,@name,@address,@faculty)";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@faculty", faculty);

            cmd.ExecuteNonQuery();

            Response.Redirect(Request.Url.AbsoluteUri + "/..");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace clz_project
{
    public partial class Edit : System.Web.UI.Page
    {
        MySqlConnection conn;
        string id;

        protected void Page_Load(object sender, EventArgs e)
        {
            conn = DatabaseConnection.Conn();
            id = Request.QueryString["id"];
            string sql = "select * from students where id=@id";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@id", id);

            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read() && !IsPostBack)
            {
                Name.Text = reader["name"].ToString();
                Address.Text = reader["address"].ToString();
                Faculty.Text = reader["faculty"].ToString();

            }
            reader.Close();


        }

        protected void update_Click(object sender, EventArgs e)
        {
            string name = Name.Text;
            string address = Address.Text;
            string faculty = Faculty.Text;

            string sql = "update students set name = @name, address = @address , faculty = @faculty where id=@id";
            //string sql = string.Format( "update students set name = '{0}', address = '{1}' , faculty = '{2}' where id='{3}'",name,address,faculty,id);
            //string sql = "insert into students values(4,@name,@address,@faculty)";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            //Response.Write(sql);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@faculty", faculty);
            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();
            var newUrl = RemoveQueryStringByKey(Request.Url.AbsoluteUri, "id");
            Response.Redirect(newUrl+"../");
            //Response.Redirect(Request.Url.AbsoluteUri + "/..");
        }

        public string RemoveQueryStringByKey(string url, string key)
        {
            var uri = new Uri(url);

            // this gets all the query string key value pairs as a collection
            var newQueryString = HttpUtility.ParseQueryString(uri.Query);

            // this removes the key if exists
            newQueryString.Remove(key);

            // this gets the page path from root without QueryString
            string pagePathWithoutQueryString = uri.GetLeftPart(UriPartial.Path);

            return newQueryString.Count > 0
                ? String.Format("{0}?{1}", pagePathWithoutQueryString, newQueryString)
                : pagePathWithoutQueryString;
        }



    }
}
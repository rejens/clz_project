using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;
using System.Xml.Linq;


namespace clz_project
{
    public partial class _Default : Page
    {

        MySqlConnection conn;
        protected void Page_Load(object sender, EventArgs e)
        {
            conn = DatabaseConnection.Conn();

            DisplayData();

        }

        public void DisplayData()
        {
            string sql = "select * from students";
            MySqlCommand cmd = new MySqlCommand(sql, conn);


            MySqlDataReader reader = cmd.ExecuteReader();

            // Create a new DataTable and load the data from the reader
            DataTable table = new DataTable();
            table.Load(reader);
            // Set the DataSource of the GridView to the DataTable
            GridView1.DataSource = table;

            GridView1.DataBind();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {

            int id = Convert.ToInt32(GridView1.DataKeys[e.NewEditIndex].Value);


            Response.Redirect("Edit.aspx?id=" + id);

        }
        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);


            string sql = "delete from students where id=@id";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();

            Response.Redirect(Request.Url.AbsoluteUri);

        }

        protected void add_student(object sender, EventArgs e)
        {
            Response.Redirect("AddStudent.aspx");
        }
    }
}
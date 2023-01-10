using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;

namespace clz_project
{
    public partial class SiteMaster : MasterPage
    {
        MySqlConnection conn;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["loggedIn"] == null || (bool)Session["loggedIn"] != true)
            {
                Response.Redirect("/login.aspx");
                return;

            }

            conn = DatabaseConnection.Conn();

        }

        protected void Logout(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect(Request.RawUrl);

        }
    }
}
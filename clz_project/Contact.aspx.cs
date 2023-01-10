using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace clz_project
{
    public partial class Contact : Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

            // divMessage.Visible = false;
            divMessage.Attributes.Add("style", "color:blue");
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string text = string.Format("your name is {0}, your email is{1}, and your fav color is{2}", name.Text, email.Text, ddlcolor.Text);
            ltMessage.Text = text;
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyProject
{
    public partial class Admin : System.Web.UI.Page
    {
       

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomeLoginPage.aspx");
        }
    }
}
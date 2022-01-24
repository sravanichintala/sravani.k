using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyProject.DataConnection;
using System.Data;

namespace MyProject
{
    public partial class post : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            PostConnection postConnectionObj = new PostConnection();
            postproperties postpropertiesObj = new postproperties();

            postpropertiesObj.Title = txttitle.Text;
            postpropertiesObj.Subtitle = txtSubtitle.Text;
            postpropertiesObj.Content = txtContent.Text;
            string msg = postConnectionObj.Insertpost(postpropertiesObj);
            lblResult.Text = msg;
            

        }

        protected void BtnReset_Click(object sender, EventArgs e)
        {

        }
    }
}
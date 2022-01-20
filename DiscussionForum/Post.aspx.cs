using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiscussionForum.PostConnection;
using System.Data;

namespace DiscussionForum
{
    public partial class Post : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            PostDataConnection PostObj = new PostDataConnection();
           PostProperties PostPropertiesObj = new PostProperties();

            PostPropertiesObj.Post_Id = Convert.ToInt32(txtPost_Id.Text);
            PostPropertiesObj.Post_Title = txtPost_Title.Text;
            PostPropertiesObj.Post_Subtitle = txtPost_Subtitle.Text;
            PostPropertiesObj.Post_Content = txtPost_Content.Text;
            PostPropertiesObj.Post_status = txtPost_status.Text;

            string msg =PostObj.InsertTutorial(PostPropertiesObj);
           
            DataTable dtResult = PostObj.SelectPost();
            gvPostDetails.DataSource = dtResult;
            gvPostDetails.DataBind();
        }

        protected void BtnReset_Click(object sender, EventArgs e)
        {

        }
    }
}
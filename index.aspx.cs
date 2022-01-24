using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TutorialApplications.DataConnection;
using System.Data;


namespace TutorialApplications
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {

            TutorialDBConnection tutorialDBConnectionObj = new TutorialDBConnection();
            TutorialModel tutorialModel = new TutorialModel();

            tutorialModel.TutorialId = Convert.ToInt32(txtTutorialId.Text);
            tutorialModel.TutorialName = txtTutorialName.Text;
            tutorialModel.TutorialDesc = txtDescription.Text;
            tutorialModel.Published = Convert.ToInt32(txtPublished.Text);

            string msg = tutorialDBConnectionObj.InsertTutorial(tutorialModel);
            lblResult.Text = msg;
            DataTable dtResult = tutorialDBConnectionObj.SelectTutorial();
            gvTutorialDetails.DataSource = dtResult;
            gvTutorialDetails.DataBind();

        }

        protected void BtnReset_Click(object sender, EventArgs e)
        {

        }
    }
}
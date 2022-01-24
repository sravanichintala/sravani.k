using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TutorialApplicationss.DataConnection;
using System.Data;

namespace TutorialApplicationss
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TutorialDBConnection tutorialDBConnectionObj = new TutorialDBConnection();
            DataTable dtResult = tutorialDBConnectionObj.SelectTutorial();
            gvTutorialDetails.DataSource = dtResult;
            gvTutorialDetails.DataBind();
        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            TutorialDBConnection tutorialDBConnectionObj = new TutorialDBConnection();
            TutorialModel tutorialModel = new TutorialModel();

            tutorialModel.TutorialId = Convert.ToInt32(txtTutorialId.Text);
            tutorialModel.TutorialName = txtTutorialName.Text;
            tutorialModel.TutorialDesc = txtDesc.Text;
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

        protected void BtnEdit_Click(object sender, EventArgs e)
        {
            TutorialDBConnection tutorialDBConnectionObj = new TutorialDBConnection();
            DataTable dtResult = tutorialDBConnectionObj.EditTutorialById(Convert.ToInt32(txtTutorialId.Text));
            txtTutorialName.Text = dtResult.Rows[0][1].ToString();
            txtDesc.Text= dtResult.Rows[0][2].ToString();
            txtPublished.Text= dtResult.Rows[0][3].ToString();
        }

        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            TutorialDBConnection tutorialDBConnectionObj = new TutorialDBConnection();
            TutorialModel tutorialModel = new TutorialModel();

            tutorialModel.TutorialId = Convert.ToInt32(txtTutorialId.Text);
            tutorialModel.TutorialName = txtTutorialName.Text;
            tutorialModel.TutorialDesc = txtDesc.Text;
            tutorialModel.Published = Convert.ToInt32(txtPublished.Text);

            string msg = tutorialDBConnectionObj.UpdateTutorial(tutorialModel);
            lblResult.Text = msg;
            DataTable dtResult = tutorialDBConnectionObj.SelectTutorial();
            gvTutorialDetails.DataSource = dtResult;
            gvTutorialDetails.DataBind();
        }

        protected void BtnDelete_Click(object sender, EventArgs e)
        {
            TutorialDBConnection tutorialDBConnectionObj = new TutorialDBConnection();
            string msg = tutorialDBConnectionObj.DeleteTutorialById(Convert.ToInt32(txtTutorialId.Text));
            Label1.Text = msg;
            DataTable dtResult = tutorialDBConnectionObj.SelectTutorial();
            gvTutorialDetails.DataSource = dtResult;
            gvTutorialDetails.DataBind();
        }
       // public void Loadtutorialdata()
        //{
          //  TutorialDBConnection tutorialDBConnectionObj = new TutorialDBConnection();
          //  DataTable dtResult = tutorialDBConnectionObj.SelectTutorial();
           // gvTutorialDetails.DataSource = dtResult;
            //gvTutorialDetails.DataBind();
            //we have to use Loadtutorialdata  fn instead of this  three lines 
        //}
    }
}
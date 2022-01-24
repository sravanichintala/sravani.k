using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TutorialApplicationBusiness;
using TutorialApplicationssEntity;
using System.Data;

namespace TutorialApplicationss
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnRegister_Click(object sender, EventArgs e)
        {
            UserInfoModel UserInfoModelObj = new UserInfoModel();
            UserInfoBusiness userInfoBusiness = new UserInfoBusiness();
            UserInfoModelObj.FirstName = txtFirstName.Text;
            UserInfoModelObj.LastName = txtLastName.Text;
            UserInfoModelObj.Email = txtEmail.Text;
            UserInfoModelObj.Mobile = Convert.ToInt32(txtMobile.Text);
            UserInfoModelObj.Pwd = txtPwd.Text;

            string msg= userInfoBusiness.InsertUser(UserInfoModelObj );
            DataTable dtUserInfo = UserInfoBusiness.GetUserInfo();
            gvUserInfo.DataSource = dtUserInfo;
            gvUserInfo.DataBind();
        }
    }
}
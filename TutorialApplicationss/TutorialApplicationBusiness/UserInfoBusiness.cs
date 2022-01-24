using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutorialApplicationData;
using System.Data;
using TutorialApplicationssEntity;


namespace TutorialApplicationBusiness
{
  public class UserInfoBusiness
    {
        public string InsertUser(UserInfoModel UserInfoModel)
        {
          UserInfoDataConnection UserObj = new UserInfoDataConnection();
            string msg = UserObj.InsertUser(UserInfoModel);
            return msg;
        }
        public DataTable GetUserInfo(UserInfoModel UserInfoObj)
        {
            UserInfoDataConnection UserObj = new UserInfoDataConnection();
            DataTable dt = UserObj.GetUserInfo(UserInfoObj);
            return dt;

        }
    }
}

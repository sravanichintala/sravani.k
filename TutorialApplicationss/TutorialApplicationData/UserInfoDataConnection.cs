using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using TutorialApplicationssEntity;

namespace TutorialApplicationData
{
   public class UserInfoDataConnection
    {
        string sqlConnectionStr = "Data Source=LAPTOP-M9MKNCAD\\SQLEXPRESS ;Initial Catalog=TutorialDB;Integrated Security=True";
        public string InsertUser(UserInfoModel UserInfoObj)
        {
            
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter("insert into UserInfo values(" + UserInfoObj.Id + ",'" + UserInfoObj.FirstName + "','" + UserInfoObj.LastName + "','" + UserInfoObj.Email + "',"+UserInfoObj.Mobile+",'"+ UserInfoObj.Pwd +"')", sqlConnectionObj);
            adp.Fill(dt);
            return "Registered successfully";
        }
        public DataTable GetUserInfo(UserInfoModel UserInfoObj)
        {

            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter("Select * from UserInfo(" + UserInfoObj.Id + ",'" + UserInfoObj.FirstName + "','" + UserInfoObj.LastName + "','" + UserInfoObj.Email + "'," + UserInfoObj.Mobile + ",'" + UserInfoObj.Pwd + "')", sqlConnectionObj);
            adp.Fill(dt);
            return dt;
        }
    }
}

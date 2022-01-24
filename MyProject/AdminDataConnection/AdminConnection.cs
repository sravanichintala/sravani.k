using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace MyProject.AdminDataConnection
{
    public class AdminConnection
    {
        string sqlConnectionStr = "Data Source=LAPTOP-M9MKNCAD\\SQLEXPRESS ;Initial Catalog=Myproject;Integrated Security=True";
        public string Insertpost(properties propertiesObj)
        {
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlCommand sqlCommandObj = new SqlCommand("insert into Admin values('" + propertiesObj.UserName+"','"+propertiesObj.Pwd+"')", sqlConnectionObj);
            sqlConnectionObj.Open();
            sqlCommandObj.ExecuteNonQuery();
            sqlConnectionObj.Close();
            return "post details saved successfully";
        }
        public void Update(properties propertiesObj)
        {

        }
        public void DeleteById()
        {

        }
        public DataTable Select()
        {
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlCommand sqlCommandObj = new SqlCommand("select * from Homeadminpage", sqlConnectionObj);
            sqlConnectionObj.Open();
            SqlDataReader sqlDataReader = sqlCommandObj.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sqlDataReader);
            sqlConnectionObj.Close();
            return dt;
        }
        public void EditById()
        {

        }
    }
}
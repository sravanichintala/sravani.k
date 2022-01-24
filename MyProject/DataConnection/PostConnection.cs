using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace MyProject.DataConnection
{
    public class PostConnection
    {
        string sqlConnectionStr = "Data Source=LAPTOP-M9MKNCAD\\SQLEXPRESS ;Initial Catalog=Myproject;Integrated Security=True";
        public string Insertpost(postproperties PostpropertiesObj)
        {
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlCommand sqlCommandObj = new SqlCommand("insert into post values('" + PostpropertiesObj.Title + "','" + PostpropertiesObj.Subtitle + "','" +PostpropertiesObj.Content + ")", sqlConnectionObj);
            sqlConnectionObj.Open();
            sqlCommandObj.ExecuteNonQuery();
            sqlConnectionObj.Close();
            return "post details saved successfully";
        }
        public void Updatepost(postproperties PostpropertiesObj)
        {

        }
        public void DeletepostById()
        {

        }
        public DataTable Selectpost()
        {
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlCommand sqlCommandObj = new SqlCommand("select * from post", sqlConnectionObj);
            sqlConnectionObj.Open();
            SqlDataReader sqlDataReader = sqlCommandObj.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sqlDataReader);
            sqlConnectionObj.Close();
            return dt;
        }
        public void EditpostById()
        {

        }
    }
}
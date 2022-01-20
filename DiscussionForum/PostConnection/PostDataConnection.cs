using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace DiscussionForum.PostConnection
{
    
    public class PostDataConnection
    {
        string sqlConnectionStr = "Data Source=LAPTOP-M9MKNCAD\\SQLEXPRESS ;Initial Catalog=DiscussionForum;Integrated Security=True";
        public string InsertTutorial(PostProperties PostObj)
        {
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlCommand sqlCommandObj = new SqlCommand("insert into Tutorial values(" +PostObj.Post_Id + ",'" + PostObj.Post_Title + "','" + PostObj.Post_Subtitle + "','" + PostObj.Post_Content+ "','"+PostObj.Post_status+"')", sqlConnectionObj);
            sqlConnectionObj.Open();
            sqlCommandObj.ExecuteNonQuery();
            sqlConnectionObj.Close();
            return "Post details saved successfully";
        }
        public void UpdatePost(PostProperties PostObj)
        {

        }
        public void DeletePostById(int Post_Id)
        {

        }
        public DataTable SelectPost()
        {
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlCommand sqlCommandObj = new SqlCommand("select * from Post", sqlConnectionObj);
            sqlConnectionObj.Open();
            SqlDataReader sqlDataReader = sqlCommandObj.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sqlDataReader);
            sqlConnectionObj.Close();
            return dt;
        }
        public void EditPostById(int Post_Id)
        {

        }
    }
}
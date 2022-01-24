using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace TutorialApplicationss.DataConnection
{
    public class TutorialDBConnection
    {
        string sqlConnectionStr = "Data Source=LAPTOP-M9MKNCAD\\SQLEXPRESS ;Initial Catalog=TutorialDB;Integrated Security=True";
        public string InsertTutorial(TutorialModel tutorialModelObj)
        {
            DataTable dt = new DataTable();
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            //*******************region connected Appoarch*****************//
            // SqlCommand sqlCommandObj = new SqlCommand("insert into Tutorial values(" + tutorialModelObj.TutorialId + ",'" + tutorialModelObj.TutorialName + "','" + tutorialModelObj.TutorialDesc + "'," + tutorialModelObj.Published + ")", sqlConnectionObj);
            // sqlConnectionObj.Open();
            // sqlCommandObj.ExecuteNonQuery();
            // sqlConnectionObj.Close();
            //*******************end region****************//


            //*************** region disconnected apporach************//
            SqlDataAdapter adp = new SqlDataAdapter("insert into Tutorial values(" + tutorialModelObj.TutorialId + ",'" + tutorialModelObj.TutorialName + "','" + tutorialModelObj.TutorialDesc + "'," + tutorialModelObj.Published + ")", sqlConnectionObj);
            adp.Fill(dt);
            //*************** End region************//

            return "Tutorial details saved successfully";

            // for disconnected apporach every function same like that.
        }
        public string UpdateTutorial(TutorialModel tutorialModelObj)
        {
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlCommand sqlCommandObj = new SqlCommand("Update Tutorial set TutorialName='" + tutorialModelObj.TutorialName+ "',TutorialDesc='" + tutorialModelObj.TutorialDesc+"',Published='" + tutorialModelObj.Published + "where TutorialId="+tutorialModelObj.TutorialId+"", sqlConnectionObj);
            sqlConnectionObj.Open();
            sqlCommandObj.ExecuteNonQuery();
            sqlConnectionObj.Close();
            return " Tutorial id "+ tutorialModelObj.TutorialId+"details Update successfully";
        }
        public string DeleteTutorialById(int tutorialId)
        {
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlCommand sqlCommandObj = new SqlCommand("Delete from Tutorial where TutorialId="+tutorialId+"", sqlConnectionObj);
            sqlConnectionObj.Open();
            sqlCommandObj.ExecuteNonQuery();
            sqlConnectionObj.Close();
            return " Tutorial id"+tutorialId+"details Delete successfully";
        }
        public DataTable SelectTutorial()
        {
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlCommand sqlCommandObj = new SqlCommand("select * from Tutorial", sqlConnectionObj);
            sqlConnectionObj.Open();
            SqlDataReader sqlDataReader = sqlCommandObj.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sqlDataReader);
            sqlConnectionObj.Close();
            return dt;
        }
        public DataTable EditTutorialById(int tutorialId)
        {
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlCommand sqlCommandObj = new SqlCommand("select * from Tutorial where TutorialId="+tutorialId+"", sqlConnectionObj);
            sqlConnectionObj.Open();
            SqlDataReader sqlDataReader = sqlCommandObj.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sqlDataReader);
            sqlConnectionObj.Close();
            return dt;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyProject.DataConnection;
using System.Data;
using System.Data.SqlClient;

namespace MyProject
{
    public partial class HomeLoginPage : System.Web.UI.Page
    {
        void FillData()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-M9MKNCAD\\SQLEXPRESS ;Initial Catalog=Myproject;Integrated Security=True");
            SqlDataAdapter Da = new SqlDataAdapter("select * from post",con);
            DataSet ds = new DataSet();
            Da.Fill(ds, "post");
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
               if(IsPostBack==false)
            {
                FillData();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            //int PostId = int.Parse(TextBox1.Text);
           // string Title = TextBox2.Text;
           /// string Subtitle = TextBox3.Text;
            //string Content = TextBox4.Text;
           // string PostStatus = TextBox5.Text;
          
        }
        
    }
}
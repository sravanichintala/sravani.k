using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tutorialinfo
{
    public partial class studentDB : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btnsave_Click(object sender, EventArgs e)
        {
            string name;int number;string course;
            name = txtname.Text;
            number = Convert.ToInt32(txtnumber.Text);
            course = txtcourse.Text;
            lblresult.Text = "details:" + name + "," + number + "," + course;


        }

        protected void Btnreset_Click(object sender, EventArgs e)
        {

        }
    }
}
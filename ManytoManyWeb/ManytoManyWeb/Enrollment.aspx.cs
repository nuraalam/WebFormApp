using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ManytoManyWeb
{
    public partial class Enrollment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Response.Write(Session.IsCookieless);
            List<Student> studentList = (List<Student>) Session["Student"];
            studentRegNoDropDownList.DataSource = studentList;
            studentRegNoDropDownList.DataTextField = "RegNo";
            studentRegNoDropDownList.DataValueField = "Name";
            studentRegNoDropDownList.DataBind();
        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
          
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ManytoManyWeb
{
    public partial class MainWebUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void studentEntryButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentEntryWebUI.aspx");
        }

        protected void courseEntryButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("DepartmentEntryWebUI.aspx");
        }

        protected void enrollmentButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Enrollment.aspx");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ManytoManyWeb
{
    public partial class StudentEntryWebUI : System.Web.UI.Page
    {
        private List<Student> studentList;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                studentList = new List<Student>();
                ViewState["Student"] = studentList;
            }
        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            studentList = (List<Student>) ViewState["Student"];
            Student aStudent=new Student(regNoTextBox.Text,nameTextBox.Text,emailTextBox.Text);
            studentList.Add(aStudent);
            ViewState["Student"] = studentList;
            Session["Student"] = studentList;
        }
        protected void goToMainUiButton_Click1(object sender, EventArgs e)
        {
            Response.Redirect("MainWebUI.aspx");
        }
    }
}
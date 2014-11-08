using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StudentManagmentApp.BLL;

namespace StudentManagmentApp
{
    public partial class StudentView : System.Web.UI.Page
    {
        StudentManager aStudentManager = new StudentManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Student> students = aStudentManager.GetStudent();
                regNoDropDownList.DataSource = students;
                regNoDropDownList.DataTextField = "RegNo";
                regNoDropDownList.DataValueField = "ID";
                regNoDropDownList.DataBind();
            }
        }

        protected void showButton_Click(object sender, EventArgs e)
        {
          
            Student aStudent=aStudentManager.GetStudentInfo(regNoDropDownList.SelectedItem.Text);
            nameTextBox.Text = aStudent.Name;
            emailTextBox.Text = aStudent.Email;
        }
    }
}
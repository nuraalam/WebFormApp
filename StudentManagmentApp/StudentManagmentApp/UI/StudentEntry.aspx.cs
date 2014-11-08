using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StudentManagmentApp.BLL;

namespace StudentManagmentApp
{
    public partial class StudentEntry : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DepartmentManager aDepartmentManager=new DepartmentManager();
            if (!IsPostBack)
            {
                List<Department> departments=new List<Department>();
                departments = aDepartmentManager.GetDepartment();
                departmentDropDownList.DataSource = departments;
                departmentDropDownList.DataTextField = "Code";
                departmentDropDownList.DataValueField = "ID";
                departmentDropDownList.DataBind();
            }
        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            Student aStudent=new Student(Convert.ToInt32(departmentDropDownList.SelectedValue),nameTextBox.Text,emailTextBox.Text,regNoTextBox.Text);
            StudentManager aStudentManager=new StudentManager();
            string msg = aStudentManager.Insert(aStudent);
            displayStudentEntryMessage.Text= msg;
        }
    }
}
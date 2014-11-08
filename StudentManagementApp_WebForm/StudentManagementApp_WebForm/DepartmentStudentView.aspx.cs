using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StudentManagementApp_WebForm.BLL;
using StudentManagementApp_WebForm.Models;

namespace StudentManagementApp_WebForm
{
    public partial class DepartmentStudentView : System.Web.UI.Page
    {
       // const string cStudentConst = "Student_cnst";
        public List<Student> studentList
        {
            get
            {
                // to do not break SRP it's better to move check logic out of the getter
                return ViewState["key"] as List<Student>;
            }
            set
            {
                ViewState["key"] = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            DepartmentManager aDepartmentManager = new DepartmentManager();
            if (!IsPostBack)
            {
                List<Department> departments = new List<Department>();
                departments = aDepartmentManager.GetAllDepartment();
                departmentDropDownList.DataSource = departments;
                departmentDropDownList.DataTextField = "Code";
                departmentDropDownList.DataValueField = "DepartmentId";
                departmentDropDownList.DataBind();
            }
        }

        protected void showButton_Click(object sender, EventArgs e)
        {
            StudentManager aStudentManager=new StudentManager();
            studentList = aStudentManager.GetAllStudentByDepartment(Convert.ToInt32(departmentDropDownList.SelectedValue));
            regNoDropDownList.DataSource = studentList;
            regNoDropDownList.DataTextField = "RegNo";
            regNoDropDownList.DataValueField = "StudentId";
            regNoDropDownList.DataBind();
            try
            {
                nameTextBox.Text = studentList[0].Name;
                emailTextBox.Text = studentList[0].Email;
                msgLevel.Text = "";
            }
            catch (Exception)
            {
                msgLevel.Text = "There is no Student in this Department";
                nameTextBox.Text = "";
                emailTextBox.Text = "";
            }
           
        }

        protected void regNoDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index=regNoDropDownList.SelectedIndex;
            nameTextBox.Text=studentList[index].Name;
            emailTextBox.Text = studentList[index].Email;
            msgLevel.Text = "";
        }
    }
}
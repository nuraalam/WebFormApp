using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StudentManagementApp_WebForm.BLL;
using StudentManagementApp_WebForm.Models;

namespace StudentManagementApp_WebForm.UI
{
    public partial class DepartmentEntry : System.Web.UI.Page
    {

        DepartmentManager aDepartmentManager = new DepartmentManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            msgLabel.Text = "";
        }

        protected void deptSave_OnClick(object sender, EventArgs e)
        {
            try
            {
                Department aDepartment = new Department(txtcode.Text, txtName.Text);
                bool isSaved = aDepartmentManager.Insert(aDepartment);
                msgLabel.Text = isSaved ? "Saved Successfully!" : "Code is Exist!";
            }
            catch (Exception exception)
            {
                msgLabel.Text = exception.Message;
            }
           
        }
    }
}
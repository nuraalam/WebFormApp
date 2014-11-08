using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentManagmentApp
{
    public partial class DepartmentEntry : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
            }
        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            Department aDepartment=new Department(codeTextBox.Text,nameTextBox.Text);
            DepartmentManager aDepartmentManager=new DepartmentManager();
            string msg = aDepartmentManager.SaveDepartment(aDepartment);
        }
    }
}
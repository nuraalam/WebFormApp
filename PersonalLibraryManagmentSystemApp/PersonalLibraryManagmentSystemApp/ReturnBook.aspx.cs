using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PersonalLibraryManagmentSystemApp
{
    public partial class ReturnBook : System.Web.UI.Page
    {
        private BookManager aBookManager=new BookManager();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void showBorrowedBookButton_Click(object sender, EventArgs e)
        {
            borrowedBooklistDropDownList.DataSource=aBookManager.ShowAllBorroweBookForThisMember(enterMemberNoTextBox.Text);
            borrowedBooklistDropDownList.DataTextField = "Book";
            borrowedBooklistDropDownList.DataValueField = "BorrowedId";
            borrowedBooklistDropDownList.DataBind();
        }

        protected void returnButton_Click(object sender, EventArgs e)
        {
            aBookManager.DeleteBookByMember(borrowedBooklistDropDownList.SelectedValue);
            msgLevel.Text = borrowedBooklistDropDownList.SelectedItem + " is deleted";
            borrowedBooklistDropDownList.Items.Clear();
            enterMemberNoTextBox.Text = "";
        }
    }
}
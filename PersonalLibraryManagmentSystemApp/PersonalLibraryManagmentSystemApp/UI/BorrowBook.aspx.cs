using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PersonalLibraryManagmentSystemApp
{
    public partial class BorrowBook : System.Web.UI.Page
    {
        private BookManager aBookManager;

        public List<Book> bookList
        {
            get
            {
                // to do not break SRP it's better to move check logic out of the getter
                return ViewState["key"] as List<Book>;
            }
            set
            {
                ViewState["key"] = value;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            aBookManager = new BookManager();
            if (!IsPostBack)
            {            
                bookList = aBookManager.GetAllBook();
                selectABookDropDownList.DataSource = bookList;
                selectABookDropDownList.DataTextField = "title";
                selectABookDropDownList.DataValueField = "title";
                authorTextBox.Text = bookList[0].Author;
                publisherTextBox.Text = bookList[0].Publisher;
                selectABookDropDownList.DataBind();
            }
        }

        protected void borrowButton_Click1(object sender, EventArgs e)
        {
            try
            {
                Borrower aBorrower=new Borrower(enterMemberNoTextBox.Text,selectABookDropDownList.SelectedValue);
                bool isSaved=aBookManager.Save(aBorrower);
                msgLevel.Text = isSaved ? selectABookDropDownList.SelectedValue+" book is borrowed by member whose number is :"+enterMemberNoTextBox.Text : "Sorry, member number doesn't exists";

            }
            catch (Exception exception)
            {

                msgLevel.Text = exception.Message;
            }
        }

        protected void selectABookDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = selectABookDropDownList.SelectedIndex;
            authorTextBox.Text = bookList[index].Author;
            publisherTextBox.Text = bookList[index].Publisher;
        }
    }
}
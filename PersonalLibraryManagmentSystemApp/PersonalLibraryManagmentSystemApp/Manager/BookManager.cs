using System.Collections.Generic;

namespace PersonalLibraryManagmentSystemApp
{
    public class BookManager
    {
        BookGateway aBookGateway=new BookGateway();
        public List<Book> GetAllBook()
        {
            return aBookGateway.GetAllbook();
        }

        public bool Save(Borrower aBorrower)
        {
            int rowAffected = 0;
            if (IsMemberExist(aBorrower))
            {
                rowAffected = aBookGateway.Save(aBorrower);
            }

            return rowAffected > 0;
        }

        private bool IsMemberExist(Borrower aBorrower)
        {
           
            Member retriveMember = aBookGateway.GetAllMember(aBorrower.Number);

            return retriveMember != null;
        }
    }
}
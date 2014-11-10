namespace PersonalLibraryManagmentSystemApp
{
    public class Borrower
    {
        public string Number { get; set; }
        public string Book { get; set; }
        public int BorrowedId { get; set; }

        public Borrower(string number, string book)
        {
            Number = number;
            Book = book;
        }
    }
}
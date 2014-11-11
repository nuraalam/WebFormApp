using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Runtime.Hosting;

namespace PersonalLibraryManagmentSystemApp
{
    public class BookGateway:Gateway
    {
        public BookGateway(): base("PersonalLibraryConnectionString")
        {
        }

        public List<Book> GetAllbook()
        {
            var query = "SELECT * FROM Book";

            Command.CommandText = query;

            Connection.Open();
            SqlDataReader rdr = Command.ExecuteReader();

            List<Book> bookList= new List<Book>();

            while (rdr.Read())
            {             
                Book aBook=new Book();
                aBook.Id = (int) rdr["Id"];
                aBook.Title = rdr["Title"].ToString();
                aBook.Author = rdr["Author"].ToString();
                aBook.Publisher = rdr["Publisher"].ToString();
                bookList.Add(aBook);
            }

            rdr.Close();
            Connection.Close();
            return bookList;
        }

        public Member GetAllMember(string number)
        {
            Member aMember = null;
            var query = "SELECT * FROM member WHERE Number = '" + number + "'";

            Command.CommandText = query;

            Connection.Open();
            SqlDataReader reader = Command.ExecuteReader();

            while (reader.Read())
            {
                aMember=new Member();
                aMember.Id = (int) reader["Id"];
                aMember.Number = reader["Number"].ToString();              
            }

            reader.Close();
            Connection.Close();
            return aMember;
        }

        public int Save(Borrower aBorrower)
        {
            var query = "INSERT INTO BorrowBook (MemberId,BookName) Values(@0,@1)";
            Command.Parameters.AddWithValue("@0", aBorrower.Number);
            Command.Parameters.AddWithValue("@1", aBorrower.Book);
            Command.CommandText = query;

            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();

            return rowAffected;
        }

        public List<Borrower> ShowAllBrrowedBookForThisMember(string memberNumber)
        {
            var query = "SELECT * FROM BorrowBook WHERE MemberId="+memberNumber;

            Command.CommandText = query;

            Connection.Open();
            SqlDataReader rdr = Command.ExecuteReader();

            List<Borrower> bookList = new List<Borrower>();

            while (rdr.Read())
            {
                Borrower aBorrowerBooks = new Borrower();
                aBorrowerBooks.BorrowedId = (int)rdr["BorrowID"];
                aBorrowerBooks.Number = rdr["MemberId"].ToString();
                aBorrowerBooks.Book = rdr["BookName"].ToString();
                bookList.Add(aBorrowerBooks);
            }

            rdr.Close();
            Connection.Close();
            return bookList;
        }

        public void DeletedBookByManager(string selectedValue)
        {
         var query= "DELETE FROM BorrowBook WHERE BorrowId = "+selectedValue;
         Command.CommandText = query;

         Connection.Open();
         Command.ExecuteNonQuery();
         Connection.Close();

        }
    }
}
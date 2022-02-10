using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Terminal
{
    internal class BookCheck
    {
       
            public static string CheckOut(BookClass book)
            {
                string duedate = book.DueDate;
                string checkedOutMessage;
                DateTime today = new DateTime();
                if (book.IsCheckedIn)
                {
                    DateTime.Now.ToString();
                    book.DueDate = today.AddDays(7).ToString();
                    duedate = book.DueDate.ToString();
                    book.IsCheckedIn = false;
                    return duedate;
                }
                else
                {
                    checkedOutMessage = $"This Book is checked out. It should be back {book.DueDate.ToString()}.";
                    return checkedOutMessage;
                }

            }

            public static string CheckIn(BookClass book)
            {
                string duedate = book.DueDate;
                DateTime today = new DateTime();
                if (book.IsCheckedIn)
                {

                    return "This book is already checked in.";
                }
                else if (!book.IsCheckedIn)
                {

                    book.IsCheckedIn = true;
                }

                return "Book Checked in.";
            }
    }
}

//<<<<<<< HEAD
//﻿K
//using BiblioTecca;
//using System.IO;

////"C:/Users/carso/source/repos/BiblioTecca/BiblioTecca/bibliotecca.txt";

//string filePath = "../../../bibliotecca.txt";
//Console.WriteLine("Write your name");

//var userInput = Console.ReadLine();


//List<Book> books = new List<Book>();

//books.Add(new Book(""));

//using FileStream filesStream = File.Create(filePath);

//using StreamWriter sw = new StreamWriter(filesStream);

//foreach (Book book in books)
//{
//    sw.WriteLine(book.Name);
//}
//namespace BiblioTecca
//{
//    public abstract class Manuscript
//    {
//        //int year;
//        //string author;
//        //bool checkedOut;

//        public Manuscript(string name)
//        {
//            this.Name = name;
//        }
//        public string Name { get; set; }

//        public virtual string checkedOut(string personName)
//        {

//            return "yes";
//        }

//    }
//}
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BiblioTecca
//{
//    public class Book : Manuscript
//    {
//        public Book(string name) : base(name)
//        {
//        }

//        public bool isCheckedIn = true;

//        public bool GetStatus()
//        {

//            return false;
//        }


//        public int year { get; set; }
//        public string author { get; set; }
//        public bool isHere { get; set; }

//    }
//}
//=======
//﻿using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.IO;

//namespace BiblioTecca
//{
//    public class Book : Manuscript
//    {
//        public Book(string name) : base(name)
//        {
//        }

//        public bool TryGetBooks(string userInput, out string isHere)
//        {
//            switch (userInput.ToLower())
//            {
//                case "book1":
//                    {
//                        isHere = true;
//                        return "This book is on the shelf";
//                    }
//                case "book2":
//                    {
//                        isHere = false;
//                        return "Sorry, this book is checked out";
//                    }
//                default:
//                    {
//                        return "Sorry, this book does not exist at this library";
//                    }
//            }
//        }

//        public bool GetStatus()
//        {

//            return false;
//        }


//        public int year { get; set; }
//        public string author { get; set; }
//        public bool isHere { get; set; }

//    }

////"C:/Users/carso/source/repos/BiblioTecca/BiblioTecca/bibliotecca.txt";


//string filePath = "../../../librarytext.txt";

//var userInput = Console.ReadLine();

//    BookList book1 = new BookList("It", "Stephen King");

//    List<BookList> Bookss = new List<BookList>();
//    Bookss.Add(book1);

////book list for the text file
//    List<BookList> books = new List<BookList>();

//    books.Add(new BookList("It", "Stephen King"));
//    books.Add(new Book("Sandman"));
//    books.Add(new Book("Room"));
//    books.Add(new Book("The Help"));
//    books.Add(new Book("One Flew Over the Cuckoos Next"));
//    books.Add(new Book("How To Teach Your Cat About Gun Safety: And Abstinence, Drugs, Satanism, And Other Dangers That Threaten Their Nine lives"));
//    books.Add(new Book("American Gods"));
//    books.Add(new Book("The Outsiders"));
//    books.Add(new Book("Pride of Bagdhad"));
//    books.Add(new Book("Drawing on the Right Side of the Brain"));
//    books.Add(new Book("Harry Potter"));
//    books.Add(new Book("Wizard of Oz"));

//    using FileStream filesStream = File.Create(filePath);
//// streamwriter to write and read from the text file
//    using StreamWriter sw = new StreamWriter(filesStream);

//    foreach (Book book in books)
//    {
//        sw.WriteLine(book.Name);
//    }
//}

//    using (StreamReader sr = new StreamReader("../../../librarytext.txt"))
//    {
//        foreach ()
//    }
//    public abstract class Manuscript
//    {
//        //due date
//        //string author;
//        //bool checkedOut;

//        public Manuscript(string name)
//        {
//            this.Name = name;
//        }
//        public string Name { get; set; }

//        public virtual string checkedOut(string personName)
//        {

//            return "yes";
//        }

//    }
//}


//>>>>>>> c7bef61c18b9995aac9e002727ed80c827cf281b

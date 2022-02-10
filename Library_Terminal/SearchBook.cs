using System;

public class SearchBook
{

    public class Manuscript
    {
        //due date
        //string author;
        //bool checkedOut;

        public Manuscript(string name)
        {
            this.Name = name;
        }
        public string Name { get; set; }

        public virtual string checkedOut(string personName)
        {

            return "yes";
        }

    }
    public class Book : Manuscript
    {
        public Book(string name) : base(name)
        {
        }

        public Book TryGetBooks(string userInput, out string isHere)
        {
            switch (userInput.ToLower())
            {
                case isHere:
                    {
                        isHere = true;
                        return "This book is on the shelf";
                    }
                case !isHere:
                    {
                        isHere = false;
                        return "Sorry, this book is checked out";
                    }
                default:
                    {
                        return "Sorry, this book does not exist at this library";
                    }
            }
        }

    }
}
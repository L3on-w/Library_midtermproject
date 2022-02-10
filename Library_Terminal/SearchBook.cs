using System;

public class SearchBook
{
<<<<<<< HEAD

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
=======
    /*public class Book : BookList
>>>>>>> baf7ec7b11e2b491d83210cb579a092d225062c1
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
                    }*/
            }
<<<<<<< HEAD
        }

    }
}
=======
        //}
        public abstract class Manuscript
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
    //}
//}
>>>>>>> baf7ec7b11e2b491d83210cb579a092d225062c1

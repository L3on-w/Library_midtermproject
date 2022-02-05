using System;

public class DisplayBooks
{
	public DisplayBooks()
	{
        List<BookList> Bookss = new List<BookList>();
        Bookss.Add(book1);

        //book list for the text file
        List<BookList> books = new List<BookList>();

        books.Add(new BookList("It", "Stephen King"));
        books.Add(new Book("Sandman"));
        books.Add(new Book("Room"));
        books.Add(new Book("The Help"));
        books.Add(new Book("One Flew Over the Cuckoos Next"));
        books.Add(new Book("How To Teach Your Cat About Gun Safety: And Abstinence, Drugs, Satanism, And Other Dangers That Threaten Their Nine lives"));
        books.Add(new Book("American Gods"));
        books.Add(new Book("The Outsiders"));
        books.Add(new Book("Pride of Bagdhad"));
        books.Add(new Book("Drawing on the Right Side of the Brain"));
        books.Add(new Book("Harry Potter"));
        books.Add(new Book("Wizard of Oz"));


        using FileStream filesStream = File.Create(filePath);
        // streamwriter to write and read from the text file
        using StreamWriter sw = new StreamWriter(filesStream);

        foreach (Book book in books)
        {
            sw.WriteLine(book.Name);
        }
    }

    using (StreamReader sr = new StreamReader("../../../BookNames.txt"))
{
    foreach ()
    }


    }


}

using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using Library_Terminal;


string filePath = "../../../BookNames.txt";

List<BookClass> books = ReadFromFile(filePath);
//List<Book> Books = new List<Book>();

foreach (BookClass book in books)
{
    Console.WriteLine(book.name + "\n");
}

Console.WriteLine(books[0].name);
Console.WriteLine(books[0].author);

do
{

    Console.WriteLine("Please pick an author/book or quit");
    Console.WriteLine(" ");
    string authorInput = Console.ReadLine();
    //string titleBook = Console.ReadLine();
    Console.WriteLine(" ");
    foreach (BookClass book in books)
    {
        if (book.author == authorInput || book.name == authorInput)
        {
            Console.WriteLine(book.name + " " + book.author + " " + book.IsCheckedIn.ToString() + "\n");
            /*Console.WriteLine("Would you like to checkout? Y N");
                if (Console.ReadLine().ToLower() == "Y");
            {
                Console.WriteLine(book.IsCheckedIn = false);
                Console.WriteLine(book.DueDate.ToString());
            }
            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.WriteLine(book.name + " " + book.author + " " + book.IsCheckedIn.ToString() + " " + book.DueDate.ToString() + "\n");
            }*/
        }
        else if (book.author != authorInput)
        {
            /*Console.WriteLine(book.name + " " + book.author + " " + book.IsCheckedIn.ToString() + "\n");
            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.WriteLine(book.name + " " + book.author + " " + book.IsCheckedIn.ToString() + " " + book.DueDate.ToString() + "\n");
            }*/
        }
        Console.WriteLine("Would you like to checkout? Y N");
    }
}

while (Console.ReadLine() != "quit");

/*using (StreamWriter sw = File.AppendText(filePath))
{
    sw.WriteLine(" ");
}*/
/*using (StreamReader sr = File.OpenText(filePath))
{
    string s = " ";
    //while ((s = sr.ReadLine()) != null)
    //{
    // Console.WriteLine(s);
    //}
}*/


static List<BookClass> ReadFromFile(string filePath)
{
    List<BookClass> Books = new List<BookClass>();
    int count = 0;
    StreamReader reader = new StreamReader(filePath);

    while (!reader.EndOfStream)
    {
        count++;
        string stringToProperties = reader.ReadLine();
        string[] properties = stringToProperties.Split('|');
        if (properties.Length > 1)
        {
            Books.Add(new BookClass(properties[0], properties[1]));
        }
        else
        {
            continue;
        }
    }
    Console.WriteLine($"There are {count} books.");
    reader.Close();
    return Books;

}
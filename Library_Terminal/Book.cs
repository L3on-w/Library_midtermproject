K
using BiblioTecca;using System.IO;

//"C:/Users/carso/source/repos/BiblioTecca/BiblioTecca/bibliotecca.txt";

string filePath = "../../../bibliotecca.txt";Console.WriteLine("Write your name");var userInput = Console.ReadLine();


List<Book> books = new List<Book>();

books.Add(new Book(""));

using FileStream filesStream = File.Create(filePath);

using StreamWriter sw = new StreamWriter(filesStream);

foreach (Book book in books)
{
    sw.WriteLine(book.Name);
}
namespace BiblioTecca{    public abstract class Manuscript    {
        //int year;
        //string author;
        //bool checkedOut;

        public Manuscript(string name)        {            this.Name = name;        }        public string Name { get; set; }        public virtual string checkedOut(string personName)        {            return "yes";        }    }}using System;using System.Collections.Generic;using System.Linq;using System.Text;using System.Threading.Tasks;namespace BiblioTecca{    public class Book : Manuscript    {        public Book(string name) : base(name)        {        }        public bool isCheckedIn = true;        public bool GetStatus()        {            return false;        }


        public int year { get; set; }        public string author { get; set; }        public bool isHere { get; set; }    }}
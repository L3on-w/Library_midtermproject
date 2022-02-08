﻿using System;

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
    Console.WriteLine(book.name);
}

Console.WriteLine(books[0].name);
Console.WriteLine(books[0].author);

Console.WriteLine(books[0].DueDate);
Console.WriteLine("Checking IT");
Console.WriteLine(books[1].IsCheckedIn);
Console.WriteLine("Checking IT out");
BookCheck.CheckOut(books[0]);
Console.WriteLine(books[0].DueDate);
Console.WriteLine("Checking IT again");
Console.WriteLine(books[0].IsCheckedIn);
Console.WriteLine("Checking IT out again");
BookCheck.CheckOut(books[0]);



static List<BookClass> ReadFromFile(string filePath)
{
    List<BookClass> Books = new List<BookClass>();
    int count = 0;
    StreamReader reader = new StreamReader(filePath);

    while (!reader.EndOfStream)
    {
        count++;
        string stringToProperties = reader.ReadLine();
        string[] properties = stringToProperties.Split(',');
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
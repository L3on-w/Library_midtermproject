using System;
using System.IO;
//using System.IO;


namespace Library_Terminal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Friend!");
            string[] PullFromTxt = File.ReadAllLines("../../../BookNames.txt");


            var bookTxtClasses = new BookList<BookText>();
            foreach (var book in PullFromTxt)










            //string FilePath = "C:\AHBC-nov2021-dotnet\Library Midterm Project\Library_midtermproject\Library_Terminal\BookNames.txt"
            //using(StreamWriter sw = new StreamWriter(FilePath))
            //{
            //    sw.WriteLine("Pick A Book");
            //}

        }
    }
}

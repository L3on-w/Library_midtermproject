using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
//using System.IO;



namespace Library_Terminal
{
    public class Book
    {

        public string author = "";
        public string title = "";
        public bool checkedIn = false;
        public int year;


        static void Main(string[] args)
        {
            Console.WriteLine("Hello Friend!");
            string[] PullFromTxt = File.ReadAllLines("../../../BookNames.txt");


            //string FilePath = "C:\AHBC-nov2021-dotnet\Library Midterm Project\Library_midtermproject\Library_Terminal\BookNames.txt"
            //using(StreamWriter sw = new StreamWriter(FilePath))
            //{
            //    sw.WriteLine("Pick A Book");
            //}

        }

    }
}


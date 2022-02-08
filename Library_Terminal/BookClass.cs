using System;
using System.Collections.Generic;
namespace Library_Terminal
{
    public class BookClass : BookInfo
    {
        public BookClass(string name, string author)
        {
            this.name = name;
            this.author = author;
        }
        public bool IsCheckedIn { get; set; } = true;

        public string DueDate { get; set; } = "";
    }
}


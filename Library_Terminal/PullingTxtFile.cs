using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class PullingFromtxt
{
    private object bookInfo;

    public PullingFromtxt()
	{
		//using (StreamReader sr = new StreamReader("../../../BookNames.txt"))
		//using FileStream filesStream = File.Create(filePath);
		//// streamwriter to write and read from the text file
		//using StreamWriter sw = new StreamWriter(filesStream);
		//sw.WriteLine(BookNames.txt)
		
		//foreach (Book book in books)
		//{
		//	sw.WriteLine(book.Name);
		//}
        string[] PullFromTxt = File.ReadAllLines("../../../BookNames.txt");

		var bookTxtGrouping = PullFromTxt.GroupBy(b => b.Split('|')[1], b => b.Split('|')[0]);

		var bookTxtClasses = new List<BookTxtPull>();
		foreach (var bookinfo in PullFromTxt)
        {
			var splitBookInfo = bookinfo.Split('|');
			var bookTitle = splitBookInfo[0];
			var authorName = splitBookInfo[1];

        }




	}
}

public class BookTxtPull
{
	public BookTxtPull(string authorName)
    {
		Author = authorName; 
    }
	public string Author { get; set; } = string.Empty;

	public IEnumerable<string> BookTitles { get; set; } = new List<string>();

}

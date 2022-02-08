using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class PullingFromtxt
{
    private object bookInfo;

    public PullingFromtxt()
	{
	    string[] PullFromTxt = File.ReadAllLines("../../../BookNames.txt");

		var bookTxtGrouping = PullFromTxt.GroupBy(b => b.Split('|')[1], b => b.Split('|')[0]);

		var bookTxtClasses = new List<BookTxtPull>();
		foreach (var bookinfo in PullFromTxt)
        {
			var splitBookInfo = bookinfo.Split('|');
			var bookTitle = splitBookInfo[0];
			var authorName = splitBookInfo[1];

        }

        Console.WriteLine("Enter an Author to search their literature.");
		foreach(var authorBooks in bookTxtClasses.Where(x => x, Author == authorName).Select(bookTxtClasses => bookTxtClasses.Title))




	}
}

public class AuthorTxtPull
{
	public AuthorTxtPull(string authorName)
	{
		Author = authorName;
	}
	public string Author { get; set; } = string.Empty;

}

public class BookTxtPull
{
	public BookTxtPull(string bookTitle)
	{
		Title = bookTitle;
	}
	public string Title { get; set; } = string.Empty;

	public IEnumerable<string> BookTitles { get; set; } = new List<string>();
}


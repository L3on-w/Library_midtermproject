using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class PullingFromtxt
{
    private object bookInfo;
    private string authorName;

    public PullingFromtxt()
	{
	    string[] PullFromTxt = File.ReadAllLines("../../../BookNames.txt");

		var bookTxtGrouping = PullFromTxt.GroupBy(b => b.Split('|')[1], b => b.Split('|')[0]);



		// lists and splits book title from author
		var bookTxtClasses = new List<BookTxtPull>();
		foreach (var bookinfo in PullFromTxt)
        {
			var splitBookInfo = bookinfo.Split('|');
			var bookTitle = splitBookInfo[0];
			var authorName = splitBookInfo[1];

        }


		//searching by author
        Console.WriteLine("Enter an Author to search their literature.");
		var author = Console.ReadLine();
		foreach (var authorBook in bookTxtClasses.Where(b => b.Equals(author == authorName)).Select(b => b.bookTitle))
        {
            Console.WriteLine(authorBook);
        }



		//dictionary route for key look up
		//var bookTxtGroupingDictionary = PullFromTxt.GroupBy(b => b.Split('|')[1], b => b.Split('|')[0]);
		//foreach (var book in bookTxtGroupingDictionary)
  //          {
		//		bookTxtClasses.Add(new PullingFromtxt

		//		{
		//			//Author = book.Key;
		//			//Title = book.Select(b => b);

		//		}

  //          }

    public string Author { get; }
    public IEnumerable<string> Title { get; }
}


public class AuthorTxtPull
{
	public AuthorTxtPull(string authorName)
	{
		Author = authorName;
	}
	public string Author { get; } = string.Empty;

}

public class BookTxtPull
{
    internal object bookTitle;

    public BookTxtPull(string bookTitle)
	{
		Title = bookTitle;
	}
	public string Title { get; set; } = string.Empty;

	public IEnumerable<string> BookTitles { get; set; } = new List<string>();
}


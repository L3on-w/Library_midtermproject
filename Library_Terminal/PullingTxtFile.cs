using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class PullingFromtxt
{
	private object bookInfo;
	private string authorName;
    private object searchBookNames;
    private string bookTitle;

    public PullingFromtxt()
	{
		string[] BookTxtPull = File.ReadAllLines("../../../BookNames.txt");

		var bookTxtGrouping = BookTxtPull.GroupBy(b => b.Split('|')[1], b => b.Split('|')[0]);



		// lists and splits book title from author
		var bookTxtClasses = new List<BookTxtPull>();
		foreach (var bookinfo in BookTxtPull)
		{
			var splitBookInfo = bookinfo.Split('|');
			var title = splitBookInfo[0];
			var authorName = splitBookInfo[1];
			DateTime checkOut = DateTime.Parse(splitBookInfo[2]);
						

		}

		//dictionary to pull from key word?
		Dictionary<string, string> book = new Dictionary<string, string>();
		var bookInfoDictionary = BookTxtPull.GroupBy(b => b.Split('|')[1], b => b.Split("|")[0]);
		//.ToDictionary(b => b.Key, b => b.Select(a => a));
		var keyWordSearch = bookInfoDictionary.Where(i => i.Contains(searchBookNames)).ToList();


		//searching by author
		Console.WriteLine("Enter an Author to search their literature.");
		var author = Console.ReadLine();
		foreach (var authorBook in bookTxtClasses.Where(b => b.Equals(author == authorName)).Select(b => b.bookTitle))
		{
			Console.WriteLine(authorBook);
		}


		//searching title
		Console.WriteLine("Enter a Book title To search options");
		var bTitle = Console.ReadLine();
		foreach (var titleBook in bookTxtClasses.Where(b => b.Equals(bTitle = bookTitle)).Select(b => b.bookTitle))
        {
            Console.WriteLine(titleBook);
        } 
		
	}
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
    internal object authorName;

    public BookTxtPull(string bookTitle)
	{
		Title = bookTitle;
	}
	public string Title { get; set; } = string.Empty;

	public IEnumerable<string> BookTitles { get; set; } = new List<string>();
}


using System;

public class PullingFromtxt
{
	public PullingFromtxt()
	{
		using (StreamReader sr = new StreamReader("../../../BookNames.txt"))
		using FileStream filesStream = File.Create(filePath);
		// streamwriter to write and read from the text file
		using StreamWriter sw = new StreamWriter(filesStream);
		sw.WriteLine(BookNames.txt)
		
		foreach (Book book in books)
		{
			sw.WriteLine(book.Name);
		}


	}
}

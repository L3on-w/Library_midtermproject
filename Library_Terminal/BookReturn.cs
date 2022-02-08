using System;

public class BookReturn
{
    public BookReturn(bool userTurnIn)
    {
        if (userTurnIn == true)
        {
            Console.WriteLine("Thank you! Feel free to browse for your next read!");
        }
        else
        {
            Console.WriteLine("Dont miss your due date!");

        }

    }
}

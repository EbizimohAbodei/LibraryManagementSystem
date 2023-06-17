using System;
namespace LibrarySystem;


public class TextBook : Book, IBorrowable
{
    public TextBook(string title, string author, string isbn, int publicationYear)
        : base(title, author, isbn, publicationYear)
    {
    }

    public void Borrow()
    {
        Console.WriteLine($"Textbook '{Title}' has been borrowed.");
    }

    public void Return()
    {
        Console.WriteLine($"Textbook '{Title}' has been returned.");
    }

    public void PrintPages(int startPage, int endPage)
    {
        int pageDifference = endPage - startPage;
        if (pageDifference < 10)
        {
            Console.WriteLine($"Printing from pages {startPage} to {endPage} of the textbook: {Title}");
            // Additional logic for printing the specified pages
        }
        else
        {
            Console.WriteLine("Error: Cannot print more than 10 pages.");
        }
    }
}
using System;
namespace LibrarySystem;

public class ResearchPaper : Book
{
    public ResearchPaper(string title, string author, string isbn, int publicationYear, int pages)
        : base(title, author, isbn, publicationYear, pages)
    {
    }

    public void PrintPages(int startPage, int endPage)
    {
        int pageDifference = endPage - startPage;
        int maxPage = 10;
        if (pageDifference < maxPage && endPage > pages)
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


using System;
namespace LibrarySystem;

public class ResearchPaper : Book
{
    public ResearchPaper(string title, string author, string isbn, int publicationYear)
        : base(title, author, isbn, publicationYear)
    {
    }

    public void PrintPages(int startPage, int endPage)
    {
        int pageLimit = 10;
        int pageCount = endPage - startPage + 1;
        int pagesToPrint = Math.Min(pageCount, pageLimit);

        Console.WriteLine($"Printing pages {startPage} to {startPage + pagesToPrint - 1} of research paper '{Title}'.");
    }
}


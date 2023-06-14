using System;

namespace LibraryManagementSystem;

class TextBook : Book, IBorrowable
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
        int pageLimit = 10;
        int pageCount = endPage - startPage + 1;
        int pagesToPrint = Math.Min(pageCount, pageLimit);

        Console.WriteLine($"Printing pages {startPage} to {startPage + pagesToPrint - 1} of textbook '{Title}'.");
    }
}
using System;

namespace LibraryManagement;

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
}
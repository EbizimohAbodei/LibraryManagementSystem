using System;
using System.Collections;

namespace LibraryManagementSystem;

class BorrowableBook : Book, IBorrowable
{
    public BorrowableBook(string title, string author, string isbn, int publicationYear)
        : base(title, author, isbn, publicationYear)
    {
    }

    public void Borrow()
    {
        Console.WriteLine($"Book '{Title}' has been borrowed.");
    }

    public void Return()
    {
        Console.WriteLine($"Book '{Title}' has been returned.");
    }
}
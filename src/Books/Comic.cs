using System;
namespace LibrarySystem;

public class Comic : Book, IBorrowable
{
    public string Artist { get; set; }

    public Comic(string title, string author, string isbn, int publicationYear, int pages, string artist)
        : base(title, author, isbn, publicationYear, pages)
    {
        Artist = artist;
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Artist: {Artist}");
    }

    public void Borrow()
    {
        Console.WriteLine($"Comic '{Title}' has been borrowed.");
    }

    public void Return()
    {
        Console.WriteLine($"Comic '{Title}' has been returned.");
    }
}

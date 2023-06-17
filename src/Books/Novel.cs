using System;
namespace LibrarySystem;


public class Novel : Book, IBorrowable
{
    public string Genre { get; set; }

    public Novel(string title, string author, string isbn, int publicationYear, string genre)
        : base(title, author, isbn, publicationYear)
    {
        Genre = genre;
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Genre: {Genre}");
    }

    public void Borrow()
    {
        Console.WriteLine($"Novel '{Title}' has been borrowed.");
    }

    public void Return()
    {
        Console.WriteLine($"Novel '{Title}' has been returned.");
    }
}

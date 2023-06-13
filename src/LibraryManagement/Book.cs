using System;

namespace LibraryManagement;

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }
    public int PublicationYear { get; set; }
    public bool CanBorrow { get; set; }
    public bool CanPrint { get; set; }

    public Book(string title, string author, string isbn, int publicationYear, bool canBorrow, bool canPrint)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
        PublicationYear = publicationYear;
        CanBorrow = canBorrow;
        CanPrint = canPrint;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"ISBN: {ISBN}");
        Console.WriteLine($"Publication Year: {PublicationYear}");
        Console.WriteLine($"Can Borrow: {CanBorrow}");
        Console.WriteLine($"Can Print: {CanPrint}");
    }
}
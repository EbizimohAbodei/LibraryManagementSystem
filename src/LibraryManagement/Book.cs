using System;

namespace LibraryManagementSystem;

public class Book
{
    private string _isbn;
    public string Title { get; set; }
    public string Author { get; set; }
    public int PublicationYear { get; set; } 

    public string ISBN
    {
        get { return _isbn; }
        private set { _isbn = value; }
    }

    public Book(string title, string author, string isbn, int publicationYear)
    {
        Title = title;
        Author = author;
        _isbn = isbn;
        PublicationYear = publicationYear;
    }

    public virtual void PrintInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"ISBN: {ISBN}");
        Console.WriteLine($"Publication Year: {PublicationYear}");
    }
}
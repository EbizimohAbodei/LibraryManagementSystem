using System;
using System.Collections.Generic;

namespace LibrarySystem;

public class Book
{
    private string _title;
    private string _author;
    private string _isbn;
    private int _publicationYear;
    private int _pages;

    public string Title
    {
        get { return _title; }
        set { _title = value; }
    }

    public string Author
    {
        get { return _author; }
        set { _author = value; }
    }

    public string ISBN
    {
        get { return _isbn; }
        private set { _isbn = value; }
    }

    public int PublicationYear
    {
        get { return _publicationYear; }
        set { _publicationYear = value; }
    }

     public int pages
    {
        get { return _pages; }
        set { _pages = value; }
    }

    public Book(string title, string author, string isbn, int publicationYear, int pages)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
        PublicationYear = publicationYear;
        pages = pages;
    }

    public virtual void PrintInfo()
    {
        Console.WriteLine($"Title: {Title} Author: {Author} ISBN: {ISBN} Publication Year: {PublicationYear} \n");
    }

}


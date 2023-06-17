using System;
using System.Collections.Generic;

namespace LibrarySystem;

public class Librarian : Person
{
    public Librarian(string name, int ID) : base(name, ID)
    {
    }

    public void AddBook(Book book)
    {
        Console.WriteLine($"{Name} has added the book: {book}");
    }

    public void RemoveBook(Book book)
    {
        Console.WriteLine($"{Name} has removed the book: {book}");
    }

    public void EditBook(Book book)
    {
        Console.WriteLine($"{Name} has edited the book: {book}");
    }

    public override void DoSomething()
    {
        Console.WriteLine($"{Name} is managing books.");
    }
}


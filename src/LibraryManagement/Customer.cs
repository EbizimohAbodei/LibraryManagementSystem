using System;
using System.Collections.Generic;
using System.Collections;

namespace LibrarySystem;

public class Customer : Person
{
    private List<Book> BorrowedBooks { get; }

    public Customer(string name, int ID) : base(name, ID)
    {
        BorrowedBooks = new List<Book>();
    }

    public void BorrowBook(Book book)
    {
        BorrowedBooks.Add(book);
        Console.WriteLine($"{Name} has borrowed the book: {book}");
    }

    public void ReturnBook(Book book)
    {
        if (BorrowedBooks.Contains(book))
        {
            BorrowedBooks.Remove(book);
            Console.WriteLine($"{Name} has returned the book: {book}");
        }
        else
        {
            Console.WriteLine($"{Name} does not have this book borrowed.");
        }
    }

    public override void DoSomething()
    {
        Console.WriteLine($"{Name} is borrowing/returning a book.");
    }
}
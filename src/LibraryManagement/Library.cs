using System;
using System.Collections.Generic;
using System.Collections;

namespace LibraryManagementSystem;

public class Library
{
    private List<Book> books;
    private List<Person> people;

    public Library()
    {
        books = new List<Book>();
        people = new List<Person>();
    }

    public void AddBook(Book book)
    {
        books.Add(book);
        Console.WriteLine($"Book added: {book.Title}");
    }

    public void RemoveBook(Book book)
    {
        books.Remove(book);
        Console.WriteLine($"Book removed: {book.Title}");
    }

    public void BorrowBook(Book book, Person person)
    {
        Console.WriteLine($"{person.Name} borrowed the book: {book.Title}");
    }

    public void ReturnBook(Book book, Person person)
    {
        Console.WriteLine($"{person.Name} returned the book: {book.Title}");
    }

    public void PrintBooks()
    {
        foreach (var book in books)
        {
            book.PrintInfo();
            Console.WriteLine();
        }
    }

    public void AddPerson(Person person)
    {
        people.Add(person);
        Console.WriteLine($"Person added: {person.Name}");
    }

    public void RemovePerson(Person person)
    {
        people.Remove(person);
        Console.WriteLine($"Person removed: {person.Name}");
    }

    public void EditPerson(Person person)
    {
        Console.WriteLine($"Person edited: {person.Name}");
    }
    
}

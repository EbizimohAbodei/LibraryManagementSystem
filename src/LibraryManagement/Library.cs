using System;
using System.Collections.Generic;
using System.Collections;

namespace LibrarySystem;

public class Library
{
    private List<Book> _books;
    private List<Person> _persons;

    public List<Book> Books
    {
        get { return _books; }
    }

    public List<Person> Persons
    {
        get { return _persons; }
    }

    public Library()
    {
        _books = new List<Book>();
        _persons = new List<Person>();
    }

    public void AddBook(Book book)
    {   
        if (IsUniqueISBN(book.ISBN))
        {
        _books.Add(book);
        Console.WriteLine($"Book added successfully: {book.Title}");
        }
        else
        {
            Console.WriteLine("A book with the same ISBN already exists in the library.");
        }
    }

    public void RemoveBook(Book book)
    {
        if (_books.Contains(book))
        {
            _books.Remove(book);
            Console.WriteLine($"Book removed: {book.Title}");
        }
        else
        {
            Console.WriteLine("Book not found in the library.");
        }
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
        foreach (var book in _books)
        {
            book.PrintInfo();
            Console.WriteLine();
        }
    }

    private bool IsUniqueISBN(string isbn)
    {
        foreach (Book book in _books)
        {
            if (book.ISBN == isbn)
            {
                return false;
            }
        }
        return true;
    }

    public void AddPerson(Person person)
    {   
        _persons.Add(person);
        Console.WriteLine($"Person added: {person.Name}");
    }

    public void RemovePerson(Person person)
    {   
        if (_persons.Contains(person))
        {
            _persons.Remove(person);
            Console.WriteLine($"Person removed: {person.Name}");
        }
        else
        {
            Console.WriteLine("Person not found in the library.");
        }

    }

    public void EditPerson(Person person)
    {
        Console.WriteLine($"Person edited: {person.Name}");
    } 
}


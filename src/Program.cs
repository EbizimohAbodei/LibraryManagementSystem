// See https://aka.ms/new-console-template for more information
using System;
using LibrarySystem;

class Program
{
    static void Main(string[] args)
    {
        Library library = new Library();

        Book book1 = new Comic("The Amazing Spider-Man", "Stan Lee", "978-1302920096", 1963, 230,  "Steve Ditko");
        Book book2 = new Novel("To Kill a Mockingbird", "Harper Lee", "978-0061120084", 1960, 150, "Classic");
        Book book3 = new TextBook("Introduction to Computer Science", "John Smith", "978-0123456789", 2021, 98);
        Book book4 = new ResearchPaper("Research Paper on Artificial Intelligence", "Jane Doe", "978-0987654321", 2022, 430);

        Person customer1 = new Customer("John Doe", 1);
        Person librarian1 = new Librarian("Emily Johnson", 2);

        library.AddBook(book1);
        library.AddBook(book2);
        library.AddBook(book3);
        library.AddBook(book4);

        Console.WriteLine("Library Contents:");
        library.PrintBooks();

        library.RemoveBook(book2);

        Console.WriteLine("Updated Library Contents:");
        library.PrintBooks();

        library.AddPerson(customer1);
        library.AddPerson(librarian1);

        library.PrintBooks();

        Customer customer = (Customer)customer1;
        customer.BorrowBook(book2);

        Librarian librarian = (Librarian)librarian1;
        librarian.RemoveBook(book1);

        Console.WriteLine("Updated Library Contents:");
        library.PrintBooks();

        // Create a TextBook instance
        TextBook textbook = new TextBook("Introduction to Computer Science", "John Smith", "978-0123456789", 2021, 530);

        // Print pages from 10 to 20
        textbook.PrintPages(11, 20);
        // Should return an error - page limit is 10
        textbook.PrintPages(5, 20);

    }
}
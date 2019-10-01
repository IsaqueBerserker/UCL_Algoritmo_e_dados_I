using System;
using System.Collections.Generic;
using System.Text;

namespace desafio_1
{
    class Book
    {
        public Book()
        {
            Bookcount = 15;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Bookcount { get; set; }

        public DateTime borrowDate;
        public DateTime returnDate;

        public enum Category
        {
            English,
            Math,
            Tech,
            Programation,
            Business
        }

        public void BookBorrow(Book book, Client client)
        {
            if (Bookcount > 0)
            {
                Console.WriteLine("Book Title:");
                book.Name = Console.ReadLine();
                Console.WriteLine("Book Id:");
                book.Id = int.Parse(Console.ReadLine());
                book.Bookcount -= 1;
                borrowDate = DateTime.Now;
                returnDate = DateTime.Now.AddDays(7);
                client.Books.Add(book);
                Console.WriteLine("Success");
            }
            else { Console.WriteLine("Sorry, but there is no book left!"); }
           
        }

        public void ReturnBook(Book book, Client client)
        {
            book.Bookcount += 1;
            Console.WriteLine("Success");
            client.Books.Remove(book);
        }

        }
}

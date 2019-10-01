using System;

namespace desafio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to UCL Library Manager \n");
            bool exit = true;
            while (exit)
            {
                Console.WriteLine("Client Name:");
                var name = Console.ReadLine();
                Console.WriteLine("Client Age:");
                var age = int.Parse(Console.ReadLine());
                Console.WriteLine("UCL Identification ID:");
                var identificationUCL = int.Parse(Console.ReadLine());

                Client cliente = new Client(name, age, identificationUCL);

                Console.WriteLine("\nMenu\n" +
                "1)Borrow book\n" +
                "2)Search my books\n" +
                "3)Return book\n" +
                "4)Close\n\n");
                Console.Write("Choose your option :");

                int option = int.Parse(Console.ReadLine());

                Book book = new Book();
                if (option == 1)
                {
                    book.BookBorrow(book , cliente);
                }
                else if (option == 2)
                {
                    book.ReturnBook(book,cliente);
                }
                else if (option == 3)
                {
                    cliente.ShowBook(cliente.Books);
                }
                else if (option == 4)
                {
                    Console.WriteLine("See you next time!");
                    exit = false;
                    break;
                }
            }
           
        }
        
    }
}

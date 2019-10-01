using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace desafio_1
{
    class Client
    {
        public Client(string name, int age, int id)
        {
            Nome = name;
            Age = age;
            Id = id;
        }

        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Nome { get; set; }

        [Required, Range(1, 100, ErrorMessage = "You Must have more than 10 Years old")]
        public int Age { get; set; }
        public virtual List<Book> Books { get; set; }
        public void ShowBook(List<Book> books)
        {
            foreach(var livro in books)
            {
                Console.WriteLine("Book Title: "+ livro.Name);
                Console.WriteLine("Return Day: " + livro.returnDate);
            }
        }
    }
}

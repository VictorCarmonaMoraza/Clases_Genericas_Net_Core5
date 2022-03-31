using System;

namespace Clase_Generica
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Books<Book>();
            book.Book = new Book
            {
                Id = 1,
                Titulo = "Pruebas C#"
            };
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{book.Book.Titulo} -----> {book.Book.Id}");
            Console.ReadKey();
        }
    }
}

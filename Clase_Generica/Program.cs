using System;

namespace Clase_Generica
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Books<Book>();
            book.Add(new Book
            {
                Id = 1,
                Titulo = "Pruebas C#"
            });
            book.Add(new Book
            {
                Id = 2,
                Titulo = "Net Core"
            });
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{book.Get(1).Titulo} -----> {book.Get(1).Id}");
            Console.ReadKey();
        }
    }
}

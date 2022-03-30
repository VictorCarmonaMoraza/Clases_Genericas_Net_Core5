using System;

namespace Clase_Generica
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Books<String>();
            book.Book = "Victor";
            var numero = new Books<int>();
            numero.Book = 202;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(book.Book);
            Console.WriteLine(numero.Book);
            Console.ReadKey();
        }
    }
}

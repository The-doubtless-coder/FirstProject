// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Immutable;

namespace FirstProject // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            Book booker = new Book("antepede", "good book", "mr IAN", 21, "Zarathustra");

            booker.Title = "Mynster, CALL ME";
          

        }
    }
}

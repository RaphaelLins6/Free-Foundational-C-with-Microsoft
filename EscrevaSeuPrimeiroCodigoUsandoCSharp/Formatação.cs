using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeFoundationalCSharpWithMicrosoft.EscrevaSeuPrimeiroCodigoUsandoCSharp
{
    public class Formatação
    {
        public static void Executar()
        {
            Console.WriteLine("===================================");
            Console.WriteLine("Olá\nWmundo!");
            Console.WriteLine("===================================");
            Console.WriteLine("Olá\tWmundo!");
            Console.WriteLine("===================================");
            Console.WriteLine("Olá \"mundo\"!");
            Console.WriteLine("===================================");
            Console.WriteLine("c:\\source\\repos");

            Console.WriteLine("===================================");
            Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ... \n");
            Console.WriteLine("Invoice: 1021\t\tComplete!");
            Console.WriteLine("Invoice: 1022\t\tComplete!");
            Console.WriteLine("\nOutput Directory:\t");

            Console.WriteLine("===================================");
            Console.WriteLine(@"    c:\source\repos    
            (this is where your code goes)");

            // Kon'nichiwa World
            Console.WriteLine("===================================");
            Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");

            Console.WriteLine("===================================");
            string firstName = "Bob";
            string message = "Hello " + firstName;
            Console.WriteLine(message);

            Console.WriteLine("===================================");
            string Name = "Bob";
            string greeting = "Hello";
            string menssagem = $"{greeting} {Name}!";
            Console.WriteLine(menssagem);

            Console.WriteLine("===================================");
            Console.WriteLine("Aperte enter para continuar...");
            Console.ReadLine();
        }
    }
}
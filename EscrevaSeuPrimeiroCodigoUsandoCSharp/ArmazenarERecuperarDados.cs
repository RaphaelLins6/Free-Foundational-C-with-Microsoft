using System;

namespace FreeFoundationalCSharpWithMicrosoft.EscrevaSeuPrimeiroCodigoUsandoCSharp
{
class ArmazenarERecuperarDados
{
    public static void Executar()
    {
        Console.WriteLine("Armazenar e Recuperar Dados");
        Console.WriteLine("===================================");
        Console.WriteLine("Digite seu nome: ");
        string? nome = Console.ReadLine();
        Console.WriteLine("Digite sua idade: ");
        var idade = Console.ReadLine();
        Console.WriteLine("===================================");
        Console.WriteLine($"Seu nome então é {nome} e sua idade é {idade} anos.");
        Console.WriteLine(true);
        Console.WriteLine("===================================");

        Console.WriteLine("Aperte enter para continuar...");
        Console.ReadLine();
    }
}
}
using System;
using System.Collections.Generic;

using FreeFoundationalCSharpWithMicrosoft.EscrevaSeuPrimeiroCodigoUsandoCSharp;

namespace FreeFoundationalCSharpWithMicrosoft {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {

                // Fundamentos
                {"Primeiro Código - Escreva seu primeiro código usando C#", PrimeiroCodigo.Executar},
                {"Armazenar e recuperar dados usando valores literais e variáveis em C# - Escreva seu primeiro código usando C#", ArmazenarERecuperarDados.Executar},
                {"Executar formatação de cadeia de caracteres básica em C# - Escreva seu primeiro código usando C#", Formatação.Executar},
                
            });

            central.SelecionarEExecutar();
        }
    }
}
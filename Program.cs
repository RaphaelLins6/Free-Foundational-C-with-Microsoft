using System;
using System.Collections.Generic;

using FreeFoundationalCSharpWithMicrosoft.EscrevaSeuPrimeiroCodigoUsandoCSharp;

namespace FreeFoundationalCSharpWithMicrosoft {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {

                // Fundamentos
                {"Primeiro Código - Escreva seu primeiro código usando C#", PrimeiroCodigo.Executar},
                
            });

            central.SelecionarEExecutar();
        }
    }
}
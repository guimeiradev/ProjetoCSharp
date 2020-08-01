using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle {
    class EstruturaDoWhile {
        public static void Executar() {
            string entrada;
            do {
                Console.WriteLine("Qual é seu nome ? ");
                entrada = Console.ReadLine();

                Console.WriteLine("Seja bem - vindo {0}", entrada);
                Console.WriteLine("Deseja continuar ? S/N");
                entrada = Console.ReadLine();
            } while (entrada.ToLower() == "s");
          
            Console.WriteLine("Até logo !");
        }

    }
}
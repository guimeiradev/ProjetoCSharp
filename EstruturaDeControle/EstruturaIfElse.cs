using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle {
    class EstruturaIfElse {
        public static void Executar() {
            Console.WriteLine("Digite uma nota: ");

            string entrada = Console.ReadLine();
            double.TryParse(entrada, out double nota);

            if (nota >= 7.0) {
                Console.WriteLine("Aprovado !");
                Console.WriteLine("Nao fez mais que sua obrigação kkk");


            } else {
             
                Console.WriteLine("recuperação !");
            }
        }
    }
}

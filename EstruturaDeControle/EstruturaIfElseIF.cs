using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace CursoCSharp.EstruturaDeControle {
    class EstruturaIfElseIF {
        public static void Executar() {
            Console.WriteLine(" Digite uma nota: ");

            string entrada = Console.ReadLine();
            double.TryParse(entrada, out double nota);

            if (nota >= 9.0) {
                Console.WriteLine("Quadro de honra ! ");
            
            }else if (nota >= 6.0) {

                Console.WriteLine("Esta na media");
            } else {
                Console.WriteLine(" Lixoso !");
            }
            Console.WriteLine("FIm !!");
        }
    }
}

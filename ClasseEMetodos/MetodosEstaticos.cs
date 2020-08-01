using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClasseEMetodos {
    class MetodosEstaticos {
        public class CalculadoraEstatica {
            
            // Metodo de instancia 
            public  int Somar(int a, int b) {
                return a + b;
            }
            // Metodo de classe ou metodo estatico
            public static int Multiplicar(int a, int b) {
                return a * b;
            }
        }
        public static void Executar() {
            var resultado = CalculadoraEstatica.Multiplicar(2, 2);
            Console.WriteLine("Resultado: {0}", resultado);

            CalculadoraEstatica calc = new CalculadoraEstatica ();
            Console.WriteLine(calc.Somar(2, 2));
        }
    }


}

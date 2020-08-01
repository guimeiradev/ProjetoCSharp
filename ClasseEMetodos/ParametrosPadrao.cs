using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClasseEMetodos {
    class ParametrosPadrao {
        public static int Somar(int a = 1, int b = 1) {
            return a + b;
        }
        public static void Executar() {
            Console.WriteLine(Somar(10,23));
            Console.WriteLine(Somar(10));
            Console.WriteLine(Somar());
            Console.WriteLine(Somar(b:7));
        }
    }
}

/* Nessa aula vimos que os metodos podem ter valores padroes sim e o interessante é que nao é preciso passar todos os parametros.
 * Colocando apenas um e outro nao ele ja assumi o valor padrao do outro.*/
// Unico metodo que nao permite valores padroes são o ref e o out
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes {

    // Funcoes de extenções
    public static class ExtensoesInteiro {
        public static int Soma (this int  num, int OutroNumero) {

            return num + OutroNumero;
        }
        public static double Subtracao(this double num, double OutroNumero) {
            return num - OutroNumero;
        }
    }
    class MetodosDeExtensao {

        public static void Executar() {
            int numero = 5;
            double numeroReal = 5.5;

            Console.WriteLine(numero.Soma(3));
            Console.WriteLine(numeroReal.Subtracao(10));

            Console.WriteLine(2.Soma(3));
            Console.WriteLine(2.5.Subtracao(4.7)); 

        }
    }
}

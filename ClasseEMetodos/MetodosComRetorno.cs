using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CursoCSharp.ClasseEMetodos {

    class CalculadoraComum {
        public int somar (int a, int b) {
            return a + b;
        }
        public int subtrair(int a , int b) {
            return a - b;
        }
        public int multiplicacao(int a , int b) {
            return a * b;
        }
        public int divisao(int a , int b) {
            return a / b;
        }
    }

    class CalculadoraCadeia {
        int memoria;
        
        public CalculadoraCadeia  Somar (int a) {
            memoria += a;
            return this;
        }
        public CalculadoraCadeia Multiplicar(int a) {
            memoria *= a;
            return this;
        }
        public CalculadoraCadeia Limpar() {
            memoria = 0;
            return this;
        }
        public CalculadoraCadeia Imprimir() {
            Console.WriteLine(memoria);
            return this;

        }
        public int Resultado () {
            return memoria;     
        }
    }
        
    class MetodosComRetorno {
        public static void Executar () {

            var calculadoraComum = new CalculadoraComum();

            Console.WriteLine(calculadoraComum.somar(4,4));
            Console.WriteLine(calculadoraComum.subtrair(8,4));
            Console.WriteLine(calculadoraComum.multiplicacao(2,4));
            Console.WriteLine(calculadoraComum.divisao(4,2));


            var CalculadoraCadeia = new CalculadoraCadeia();
     
            CalculadoraCadeia.Somar(3).Multiplicar(3).Imprimir().Limpar().Imprimir().Resultado();

             var resultado = CalculadoraCadeia.Somar(3).Multiplicar(2).Resultado();
            Console.WriteLine(resultado);
        }
    }
}

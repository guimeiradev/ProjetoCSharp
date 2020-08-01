using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Security;
using System.Text;

namespace CursoCSharp.OO {
    class Interface {
        interface OperacaoBinaria {
            int Operacao(int a, int b); // Os metodos dentro de uma interface sao por padrao publico e abstrato.
        }

        class Soma : OperacaoBinaria {
            public int Operacao(int a, int b) { // Nao é aceito outro nivel  de visibilidade a nao ser publico. 
                                               // E neste caso nao colocando o public , vai ser entendido como se fosse privado e ira dar erro;                    
                return a + b;
            }
        }
        class Calculadora {
            List<OperacaoBinaria> operacoes = new List<OperacaoBinaria> {
                new Soma (),
                new Subtracao(),
                new Multiplicacao()
            };
            public string ExecutarOperacoes(int a , int b) {
                string resultado = "";

                foreach (var op in operacoes) {
                    resultado += $"Usando {op.GetType().Name} = {op.Operacao(a,b)}\n";
                }
                return resultado;
            }
        }
        class Subtracao : OperacaoBinaria {
            public int Operacao(int a,int b) {
                return a - b;
            }
        }

        class Multiplicacao : OperacaoBinaria {
            public int Operacao(int a , int b) {
                return a * b;
            }
        }

        public static void Executar() {
            var calc = new Calculadora();
            var resultado = calc.ExecutarOperacoes(20, 5);
            Console.WriteLine(resultado);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes {
    class ExemploLambda {
        public static void Executar() {
            Action algoNoConsole = () =>
            { // A funcao action é uma funcao que nao tem retorno. È uma funcao void.
                Console.WriteLine("Lambda no c# ! ");
            };
            algoNoConsole();


            Func<int> jogarDaDo = () =>
            {
                Random random = new Random();
                return random.Next(1, 7);
            };
            Console.WriteLine(jogarDaDo());

            Func<int, string> conversorHex = numero => numero.ToString("x"); // Segunda forma de fazer !

            Console.WriteLine(conversorHex(1234));

            Func<int, int, int, string> formatarData = (dia, mes, ano) =>
               String.Format("{0:D2}/{1:D2}/{2:D2}", dia, mes, ano);

            Console.WriteLine(formatarData(1,1,2019 ));
        }   
    }
}

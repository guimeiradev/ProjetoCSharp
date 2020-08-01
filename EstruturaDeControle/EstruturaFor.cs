using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace CursoCSharp.EstruturaDeControle {
    class EstruturaFor {
        public static void Executar() {

            // Usando o WHILE  de forma determinada 
            //int i = 1;
            //while(i <=10) {
            //    Console.WriteLine($"o valor de i é {i}.");
            //    i++;

            //// Usando for de forma determinada
            //for (int i = 1; i <= 10;) {
            //    Console.WriteLine($"O valor de i é {i}.");

            double somatorio = 0;
            string entrada;

            Console.WriteLine("Informe o tamanho da turma");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out int tamanhoDaTurma);

            for (int i = 1; i <= tamanhoDaTurma; i++) {
                Console.Write("Informe a nota do aluno {0}: ");
                entrada = Console.ReadLine();
                double.TryParse(entrada, out double notaAtual);

                somatorio += notaAtual;

            }
            double media = tamanhoDaTurma > 0 ? somatorio / tamanhoDaTurma : 0;
            Console.WriteLine("Media da turma: {0}", media);

        }

    }
}



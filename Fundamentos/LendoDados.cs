using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class LendoDados {
        public static void Executar() {
            Console.WriteLine("Qual é seu nome ?"); 
            string nome = Console.ReadLine();

            Console.WriteLine(" Qual é sua idade ?");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual é seu salario ?");
            double salario = double.Parse(Console.ReadLine());
        }
    }
}

// " Resumo da aula " 

// Usamos a funcao a console.Redline para imprimir alguns resultados no console 

// Tambem foi visto como o parse que permite voce imprimir resultados de outros tipos no console. Por que afinal de contas  o console redline imprimi so dados do tipo string
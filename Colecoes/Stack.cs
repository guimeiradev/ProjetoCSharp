
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CursoCSharp.Colecoes {
    class Stack {
        public static void Executar() {
            Stack<string> numeros = new Stack<string>();

            numeros.Push("Um"); // Vimos neste exemplo que o push é responsavel por add os elementos .
            numeros.Push("dois");
            numeros.Push("Tres");
            numeros.Push("Quatro");
            numeros.Push("Cinco");

            foreach(var numero in numeros) {
                Console.WriteLine($"{numeros}");
            }

            Console.WriteLine($"\nPop: {numeros.Pop()}"); // E vimos que o Pop é responsavel por remover.

            foreach(var numero in numeros) {

                Console.WriteLine($"{numeros}");
            }
            Console.WriteLine($"\nPeek {numeros.Peek()}");
            Console.WriteLine(numeros.Count);
        }
    }
}

// Obs : Neste exemplo o primeiro a entrar é o ultimo a sair .
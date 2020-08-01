using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes {
    class Queue {

        public static void Executar() {

            var fila = new Queue<string>();

            fila.Enqueue("Fulano"); // O enqueue infilera 
            fila.Enqueue("Sicrano");
            fila.Enqueue("Beltrano");
            fila.Enqueue("Beltrano"); // A fila aceita repetições 

            Console.WriteLine(fila.Peek()); // O peek pega um item da lista sem  remover
            Console.WriteLine(fila.Count); // Conta quantos itens tem 

            Console.WriteLine(fila.Dequeue()); // O dequeue desinfilera  
            Console.WriteLine(fila.Count);

            foreach (var pessoa in fila) {
                Console.WriteLine(pessoa);
            }
          


        }
    }
}

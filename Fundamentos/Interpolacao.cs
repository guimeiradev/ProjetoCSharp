using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class Interpolacao {
     public static void Executar() {
            string nome = "Notebook Gamer";
            string marca = "Dell";
            double preco = 5800.90;

            Console.WriteLine("O " + nome + "da marca" + " "+ marca + " "+  "custa" +  "R$" + preco + ".");

            Console.WriteLine("O {0} da marca {1} custa {2}.", nome,marca,preco);
            Console.WriteLine($"A maarca {marca} é legal ! ");
            Console.WriteLine($"1 + 1 =  {1 + 1 } ! ");

            // Foi dado alguns exemplos de interpolacao
         
        }
    }
}

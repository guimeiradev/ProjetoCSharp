using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class Conversoes {

        public static void Executar() {
            int inteiro = 10;
            double quebrado = inteiro; // Foi visto nesse exemplo conversao implicita. Qunado nao a perigo de perder informacoes
            Console.WriteLine(quebrado);

            double nota = 9.7;
            int notaTruncada = (int)nota; // Fizemos uma conversao numerica explicita , usando cast .
            Console.WriteLine("Nota truncada: {0}", notaTruncada);

            Console.WriteLine("Digite sua idade : ");
            string idadeString = Console.ReadLine(); // E aqui foi visto uma conversao entre string e inteiro , usando int. parse
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine("Idade inserida: {0}", idadeInteiro);

            idadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine("Resultado: {0}", idadeInteiro);


            Console.WriteLine("Digite um numero");
            string palavra = Console.ReadLine();
            int numero;                           // E aqui foi visto uma conversao usando entre string e int tambem , so que usando try.parse
            int.TryParse(palavra, out numero);
            Console.WriteLine("Resultado: {0}", numero);

            Console.Write("Digite o segundo numero: ");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine("Resultado 2: {0}",numero2);
        }
    }
}

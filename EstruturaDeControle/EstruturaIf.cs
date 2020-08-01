using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle {
    class EstruturaIf {
        public static void Executar() {

            bool bomComportamento = false;
            string entrada;

            Console.WriteLine("Digite uma nota: ");
            entrada = Console.ReadLine();
            double.TryParse(entrada, out double nota);

            Console.WriteLine(" Possui um bom comportamento (S/N): ");
            entrada = Console.ReadLine();

            // if (entrada == "S" || entrada == "s") ; -- Primeira forma de se fazer 
            // bomComportamento = true;

            // bomComportamento = entrada == "S" || entrada == "s"; -- Segunda forma

            bomComportamento = entrada.ToLower() == "s"; // Terceira mais simplificado usando o toLower que transforma a letra se tiver minuscula pra maiuscula e vice versa.

            //if (nota >= 9 && bomComportamento) ; { // Percebe-se que colocamos um ponto e virgula antes de imprimir... Isso causa um bug que pode estragar o programa . 
            //    Console.WriteLine("Quadro de honra!");
           
            if (nota >= 9 && bomComportamento) {
                Console.WriteLine("Quadro de honra!");
            }

        }
    }
}

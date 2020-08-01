using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class FormatandoNome {
        public static void Executar () {

            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1")); // F1 vai passar uma unica casa decimal para o numero
            Console.WriteLine(valor.ToString("C")); // C vai passar o valor da moeda de acordo com idioma que esta usando na maquina , no meu caso vai ser R$ pois minha maquina esta em pt-br
            Console.WriteLine(valor.ToString("P")); // P vai passar o percentual do numero
            Console.WriteLine(valor.ToString("#.##")); // #.## Vai passar quantas casas decimais voce quer depois da virgula tamebem

            CultureInfo cultura = new CultureInfo("pt-br");

            Console.WriteLine(valor.ToString("C0",cultura));

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10")); // Aqui usamos usamos uma funcao para acrescentar numero na direita
        }
    }
}

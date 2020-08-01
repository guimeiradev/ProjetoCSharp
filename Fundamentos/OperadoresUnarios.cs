using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class OperadoresUnarios {
        public static void Executar() {
            var valorNegativo = -1;
            var numero1 = 2;
            var numero2 = 3;
            var booleano = true;

            Console.WriteLine(-valorNegativo); // Vai alterar o valor para positivo
            Console.WriteLine(!booleano); // Vai alterar o valor para false

            numero1++;
            Console.WriteLine(numero1); // Vai somar mais uma numero

            --numero1;
            Console.WriteLine(numero1); // Vai subtrair um numero

            Console.WriteLine(numero1++ == --numero2); // Aqui o numero2 vai ser subtraido primeiro 
            Console.WriteLine($"{numero1} {numero2}");
        }
    }
}

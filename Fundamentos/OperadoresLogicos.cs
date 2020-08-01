using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class OperadoresLogicos {
        public static void Executar() {
            var executouTrabalho1 = true;
            var executouTrabalho2 = false;

            bool comprouTv50 = executouTrabalho1 && executouTrabalho2;
            Console.WriteLine("Comprou Tv 50? {0}", comprouTv50);

            var comprouTv32 = executouTrabalho1 ^ executouTrabalho2;
            Console.WriteLine("comprou tv 32 ? {0}", comprouTv32);

            var comprouSorvete = executouTrabalho1 || executouTrabalho2; ;
            Console.WriteLine("comprou sorvete ? {0}", comprouSorvete);

            Console.WriteLine("Mais saudavel ? {0}", !comprouSorvete);


        }
    }
}


// Vimos que operadores binarios opera em dois operandos , como visto no exemplo acima.

// E operadores unarios opera em um operando só;
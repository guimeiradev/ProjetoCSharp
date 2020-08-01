using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class Inferencia {
        public static void Executar() {

            var nome = "guilherme";
            //nome = 123 (O c# nao vai reatribuir o valor pois é uma inferencia 
            Console.WriteLine(nome);

            var idade = 20;

            int a;
            a = 21; // Ja com o tipo inte é diferente . Voce pode reatribuir o valor apos ter declarado

            int b = 2;

            Console.WriteLine(a + b);
            
        }
    }
}

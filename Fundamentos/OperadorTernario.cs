using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class OperadorTernario {
        public static void Executar() {
            var nota = 7.0;
            bool bomComportamneto = true;
            string resultado = nota <= 7 && bomComportamneto ? "Aprovado" : "Reprovado";
            Console.WriteLine(resultado);
        }
    }
}

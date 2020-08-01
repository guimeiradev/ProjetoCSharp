using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClasseEMetodos {
    class ParametrosNomeados {

        public static void Formatar(int dia , int mes , int ano) {
            Console.WriteLine("{0:D2}/{1:D2}/{2}",dia,mes,ano);

        }
        public static void Executar() {
            Formatar(dia: 12, mes: 08, ano: 1999);
        }
    }
}

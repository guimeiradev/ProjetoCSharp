using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClasseEMetodos {
    public struct Sponto {
        public int x;
        public int y;
    }

    public class Cponto {
        public int x;
        public int y;
    }


    class StructVsClasse {

        public static void Executar() {

            Sponto ponto1 = new Sponto { x = 1, y = 2 };
            Sponto copiaPonto1 = ponto1;
            ponto1.x = 3;

            Console.WriteLine("Ponto 1 = {0}", ponto1.x);
            Console.WriteLine("CopiaPonto1 = {0}", copiaPonto1.x); // Atrinuicao por VALOR !!

            Cponto ponto2 = new Cponto { x = 2, y = 4 };
            Cponto copiaPonto2 = ponto2;

            Console.WriteLine("ponto2 = {0}", ponto2.x); // Atribuicao por REFERENCIA !!
            Console.WriteLine("CopiaPonto2 = {0}",copiaPonto2.x);
        }
    }
}

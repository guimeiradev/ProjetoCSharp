
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace CursoCSharp.ClasseEMetodos {
    class DesafioAtributo {
        // Primeira Fomra de imprimir o valor dez fora da classe do desafio é colocando o static  
        // static  int a = 10;
        int a = 10;
        public static void Executar() {

        // Segunda forma de colocar de imprimir o valor é criando uma instancia

            DesafioAtributo desafio = new DesafioAtributo();
            Console.WriteLine(desafio.a);


        }
    }
}

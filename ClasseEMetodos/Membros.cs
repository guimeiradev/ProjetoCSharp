using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClasseEMetodos {
    class Membros {
        public static void Executar() {
            Pesssoa sicrano = new Pesssoa();
            sicrano.Nome = "Renato";
            sicrano.Idade = 21;


            //Aqui foi criado dois objeto onde o tipo deles é pessoa. 
            // Logo apos de criar o objeto , criamos dois objetos idade e nome
            
           Console.WriteLine($"{sicrano.Nome} tem {sicrano.Idade} anos.");

            sicrano.ApresentarNoConsole();
            sicrano.zerar();
            sicrano.ApresentarNoConsole();

            var fulano = new Pesssoa();
            fulano.Nome = "beto";
            fulano.Idade = 22;

            var apresentacaoDoFulano = fulano.Apresentar();

        }
    }
}

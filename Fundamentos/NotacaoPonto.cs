using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class NotacaoPonto {
        public static void Executar() {
            var saudacao = "ola".ToUpper().Insert(3, " word ! ").Replace(" word !", " munndo !");
            Console.WriteLine(saudacao);

            Console.WriteLine("teste".Length);

            string valorImportante = null;
            Console.WriteLine(valorImportante.Length); // Ira ocorrer um erro quando for executar pois o valor esta nulo e c# nao permite.
            Console.WriteLine(valorImportante?.Length); // O interrogacao muda tudo , so executa quando o valor estiver ok . Caso contrario ele nao mostra nada no console. (Isso é chamado de valor seguro)


        }
    }
}

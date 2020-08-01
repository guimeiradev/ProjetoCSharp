using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace CursoCSharp.Colecoes {
 
    class ColecoesSet {
        public static void Executar() {

            var livro = new Produto("Game of Thrones", 49.9);

            var carrinho = new HashSet<Produto>();
            carrinho.Add(livro);

            var combo = new HashSet<Produto> {
                new Produto("Camisa", 50.90),
                new Produto("Calça",65.80),
                new Produto("Poster", 10.0),
                new Produto("Poster", 10.0),
                new Produto(" 5 Temporada Pink Bliders", 150.90)

            };

            carrinho.UnionWith(combo);
            Console.WriteLine(carrinho.Count);
           // carrinho.RemoveAt(3);

            foreach (var item in carrinho) {

                //Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($"{item.Nome} {item.Preco}");

            }
            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);                
           // Console.WriteLine(carrinho.LastIndexOf(livro));
        }
    }
}


// O set é uma estrutura nao indexada . OU seja , nao tem como Add ou remover algo com indice.
// O set não aceita repetições 

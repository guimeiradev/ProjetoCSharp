using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CursoCSharp.Colecoes {
    public class Produto {
        public string Nome;
        public double Preco;
        public Produto(string nome, double preco) {

            Nome = nome;
            Preco = preco;
        }

        public override bool Equals(object obj) {
            return obj is Produto produto &&
                   Nome == produto.Nome &&
                   Preco == produto.Preco;
        }

        public override int GetHashCode() {
            return HashCode.Combine(Nome, Preco);
        }

        //public override bool Equals(object obj) {
        //    Produto outroProduto = (Produto)obj;
        //    bool mesmoNome = Nome == outroProduto.Nome;
        //    bool mesmoPreco = Preco == outroProduto.Preco;
        //    return mesmoNome && mesmoPreco;
        //}
        //public override int GetHashCode() {
        //    return Nome.Length;
        //}

    }



    class ColecoesList {
        public static void Executar() {

            var livro = new Produto("Game of Thrones", 49.9);

            var carrinho = new List<Produto>();
            carrinho.Add(livro);

            var combo = new List<Produto> {
                new Produto("Camisa", 50.90),
                new Produto("Calça",65.80),
                new Produto("Poster", 10.0),
                new Produto(" 5 Temporada Pink Bliders", 150.90)

            };

            carrinho.AddRange(combo);
            Console.WriteLine(carrinho.Count);
            carrinho.RemoveAt(3);

            foreach (var item in carrinho) {

                Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($"{item.Nome} {item.Preco}");

            }
            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);              // Tarefa de casa : Explorar os outros metodos disponiveis no carrinho.
            Console.WriteLine(carrinho.LastIndexOf(livro));
        }
    }
}


/* Foi visto nessa aula que a Lis é uma estrutura dinamina, ou seja cresce dinamicamente a partir do momento que vai colocando 
   novos elementos.
*  A list é uma estrutura homegenia , usamos uma lista de produtos.
*  A list aceita repetições 
*  A list é uma estrutura indexada */
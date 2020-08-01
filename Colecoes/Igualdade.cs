
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CursoCSharp.Colecoes {
    class Igualdade {
        public static void Executar() {
            var p1 = new Produto("Caneta1", 1.89);
            var p2 = new Produto("Caneta1", 1.89);
            var p3 = p2; // Neste caso vai ser igual pois sabemos que essa é uma atribuição por referencia.

            Console.WriteLine(p1 == p2);
                                         // Neste dois exemplos vimos que a comparação é feita por endereço de memoria.
            Console.WriteLine(p3 == p2);

            Console.WriteLine(p1.Equals(p2)); // O metodo Equals faz exatamente a mesma coisa . Compara o endereço de memoria.


            // Usando esse metodo de implemento Equals . Voce consegue fazer que a comparação nao seja por endereço de memoria.

            //public override bool Equals(object obj) {
            //    Produto outroProduto = (Produto)obj;
            //    bool mesmoNome = Nome == outroProduto.Nome;
            //    bool mesmoPreco = Preco == outroProduto.Preco;
            //    return mesmoNome && mesmoPreco;
            //}

            // O metodo Hash é um metodo que é usado junto com Equals . A funcao dele é nao permitir que tenha elementos iguais ao outro 

            //public override int GetHashCode() {
            //    return Nome.Length;
            //}

        }
    }
}

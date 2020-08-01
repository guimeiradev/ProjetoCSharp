using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClasseEMetodos {
    class Readonly {
        public class Cliente {
            public string Nome;
           public readonly DateTime Nascimento;

            public Cliente(string nome , DateTime nascimento) {
                Nascimento = nascimento;
                Nome = nome;
                Nascimento = new DateTime(2020, 12, 12); // O readOnly so permite alterações dentro da mesma classe.
            }

            public string GetDateNascimento () {
                return String.Format("{0}/{1}/{2}", Nascimento.Day, Nascimento.Month, Nascimento.Year);
            }
        }
        public static void Executar() {

            var novoCliente = new Cliente("Guilherme", new DateTime(1999 , 08 , 12));


            Console.WriteLine(novoCliente.Nome);
            Console.WriteLine(novoCliente.GetDateNascimento());

            //novoCliente.Nascimento = new DateTime(2020, 12, 12); Não é possivel alterar fora devico a proteção do ReadOnly

                      
        }
    }
}

/* ReadOnly :
 * A palavra-chave readonly é um modificador que você pode usar em campos.
Quando uma declaração de campo inclui um modificador readonly, 
as atribuições para os campos introduzidos pela declaração só podem ocorrer como parte da declaração 
ou em um construtor da mesma classe.*/

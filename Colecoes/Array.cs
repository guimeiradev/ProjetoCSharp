using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes {
    class ExemploArray {
     public static void Executar() {
            // Array de String
            string[] alunos = new string[5];
            alunos[0] = "Gui";
            alunos[1] = "Pedro";
            alunos[2] = "Bia";
            alunos[3] = "Joao";
            alunos[4] = "Maicon";

            foreach(var aluno in alunos) {
                Console.WriteLine(aluno);
            }

            // Array Somatorio de notas 

            double somatorio = 0;

            double[] notas = { 9.7, 8.6, 5.5, 7.8, 10.0 };

            foreach(var nota in notas) {
                somatorio += nota;
            }
            
            // Uma Segunda forma de percorrer uma array

            //for (int i = 0; i < notas[i]; i++) {
            //    somatorio += notas[i];
            //}

            double media = somatorio / notas.Length;
            Console.WriteLine(media);

            // Array de Letras
            char[] letras = { 'a', 'r', 'r', 'a', 'y' };


            // Chamando o array pela uma string
            string palavras = new string(letras);

            Console.WriteLine(palavras);

            /* O array é uma esrutura homegenia . Ou seja , uma vez que voce armazena tipos string 
              dentro do array só podera ter tipos string. Não é possivel misturar string com int e vice versa.

            * Uma outra caracterisca bem importante no array é que o array é uma estrutura statica. Ela não cresce
              a partir do momento que voce vai acrescentando novos elementos dentro dela */




        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace CursoCSharp.EstruturaDeControle {
    class EstruturaForeach {
        public static void Executar() {
            var palavra = "opa !";

            foreach (var letra in palavra){
                Console.WriteLine(letra);
            }
            var alunos = new string[] { "ana", "bia", "Carlos" };

            foreach( string aluno in alunos) {
                Console.WriteLine(aluno);
            }
            
        }
    }
}

// Vimos que o foreach percorre cada elemento do primeiro ao ultimo passando por todos elementos.
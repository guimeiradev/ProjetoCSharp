using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClasseEMetodos {
    class ExemploEnum {
        public enum Genero {Acao, Aventura, Terror,Animacao,Comedia};
        
        public class Filme {
            public string Titulo;
            public Genero GeneroDoFilme;
        }
        public static void Executar() {

            int id = (int)Genero.Animacao;
            Console.WriteLine(id);

            var FilmesParaFamilia = new Filme();
            FilmesParaFamilia.Titulo = "Meu malvado Favorito";
            FilmesParaFamilia.GeneroDoFilme = Genero.Animacao;

            Console.WriteLine("{0} e {1} !", FilmesParaFamilia.Titulo ,FilmesParaFamilia.GeneroDoFilme); 

        }
    }
}

// VImos um pouco sobre o ENUM. Ele é usado para atribuir nomes  constantes a um grupo de valores inteiros ou numericos. 
// Tornando os valores constates mais legiveis
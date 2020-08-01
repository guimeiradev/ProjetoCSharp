using System;
using System.Security.Cryptography.X509Certificates;
using Encapsulamento;

namespace CursoCSharp.OO {
    public class FilhoNaoReconhecido : SubCelebridade {
        public new void MeusAcessos() {
            Console.WriteLine("FilhoNaoReconhecido...");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDosOlhos);
            //Console.WriteLine(NumeroDoCelular);
            Console.WriteLine(JeitoDeFalar);
            // Console.WriteLine(SegredoDeFamilia);
            // Console.WriteLine(UsaMuitoPhotoshop);



        }
    }

    public class AmigoDistante {
        public readonly SubCelebridade amiga = new SubCelebridade();

        public void MeuAcessos() {
            Console.WriteLine("AmigoDistante...");

            Console.WriteLine(amiga.InfoPublica);
            //Console.WriteLine(amiga.CorDosOlhos);
            //Console.WriteLine(NumeroDoCelular);
            //Console.WriteLine(amiga.JitoDeFalar);
            //Console.WriteLine(amiga.SegredoDeFamila);
            //Console.WriteLine(amiga.UsaMuitoPhotoshop);
        }
    }

    class Encapsulamento {

        public static void Executar() {

            SubCelebridade sub = new SubCelebridade();
            sub.MeusAcessos();

            new FilhoReconhecido().MeusAcessos();
            new AmigoProximo().MeusAcessos();

            new FilhoNaoReconhecido().MeusAcessos();
            new AmigoDistante().MeuAcessos();

        }
    }
}

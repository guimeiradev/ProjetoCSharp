using System;
using System.Collections.Generic;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CursoCSharp.ClasseEMetodos {

    // Obs: Por padrao os metodos de uma interface é publico.
    interface Ponto {
        void MoverNaDiagonal(int delta);

    }
    struct Coordenada: Ponto {
        public int X;
        public int Y;

        public Coordenada(int x, int y) {
            X = x;
            Y = y;
        }
        public void MoverNaDiagonal(int delta) {
            X += delta;
            Y +=  delta; 
        }
        
    }
    class ExemploStruct {
        public static void Executar () {
            Coordenada coordenadaInicial;
            coordenadaInicial.X = 2;
            coordenadaInicial.Y = 2;

            Console.WriteLine("Coordenada Inicial");
            Console.WriteLine("X = {0}", coordenadaInicial.X);
            Console.WriteLine("Y = {0}", coordenadaInicial.Y);

            var coordenadaFinal = new Coordenada(x: 9, y: 1);
            coordenadaFinal.MoverNaDiagonal(10);

            Console.WriteLine("Coordenada Final"    );
            Console.WriteLine("X = {0}",coordenadaFinal.X);
            Console.WriteLine("Y = {0}",coordenadaFinal.Y);

        }
    }
}

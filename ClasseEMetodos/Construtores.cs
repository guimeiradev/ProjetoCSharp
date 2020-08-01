using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClasseEMetodos {
  
    class Carro {
        public String Modelo;
        public String Fabricante;
        public int Ano; 


        public Carro(string modelo , string fabricante, int ano) {
            Modelo = modelo;
            Fabricante = fabricante;
            Ano = ano;
        }
        public Carro () {

        }
    }
    
    
    class Construtores { 
        public static void Executar() {

            var carro1 = new Carro();
            carro1.Modelo = "BMW";
            carro1.Fabricante = "325i";
            carro1.Ano = 2020;

            Console.WriteLine($"{carro1.Modelo} {carro1.Fabricante} {carro1.Ano}");

            var carro2 = new Carro("ford","ka", 2019);
            Console.WriteLine($"{carro2.Fabricante} { carro2.Modelo} { carro2.Ano}");


            var carro3 = new Carro() {
                Fabricante = "Fiat",
                Modelo = "Punto",
                Ano = 2020,
            };
            Console.WriteLine($"{carro3.Fabricante} {carro3.Modelo} {carro3.Ano}");
        }
    }
}

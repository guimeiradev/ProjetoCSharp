using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace CursoCSharp.OO {

    public class Carro {
        protected readonly int VelocidadeMaxima; /* Foi usado o Protected pois a velocidade maxima vai ser herdada em outras clases . E o readonly
                                                    para ninguem conseguir mexer na  velocidade Maxima. */
        int VelocidadeAtual; // Aqui foi colocado privado para nao acontecer de alguem colocar velocidade absurdas 

        public Carro(int velocidadeMaxima) { // Metodo construção criado para obrigatoriamente voce ter que informar velocidade
            VelocidadeMaxima = velocidadeMaxima;
        }                                           // E esse tambem é um construtor base que é chamado logo ali abaixo

        protected int AlterarVelocidade(int delta) {
            int novaVelociade = VelocidadeAtual + delta;

            if (VelocidadeAtual < 0) {
                VelocidadeAtual = 0;
            } else if (novaVelociade > VelocidadeMaxima) {
                VelocidadeAtual = VelocidadeMaxima;
            } else {
                VelocidadeAtual = novaVelociade;
            }
            return VelocidadeAtual;
        }
        
        // O virtual é a palavra que da o avara para usar o override, se  voce nao colocar ira dar erro quando foi subscrever.

        public virtual int Acelerar() {
            return AlterarVelocidade(5);
        }
                                            // Foi passado dois metodos aqui : Um para acelerar e outro para frear
        public int Frear() {
            return AlterarVelocidade(-5);

        }
    }
    public class Uno : Carro {
        public Uno() : base(200) { // Chamando construtor base.

        }       // Implmentando Uno e Ferrari  herdada de Carro. Automaticamente o uno vai receber alguns metodos como frear , acelerar e alterar velocidade
    }
    public class Ferrari : Carro {
        public Ferrari() : base(350) {

        }

        // Usando a palavrinha override voce ira conseguir sobrescrever uma funcao que foi feita acima.
        public override int Acelerar() {
            return AlterarVelocidade(15);
        }
         // Alterar velocidade ocultando o metodo da classe pai     
         public new int Frear () {
         return AlterarVelocidade(-15);
        }
    }

    class Heranca {
        public static void Exeuctar() {

            Console.WriteLine("Uno ...");
            Uno carro1 = new Uno();
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());

            Console.WriteLine("Ferrari...");

            Ferrari carro2 = new Ferrari();
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Frear());

            Console.WriteLine("Ferrari com o tipo carro...");
            Carro carro3 = new Ferrari(); // Polimorfismo
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());

            Console.WriteLine("Uno com o tipo carro...");
            carro3 = new Uno();
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());

        }
    }
}


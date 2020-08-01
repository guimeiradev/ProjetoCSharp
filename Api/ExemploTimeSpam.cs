
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Api {
    class ExemploTimeSpam {
        public static void Executar() {
            var intervalo = new TimeSpan(days: 10, hours: 20, minutes: 30, seconds: 40);
            Console.WriteLine(intervalo);

            Console.WriteLine("Minutos: " + intervalo.Minutes);
            Console.WriteLine("Intervalo em Minutos: " + intervalo.TotalMinutes);

            var largada = DateTime.Now;
            var Chegada = DateTime.Now.AddMinutes(15);

            var tempo = Chegada - largada;

            Console.WriteLine("Duração : " + tempo);

            Console.WriteLine(intervalo.Add(TimeSpan.FromMinutes(8))); // Foi acrescentado 8 minutos 
            Console.WriteLine(intervalo.Subtract(TimeSpan.FromMinutes(8))); // Foi tirado 8 minutos

            Console.WriteLine("Tostring 1: " + intervalo.ToString("g")) ; // Mostra o dia e ahora padrao 
            Console.WriteLine("Tostring 2: " + intervalo.ToString("G")) ; // Mostra os milisegundos junto com o dia e o tempo padrao
            Console.WriteLine("Tostring 3: " + intervalo.ToString("c")) ; // Separa o dia e a hora com "."

            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03").TotalMilliseconds); // Junto tudo e deu o total em milisegundos
        }
    }
}

/* Foi visto nessa aula que é possivel gerar um intervalo de tempo (TimeSpan)
 * Vimos que como criar uma funcao a partir do FromMinutes. Foi feito add minutos e subtrair
 * Vimos que a diferença de dois DateTime fazendo subtração ,gera um intervalo de tempo
 * Vimos que o TimeSpan é muito importante para manipular datas assim como DateTime */
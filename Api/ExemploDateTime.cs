using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Api {
    class ExemploDateTime {
        public static void Executar () {
            var datetime = new DateTime(year: 2030,month: 2, day: 6);

            Console.WriteLine(datetime.Day);
            Console.WriteLine(datetime.Month);
            Console.WriteLine(datetime.Year);

            // Sem horas 

            var hoje = DateTime.Today;
            Console.WriteLine(hoje);

            // Com horas
            var diaAtual = DateTime.Now;
            Console.WriteLine(diaAtual);
            Console.WriteLine("Horas: " + diaAtual.Hour); // Mostrar apenas as horas
            Console.WriteLine("Minutos: " + diaAtual.Minute); // Mostrar os minutos

            var amanha = diaAtual.AddDays(1);
            Console.WriteLine(amanha);

            var ontem = diaAtual.AddDays(-1); // Menos um dia (Como se fosse ontem)
            Console.WriteLine(ontem);


            Console.WriteLine(diaAtual.ToString("dd"));    // Vai pegar apenas o dia.
            Console.WriteLine(diaAtual.ToString("d"));    // Vai mostrar apenas o dia atual 
            Console.WriteLine(diaAtual.ToString("D"));   // Vai mostrar o dia mais descritivo 
            Console.WriteLine(diaAtual.ToString("g"));  // Vai passar o dia atual com a hora 
            Console.WriteLine(diaAtual.ToString("G")); // Vai passar o dia atual com a hora porem com segundos
            Console.WriteLine(diaAtual.ToString("dd-mm-yyy HH:mm")); 
            
        }
    }
}

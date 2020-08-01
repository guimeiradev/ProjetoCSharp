using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class VariaveisEConstantes {
        public static void Executar() {
            // Ex1
            double raio = 4.5;
            // Ex2
            const double pi = 3.14;

            raio = 5.5; // Neste exemplo vimos que conseguimos alterar o valor do raio . 

            // pi = 6.5 (Neste exemplo vimos que nao é possiviel reatribuir valor para uma constante

            double area = pi * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Area é " + area); // Aqui concatenamos o valor da area coma string "Area é "
            Console.WriteLine("Area é " + (area + 1000)); // Neste exemplo concatenamos o " area é " e somamos o resultado da area com 1000

            // Tipos internos 

            bool estaChovendo = true; // true ou false 
            Console.WriteLine("Esta chovendo" + estaChovendo);

            byte IDADE = 45;
            Console.WriteLine("iDADE" + IDADE);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de Gols" + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("salario" + salario);

            int menorValorInt = int.MinValue; // Mais usado dos inteiros !
            Console.WriteLine("Mneor int" + menorValorInt);

            uint populacaoBrasileira = 207_6_00_000;
            Console.WriteLine(populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor long" + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("populacao mundial é " + populacaoMundial);

            // Valores Reais 

            float precoComputador = 1299.99f;
            Console.WriteLine(" Preco computador " + precoComputador);

            double valorDeMercadoDaApple = 10000000000.00; // Mais usado no mundo dos reais !
            Console.WriteLine("valor de apple " + valorDeMercadoDaApple);

            decimal distanciaEntreAsEstrelas = decimal.MaxValue;
            Console.WriteLine("distancia entre estrelas" + distanciaEntreAsEstrelas);

            // 1 caracter

            char letra = 'g';
            Console.WriteLine(letra);

            // texto
            string texto = ("Meu nome é guilherme ");
            Console.WriteLine(texto);


        }
    }
}

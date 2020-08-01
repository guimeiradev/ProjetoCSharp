using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CursoCSharp.Colecoes {
    class Dictionary {
        public static void Executar() {
            
           // Obs: No caso do dicionario ele vai aceitar repetição no valor , mas nao vai aceitar repetição na chave. 
           
            var Filmes = new Dictionary<int, string>();

            Filmes.Add(2000, "Gladiador");
            Filmes.Add(2002, "Homem - Aranha");
            Filmes.Add(2004, "Os Incriveis");
            Filmes.Add(2006, "O gtande truque");

            if(Filmes.ContainsKey(2004)) {
                Console.WriteLine("2004: " + Filmes[2004]);
                Console.WriteLine("2004: " + Filmes.GetValueOrDefault(2004)); // Segunda forma de pega o valor da chave

                Console.WriteLine(Filmes.ContainsValue("Amnésia")); // Verficando se tem determinado valor.

                Console.WriteLine($"Removeu? {Filmes.Remove(2004)}"); // Metodo para remover item

                Filmes.TryGetValue(2006, out string filme2006); // Um outra forma de pegar o valor.
                Console.WriteLine($"Filme {filme2006} !"); // Caso nao ache determinado item vai ser retornado um valor vazio

                // Formas de percorrer um dicionario :

                foreach(var chave in Filmes.Keys) { // Vai imprimir todas as chaves (anos) , exceto a chave 2004, que foi removida no exemplo acima.
                    Console.WriteLine(chave);  

                    foreach(var valor in Filmes.Values) { // Vai imprimir todos os valores (Nomes dos filmes)
                        Console.WriteLine(valor);
                    }
                    foreach(KeyValuePair<int,string> filme in Filmes) { // Vai imprimir os nomes e os anos 
                        Console.WriteLine($"{filme.Value} é de {filme.Key}");
                    }
                    foreach(var filme in Filmes) { // Nesta forma não colocamos o KeyValue pois o c# ja coloca por padrao.
                        Console.WriteLine($"{filme.Value} é de {filme.Key}.");
                    }
                }



            }

        }
    }
}

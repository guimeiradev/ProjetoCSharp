using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CursoCSharp.Api {
    class LendoAquivos {
        public static void Executar() {
          var path = @"G:/lendo_arquivos.txt";

            if (!File.Exists(path)) {
                using (StreamWriter sw = File.AppendText(path)) {
                    sw.WriteLine("Produto;Preço;Qtde");     // Aqui foi criado  uma condicional que se o arquivo nao existir , ele sera criado.
                    sw.WriteLine("Caneta Bic Preta;3.59; 89");
                    sw.WriteLine("Borracha Branca; 2.89;27");

                }
            }
            try {
                using (StreamReader sr = new StreamReader(path)) { // Lendo arquivo 
                    var texto = sr.ReadToEnd();
                    Console.WriteLine(texto);  // E aqui foi criado um try que vai ler o arquivo caso nao exite , vai cair no cath com a mensagem que nao exite o arquivo
                }
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
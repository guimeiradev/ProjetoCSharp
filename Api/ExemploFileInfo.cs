using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CursoCSharp.Api {
    class ExemploFileInfo {
        public static void ExcluuirSeExistir(params string[] caminhos) {
            foreach(var caminnho in caminhos) {
                FileInfo arquivo = new FileInfo(caminnho);

                if (arquivo.Exists) {
                    arquivo.Delete();
                }
            } 
        }

        public static void Executar() {
            var caminhoOrigem = @"G:/arq_origen.txt";
            var caminhoDestino = @"G:/arq_destino.txt";
            var caminhoCopia = @"G:/arq_copia.txt";

            ExcluuirSeExistir(caminhoOrigem, caminhoDestino, caminhoCopia);

            using (StreamWriter sw = File.CreateText(caminhoOrigem)) {
                sw.WriteLine("Arquivo original!");
            }

            FileInfo origem = new FileInfo(caminhoOrigem);
            Console.WriteLine(origem.Name);
            Console.WriteLine(origem.IsReadOnly);
            Console.WriteLine(origem.FullName);
            Console.WriteLine(origem.Extension);
            Console.WriteLine(origem.Directory);


            origem.CopyTo(caminhoCopia);
            origem.MoveTo(caminhoDestino);
            
        }
    }
}

/* Neste exemplo usamos o file info para deletar e criar aquivos.
 * Tambem movemos o aqruivo de caminho origem para o caminho de destino , criando uma copia. 
 * Depois exploramos algumas funcionalidades de file info . Onde vimo o nome do arquivo , extensão, diretorio , se ele é somente leitura ou 
   vimos tambem o nome completo do arquivo. 
 *  Depois criamos uma condicional que onde deletava o arquivo se existir para nao dar erro.
                                                                                                    */
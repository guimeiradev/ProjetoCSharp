using System;
using System.IO; // Usamos o system.io para trabalhar com arquivos.
using System.Reflection.Metadata.Ecma335;

namespace CursoCSharp.Api {
    //public static class ExtensaoString {
    //    public static string ParseHome(this string path) {
    //        string home = (Environment.OSVersion.Platform == PlatformID.Unix ||
    //            Environment.OSVersion.Platform == PlatformID.MacOSX)
    //            ? Environment.GetEnvironmentVariable("HOME")
    //            : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%HOMEPATH%");
    //        return path.Replace("~", home);

    //    }  // Aqui foi criado uma funcao extensao com a variavel de ambiente substituindo o "~" pela a pasta home .
    }
    class PrimeiroArquivo {

        public static void Executar() {
            var path = @"G:/primeiro_arquivo.txt";
          //  var path = @"~/primeiro_arquivo.txt"; Aqui o arquivo seria criado no diretorio home . 

            if (!File.Exists(path)) {
                using (StreamWriter sw = File.CreateText(path)) { // CreateText cria um arquivo 
                    sw.WriteLine("Essa é");
                    sw.WriteLine("o nosso");
                    sw.WriteLine("primeiro");
                    sw.WriteLine("arquivo!");
                }
            }
            using (StreamWriter sw = File.AppendText(path)) { //AppendText vai escrever mais textos em um arquivo ja existente
                sw.WriteLine("");
                sw.WriteLine("È possivel");
                sw.WriteLine("adcionar");
                sw.WriteLine("Mais");
                sw.WriteLine("Texto");
            }

        }
    }

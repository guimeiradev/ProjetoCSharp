using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CursoCSharp.Api {
    class UsandoPath {
        public static void Executar() {
            var arquivo = @"G:/exemplo_path_arquivo.txr";
            var pasta = @"G:/exemplo_path_pasta";

            if(!File.Exists(arquivo)) {

                using (StreamWriter sw = File.CreateText(arquivo)) {

                }  
            }

            if(!Directory.Exists(pasta)) {
                Directory.CreateDirectory(pasta);
            }
            Console.WriteLine(Path.GetExtension(arquivo));
            Console.WriteLine(Path.GetFileName(arquivo));
            Console.WriteLine(Path.GetFileNameWithoutExtension(arquivo));
            Console.WriteLine(Path.GetDirectoryName(arquivo));
            Console.WriteLine(Path.HasExtension(arquivo));

            // Extraindo algumas informçoes do diretorio

            Console.WriteLine(Path.HasExtension(pasta));
            Console.WriteLine(Path.GetFullPath(pasta));
            Console.WriteLine(Path.GetPathRoot(pasta));

        }
    }
}

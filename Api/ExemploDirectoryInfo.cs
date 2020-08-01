using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CursoCSharp.Api {
    class ExemploDirectoryInfo {
        public static void Executar () {
            var dirProjeto = @"G:/VisualStudio/Projetos/CursoCSharp/CursoCSharp";

            var dirInfo = new DirectoryInfo(dirProjeto);

            if (!dirInfo.Exists) {
                dirInfo.Create();
            }
            Console.WriteLine("== Arquivos =============================");
            var arquivos = dirInfo.GetFiles(); // Aqui nao foi preciso passar o caminho pois quando criamos a instancia dirInfo ja informamos o caminho.
            foreach(var arquivo in arquivos) {
                Console.WriteLine(arquivo);
            }
            Console.WriteLine("/n== Diretorios ===========================");
            var pastas = dirInfo.GetDirectories();
            
            foreach(var pasta in pastas) {
                Console.WriteLine(pasta);

            }
            Console.WriteLine(dirInfo.CreationTime);
            Console.WriteLine(dirInfo.FullName);
            Console.WriteLine(dirInfo.Root);
            Console.WriteLine(dirInfo.Parent);
            Console.WriteLine(dirInfo.Parent.Parent);
        }
    }
}

// Foi visto neste exemplo prioritarimente o file info

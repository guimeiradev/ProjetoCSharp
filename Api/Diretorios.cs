using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Api {
    class Diretorios {
        public static void Executar () {
            var novoDir = @"G:/PastaCSharp";
            var novoDirDestino = @"G:/PastaCSharpDestino";
            var dirProjeto = @"G:/VisualStudio/Projetos/CursoCSharp/CursoCSharp";

            if (Directory.Exists(novoDir)) {
                Directory.Delete(novoDir, true);
            }
            if (Directory.Exists(novoDirDestino)) {
                Directory.Delete(novoDir, true);
            }
            Directory.CreateDirectory(novoDir);
            Console.WriteLine(Directory.GetCreationTime(novoDir));

            Console.WriteLine("== Pastas =========================");
            var pastas = Directory.GetDirectories(dirProjeto);

            foreach(var pasta in pastas) {
                Console.WriteLine(pasta);
            }
            Console.WriteLine("== Arquivos =========================");
            var arquivos = Directory.GetFiles(dirProjeto);
            foreach(var arquivo in arquivos) {
                Console.WriteLine(arquivo);
            }
            Console.WriteLine("== Raiz ===============================");
            Console.WriteLine(Directory.GetDirectoryRoot(novoDir));

            Directory.Move(novoDir, novoDirDestino);

        }
    }
}

/* Neste exemplo vimos como criar diretorio , como mover , como deletar e vimos como ver a data de criação */
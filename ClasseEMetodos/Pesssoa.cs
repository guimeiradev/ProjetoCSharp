using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CursoCSharp.ClasseEMetodos {
    class Pesssoa {
        public string Nome; // Foi criado dois atributos um de tipo string e outro de tipo int e os dois sao visiveis , ou seja public.
        public int Idade; // Foi usado pascalcase , que a ter a primeira letra maiuscula

        public string Apresentar() {
            return string.Format($"Ola me chamo {Nome} e tenho {Idade} anos .");
        }
        public void ApresentarNoConsole() {
            Console.WriteLine(Apresentar());

           
        }
        public void zerar() {
            Nome = " ";
            Idade = 0;
        }

    }
}


// Obs: String tem valor padrao null e int tem valor padrao 0
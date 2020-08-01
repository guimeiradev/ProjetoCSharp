
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes {
    class DelgatesFuncAnonima {
        delegate string StringOperacao(string s);
        

        public static void Executar () {
            StringOperacao inverter = delegate (string s) {
                char[] charArray = s.ToCharArray();
                Array.Reverse(charArray);
                return new string(charArray);
            };
            Console.WriteLine(inverter("! show é C#"));
            

        }
    }
}

/* Neste exemplo foi criado um delegate onde passamos um valor do tipo string.
 * Criamos uma variavel do tipo StringOperacao e passamos como valor outro delegate associado com uma funcao anonima
 * E tambem criamos uma funcao que visa inverter os caracteres de uma string.*/
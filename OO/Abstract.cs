using CursoCSharp.OO;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO {
    public abstract class Celular {
        public abstract string Assistente();
    
        public string Tocar() {
            return "Trim trim trim...";

        }
    }
    public class Samsunga70 : Celular {
        public override  string Assistente() {
            return "Ola! meu nome é Bixby!";
        }
    }
    public class Iphone : Celular {
        public override string Assistente() {
            return "Ola! Meu nome é Siri !";
        }
    }


    class Abstract {
        public static void Executar() {

            var celulares = new List<Celular> {
                new Iphone(),
                new Samsunga70()
            };
            foreach (var celular in celulares) {
                Console.WriteLine(celular.Assistente());
            }
        }
    }
}


/* Uma classe abstrata é uma classe que não pode ser instanciada. 
 * Você não pode criar um objeto a partir de uma classe abstrata. 
 * Uma classe abstrata pode ser herdada e geralmente serve como classe base para outras classes. 
 * Uma classe abstrata pode conter métodos abstratos e métodos comuns.  */

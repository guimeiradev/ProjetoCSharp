using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace CursoCSharp.ClasseEMetodos {
 
    public class CarroOpcional {
        double descconto = 0.1;
        
        string nome;
        public string Nome {
            get {
                return "Opcional: " + nome; 
            }
            set {
                nome = value;
            }
        }
        // Propriedade autoimplementada
        public double Preco { get; set; }

        // Somente leitura
        public double PrecoComDesconto {

            get =>   Preco - (descconto * Preco);  // Lambda
            
            
            // Outra forma de fazer :

            //get {
            //    return Preco - (descconto * Preco);
            //}
        }
        public CarroOpcional () {

        }
        public CarroOpcional(string nome , double preco) {
            Nome = nome;
            Preco = preco; 
        }
            
    }
    
    class Props {

        public static void Executar () { 

            var op1 = new CarroOpcional("Ar condicionado", 3500.90);
            Console.WriteLine(op1.PrecoComDesconto);
            Console.WriteLine(op1.Nome);

            
            var op2 = new CarroOpcional();
            op2.Nome = "Direcao e Trava";
            op2.Preco = 4550.90;

            Console.WriteLine(op2.Nome);
            Console.WriteLine(op2.Preco);
            Console.WriteLine(op2.PrecoComDesconto);


        }
    }
}

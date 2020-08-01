using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes {
    class UsandoDelegate {
        delegate double Soma(double a, double b);
        delegate void ImprimirSoma(double a, double b);

        static double MinhaSoma(double x, double y) {
            return x + y;
        }
        static void MeuImprimirSoma(double a , double b) {

            Console.WriteLine(a + b);
        }
        


        public static void Executar () {
            Soma op1 = MinhaSoma;
            Console.WriteLine(op1(4.4,5.5));

            ImprimirSoma op2 = MeuImprimirSoma;
            op2(8.7, 3);

            Func<double, double, double> op3 = MinhaSoma;
            Console.WriteLine(MinhaSoma(2.5,4));

            Action<double, double> op4 = MeuImprimirSoma;
            op4(7.7, 23.4);

        }
    }
}

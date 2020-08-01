using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO {
    sealed class Semfilho {
        public double ValorDaFortuna() {
            return 1_407__033.65;
        }
    }
    //class SouFilho : Semfilho { // Não é possivel herdar de uma classe sealed (selada)

    //}

    class Avo {
        public virtual bool HonrarNomeFamilia() {
            return true;
        }
    }
    class Pai : Avo {
        public override sealed bool HonrarNomeFamilia() {
            return true;
        }
    }
    class FilhoRebelde : Pai {
        //    public override bool HonrarNomeFamilia() { // O  sealed não permite  sobescrever um metodo
        //        return false;
        //    }
        }


        class Sealed {
            public static void Executar() {
                Semfilho semFilho = new Semfilho();
                Console.WriteLine(semFilho.ValorDaFortuna());

                FilhoRebelde filho = new FilhoRebelde();
                Console.WriteLine(filho.HonrarNomeFamilia());

            }
        }
    }

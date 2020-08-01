using System; 
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CursoCSharp.ClasseEMetodos {

    public class Moto {
        private string Marca; // No c# voce nao precisa por obrigatoriamente o private . Ele ja é privado por padrao
        private string Modelo;
        private uint Cilindrada; // O ultimo exemplo usamos o metodo uint , ele é um metodo que nao permite valores negativos

        public Moto(string marca, string modelo, uint cilindrada) {
            //Marca = marca;
            //Modelo = modelo;
            //Cilindrada = cilindrada;

            SetMarca(marca);
            SetModelo(modelo);
            SetCilindrada(cilindrada);
        }
        public Moto() {

        }
        public string GetMarca() {
            return Marca;
        }
        public void SetMarca(string marca) {
            Marca = marca;
        }
        public string GetModelo() {
            return Modelo;
        }
        public void SetModelo(string modelo) {
            Modelo = modelo;

        }
        public uint GetCilindrada() {
            return Cilindrada;
        }

        public void SetCilindrada(uint cilindrada) {

            // Um dos metodos para nao deixar um valor ser setado negativo
            //if(cilindrada > 0 ) {


            /*  Cilindrada = Math.Abs(cilindrada);  Uma terceira forma de não permitir numeros negativos . 
                                                  Esse math.abs faz com que os valores negativos se tranforme em positivo*/

            Cilindrada = cilindrada;
        }
    }


    class GetSet {
        public static void Executar() {
            var moto1 = new Moto("Kawasaki", "NInja ZX-GR", 636); /* Passando valor negativo no construtor voce vai ainda conseguir imprimir valores negativos. 
                                                                   * Porem se voce antes mandar passar pelo set onde nos colocamos a clausula de valores menor que 0 nao são permitdos 
                                                                   * , ai sim nao sera possivel obter valores negativos.*/
            Console.WriteLine(moto1.GetCilindrada());
            Console.WriteLine(moto1.GetModelo());
            Console.WriteLine(moto1.GetCilindrada());

            var moto2 = new Moto();

            moto2.SetMarca("Honda");
            moto2.SetModelo("CG-TITAN");
            moto2.SetCilindrada(150);
            Console.WriteLine(moto2.GetMarca() + " " + moto2.GetModelo() + " " + moto2.GetCilindrada());


        }
    }
}
    


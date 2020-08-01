using CursoCSharp.Fundamentos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml.Schema;

namespace CursoCSharp.TopicosAvancados {
    public class Aluno {
        public string Nome;
        public int Idade;
        public double Nota;
    }
    class LINQ1 {
        public static void Executar() {
            var alunos = new List<Aluno> {
                new Aluno() {Nome = "Guilherme" , Idade = 24 , Nota = 8.5},
                new Aluno() { Nome = "Pedro", Idade = 22, Nota = 4.3},
                new Aluno() { Nome = "Ana", Idade = 25 , Nota = 9.5},
                new Aluno() { Nome = "Jorge", Idade = 19 , Nota = 8.5},
                new Aluno() { Nome = "Ana", Idade = 21 , Nota = 7.7},
                new Aluno() { Nome = "Julia", Idade = 22 , Nota = 7.5},
                new Aluno() { Nome = "Marcio", Idade = 18 , Nota = 6.8}
            };
            Console.WriteLine("== Aprovados ===========================");
            var aprovados = alunos.Where(a => a.Nota >= 7).OrderBy (a => -a.Nota);
            foreach(var aluno in aprovados) {
                Console.WriteLine(aluno.Nome);
            }
            Console.WriteLine("\n ==Chamada===========================");
            var chamada = alunos.OrderBy(a => a.Nome).Select(a => a.Nome);
            foreach (var aluno in chamada) {
                Console.WriteLine(aluno);
            }
            Console.WriteLine("==\n Aprovados (por Idade)=======================");

            var alunosAprovados = from Aluno in alunos where Aluno.Nota >= 7 orderby Aluno.Idade select Aluno.Nome;

            foreach(var aluno in alunosAprovados) {
                Console.WriteLine(aluno);
            }
        }
    }
}

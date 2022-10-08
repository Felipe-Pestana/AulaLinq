using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjLinqAula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Aeronave> lstAero = new List<Aeronave>();
            List<Companhia> lstComp = new List<Companhia>();

            lstAero.Add(new Aeronave { ID = 1, Inscricao = "PT-LSD", Capacidade = 10 });
            lstAero.Add(new Aeronave { ID = 2, Inscricao = "PL-BRA", Capacidade = 20 });
            lstAero.Add(new Aeronave { ID = 3, Inscricao = "PP-USA", Capacidade = 30 });
            lstAero.Add(new Aeronave { ID = 4, Inscricao = "PR-ABC", Capacidade = 40 });
            lstAero.Add(new Aeronave { ID = 5, Inscricao = "PU-CNO", Capacidade = 50 });
            lstAero.Add(new Aeronave { ID = 6, Inscricao = "PT-JHO", Capacidade = 60 });
            lstAero.Add(new Aeronave { ID = 7, Inscricao = "PL-DIN", Capacidade = 70 });
            lstAero.Add(new Aeronave { ID = 8, Inscricao = "PR-PAD", Capacidade = 80 });
            lstAero.Add(new Aeronave { ID = 9, Inscricao = "PU-DIM", Capacidade = 90 });
            lstAero.Add(new Aeronave { ID = 10, Inscricao = "PT-PPL", Capacidade = 100 });
            lstAero.Add(new Aeronave { ID = 11, Inscricao = "PL-XYZ", Capacidade = 110 });

            lstComp.Add(new Companhia { ID = 1, Nome = "Unicornios Coloridos" });
            lstComp.Add(new Companhia { ID = 2, Nome = "Dragões Flamejantes" });

            lstAero.ForEach(item => Console.WriteLine(item.ToString()));
            //lstComp.ForEach(item => Console.WriteLine(item.ToString()));

            //var paginacao = lstAero.Skip(50);

            //var paginacao = lstAero.Skip(2).Take(3);

            //foreach (var i in paginacao)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 0; i < lstAero.Count; i = i+3)
            //{
            //    foreach (var aviao in lstAero.Skip(i).Take(3))
            //    {
            //        Console.WriteLine(aviao);
            //    }
            //    Console.ReadKey();
            //    Console.Clear();
            //}


            //Environment.Exit(0);
            var item = from aeronave in lstAero
                       select new AeronaveDTO
                       {
                           Inscricao = aeronave.Inscricao,
                           Capacidade = aeronave.Capacidade
                       };

            var newList = from aeronave in lstAero
                          where aeronave.Capacidade > 20
                          select new
                          {
                              aeronave.Inscricao,
                              aeronave.Capacidade
                          };

            foreach (var i in item)
            {
                Console.WriteLine(i);
            }
        }

        public class AeronaveDTO
        {
            public string Inscricao { get; set; }
            public int Capacidade { get; set; }

            public override string ToString()
            {
                return $"Inscrição: {this.Inscricao}\nCapacidade: {this.Capacidade}";
            }
        }
            public class Aeronave
        {
            public int ID { get; set; }
            public string Inscricao { get; set; }
            public int Capacidade { get; set; }

            public override string ToString()
            {
                return $"ID: {this.ID}\nInscrição: {this.Inscricao}\nCapacidade: {this.Capacidade}" ;
            }
        }

        public class Companhia
        {
            public int ID { get; set; }
            public string Nome { get; set; }

            public override string ToString()
            {
                return $"ID: {this.ID}\nNome: {this.Nome}\n";
            }
        }
    }
}

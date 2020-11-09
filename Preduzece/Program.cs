using System;

namespace Preduzece
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite maksimalni broj radnika:");
            int maksBrojRadnika = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesite cenu rada:");
            float cenaRada = float.Parse(Console.ReadLine());
            Console.WriteLine("Unesite cenu prevoza:");
            float prevoz = float.Parse(Console.ReadLine());
            Preduzece p = new Preduzece(maksBrojRadnika, cenaRada, prevoz);

            Console.WriteLine("Za dodavanje novog radnika unesite broj 1, za kraj rada rada unesite bilo koji drugi broj");
            int unos = int.Parse(Console.ReadLine());
            while (unos == 1)
            {
                Console.WriteLine("Unesite poziciju radnika (0-radnik, 1-sef, 2-direktor):");
                int pozInt = int.Parse(Console.ReadLine());
                Console.WriteLine("Unesite ime radnika:");
                String ime = Console.ReadLine();
                Console.WriteLine("Unesite prezime radnika:");
                String prezime = Console.ReadLine();
                Console.WriteLine("Unesite koeficijent strucne spreme:");
                float kss = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Unesite godinu zaposlenja:");
                int godina = int.Parse(Console.ReadLine());

                if (pozInt < 0 || pozInt > 2)
                    Console.WriteLine("Nevalidna vrednost za poziciju!");
                Radnik noviRadnik;
                if (pozInt == 2)
                    noviRadnik = new Direktor(ime, prezime, kss, godina);
                else if (pozInt == 1)
                    noviRadnik = new Sef(ime, prezime, kss, godina);
                else
                    noviRadnik = new Radnik(ime, prezime, kss, godina);
                p.DodajRadnika(noviRadnik);

                Console.WriteLine("Za dodavanje novog radnika unesite broj 1, za kraj rada rada unesite bilo koji drugi broj");
                unos = int.Parse(Console.ReadLine());
            }
            p.Prikazi();
            Console.WriteLine("Unesite indeks radnika za brisanje iz preduzeca:");
            int indeks = int.Parse(Console.ReadLine());
            p.BrisiRadnika(indeks);
            p.Prikazi();

            Console.Write("Ukupno za prevoz: ");
            p.PrikaziNaknadeZaPrevoz();
        }
    }
}

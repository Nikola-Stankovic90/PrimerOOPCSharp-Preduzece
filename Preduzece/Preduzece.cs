using System;
using System.Collections.Generic;
using System.Text;

namespace Preduzece
{
    class Preduzece
    {
        private int brojRadnika;
        private int maksRadnika;
        private Radnik[] radnici;
        private float cenaRada;
        private float prevoz;

        public Preduzece(int maksRadnika, float cenaRada, float prevoz)
        {
            this.maksRadnika = maksRadnika;
            this.radnici = new Radnik[this.maksRadnika];
            this.brojRadnika = 0;
            this.cenaRada = cenaRada;
            this.prevoz = prevoz;
        }

        public void DodajRadnika(Radnik radnik)
        {
            if (this.brojRadnika < this.maksRadnika)
            {
                this.radnici[this.brojRadnika] = radnik;
                this.brojRadnika++;
            }
            else
            {
                Console.WriteLine("Nema vise mesta u nizu!");
            }
        }

        public void BrisiRadnika(int indeks)
        {
            if (indeks >= 0 && indeks < this.brojRadnika)
            {
                for (int i = indeks; i < this.brojRadnika - 1; i++)
                {
                    this.radnici[i] = this.radnici[i + 1];
                }
                this.radnici[this.brojRadnika - 1] = null;
                this.brojRadnika--;

            }
            else
            {
                Console.WriteLine("Nevalidan indeks za brisanje");
            }
        }

        /*
        public void Ucitaj()
        {
            Console.WriteLine("Unesite broj radnika:");
            this.brojRadnika = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesite cenu rada:");
            this.cenaRada = float.Parse(Console.ReadLine());
            Console.WriteLine("Unesite cenu prevoza:");
            this.prevoz = float.Parse(Console.ReadLine());

            this.radnici = new Radnik[this.brojRadnika];
            for (int i = 0; i < this.brojRadnika; i++)
            {
                this.radnici[i] = new Radnik();
                this.radnici[i].Ucitaj();
            }
        }
        */

        public void Prikazi()
        {
            Console.WriteLine("Platni spisak: ");
            for (int i = 0; i < this.brojRadnika; i++)
            {
                this.radnici[i].Prikazi(this.cenaRada);
            }
        }

        public void PrikaziNaknadeZaPrevoz()
        {
            float ukupnoZaPrevoz = this.brojRadnika * this.prevoz;
            Console.WriteLine($"Ukupna naknada za prevoz: {ukupnoZaPrevoz}. ");
        }
    }
}

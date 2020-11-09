using System;
using System.Collections.Generic;
using System.Text;

namespace Preduzece
{
    class Radnik
    {
        private String ime;
        private String prezime;
        private float kss;
        private int godina;

        public Radnik(String ime, String prezime,
            float kss, int godina)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.kss = kss;
            this.godina = godina;
        }

        virtual protected float IzracunajPlatu(float cenaRada)
        {
            float osnovnaPlata = cenaRada * kss
                * (1 + 0.005f * (2020 - godina));
            return osnovnaPlata;
        }

        public void Prikazi(float cenaRada)
        {
            Console.WriteLine(ime + " " + prezime + " " + IzracunajPlatu(cenaRada));
        }
    }
}

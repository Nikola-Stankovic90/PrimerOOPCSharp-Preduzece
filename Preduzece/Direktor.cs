
using System;
using System.Collections.Generic;
using System.Text;

namespace Preduzece
{
    class Direktor : Radnik
    {
        public Direktor(String ime, String prezime, float kss, int godina)
            : base(ime, prezime, kss, godina)
        { }

        protected override float IzracunajPlatu(float cenaRada)
        {
            return 1.3f * base.IzracunajPlatu(cenaRada);
        }
    }
}

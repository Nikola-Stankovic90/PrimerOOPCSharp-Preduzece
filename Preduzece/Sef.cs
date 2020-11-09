using System;
using System.Collections.Generic;
using System.Text;

namespace Preduzece
{
    class Sef : Radnik
    {
        public Sef(String ime, String prezime, float kss, int godina)
            : base(ime, prezime, kss, godina)
        { }

        protected override float IzracunajPlatu(float cenaRada)
        {
            return 1.1f * base.IzracunajPlatu(cenaRada);
        }
    }
}

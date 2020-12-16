using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pekseg
{
    class Pekaru
    {
        private string nev;
        private int ar;
        private bool laktozmentes;

        public Pekaru(string nev, int ar, bool laktozmentes)
        {
            this.Nev = nev;
            this.Ar = ar;
            this.Laktozmentes = laktozmentes;
        }

        public string Nev { get => nev; set => nev = value; }
        public int Ar { get => ar; set => ar = value; }
        public bool Laktozmentes { get => laktozmentes; set => laktozmentes = value; }

        public override string ToString()
        {
            return nev + " (" + ar + " Ft / db)";
        }
    }
}

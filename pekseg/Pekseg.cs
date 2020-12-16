using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pekseg
{
    class Pekseg
    {

        private string nev;
        private List<Pekaru> termekek;
        private DateTime alapitva;

        public Pekseg(string nev, DateTime alapitva)
        {
            this.Nev = nev;
            this.Alapitva = alapitva;
            this.Termekek = new List<Pekaru>();
        }

        public string Nev { get => nev; set => nev = value; }
        public DateTime Alapitva { get => alapitva; set => alapitva = value; }
        internal List<Pekaru> Termekek { get => termekek; set => termekek = value; }

        public override string ToString()
        {
            return nev + " - " + alapitva.ToString().Remove(alapitva.ToString().Length - 8);
        }

        public double AtlagAr()
        {
            double termekekOsszege = 0;

            foreach (var pekaru in termekek)
            {
                termekekOsszege += pekaru.Ar;
            }
            return termekekOsszege /= termekek.Count();
        }

        public Pekaru Legolcsobb()
        {
            try
            {
                Pekaru legolcsobb = termekek[0];
                foreach (var pekaru in termekek)
                {
                    if (legolcsobb.Ar > pekaru.Ar)
                    {
                        legolcsobb = pekaru;
                    }
                }
                return legolcsobb;
            }
            catch
            {
                return null;
            }
        }

        public Pekaru Legdragabb()
        {
            try
            {
                Pekaru legdragabb = termekek[0];
                foreach (var pekaru in termekek)
                {
                    if (legdragabb.Ar < pekaru.Ar)
                    {
                        legdragabb = pekaru;
                    }
                }
                return legdragabb;
            }
            catch
            {
                return null;
            }
        }

        public string Laktozmentesek()
        {
            int laktozmentesek = 0;

            foreach (var pekaru in termekek)
            {
                if (pekaru.Laktozmentes == true)
                {
                    laktozmentesek++;
                }
            }
            try
            {
                return laktozmentesek + " db, " + Math.Ceiling(Convert.ToDecimal(100 / termekek.Count) * laktozmentesek) + "%";
            }
            catch (Exception err)
            {
                return "0 db, 0%";
            }
        }
    }
}

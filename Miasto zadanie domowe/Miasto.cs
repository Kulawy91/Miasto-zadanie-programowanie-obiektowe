using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miasto_zadanie_domowe
{
    public class Miasto
    {
        private string nazwa;

            public string Nazwa
            {
            get { return nazwa; }
            set { nazwa = value; }
            }


        private uint populacja;

            public uint Populacja
            {
            get { return populacja; }
            set { populacja = value; }
            }

        private double powierzchnia;
            public double Powierzchnia
            {
            get { return powierzchnia; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Powierzchnia musi być większa od zera.");
                }
                powierzchnia = value;
                }
            }

        public double GęstośćZaludnienia
        {
            get { return Populacja / Powierzchnia; }
        }
    }
}

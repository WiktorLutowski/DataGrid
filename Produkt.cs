using System;

namespace DataBinding
{

    public class Produkt
    {
        public Produkt()
        {
            
        }
        public string Symbol { get; set; }
        public string Nazwa { get; set; }
        public int LiczbaSztuk { get; set; }
        public string Magazyn { get; set; }
        public Uri Zdjecie { get; set; }

        public Produkt(string sym, string naz, int szt, string mag, Uri zdj)
        {
            Symbol = sym;
            Nazwa = naz;
            LiczbaSztuk = szt;
            Magazyn = mag;
            Zdjecie = zdj;
        }

        public override string ToString()
        {
            return String.Format("{0} {1} {2} {3}", Symbol, Nazwa, LiczbaSztuk, Magazyn);
        }
    }
}
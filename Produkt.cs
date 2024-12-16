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
        public string Opis { get; set; }

        public Produkt(string sym, string naz, int szt, string mag, Uri zdj, string opis)
        {
            Symbol = sym;
            Nazwa = naz;
            LiczbaSztuk = szt;
            Magazyn = mag;
            Zdjecie = zdj;
            Opis = opis;

        }
    }
}
using System;

namespace Pojazd
{
    public enum Rodzaj
    {
        Osobowy, Ciezarowy
    }
    public class Pojazd
    {
        public string Marka { get; set; }
        public Rodzaj RodzajPojazdu { get; set; }
        public decimal Cena { get; set; }
        public string Kolor { get; set; }

        public Pojazd(string marka, Rodzaj rodzaj, decimal cena, string kolor)
        {
            this.Marka = marka;
            this.RodzajPojazdu = rodzaj;
            this.Cena = cena;
            this.Kolor = kolor;
        }
    }
}

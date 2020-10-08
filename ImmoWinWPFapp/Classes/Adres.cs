using ImmoWinWPFapp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImmoWinWPFapp
{
    class Adres : IAdres
    {
        public string Straat { get; set; }
        public int Huisnummer { get; set; }
        public int Postcode { get; set; }
        public string Gemeente { get; set; }

        public Adres(string straat, int huisnummer, string gemeente, int postcode )
        {
           
            Huisnummer = huisnummer;
            Straat = straat;
            Gemeente = gemeente;
            Postcode = postcode;
        }

    }
}

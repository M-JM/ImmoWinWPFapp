using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImmoWinWPFapp.Classes
{
    class Appartement : Woning, IAppartement, IWoning
    {
        public int Verdieping { get; set; }

        public Appartement(int verdieping, double prijs, string straat, int huisnummer, string gemeente, int postcode)
           : base(prijs, straat, huisnummer, gemeente, postcode)
        {
            Verdieping = verdieping;
        }
        public override string ToString()
        {
            return $" {Adres.Straat} - {Adres.Huisnummer} - {Verdieping} -  {Adres.Gemeente} - {Adres.Postcode} , € {Prijs}{Environment.NewLine}";
        }

    }
}

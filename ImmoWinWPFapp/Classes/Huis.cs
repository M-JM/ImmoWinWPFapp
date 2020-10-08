using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImmoWinWPFapp.Classes
{
    class Huis : Woning, IHuis, IWoning
    {
        public string TypeWoning { get; set; }


        public Huis(string typeWoning, double prijs, string straat, int huisnummer, string gemeente, int postcode)
            : base(prijs, straat, huisnummer, gemeente, postcode)
        {
            TypeWoning = typeWoning;
        }
        public override string ToString()
        {
            return $" {Adres.Straat} - {Adres.Huisnummer} - {TypeWoning} -  {Adres.Gemeente} - {Adres.Postcode} , € {Prijs}{Environment.NewLine}";
        }
    }
}

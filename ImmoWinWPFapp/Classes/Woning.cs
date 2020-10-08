using ImmoWinWPFapp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImmoWinWPFapp
{
    class Woning : IWoning, IComparable
    {

        public double Prijs { get; set; }
        // Has-a relationship use Composition to let Woning have an address
        public IAdres Adres { get; set; }

        // constructor met parameters voor het aanmaken van instance
        public Woning(double prijs, string straat, int huisnummer, string gemeente, int postcode)
        {
            Prijs = prijs;
            Adres = new Adres(straat, huisnummer, gemeente, postcode);
        }

        public int CompareTo(object obj)
        {
            int result;

            if (obj is Huis huis)
            {
                return Adres.Straat.CompareTo(huis.Adres.Straat);
            }
            else
            {
            if (obj is Appartement appartement)
            {
                    if ((result = Adres.Straat.CompareTo(appartement.Adres.Straat)) == 0)
                    {
                        result = ((Appartement)this).Verdieping.CompareTo(appartement.Verdieping) * -1 ;
                        // vragen aan Serge of het niet anders kan -> //
                    }
                    return result;
            }
            else
            {
              throw new ArgumentException("obj is geen Appartement of Huis");
            }
            }
        }
    }
}

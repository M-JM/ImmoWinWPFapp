using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImmoWinWPFapp.Classes
{
    interface IAdres
    {
        string Straat { get; set; }
        int Huisnummer { get; set; }
        int Postcode { get; set; }
        string Gemeente { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImmoWinWPFapp.Classes
{
    interface IWoning
    {
         double Prijs { get; set; }
        
         IAdres Adres { get; set; }

         string ToString();

    }
}

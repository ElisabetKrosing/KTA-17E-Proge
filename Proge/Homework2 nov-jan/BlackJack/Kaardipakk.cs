using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Kaardipakk
    {
        public List<int> KaardiNr = new List<int>();

        public void LisaKaart() 
        {
            for (int nr = 1; nr< 53; nr++ )
            {
                KaardiNr.Add(nr);
            }
        }
        var list = Enumerable.Range(1, 52).ToList();
    }
}

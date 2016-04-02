using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF731_TP2
{
    class Horaire
    {
        private string jour;
        private int heure;

      //Declaration proprietes

        public string Jour { get; private set; }
        public int  Heure { get; private set; }


        // Constructeur 

        public Horaire (string valjour, int valheure)
        {
            jour = valjour;
            heure = valheure;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF731_TP2
{
    class LaboratoireChimie : SalleCours
    {
        int nbreAireExp_; // nombre d'aire d'experimentation

        public int NbreAireExp
        {
            get
            {
                return nbreAireExp_;
            }
            protected set
            {
                if (value > 0)
                {
                    NbreAireExp = value;
                }
                else { Console.WriteLine("je prevois mettre en place les exceptions"); }
            }
        }

        public LaboratoireChimie(string numSalle, int nbrePersMax, int nbreTable, int nbreAireExp)
            : base(numSalle, nbrePersMax, nbreTable)
        {
            NbreAireExp = nbreAireExp;
        }
    }
}

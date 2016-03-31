using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF731_TP2
{
    class LaboratoireInfo : SalleCours
    {
        int nbrePosteInfo_;

        public int NbrePosteInfo
        {
            get
            {
                return nbrePosteInfo_;
            }
            protected set
            {
                if (value > 0)
                {
                    nbrePosteInfo_ = value;
                }
                else { Console.WriteLine("je prevois mettre en place les exceptions"); }
            }
        }

        public LaboratoireInfo(string numSalle, int nbrePersMax, int nbreTable, int nbrePosteInfo)
            : base(numSalle, nbrePersMax, nbreTable)
        {
            NbrePosteInfo = nbrePosteInfo;
        }
    }
}

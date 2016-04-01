using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace INF731_TP2
{
    class Program
    {
        const string CHEMIN = "../../";
        const string FICHIER_ENTREE = "Salles.txt";

        static void Main(string[] args)
        {
            Salle s1 = new LaboratoireInfo("labo", "li02", 45, 55, 45);
            Console.WriteLine("{0}", s1.Afficher());
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace INF731_TP2
{
    class Groupe
    {
        class HeureReservationHorsBornesException : ApplicationException { }
        class JourReservationHorsBornesException : ApplicationException { }
        class SalleDisponibiliteHorsBornesException : ApplicationException { }
        class SalleCapaciteHorsBornesException : ApplicationException { }
        class NbrePeriodesHorsBornesException : ApplicationException { }

       //La classe Groupe permet de gerer les groupes ayant pour objet de faire des reservations de salle

        

            //Declaration des constantes

            public const int NBRE_PERIODES_DEPART = 8;
            public const int  NBRE_PERIODES_MAX= 10;


            //Declaration des attributs

            private string nomGroupe;
            private string typeSalle;
            private string jourRes;
            private int nbrePeriode;
            private int heureReservation;



            // Declaration des proprietes

            public string NomGroupe { get; private set; }
            public string TypeSalle { get; private set; }
            public int NumDepart { get; private set; }
            public int NombrePeriode { get; private set; }
            public string JourRes { get; private set; }
            public int HeureReservation { get; private set; }

           public Groupe() { }

            public Groupe(Groupe existant)
          {
            NomGroupe = existant.NomGroupe;
            TypeSalle = existant.TypeSalle;
            JourRes = existant.JourRes;
            NombrePeriode = existant.NombrePeriode;
            HeureReservation = existant.HeureReservation;
        }

                          

            //Declaration du constructeur parametrique

            public Groupe(string valnomGroupe,  string valtypeSalle,  string valjourRes, int valnbrePeriode, int valheureReservation)


            {
                NomGroupe = valnomGroupe;
                TypeSalle = valtypeSalle;
                JourRes = valjourRes;
                NombrePeriode = valnbrePeriode;
                HeureReservation = valheureReservation;
            }

        public override string ToString()
        {
            return string.Format("NomGroupe {1} - TypeSalle {2} - JourRes {3} -  NombrePeriode {4}- HeureReservation  {5}", NomGroupe, TypeSalle, JourRes, NombrePeriode, HeureReservation);
        }





    }
}






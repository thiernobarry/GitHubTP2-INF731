using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF731_TP2
{
    class Program
    {
        static void Main(string[] args)
        {
            const string CHEMIN = "../../";
            const string FICHIER_ENTREE = CHEMIN + "Groupe.txt";
            //const string FICHIER_SORTIE_Rapport1 = CHEMIN + "Rapport_Par_Horaire.txt";
            //const string FICHIER_SORTIE_Rapport2 = CHEMIN + "Rapport_Par_Salle.txt";
            //const string FICHIER_SORTIE_Rapport3 = CHEMIN + "Rapport_Par_Groupe.txt";
            const char delimiteur = ';';

           
        {
                try
                {

                    //Lire Fichier et charger les donnees dans une liste de groupes
                    List<Groupe> listGroupe = Generer.CreerListeGroupes(FICHIER_ENTREE, delimiteur);

                    //// Produire Rapport 1
                    //Generer.CreerRapport1_ParHoraire(listGroupe, FICHIER_SORTIE_Rapport1);

                    //// Produire Rapport 2

                    //Generer.CreerRapport2_ParSalle(listGroupe, FICHIER_SORTIE_Rapport2);


                    //// Produire Rapport 3 

                    //Generer.CreerRapport3_ParGroupe(listGroupe, FICHIER_SORTIE_Rapport3);



                    Console.WriteLine(System.Environment.NewLine);
                    Console.WriteLine("Rapports generes avec success!");
                    Console.ReadLine();

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Attention! une exception s'est produite lors de l'execution du programme");
                    Console.WriteLine("Veuillez trouver ci-dessous la description de l'exception");
                    Console.WriteLine(System.Environment.NewLine);
                    Console.WriteLine(ex.Message);
                    Console.ReadLine();
                }

            }
        }
    }



    
        }
    


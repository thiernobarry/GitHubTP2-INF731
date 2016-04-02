using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace INF731_TP2
{
    class Generer
    {
        //Lire fichier et puis creer la liste des Groupes

        public static List<Groupe>CreerListeGroupes(string chemin, char delimiteur)
      
        {
            List<Groupe> listeGroupes = new List<Groupe>();

            if (File.Exists(chemin))
            {

                using (StreamReader sr = File.OpenText(chemin))
                {
                    string s = String.Empty;
                    string[] line = new string[5];

                    while ((s = sr.ReadLine()) != null)
                    {
                        try
                        {

                            line = s.Split(delimiteur);

                            string nomGroupe = line[0];
                            string typeSalle = line[1];
                            string jourRes = line[2];
                            int nbrePeriode = int.Parse(line[3]);
                            int heureReservation = int.Parse(line[4]);

                            Groupe groupe = new Groupe(nomGroupe, typeSalle, jourRes, nbrePeriode, heureReservation);

                            listeGroupes.Add(Groupe);
                        
                                               
                                                
                        
                        //    Console.WriteLine("Erreur , une erreur s'est produite lors du traitement de la ligne : '{0}'");
                        //}

                      
                         else
                      {
                                Console.WriteLine(" le fichier en lecture {0} n existe pas");

                            } // End if



                     catch (FormatException exception)
                        {
                            Console.WriteLine("Erreur impossible de convertir la valeur en nombre : '{0}'");

                        }

                        catch (ArgumentException exception)
                        {
                            Console.WriteLine("Erreur type  d operation invalide : '{0}' ");

                        }

                        catch (IndexOutOfRangeException exception)
                        {
                            Console.WriteLine("Erreur format de la ligne de l'operation invalide : '{0}'");

                        }


                        catch (Exception exception)
                        {
                            Console.WriteLine("Erreur , une erreur s'est produite lors du traitement de la ligne : '{0}'");
                        }
                    
            else
            {
                        Console.WriteLine(" le fichier en lecture {0} n existe pas");

                    } // End if

                    return listeGroupes;
                }


           
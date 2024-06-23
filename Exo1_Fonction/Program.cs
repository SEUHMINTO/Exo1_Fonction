using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Reflection;

namespace Exo1_fonction // Note: actual namespace depends on the project name.
{

    internal class Collection
    {
        static void listeEdutiants()
        {
         int nombre = 0;

        List<string> List = new List<string>();
       
            while (true)
            {
                Console.WriteLine("Entrez le Nom et le Pronoms de l'étudiant: ");
                string nomPrenoms = Console.ReadLine();
                List.Add(nomPrenoms);
                Console.WriteLine("Voullez-vous continuer la saisie? (O=Oui / N=Non)");
                string Reponse = Console.ReadLine();
                if (Reponse == "N")
                {
                    Console.WriteLine("Voullez le Nom à rechercher)");
                    nomPrenoms = Console.ReadLine();
                    nombre  = List.IndexOf(nomPrenoms);
                    Console.WriteLine("Le nom a été retrouvé c'est " +List[nombre]) ;
                    break;
                 }
            }

        }
        static void Main(string[] args)
            {
            listeEdutiants();
            }
    }
}
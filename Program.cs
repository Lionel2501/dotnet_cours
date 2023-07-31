using System;
using GestionCours.Models;

namespace GestionCours
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Diplome dCDA = new Diplome { Code="CDA", Nom="Concepteur Développeur d'Applications" };

            Promotion promo1 = new Promotion { Id = 1, Nom = "CDA 2021", Diplome = dCDA };

            dCDA.Promotions.Add(promo1);

            Eleve dupont = new Eleve { Id = 1, Nom = "Dupont", Prenom = "Jean", Promotion = promo1 };

            promo1.Eleves.Add(dupont);

            Console.WriteLine(dCDA);
            foreach (Promotion promo in dCDA.Promotions)
            {
                Console.WriteLine(promo);
                foreach (Eleve eleve in promo.Eleves)
                {
                    Console.WriteLine(eleve);
                }
            }

        }
    }
}

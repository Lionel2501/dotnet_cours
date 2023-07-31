using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCours.Models
{
    internal class Promotion
    {
        public int Id { get; set; }

        public string Nom { get; set; }

        public Diplome Diplome { get; set; }

        public List<Eleve> Eleves { get; set; } = new List<Eleve>();

        public override string ToString()
        {
            return $"Promotion {Nom} Eleves: {Eleves.Count}";
        }
    
    }
}
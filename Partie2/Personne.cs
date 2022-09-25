using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Partie2
{
    public class Personne
    {
        private string nom;
        private string prenom;
        private DateTime dateNaissance;

        public Personne(string nom,string prenom, DateTime dateNaissance){
            this.nom = nom;
            this.prenom = prenom;
            this.dateNaissance = dateNaissance;
        }

        
    }
}
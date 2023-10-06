using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dm_cinema
{
    internal class Acteur
    {
        private DateTime anneeNaissance;
        private int id;
        private string nom;
        private string prenom;

        public Acteur(DateTime anneeNaissance, int id, string nom, string prenom)
        {
            this.anneeNaissance = anneeNaissance;
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
        }
        public Acteur() { }

        public DateTime AnneeNaissance { get => anneeNaissance; set => anneeNaissance = value; }
        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }

        public Acteur getInstance(DateTime anneeNaissance, int id, string nom, string prenom)
        {
            Acteur nvActeur = new Acteur(anneeNaissance, id, nom, prenom);
            return nvActeur;
        }

        public override string ToString()
        {
            string affichage = "nom : " + nom + " prenom : " + prenom + " année de naissance : " + anneeNaissance.Day +"/" + anneeNaissance.Month + "/" + anneeNaissance.Year;
            return affichage;
        }
    }
}

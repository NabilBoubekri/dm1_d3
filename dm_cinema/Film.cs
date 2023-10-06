using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dm_cinema
{
    internal class Film
    {
        private int annee;
        private string genre;
        private int idFilm;
        private string resume;
        private string titre;
        private Acteur acteurPrincipal;

        public Film(int annee, string genre, int idFilm, string resume, string titre)
        {
            this.annee = annee;
            this.genre = genre;
            this.idFilm = idFilm;
            this.resume = resume;
            this.titre = titre;
        }

        public Film() { }

        public int Annee { get => annee; set => annee = value; }
        public string Genre { get => genre; set => genre = value; }
        public int IdFilm { get => idFilm; set => idFilm = value; }
        public string Resume { get => resume; set => resume = value; }
        public string Titre { get => titre; set => titre = value; }
        public Acteur ActeurPrincipal { get => acteurPrincipal; set => acteurPrincipal = value; }

        public Film getInstance(int annee, string genre, int idFilm, string resume, string titre)
        {
            Film nvFilm = new Film(annee, genre, idFilm, resume, titre);
            return nvFilm;
        }

        public override string ToString()
        {
            string affichage = "Titre : " + titre + "\nAnnée : " + annee + "\nGenre : " + genre + "\nRésumé : " + resume;
            return affichage;
        }

    }
}

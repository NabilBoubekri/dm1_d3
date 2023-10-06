using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dm_cinema
{
    internal class Cinema
    {
        private Cinema cine;
        private List<Acteur> lesActeurs;
        private List<Film> lesFilms;

        public Cinema()
        {
            this.lesActeurs= new List<Acteur>();
            this.lesFilms = new List<Film>();
        }

        internal List<Acteur> LesActeurs { get => lesActeurs; set => lesActeurs = value; }
        internal List<Film> LesFilms { get => lesFilms; set => lesFilms = value; }

        public Acteur GetActeur(int id)
        {
            Acteur bonActeur = new Acteur();
            foreach (Acteur unActeur in this.lesActeurs)
            {
                if( unActeur.Id == id)
                {
                    bonActeur = unActeur;
                }
            }
            return bonActeur;
        }
        public Film GetFilm(int id)
        {
            Film bonFilm = new Film();
            foreach(Film unFilm in this.lesFilms)
            {
                if(unFilm.IdFilm == id)
                {
                    bonFilm = unFilm;
                }
            }
            return bonFilm;
        }

        public void AjouterFilm(Film nvFilm)
        {
            lesFilms.Add(nvFilm);
        }

        public void AjouterActeur(Acteur nvActeur)
        {
            lesActeurs.Add(nvActeur);
        }

        public int NbFilm()
        {
            return lesFilms.Count;
        }

        public int NbActeur()
        {
            return lesActeurs.Count;
        }
    }
}

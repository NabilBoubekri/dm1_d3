// See https://aka.ms/new-console-template for more information
using dm_cinema;

DateTime date1 = new DateTime(1942, 06, 13);
DateTime date2 = new DateTime(1956, 07, 09);

Acteur a1 = new Acteur(date1, 1, "Ford", "Harisson");
Acteur a2 = new Acteur(date2, 2, "Hanks", "Tom");

Film f1 = new Film(1982, "Science-Fiction", 1, "L'action du film se situe à Los " +
    "Angeles en 2019 et met en scène Rick Deckard (interprété par Harrison Ford), un" +
    "ancien policier qui reprend du service pour traquer un groupe de réplicants, des " +
    "androïdes créés à l'image de l'Homme, menés par l'énigmatique Roy Batty " +
    "(interprété par Rutger Hauer).", "Blade Runner");

Film f2 = new Film(1992, "Animation", 2, "Le film met en scène un groupe de jouets." +
    " Woody, une poupée représentant un cow-boy, et Buzz l'Éclair, une figurine " +
    "d'astronaute, en sont les personnages principaux.", "Toy Story");
f1.ActeurPrincipal = a1;
f2.ActeurPrincipal = a2;

Cinema monCinema = new Cinema();
Console.WriteLine(f1.ToString() + "\n");
Console.WriteLine("Acteur principal "+ f1.Titre + ": " + f1.ActeurPrincipal.ToString() + "\n");

Console.WriteLine(f2.ToString() + "\n");
Console.WriteLine("Acteur principal de "+ f2.Titre +" : " + f2.ActeurPrincipal.ToString() + "\n");

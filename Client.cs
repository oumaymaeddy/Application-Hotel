﻿using System;
namespace ApplicationGrestion_Hotels
{
    class Client
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Courriel { get; set; }
        public string CarteCredit { get; set; }
        public int NumeroChambre { get; set; }

        public Client(string nom, string prenom, string courriel, string carteCredit, int numeroChambre)
        {
            Nom = nom;
            Prenom = prenom;
            Courriel = courriel;
            CarteCredit = carteCredit;
            NumeroChambre = numeroChambre;
        }
    }
}
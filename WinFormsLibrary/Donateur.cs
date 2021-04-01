using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsLibrary
{
    class Donateur : Personne
    {
        private string idDonateur;
        private string adresse;
        private string telephone;
        private string typeCarte;
        private string numeroCarte;
        private string dateExpiration;

        //  id d'incrementation pour avoir des id differents sans etres saisie par l'utilisateur
        static int idIncrement = 1;

        public Donateur(string prenom, string surnom, string adresse, string telephone, string typeCarte, string numeroCarte, string dateExpiration) : base(prenom, surnom)
        {
            this.idDonateur = "" + idIncrement++;
            this.adresse = adresse;
            this.telephone = telephone;
            this.typeCarte = typeCarte;
            this.numeroCarte = numeroCarte;
            this.dateExpiration = dateExpiration;
        }

        public override string ToString()
        {
            return this.idDonateur + " - " + base.ToString() + " -Adresse : " + this.adresse + " tel : " + this.telephone;
        }

        public string getIdDonateur()
        {
            return this.idDonateur;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsLibrary
{
    class Commanditaire : Personne
    {
        private string idCommanditaire;

        //  id d'incrementation pour avoir des id differents sans etres saisie par l'utilisateur
        static int idIncrement = 1;
        public Commanditaire(string prenom, string surnom) : base(prenom, surnom)
        {
            this.idCommanditaire = ""+ idIncrement++;
        }

        public override string ToString()
        {
            return this.idCommanditaire + " - " + base.ToString();
        }

        public string getIdCommanditaire()
        {
            return this.idCommanditaire;
        }
    }
}

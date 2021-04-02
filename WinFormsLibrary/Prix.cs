using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsLibrary
{
    class Prix
    {
        private string idPrix;
        private string description;
        private double valeur;

        private int qts_original;
        private int qts_disponible;
        private string idCommanditaire;

        //  id d'incrementation pour avoir des id differents sans etres saisie par l'utilisateur
        static int idIncrement = 1;

        public Prix(string description, double valeur, int qts_original, string idCommanditaire)
        {
            this.idPrix = "" + idIncrement++;
            this.description = description;
            this.valeur = valeur;
            this.qts_original = qts_original;
            this.qts_disponible = qts_original;
            this.idCommanditaire = idCommanditaire;
        }

        public override string ToString()
        {
            return "description : " + this.description + " valeur : " + this.valeur;
        }

        public void Deduire(int nombre)
        {
            this.qts_disponible -= nombre;
        }

        public string getIdPrix()
        {
            return this.idPrix;
        }
    }
}

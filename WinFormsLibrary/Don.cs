using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsLibrary
{
    class Don
    {
        private string idDon;
        private string dateDuDon;
        private string idDonateur;
        private double montantDuDon;

        //  id d'incrementation pour avoir des id differents sans etres saisie par l'utilisateur
        static int idIncrement = 1;

        public Don(string dateDuDon, double montantDuDon, string idDonateur)
        {
            this.idDon = "" + idIncrement++;
            this.dateDuDon = dateDuDon;
            this.montantDuDon = montantDuDon;
            this.idDonateur = idDonateur;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public string getIdDon()
        {
            return this.idDon;
        }
    }
}

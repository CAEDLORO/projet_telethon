using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsLibrary
{
    class Personne
    {
        private string prenom;
        private string surnom;

        public Personne(string prenom, string surnom)
        {
            this.prenom = prenom;
            this.surnom = surnom;
        }

        public override string ToString()
        {
            return this.prenom + " / " + this.surnom;
        }
    }
}

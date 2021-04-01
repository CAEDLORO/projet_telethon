using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsLibrary
{
    class GestionnaireSTE
    {
        public List<Donateur> donateurs;
        public List<Commanditaire> commanditaires;
        public List<Don> dons;
        public List<Prix> prix;

        public GestionnaireSTE()
        {
            this.donateurs = new List<Donateur>();
            this.commanditaires = new List<Commanditaire>();
            this.dons = new List<Don>();
            this.prix = new List<Prix>();
        }

        public void AjouterDonateur(string prenom, string surnom, string adresse, string telephone, string typeCarte, string numeroCarte, string dateExpiration)
        {
            donateurs.Add(new Donateur(prenom, surnom, adresse, telephone, typeCarte, numeroCarte, dateExpiration));
        }

        public void AjouterCommanditaire(string prenom, string surnom)
        {
            commanditaires.Add(new Commanditaire(prenom, surnom));
        }

        public void AjouterPrix(string description, double valeur, int qts_original, string idCommanditaire)
        {
            prix.Add(new Prix(description, valeur, qts_original, idCommanditaire));
        }

        public void AjouterDon(string dateDuDon, double montantDuDon, string idDonateur)
        {
            dons.Add(new Don(dateDuDon, montantDuDon, idDonateur));
        }

        public string AfficherDonateurs()
        {
            string affichage = "";
            for(int i =0; i < donateurs.Count; i++)
            {
                affichage += donateurs[i] + "\n";
            }
            return affichage;
        }

        public string AfficherCommanditaires()
        {
            string affichage = "";
            for (int i = 0; i < commanditaires.Count; i++)
            {
                affichage += commanditaires[i] + "\n";
            }
            return affichage;
        }

        public string AfficherPrix()
        {
            string affichage = "";
            for (int i = 0; i < prix.Count; i++)
            {
                affichage += prix[i] + "\n";
            }
            return affichage;
        }

        public string AfficherDons()
        {
            string affichage = "";
            for (int i = 0; i < dons.Count; i++)
            {
                affichage += dons[i] + "\n";
            }
            return affichage;
        }

        //changement du type de retour pour avoir quel prix a été attribuer au donateur
        public string AttribuerPrix(double montantDuDon)
        {
            int calculerPoints = 0;
            
            if (montantDuDon >= 500) { calculerPoints = 4 * (Convert.ToInt32(montantDuDon) % 500); }
            else if (montantDuDon >= 350) { calculerPoints = 3; }
            else if (montantDuDon >= 200) { calculerPoints = 2; }
            else if (montantDuDon >= 50) { calculerPoints = 1; }

            if (calculerPoints >= 12) { return "Tv attribuer a ce donateur"; }
            else if (calculerPoints >= 10) { return "BBQ attribuer a ce donateur"; }
            else if (calculerPoints >= 3) {  return "Repas pour deux attribuer a ce donateur"; }
            else if (calculerPoints >= 1) { return "calandrier attribuer a ce donateur"; }
            else { return "Aucun prix attribuer a ce donateur"; }
        }

        public Boolean isDonateurExiste(string id)
        {
            for (int i = 0; i < donateurs.Count; i++)
            {
                if (donateurs[i].getIdDonateur().Equals(id))
                {
                    return true;
                }
            }
            return false;
        }

        public Boolean isCommanditaireExiste(string id)
        {
            for (int i = 0; i < commanditaires.Count; i++)
            {
                if (commanditaires[i].getIdCommanditaire().Equals(id))
                {
                    return true;
                }
            }
            return false;
        }

        public Boolean isPrixExiste(string id)
        {
            for (int i = 0; i < prix.Count; i++)
            {
                if (prix[i].getIdPrix().Equals(id))
                {
                    return true;
                }
            }
            return false;
        }

        public Boolean isDonExiste(string id)
        {
            for (int i = 0; i < dons.Count; i++)
            {
                if (dons[i].getIdDon().Equals(id))
                {
                    return true;
                }
            }
            return false;
        }
    }
}

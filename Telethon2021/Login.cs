using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Telethon2021
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public object Response { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            string utilisateur = txt_Box_User.Text.Trim().ToLower(); 
            string motPasse = txt_Box_Pass.Text.Trim().ToLower();
            if (!String.IsNullOrEmpty(utilisateur) && !String.IsNullOrEmpty(motPasse))
            {
                if (utilisateur == "téléthon2021" && motPasse == "don@2021")
                {
                    this.Hide();
                    Accueil accueil = new Accueil();
                    accueil.Show();
                }
                else
                {
                    MessageBox.Show("Les informations saisies ne sont pas valides.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_Box_User.Text = String.Empty; 
                    txt_Box_Pass.Text = String.Empty;
                    txt_Box_User.Focus();
                }
            }
            else
            {
                MessageBox.Show("Vous devez saisir votre nom d'utilisateur et votre mot de passe.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Box_User.Focus();
            }
        }

        private void btn_Annuler_Click(object sender, EventArgs e)
        {
            DialogResult reponse = MessageBox.Show("Désirez-vous réellement quitter cette application ? ", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (reponse == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txt_Box_Pass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

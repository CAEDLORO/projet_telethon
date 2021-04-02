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
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void customizeDesign()
        {
            panelDonateur.Visible = false;
            panelCommanditaire.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelDonateur.Visible == true)
                panelDonateur.Visible = false;
            if (panelCommanditaire.Visible == true)
                panelCommanditaire.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        // Block Donnateur avec boutons déroulants

        private void btn_Donateur_Click(object sender, EventArgs e)
        {
            showSubMenu(panelDonateur);
        }

        private void InfoDonateur_Click(object sender, EventArgs e)
        {
            openChildForm(new InfoDonateurs());
            hideSubMenu();
        }

        private void btnModePaiement_Click(object sender, EventArgs e)
        {
            openChildForm(new ModePaiement());
            hideSubMenu();
        }

        private void btnAfficherDonateur_Click(object sender, EventArgs e)
        {
            openChildForm(new AfficherDonateur());
            hideSubMenu();
        }

        // Block Commanditaire avec boutons déroulants

        private void btnCommanditaire_Click(object sender, EventArgs e)
        {
            showSubMenu(panelCommanditaire);
        }

        private void btnInfoCommanditaire_Click(object sender, EventArgs e)
        {
            openChildForm(new InformationCommanditaire());
            hideSubMenu();
        }

        private void btnInfoPrix_Click(object sender, EventArgs e)
        {
            openChildForm(new InformationPrix());
            hideSubMenu();
        }

        private void btnAfficherCommanditaire_Click(object sender, EventArgs e)
        {
            openChildForm(new AfficherCommanditaire());
            hideSubMenu();
        }

        // Panel Fille

        private Form activeForm = null;

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelFille.Controls.Add(childForm);
            panelFille.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label_Heure.Text = DateTime.Now.ToLongTimeString();
            label_Date.Text = DateTime.Now.ToLongDateString();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DialogResult reponse = MessageBox.Show("Désirez-vous réellement quitter cette application ? ", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (reponse == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult reponse = MessageBox.Show("Désirez-vous réellement quitter cette application ? ", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (reponse == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}

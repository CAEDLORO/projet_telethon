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
            if (txt_Box_User.Text != "Utilisateur")
            {
                if (txt_Box_Pass.Text != "Mot de pass")
                {

                }
                else msgError("SVP entrer mot de pass");
            }
            else msgError("SVP entrer utilisateur");
        }
        private void msgError(string msg)
        {
            lab_ErrorMessage.Text = "   " + msg;
            lab_ErrorMessage.Visible = true;
        }
    }
}

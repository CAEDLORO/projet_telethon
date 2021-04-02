
namespace Telethon2021
{
    partial class InfoDonateurs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_InfoDonateur = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_InfoDonateur
            // 
            this.label_InfoDonateur.AutoSize = true;
            this.label_InfoDonateur.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_InfoDonateur.ForeColor = System.Drawing.Color.Navy;
            this.label_InfoDonateur.Location = new System.Drawing.Point(70, 12);
            this.label_InfoDonateur.Name = "label_InfoDonateur";
            this.label_InfoDonateur.Size = new System.Drawing.Size(278, 30);
            this.label_InfoDonateur.TabIndex = 0;
            this.label_InfoDonateur.Text = "Informations Donateur";
            // 
            // InfoDonateurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 350);
            this.Controls.Add(this.label_InfoDonateur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InfoDonateurs";
            this.Text = "InfoDonateurs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_InfoDonateur;
    }
}
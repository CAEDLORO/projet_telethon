
namespace Telethon2021
{
    partial class AfficherDonateur
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
            this.label_InfoDons = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label_InfoDons
            // 
            this.label_InfoDons.AutoSize = true;
            this.label_InfoDons.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_InfoDons.ForeColor = System.Drawing.Color.Navy;
            this.label_InfoDons.Location = new System.Drawing.Point(91, 12);
            this.label_InfoDons.Name = "label_InfoDons";
            this.label_InfoDons.Size = new System.Drawing.Size(276, 60);
            this.label_InfoDons.TabIndex = 5;
            this.label_InfoDons.Text = "Résumé des données \r\nsaisies donateur";
            this.label_InfoDons.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Location = new System.Drawing.Point(35, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 132);
            this.panel1.TabIndex = 6;
            // 
            // AfficherDonateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 350);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_InfoDons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AfficherDonateur";
            this.ShowIcon = false;
            this.Text = "AfficherDonateur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_InfoDons;
        private System.Windows.Forms.Panel panel1;
    }
}
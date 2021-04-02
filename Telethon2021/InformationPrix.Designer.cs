
namespace Telethon2021
{
    partial class InformationPrix
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
            this.SuspendLayout();
            // 
            // label_InfoDons
            // 
            this.label_InfoDons.AutoSize = true;
            this.label_InfoDons.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_InfoDons.ForeColor = System.Drawing.Color.Navy;
            this.label_InfoDons.Location = new System.Drawing.Point(113, 12);
            this.label_InfoDons.Name = "label_InfoDons";
            this.label_InfoDons.Size = new System.Drawing.Size(206, 30);
            this.label_InfoDons.TabIndex = 5;
            this.label_InfoDons.Text = "Informations Prix";
            // 
            // InformationPrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 350);
            this.Controls.Add(this.label_InfoDons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InformationPrix";
            this.ShowIcon = false;
            this.Text = "InformationPrix";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_InfoDons;
    }
}
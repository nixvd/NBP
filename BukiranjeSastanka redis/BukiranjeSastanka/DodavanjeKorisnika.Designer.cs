namespace BukiranjeSastanka
{
    partial class DodavanjeKorisnika
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
            this.korisnik1Label = new System.Windows.Forms.Label();
            this.korisnik2Label = new System.Windows.Forms.Label();
            this.korisnik3Label = new System.Windows.Forms.Label();
            this.korisnik1 = new System.Windows.Forms.ComboBox();
            this.korisnik2 = new System.Windows.Forms.ComboBox();
            this.korisnik3 = new System.Windows.Forms.ComboBox();
            this.dodajKorisnike = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // korisnik1Label
            // 
            this.korisnik1Label.AutoSize = true;
            this.korisnik1Label.Location = new System.Drawing.Point(35, 40);
            this.korisnik1Label.Name = "korisnik1Label";
            this.korisnik1Label.Size = new System.Drawing.Size(53, 13);
            this.korisnik1Label.TabIndex = 0;
            this.korisnik1Label.Text = "Korisnik 1:";
            // 
            // korisnik2Label
            // 
            this.korisnik2Label.AutoSize = true;
            this.korisnik2Label.Location = new System.Drawing.Point(35, 91);
            this.korisnik2Label.Name = "korisnik2Label";
            this.korisnik2Label.Size = new System.Drawing.Size(53, 13);
            this.korisnik2Label.TabIndex = 1;
            this.korisnik2Label.Text = "Korisnik 2:";
            // 
            // korisnik3Label
            // 
            this.korisnik3Label.AutoSize = true;
            this.korisnik3Label.Location = new System.Drawing.Point(35, 142);
            this.korisnik3Label.Name = "korisnik3Label";
            this.korisnik3Label.Size = new System.Drawing.Size(53, 13);
            this.korisnik3Label.TabIndex = 2;
            this.korisnik3Label.Text = "Korisnik 3:";
            // 
            // korisnik1
            // 
            this.korisnik1.FormattingEnabled = true;
            this.korisnik1.Location = new System.Drawing.Point(119, 37);
            this.korisnik1.Name = "korisnik1";
            this.korisnik1.Size = new System.Drawing.Size(161, 21);
            this.korisnik1.TabIndex = 3;
            // 
            // korisnik2
            // 
            this.korisnik2.FormattingEnabled = true;
            this.korisnik2.Location = new System.Drawing.Point(119, 88);
            this.korisnik2.Name = "korisnik2";
            this.korisnik2.Size = new System.Drawing.Size(161, 21);
            this.korisnik2.TabIndex = 4;
            // 
            // korisnik3
            // 
            this.korisnik3.FormattingEnabled = true;
            this.korisnik3.Location = new System.Drawing.Point(119, 139);
            this.korisnik3.Name = "korisnik3";
            this.korisnik3.Size = new System.Drawing.Size(161, 21);
            this.korisnik3.TabIndex = 5;
            // 
            // dodajKorisnike
            // 
            this.dodajKorisnike.Location = new System.Drawing.Point(205, 178);
            this.dodajKorisnike.Name = "dodajKorisnike";
            this.dodajKorisnike.Size = new System.Drawing.Size(75, 23);
            this.dodajKorisnike.TabIndex = 6;
            this.dodajKorisnike.Text = "Dodaj";
            this.dodajKorisnike.UseVisualStyleBackColor = true;
            this.dodajKorisnike.Click += new System.EventHandler(this.dodajKorisnike_Click);
            // 
            // DodavanjeKorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 222);
            this.Controls.Add(this.dodajKorisnike);
            this.Controls.Add(this.korisnik3);
            this.Controls.Add(this.korisnik2);
            this.Controls.Add(this.korisnik1);
            this.Controls.Add(this.korisnik3Label);
            this.Controls.Add(this.korisnik2Label);
            this.Controls.Add(this.korisnik1Label);
            this.Name = "DodavanjeKorisnika";
            this.Text = "Dodavanje korisnika";
            this.Load += new System.EventHandler(this.DodavanjeKorisnika_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label korisnik1Label;
        private System.Windows.Forms.Label korisnik2Label;
        private System.Windows.Forms.Label korisnik3Label;
        private System.Windows.Forms.ComboBox korisnik1;
        private System.Windows.Forms.ComboBox korisnik2;
        private System.Windows.Forms.ComboBox korisnik3;
        private System.Windows.Forms.Button dodajKorisnike;
    }
}
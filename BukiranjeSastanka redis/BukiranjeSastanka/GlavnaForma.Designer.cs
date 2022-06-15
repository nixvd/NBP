namespace BukiranjeSastanka
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.pKorisnikTab = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.pKorisnikDodaj = new System.Windows.Forms.Button();
            this.dodajBroj = new System.Windows.Forms.LinkLabel();
            this.dodajEmail = new System.Windows.Forms.LinkLabel();
            this.brTelTb1 = new System.Windows.Forms.TextBox();
            this.emailTb1 = new System.Windows.Forms.TextBox();
            this.prezimeTb = new System.Windows.Forms.TextBox();
            this.imeTb = new System.Windows.Forms.TextBox();
            this.brTelLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.prezimeLabel = new System.Windows.Forms.Label();
            this.imeLabel = new System.Windows.Forms.Label();
            this.pSastanakTab = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.pSastanakDodaj = new System.Windows.Forms.Button();
            this.comboBoxS = new System.Windows.Forms.ComboBox();
            this.mestoSTb = new System.Windows.Forms.TextBox();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.korisnikLabel = new System.Windows.Forms.Label();
            this.mestoSLabel = new System.Windows.Forms.Label();
            this.vremeSLabel = new System.Windows.Forms.Label();
            this.datumSLabel = new System.Windows.Forms.Label();
            this.pKonferencijaTab = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.pKonfDodaj = new System.Windows.Forms.Button();
            this.comboBoxK = new System.Windows.Forms.ComboBox();
            this.mestoKTb = new System.Windows.Forms.TextBox();
            this.timePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.tipKonfLabel = new System.Windows.Forms.Label();
            this.mestoKLabel = new System.Windows.Forms.Label();
            this.vremeKLabel = new System.Windows.Forms.Label();
            this.datumKLabel = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.pKorisnikTab.SuspendLayout();
            this.pSastanakTab.SuspendLayout();
            this.pKonferencijaTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.pKorisnikTab);
            this.tabControl.Controls.Add(this.pSastanakTab);
            this.tabControl.Controls.Add(this.pKonferencijaTab);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tabControl.Location = new System.Drawing.Point(12, 14);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(330, 387);
            this.tabControl.TabIndex = 0;
            // 
            // pKorisnikTab
            // 
            this.pKorisnikTab.Controls.Add(this.button1);
            this.pKorisnikTab.Controls.Add(this.pKorisnikDodaj);
            this.pKorisnikTab.Controls.Add(this.dodajBroj);
            this.pKorisnikTab.Controls.Add(this.dodajEmail);
            this.pKorisnikTab.Controls.Add(this.brTelTb1);
            this.pKorisnikTab.Controls.Add(this.emailTb1);
            this.pKorisnikTab.Controls.Add(this.prezimeTb);
            this.pKorisnikTab.Controls.Add(this.imeTb);
            this.pKorisnikTab.Controls.Add(this.brTelLabel);
            this.pKorisnikTab.Controls.Add(this.emailLabel);
            this.pKorisnikTab.Controls.Add(this.prezimeLabel);
            this.pKorisnikTab.Controls.Add(this.imeLabel);
            this.pKorisnikTab.Location = new System.Drawing.Point(4, 22);
            this.pKorisnikTab.Name = "pKorisnikTab";
            this.pKorisnikTab.Padding = new System.Windows.Forms.Padding(3);
            this.pKorisnikTab.Size = new System.Drawing.Size(322, 361);
            this.pKorisnikTab.TabIndex = 0;
            this.pKorisnikTab.Text = "Korisnik";
            this.pKorisnikTab.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Prikazi korisnike";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pKorisnikDodaj
            // 
            this.pKorisnikDodaj.Location = new System.Drawing.Point(193, 312);
            this.pKorisnikDodaj.Name = "pKorisnikDodaj";
            this.pKorisnikDodaj.Size = new System.Drawing.Size(91, 23);
            this.pKorisnikDodaj.TabIndex = 10;
            this.pKorisnikDodaj.Text = "Dodaj korisnika";
            this.pKorisnikDodaj.UseVisualStyleBackColor = true;
            this.pKorisnikDodaj.Click += new System.EventHandler(this.pKorisnikDodaj_Click);
            // 
            // dodajBroj
            // 
            this.dodajBroj.AutoSize = true;
            this.dodajBroj.Location = new System.Drawing.Point(138, 188);
            this.dodajBroj.Name = "dodajBroj";
            this.dodajBroj.Size = new System.Drawing.Size(35, 13);
            this.dodajBroj.TabIndex = 9;
            this.dodajBroj.TabStop = true;
            this.dodajBroj.Text = "Dodaj";
            this.dodajBroj.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.dodajBroj_LinkClicked_1);
            // 
            // dodajEmail
            // 
            this.dodajEmail.AutoSize = true;
            this.dodajEmail.Location = new System.Drawing.Point(138, 126);
            this.dodajEmail.Name = "dodajEmail";
            this.dodajEmail.Size = new System.Drawing.Size(35, 13);
            this.dodajEmail.TabIndex = 8;
            this.dodajEmail.TabStop = true;
            this.dodajEmail.Text = "Dodaj";
            this.dodajEmail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.dodajBroj_LinkClicked);
            // 
            // brTelTb1
            // 
            this.brTelTb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.brTelTb1.Location = new System.Drawing.Point(141, 165);
            this.brTelTb1.Name = "brTelTb1";
            this.brTelTb1.Size = new System.Drawing.Size(143, 20);
            this.brTelTb1.TabIndex = 7;
            // 
            // emailTb1
            // 
            this.emailTb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.emailTb1.Location = new System.Drawing.Point(141, 103);
            this.emailTb1.Name = "emailTb1";
            this.emailTb1.Size = new System.Drawing.Size(143, 20);
            this.emailTb1.TabIndex = 6;
            // 
            // prezimeTb
            // 
            this.prezimeTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.prezimeTb.Location = new System.Drawing.Point(141, 64);
            this.prezimeTb.Name = "prezimeTb";
            this.prezimeTb.Size = new System.Drawing.Size(143, 20);
            this.prezimeTb.TabIndex = 5;
            // 
            // imeTb
            // 
            this.imeTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.imeTb.Location = new System.Drawing.Point(141, 28);
            this.imeTb.Name = "imeTb";
            this.imeTb.Size = new System.Drawing.Size(143, 20);
            this.imeTb.TabIndex = 4;
            // 
            // brTelLabel
            // 
            this.brTelLabel.AutoSize = true;
            this.brTelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brTelLabel.Location = new System.Drawing.Point(26, 165);
            this.brTelLabel.Name = "brTelLabel";
            this.brTelLabel.Size = new System.Drawing.Size(92, 17);
            this.brTelLabel.TabIndex = 3;
            this.brTelLabel.Text = "Broj telefona:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(26, 103);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(46, 17);
            this.emailLabel.TabIndex = 2;
            this.emailLabel.Text = "Email:";
            // 
            // prezimeLabel
            // 
            this.prezimeLabel.AutoSize = true;
            this.prezimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prezimeLabel.Location = new System.Drawing.Point(26, 64);
            this.prezimeLabel.Name = "prezimeLabel";
            this.prezimeLabel.Size = new System.Drawing.Size(63, 17);
            this.prezimeLabel.TabIndex = 1;
            this.prezimeLabel.Text = "Prezime:";
            // 
            // imeLabel
            // 
            this.imeLabel.AutoSize = true;
            this.imeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imeLabel.Location = new System.Drawing.Point(26, 28);
            this.imeLabel.Name = "imeLabel";
            this.imeLabel.Size = new System.Drawing.Size(34, 17);
            this.imeLabel.TabIndex = 0;
            this.imeLabel.Text = "Ime:";
            // 
            // pSastanakTab
            // 
            this.pSastanakTab.Controls.Add(this.button2);
            this.pSastanakTab.Controls.Add(this.pSastanakDodaj);
            this.pSastanakTab.Controls.Add(this.comboBoxS);
            this.pSastanakTab.Controls.Add(this.mestoSTb);
            this.pSastanakTab.Controls.Add(this.timePicker);
            this.pSastanakTab.Controls.Add(this.dateTimePicker);
            this.pSastanakTab.Controls.Add(this.korisnikLabel);
            this.pSastanakTab.Controls.Add(this.mestoSLabel);
            this.pSastanakTab.Controls.Add(this.vremeSLabel);
            this.pSastanakTab.Controls.Add(this.datumSLabel);
            this.pSastanakTab.Location = new System.Drawing.Point(4, 22);
            this.pSastanakTab.Name = "pSastanakTab";
            this.pSastanakTab.Padding = new System.Windows.Forms.Padding(3);
            this.pSastanakTab.Size = new System.Drawing.Size(322, 361);
            this.pSastanakTab.TabIndex = 1;
            this.pSastanakTab.Text = "Sastanak";
            this.pSastanakTab.UseVisualStyleBackColor = true;
            this.pSastanakTab.Click += new System.EventHandler(this.pSastanakTab_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(25, 307);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Prikazi sastanke";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pSastanakDodaj
            // 
            this.pSastanakDodaj.Location = new System.Drawing.Point(200, 307);
            this.pSastanakDodaj.Name = "pSastanakDodaj";
            this.pSastanakDodaj.Size = new System.Drawing.Size(104, 23);
            this.pSastanakDodaj.TabIndex = 8;
            this.pSastanakDodaj.Text = "Dodaj sastanak";
            this.pSastanakDodaj.UseVisualStyleBackColor = true;
            this.pSastanakDodaj.Click += new System.EventHandler(this.pSastanakDodaj_Click);
            // 
            // comboBoxS
            // 
            this.comboBoxS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.comboBoxS.FormattingEnabled = true;
            this.comboBoxS.Items.AddRange(new object[] {
            "Probni korisnik"});
            this.comboBoxS.Location = new System.Drawing.Point(145, 161);
            this.comboBoxS.Name = "comboBoxS";
            this.comboBoxS.Size = new System.Drawing.Size(159, 21);
            this.comboBoxS.TabIndex = 7;
            // 
            // mestoSTb
            // 
            this.mestoSTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.mestoSTb.Location = new System.Drawing.Point(145, 117);
            this.mestoSTb.Name = "mestoSTb";
            this.mestoSTb.Size = new System.Drawing.Size(159, 20);
            this.mestoSTb.TabIndex = 6;
            // 
            // timePicker
            // 
            this.timePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timePicker.Location = new System.Drawing.Point(145, 72);
            this.timePicker.Name = "timePicker";
            this.timePicker.Size = new System.Drawing.Size(159, 20);
            this.timePicker.TabIndex = 5;
            this.timePicker.ValueChanged += new System.EventHandler(this.timePicker_ValueChanged);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Location = new System.Drawing.Point(145, 35);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(159, 20);
            this.dateTimePicker.TabIndex = 4;
            this.dateTimePicker.Value = new System.DateTime(2017, 1, 25, 0, 55, 2, 0);
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // korisnikLabel
            // 
            this.korisnikLabel.AutoSize = true;
            this.korisnikLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.korisnikLabel.Location = new System.Drawing.Point(22, 165);
            this.korisnikLabel.Name = "korisnikLabel";
            this.korisnikLabel.Size = new System.Drawing.Size(62, 17);
            this.korisnikLabel.TabIndex = 3;
            this.korisnikLabel.Text = "Korisnik:";
            // 
            // mestoSLabel
            // 
            this.mestoSLabel.AutoSize = true;
            this.mestoSLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mestoSLabel.Location = new System.Drawing.Point(22, 121);
            this.mestoSLabel.Name = "mestoSLabel";
            this.mestoSLabel.Size = new System.Drawing.Size(50, 17);
            this.mestoSLabel.TabIndex = 2;
            this.mestoSLabel.Text = "Mesto:";
            // 
            // vremeSLabel
            // 
            this.vremeSLabel.AutoSize = true;
            this.vremeSLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vremeSLabel.Location = new System.Drawing.Point(22, 79);
            this.vremeSLabel.Name = "vremeSLabel";
            this.vremeSLabel.Size = new System.Drawing.Size(53, 17);
            this.vremeSLabel.TabIndex = 1;
            this.vremeSLabel.Text = "Vreme:";
            // 
            // datumSLabel
            // 
            this.datumSLabel.AutoSize = true;
            this.datumSLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datumSLabel.Location = new System.Drawing.Point(22, 42);
            this.datumSLabel.Name = "datumSLabel";
            this.datumSLabel.Size = new System.Drawing.Size(53, 17);
            this.datumSLabel.TabIndex = 0;
            this.datumSLabel.Text = "Datum:";
            // 
            // pKonferencijaTab
            // 
            this.pKonferencijaTab.Controls.Add(this.button3);
            this.pKonferencijaTab.Controls.Add(this.pKonfDodaj);
            this.pKonferencijaTab.Controls.Add(this.comboBoxK);
            this.pKonferencijaTab.Controls.Add(this.mestoKTb);
            this.pKonferencijaTab.Controls.Add(this.timePicker2);
            this.pKonferencijaTab.Controls.Add(this.dateTimePicker2);
            this.pKonferencijaTab.Controls.Add(this.tipKonfLabel);
            this.pKonferencijaTab.Controls.Add(this.mestoKLabel);
            this.pKonferencijaTab.Controls.Add(this.vremeKLabel);
            this.pKonferencijaTab.Controls.Add(this.datumKLabel);
            this.pKonferencijaTab.Location = new System.Drawing.Point(4, 22);
            this.pKonferencijaTab.Name = "pKonferencijaTab";
            this.pKonferencijaTab.Padding = new System.Windows.Forms.Padding(3);
            this.pKonferencijaTab.Size = new System.Drawing.Size(322, 361);
            this.pKonferencijaTab.TabIndex = 2;
            this.pKonferencijaTab.Text = "Konferencija";
            this.pKonferencijaTab.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(23, 305);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "Prikazi konferencije";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pKonfDodaj
            // 
            this.pKonfDodaj.Location = new System.Drawing.Point(198, 305);
            this.pKonfDodaj.Name = "pKonfDodaj";
            this.pKonfDodaj.Size = new System.Drawing.Size(104, 23);
            this.pKonfDodaj.TabIndex = 17;
            this.pKonfDodaj.Text = "Dodaj konferenciju";
            this.pKonfDodaj.UseVisualStyleBackColor = true;
            this.pKonfDodaj.Click += new System.EventHandler(this.pKonfDodaj_Click);
            // 
            // comboBoxK
            // 
            this.comboBoxK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.comboBoxK.FormattingEnabled = true;
            this.comboBoxK.Items.AddRange(new object[] {
            "Video konferencija",
            "Press konferencija",
            "Prezentacija"});
            this.comboBoxK.Location = new System.Drawing.Point(143, 159);
            this.comboBoxK.Name = "comboBoxK";
            this.comboBoxK.Size = new System.Drawing.Size(159, 21);
            this.comboBoxK.TabIndex = 16;
            // 
            // mestoKTb
            // 
            this.mestoKTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.mestoKTb.Location = new System.Drawing.Point(143, 115);
            this.mestoKTb.Name = "mestoKTb";
            this.mestoKTb.Size = new System.Drawing.Size(159, 20);
            this.mestoKTb.TabIndex = 15;
            // 
            // timePicker2
            // 
            this.timePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timePicker2.Location = new System.Drawing.Point(143, 70);
            this.timePicker2.Name = "timePicker2";
            this.timePicker2.Size = new System.Drawing.Size(159, 20);
            this.timePicker2.TabIndex = 14;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(143, 33);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(159, 20);
            this.dateTimePicker2.TabIndex = 13;
            this.dateTimePicker2.Value = new System.DateTime(2017, 1, 25, 0, 55, 2, 0);
            // 
            // tipKonfLabel
            // 
            this.tipKonfLabel.AutoSize = true;
            this.tipKonfLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipKonfLabel.Location = new System.Drawing.Point(20, 163);
            this.tipKonfLabel.Name = "tipKonfLabel";
            this.tipKonfLabel.Size = new System.Drawing.Size(32, 17);
            this.tipKonfLabel.TabIndex = 12;
            this.tipKonfLabel.Text = "Tip:";
            // 
            // mestoKLabel
            // 
            this.mestoKLabel.AutoSize = true;
            this.mestoKLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mestoKLabel.Location = new System.Drawing.Point(20, 119);
            this.mestoKLabel.Name = "mestoKLabel";
            this.mestoKLabel.Size = new System.Drawing.Size(50, 17);
            this.mestoKLabel.TabIndex = 11;
            this.mestoKLabel.Text = "Mesto:";
            // 
            // vremeKLabel
            // 
            this.vremeKLabel.AutoSize = true;
            this.vremeKLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vremeKLabel.Location = new System.Drawing.Point(20, 77);
            this.vremeKLabel.Name = "vremeKLabel";
            this.vremeKLabel.Size = new System.Drawing.Size(53, 17);
            this.vremeKLabel.TabIndex = 10;
            this.vremeKLabel.Text = "Vreme:";
            // 
            // datumKLabel
            // 
            this.datumKLabel.AutoSize = true;
            this.datumKLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datumKLabel.Location = new System.Drawing.Point(20, 40);
            this.datumKLabel.Name = "datumKLabel";
            this.datumKLabel.Size = new System.Drawing.Size(53, 17);
            this.datumKLabel.TabIndex = 9;
            this.datumKLabel.Text = "Datum:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(357, 413);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Zakazivanje Sastanka";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.pKorisnikTab.ResumeLayout(false);
            this.pKorisnikTab.PerformLayout();
            this.pSastanakTab.ResumeLayout(false);
            this.pSastanakTab.PerformLayout();
            this.pKonferencijaTab.ResumeLayout(false);
            this.pKonferencijaTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage pKorisnikTab;
        private System.Windows.Forms.TabPage pSastanakTab;
        private System.Windows.Forms.TabPage pKonferencijaTab;
        private System.Windows.Forms.LinkLabel dodajEmail;
        private System.Windows.Forms.TextBox brTelTb1;
        private System.Windows.Forms.TextBox emailTb1;
        private System.Windows.Forms.TextBox prezimeTb;
        private System.Windows.Forms.TextBox imeTb;
        private System.Windows.Forms.Label brTelLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label prezimeLabel;
        private System.Windows.Forms.Label imeLabel;
        private System.Windows.Forms.LinkLabel dodajBroj;
        private System.Windows.Forms.Button pKorisnikDodaj;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label korisnikLabel;
        private System.Windows.Forms.Label mestoSLabel;
        private System.Windows.Forms.Label vremeSLabel;
        private System.Windows.Forms.Label datumSLabel;
        private System.Windows.Forms.ComboBox comboBoxS;
        private System.Windows.Forms.TextBox mestoSTb;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.Button pSastanakDodaj;
        private System.Windows.Forms.Button pKonfDodaj;
        private System.Windows.Forms.ComboBox comboBoxK;
        private System.Windows.Forms.TextBox mestoKTb;
        private System.Windows.Forms.DateTimePicker timePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label tipKonfLabel;
        private System.Windows.Forms.Label mestoKLabel;
        private System.Windows.Forms.Label vremeKLabel;
        private System.Windows.Forms.Label datumKLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}


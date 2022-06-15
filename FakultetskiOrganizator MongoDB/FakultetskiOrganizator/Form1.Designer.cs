namespace FakultetskiOrganizator
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.studentTab = new System.Windows.Forms.TabPage();
            this.pregledStudenata = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dodajStudenta = new System.Windows.Forms.Button();
            this.tbListaPredmeta = new System.Windows.Forms.TextBox();
            this.listaPredmetaLabel = new System.Windows.Forms.Label();
            this.tbListaOcena = new System.Windows.Forms.TextBox();
            this.tbBrInd = new System.Windows.Forms.TextBox();
            this.tbPrezStudenta = new System.Windows.Forms.TextBox();
            this.tbImeStudenta = new System.Windows.Forms.TextBox();
            this.listaOcenaLabel = new System.Windows.Forms.Label();
            this.brojIndLabel = new System.Windows.Forms.Label();
            this.prezimeLabel = new System.Windows.Forms.Label();
            this.imeLabel = new System.Windows.Forms.Label();
            this.profesorTab = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dodajP = new System.Windows.Forms.Button();
            this.pPredmeti = new System.Windows.Forms.TextBox();
            this.pPrezime = new System.Windows.Forms.TextBox();
            this.pIme = new System.Windows.Forms.TextBox();
            this.label3p = new System.Windows.Forms.Label();
            this.label2p = new System.Windows.Forms.Label();
            this.label1p = new System.Windows.Forms.Label();
            this.predmetTab = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.comboEspb = new System.Windows.Forms.ComboBox();
            this.dodajPredmet = new System.Windows.Forms.Button();
            this.tbAsistent = new System.Windows.Forms.TextBox();
            this.asistentLabel = new System.Windows.Forms.Label();
            this.tbProfesor = new System.Windows.Forms.TextBox();
            this.tbNaziv = new System.Windows.Forms.TextBox();
            this.profesorLabel = new System.Windows.Forms.Label();
            this.espbLabel = new System.Windows.Forms.Label();
            this.nazivLabel = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.rez = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.predmetT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.indexT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.studentTab.SuspendLayout();
            this.profesorTab.SuspendLayout();
            this.predmetTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.studentTab);
            this.tabControl1.Controls.Add(this.profesorTab);
            this.tabControl1.Controls.Add(this.predmetTab);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(333, 380);
            this.tabControl1.TabIndex = 0;
            // 
            // studentTab
            // 
            this.studentTab.Controls.Add(this.pregledStudenata);
            this.studentTab.Controls.Add(this.label1);
            this.studentTab.Controls.Add(this.dodajStudenta);
            this.studentTab.Controls.Add(this.tbListaPredmeta);
            this.studentTab.Controls.Add(this.listaPredmetaLabel);
            this.studentTab.Controls.Add(this.tbListaOcena);
            this.studentTab.Controls.Add(this.tbBrInd);
            this.studentTab.Controls.Add(this.tbPrezStudenta);
            this.studentTab.Controls.Add(this.tbImeStudenta);
            this.studentTab.Controls.Add(this.listaOcenaLabel);
            this.studentTab.Controls.Add(this.brojIndLabel);
            this.studentTab.Controls.Add(this.prezimeLabel);
            this.studentTab.Controls.Add(this.imeLabel);
            this.studentTab.Location = new System.Drawing.Point(4, 22);
            this.studentTab.Name = "studentTab";
            this.studentTab.Padding = new System.Windows.Forms.Padding(3);
            this.studentTab.Size = new System.Drawing.Size(325, 354);
            this.studentTab.TabIndex = 0;
            this.studentTab.Text = "Student";
            this.studentTab.UseVisualStyleBackColor = true;
            // 
            // pregledStudenata
            // 
            this.pregledStudenata.Location = new System.Drawing.Point(23, 279);
            this.pregledStudenata.Name = "pregledStudenata";
            this.pregledStudenata.Size = new System.Drawing.Size(106, 23);
            this.pregledStudenata.TabIndex = 20;
            this.pregledStudenata.Text = "Pregled studenata";
            this.pregledStudenata.UseVisualStyleBackColor = true;
            this.pregledStudenata.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Zarezom odvojite ocene i predmete.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dodajStudenta
            // 
            this.dodajStudenta.Location = new System.Drawing.Point(201, 279);
            this.dodajStudenta.Name = "dodajStudenta";
            this.dodajStudenta.Size = new System.Drawing.Size(98, 23);
            this.dodajStudenta.TabIndex = 10;
            this.dodajStudenta.Text = "Dodaj studenta";
            this.dodajStudenta.UseVisualStyleBackColor = true;
            this.dodajStudenta.Click += new System.EventHandler(this.dodajStudenta_Click);
            // 
            // tbListaPredmeta
            // 
            this.tbListaPredmeta.Location = new System.Drawing.Point(148, 196);
            this.tbListaPredmeta.Multiline = true;
            this.tbListaPredmeta.Name = "tbListaPredmeta";
            this.tbListaPredmeta.Size = new System.Drawing.Size(151, 47);
            this.tbListaPredmeta.TabIndex = 9;
            // 
            // listaPredmetaLabel
            // 
            this.listaPredmetaLabel.AutoSize = true;
            this.listaPredmetaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaPredmetaLabel.Location = new System.Drawing.Point(20, 195);
            this.listaPredmetaLabel.Name = "listaPredmetaLabel";
            this.listaPredmetaLabel.Size = new System.Drawing.Size(109, 18);
            this.listaPredmetaLabel.TabIndex = 8;
            this.listaPredmetaLabel.Text = "Lista predmeta:";
            // 
            // tbListaOcena
            // 
            this.tbListaOcena.Location = new System.Drawing.Point(148, 143);
            this.tbListaOcena.Multiline = true;
            this.tbListaOcena.Name = "tbListaOcena";
            this.tbListaOcena.Size = new System.Drawing.Size(151, 47);
            this.tbListaOcena.TabIndex = 7;
            // 
            // tbBrInd
            // 
            this.tbBrInd.Location = new System.Drawing.Point(148, 94);
            this.tbBrInd.Name = "tbBrInd";
            this.tbBrInd.Size = new System.Drawing.Size(151, 20);
            this.tbBrInd.TabIndex = 6;
            // 
            // tbPrezStudenta
            // 
            this.tbPrezStudenta.Location = new System.Drawing.Point(148, 68);
            this.tbPrezStudenta.Name = "tbPrezStudenta";
            this.tbPrezStudenta.Size = new System.Drawing.Size(151, 20);
            this.tbPrezStudenta.TabIndex = 5;
            // 
            // tbImeStudenta
            // 
            this.tbImeStudenta.Location = new System.Drawing.Point(148, 42);
            this.tbImeStudenta.Name = "tbImeStudenta";
            this.tbImeStudenta.Size = new System.Drawing.Size(151, 20);
            this.tbImeStudenta.TabIndex = 4;
            // 
            // listaOcenaLabel
            // 
            this.listaOcenaLabel.AutoSize = true;
            this.listaOcenaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaOcenaLabel.Location = new System.Drawing.Point(41, 142);
            this.listaOcenaLabel.Name = "listaOcenaLabel";
            this.listaOcenaLabel.Size = new System.Drawing.Size(88, 18);
            this.listaOcenaLabel.TabIndex = 3;
            this.listaOcenaLabel.Text = "Lista ocena:";
            this.listaOcenaLabel.Click += new System.EventHandler(this.listaOcenaLabel_Click);
            // 
            // brojIndLabel
            // 
            this.brojIndLabel.AutoSize = true;
            this.brojIndLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brojIndLabel.Location = new System.Drawing.Point(35, 93);
            this.brojIndLabel.Name = "brojIndLabel";
            this.brojIndLabel.Size = new System.Drawing.Size(94, 18);
            this.brojIndLabel.TabIndex = 2;
            this.brojIndLabel.Text = "Broj indeksa:";
            // 
            // prezimeLabel
            // 
            this.prezimeLabel.AutoSize = true;
            this.prezimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prezimeLabel.Location = new System.Drawing.Point(62, 67);
            this.prezimeLabel.Name = "prezimeLabel";
            this.prezimeLabel.Size = new System.Drawing.Size(67, 18);
            this.prezimeLabel.TabIndex = 1;
            this.prezimeLabel.Text = "Prezime:";
            // 
            // imeLabel
            // 
            this.imeLabel.AutoSize = true;
            this.imeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imeLabel.Location = new System.Drawing.Point(93, 41);
            this.imeLabel.Name = "imeLabel";
            this.imeLabel.Size = new System.Drawing.Size(36, 18);
            this.imeLabel.TabIndex = 0;
            this.imeLabel.Text = "Ime:";
            this.imeLabel.Click += new System.EventHandler(this.imeLabel_Click);
            // 
            // profesorTab
            // 
            this.profesorTab.Controls.Add(this.button2);
            this.profesorTab.Controls.Add(this.label2);
            this.profesorTab.Controls.Add(this.dodajP);
            this.profesorTab.Controls.Add(this.pPredmeti);
            this.profesorTab.Controls.Add(this.pPrezime);
            this.profesorTab.Controls.Add(this.pIme);
            this.profesorTab.Controls.Add(this.label3p);
            this.profesorTab.Controls.Add(this.label2p);
            this.profesorTab.Controls.Add(this.label1p);
            this.profesorTab.Location = new System.Drawing.Point(4, 22);
            this.profesorTab.Name = "profesorTab";
            this.profesorTab.Padding = new System.Windows.Forms.Padding(3);
            this.profesorTab.Size = new System.Drawing.Size(325, 354);
            this.profesorTab.TabIndex = 1;
            this.profesorTab.Text = "Profesor";
            this.profesorTab.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(23, 197);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Pregled profesora";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(62, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Zarezom odvojite ocene i predmete.";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dodajP
            // 
            this.dodajP.Location = new System.Drawing.Point(209, 197);
            this.dodajP.Name = "dodajP";
            this.dodajP.Size = new System.Drawing.Size(98, 23);
            this.dodajP.TabIndex = 20;
            this.dodajP.Text = "Dodaj profesora";
            this.dodajP.UseVisualStyleBackColor = true;
            this.dodajP.Click += new System.EventHandler(this.dodajP_Click);
            // 
            // pPredmeti
            // 
            this.pPredmeti.Location = new System.Drawing.Point(156, 122);
            this.pPredmeti.Multiline = true;
            this.pPredmeti.Name = "pPredmeti";
            this.pPredmeti.Size = new System.Drawing.Size(151, 47);
            this.pPredmeti.TabIndex = 19;
            // 
            // pPrezime
            // 
            this.pPrezime.Location = new System.Drawing.Point(156, 70);
            this.pPrezime.Name = "pPrezime";
            this.pPrezime.Size = new System.Drawing.Size(151, 20);
            this.pPrezime.TabIndex = 18;
            // 
            // pIme
            // 
            this.pIme.Location = new System.Drawing.Point(156, 44);
            this.pIme.Name = "pIme";
            this.pIme.Size = new System.Drawing.Size(151, 20);
            this.pIme.TabIndex = 17;
            // 
            // label3p
            // 
            this.label3p.AutoSize = true;
            this.label3p.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3p.Location = new System.Drawing.Point(20, 121);
            this.label3p.Name = "label3p";
            this.label3p.Size = new System.Drawing.Size(109, 18);
            this.label3p.TabIndex = 16;
            this.label3p.Text = "Lista predmeta:";
            // 
            // label2p
            // 
            this.label2p.AutoSize = true;
            this.label2p.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2p.Location = new System.Drawing.Point(62, 69);
            this.label2p.Name = "label2p";
            this.label2p.Size = new System.Drawing.Size(67, 18);
            this.label2p.TabIndex = 15;
            this.label2p.Text = "Prezime:";
            // 
            // label1p
            // 
            this.label1p.AutoSize = true;
            this.label1p.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1p.Location = new System.Drawing.Point(93, 43);
            this.label1p.Name = "label1p";
            this.label1p.Size = new System.Drawing.Size(36, 18);
            this.label1p.TabIndex = 14;
            this.label1p.Text = "Ime:";
            // 
            // predmetTab
            // 
            this.predmetTab.Controls.Add(this.button1);
            this.predmetTab.Controls.Add(this.comboEspb);
            this.predmetTab.Controls.Add(this.dodajPredmet);
            this.predmetTab.Controls.Add(this.tbAsistent);
            this.predmetTab.Controls.Add(this.asistentLabel);
            this.predmetTab.Controls.Add(this.tbProfesor);
            this.predmetTab.Controls.Add(this.tbNaziv);
            this.predmetTab.Controls.Add(this.profesorLabel);
            this.predmetTab.Controls.Add(this.espbLabel);
            this.predmetTab.Controls.Add(this.nazivLabel);
            this.predmetTab.Location = new System.Drawing.Point(4, 22);
            this.predmetTab.Name = "predmetTab";
            this.predmetTab.Padding = new System.Windows.Forms.Padding(3);
            this.predmetTab.Size = new System.Drawing.Size(325, 354);
            this.predmetTab.TabIndex = 2;
            this.predmetTab.Text = "Predmet";
            this.predmetTab.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Pregled predmeta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboEspb
            // 
            this.comboEspb.FormattingEnabled = true;
            this.comboEspb.Items.AddRange(new object[] {
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.comboEspb.Location = new System.Drawing.Point(155, 76);
            this.comboEspb.Name = "comboEspb";
            this.comboEspb.Size = new System.Drawing.Size(42, 21);
            this.comboEspb.TabIndex = 18;
            // 
            // dodajPredmet
            // 
            this.dodajPredmet.Location = new System.Drawing.Point(208, 250);
            this.dodajPredmet.Name = "dodajPredmet";
            this.dodajPredmet.Size = new System.Drawing.Size(98, 23);
            this.dodajPredmet.TabIndex = 17;
            this.dodajPredmet.Text = "Dodaj predmet";
            this.dodajPredmet.UseVisualStyleBackColor = true;
            this.dodajPredmet.Click += new System.EventHandler(this.dodajPredmet_Click);
            // 
            // tbAsistent
            // 
            this.tbAsistent.Location = new System.Drawing.Point(155, 124);
            this.tbAsistent.Name = "tbAsistent";
            this.tbAsistent.Size = new System.Drawing.Size(151, 20);
            this.tbAsistent.TabIndex = 15;
            // 
            // asistentLabel
            // 
            this.asistentLabel.AutoSize = true;
            this.asistentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asistentLabel.Location = new System.Drawing.Point(78, 123);
            this.asistentLabel.Name = "asistentLabel";
            this.asistentLabel.Size = new System.Drawing.Size(64, 18);
            this.asistentLabel.TabIndex = 13;
            this.asistentLabel.Text = "Asistent:";
            this.asistentLabel.Click += new System.EventHandler(this.asistentLabel_Click);
            // 
            // tbProfesor
            // 
            this.tbProfesor.Location = new System.Drawing.Point(155, 202);
            this.tbProfesor.Name = "tbProfesor";
            this.tbProfesor.Size = new System.Drawing.Size(151, 20);
            this.tbProfesor.TabIndex = 12;
            // 
            // tbNaziv
            // 
            this.tbNaziv.Location = new System.Drawing.Point(155, 38);
            this.tbNaziv.Name = "tbNaziv";
            this.tbNaziv.Size = new System.Drawing.Size(151, 20);
            this.tbNaziv.TabIndex = 10;
            // 
            // profesorLabel
            // 
            this.profesorLabel.AutoSize = true;
            this.profesorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profesorLabel.Location = new System.Drawing.Point(72, 201);
            this.profesorLabel.Name = "profesorLabel";
            this.profesorLabel.Size = new System.Drawing.Size(70, 18);
            this.profesorLabel.TabIndex = 9;
            this.profesorLabel.Text = "Profesor:";
            this.profesorLabel.Click += new System.EventHandler(this.profesorLabel_Click);
            // 
            // espbLabel
            // 
            this.espbLabel.AutoSize = true;
            this.espbLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.espbLabel.Location = new System.Drawing.Point(50, 75);
            this.espbLabel.Name = "espbLabel";
            this.espbLabel.Size = new System.Drawing.Size(92, 18);
            this.espbLabel.TabIndex = 8;
            this.espbLabel.Text = "Broj bodova:";
            // 
            // nazivLabel
            // 
            this.nazivLabel.AutoSize = true;
            this.nazivLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nazivLabel.Location = new System.Drawing.Point(27, 37);
            this.nazivLabel.Name = "nazivLabel";
            this.nazivLabel.Size = new System.Drawing.Size(115, 18);
            this.nazivLabel.TabIndex = 7;
            this.nazivLabel.Text = "Naziv predmeta:";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.rez);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(325, 354);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Opcije";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 36);
            this.label5.TabIndex = 21;
            this.label5.Text = "Upisani predmeti\r\ni profesori";
            // 
            // rez
            // 
            this.rez.Location = new System.Drawing.Point(137, 173);
            this.rez.Multiline = true;
            this.rez.Name = "rez";
            this.rez.Size = new System.Drawing.Size(185, 178);
            this.rez.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.predmetT);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.indexT);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(3, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 140);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Upis studenta";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(187, 111);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "Upisi studenta";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // predmetT
            // 
            this.predmetT.Location = new System.Drawing.Point(134, 71);
            this.predmetT.Name = "predmetT";
            this.predmetT.Size = new System.Drawing.Size(151, 20);
            this.predmetT.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Naziv predmeta:";
            // 
            // indexT
            // 
            this.indexT.Location = new System.Drawing.Point(134, 34);
            this.indexT.Name = "indexT";
            this.indexT.Size = new System.Drawing.Size(151, 20);
            this.indexT.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Broj indeksa:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 411);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Organizacija fakulteta";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.tabControl1.ResumeLayout(false);
            this.studentTab.ResumeLayout(false);
            this.studentTab.PerformLayout();
            this.profesorTab.ResumeLayout(false);
            this.profesorTab.PerformLayout();
            this.predmetTab.ResumeLayout(false);
            this.predmetTab.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage studentTab;
        private System.Windows.Forms.Label imeLabel;
        private System.Windows.Forms.TabPage profesorTab;
        private System.Windows.Forms.TabPage predmetTab;
        private System.Windows.Forms.Label listaOcenaLabel;
        private System.Windows.Forms.Label brojIndLabel;
        private System.Windows.Forms.Label prezimeLabel;
        private System.Windows.Forms.TextBox tbListaOcena;
        private System.Windows.Forms.TextBox tbBrInd;
        private System.Windows.Forms.TextBox tbPrezStudenta;
        private System.Windows.Forms.TextBox tbImeStudenta;
        private System.Windows.Forms.TextBox tbListaPredmeta;
        private System.Windows.Forms.Label listaPredmetaLabel;
        private System.Windows.Forms.Button dodajStudenta;
        private System.Windows.Forms.TextBox tbProfesor;
        private System.Windows.Forms.TextBox tbNaziv;
        private System.Windows.Forms.Label profesorLabel;
        private System.Windows.Forms.Label espbLabel;
        private System.Windows.Forms.Label nazivLabel;
        private System.Windows.Forms.TextBox tbAsistent;
        private System.Windows.Forms.Label asistentLabel;
        private System.Windows.Forms.Button dodajPredmet;
        private System.Windows.Forms.ComboBox comboEspb;
        private System.Windows.Forms.Button dodajP;
        private System.Windows.Forms.TextBox pPredmeti;
        private System.Windows.Forms.TextBox pPrezime;
        private System.Windows.Forms.TextBox pIme;
        private System.Windows.Forms.Label label3p;
        private System.Windows.Forms.Label label2p;
        private System.Windows.Forms.Label label1p;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button pregledStudenata;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox predmetT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox indexT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox rez;
    }
}


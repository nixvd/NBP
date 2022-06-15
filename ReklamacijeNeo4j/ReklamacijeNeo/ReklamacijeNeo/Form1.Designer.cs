namespace ReklamacijeNeo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Glavni = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.imeK = new System.Windows.Forms.TextBox();
            this.prezimeK = new System.Windows.Forms.TextBox();
            this.SifraK = new System.Windows.Forms.TextBox();
            this.UlicaTx = new System.Windows.Forms.TextBox();
            this.BrojTx = new System.Windows.Forms.TextBox();
            this.ReonTx = new System.Windows.Forms.ComboBox();
            this.UslugaTx = new System.Windows.Forms.ComboBox();
            this.PrioritetTx = new System.Windows.Forms.ComboBox();
            this.ImeS = new System.Windows.Forms.TextBox();
            this.PrezimeS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.KvarTx = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Pretrazi = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabelaPrikaz = new System.Windows.Forms.DataGridView();
            this.Generisi_PDF = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaPrikaz)).BeginInit();
            this.SuspendLayout();
            // 
            // Glavni
            // 
            this.Glavni.FormattingEnabled = true;
            this.Glavni.Items.AddRange(new object[] {
            "Reklamacije",
            "Korisnici",
            "Serviseri",
            "Ponovljene reklamacije"});
            this.Glavni.Location = new System.Drawing.Point(642, 255);
            this.Glavni.Margin = new System.Windows.Forms.Padding(6);
            this.Glavni.Name = "Glavni";
            this.Glavni.Size = new System.Drawing.Size(1132, 39);
            this.Glavni.TabIndex = 0;
            this.Glavni.SelectedIndexChanged += new System.EventHandler(this.Glavni_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(2766, 262);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowCheckBox = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(262, 38);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1674, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 63);
            this.label1.TabIndex = 2;
            this.label1.Text = "Претрага";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Checked = false;
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker3.Location = new System.Drawing.Point(2766, 335);
            this.dateTimePicker3.Margin = new System.Windows.Forms.Padding(6);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.ShowCheckBox = true;
            this.dateTimePicker3.Size = new System.Drawing.Size(262, 38);
            this.dateTimePicker3.TabIndex = 4;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Checked = false;
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(3116, 335);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(6);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowCheckBox = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(274, 38);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Checked = false;
            this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker4.Location = new System.Drawing.Point(3116, 260);
            this.dateTimePicker4.Margin = new System.Windows.Forms.Padding(6);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.ShowCheckBox = true;
            this.dateTimePicker4.Size = new System.Drawing.Size(274, 38);
            this.dateTimePicker4.TabIndex = 6;
            // 
            // imeK
            // 
            this.imeK.Location = new System.Drawing.Point(158, 41);
            this.imeK.Margin = new System.Windows.Forms.Padding(6);
            this.imeK.Name = "imeK";
            this.imeK.Size = new System.Drawing.Size(204, 38);
            this.imeK.TabIndex = 7;
            // 
            // prezimeK
            // 
            this.prezimeK.Location = new System.Drawing.Point(158, 95);
            this.prezimeK.Margin = new System.Windows.Forms.Padding(6);
            this.prezimeK.Name = "prezimeK";
            this.prezimeK.Size = new System.Drawing.Size(204, 38);
            this.prezimeK.TabIndex = 8;
            // 
            // SifraK
            // 
            this.SifraK.Location = new System.Drawing.Point(158, 149);
            this.SifraK.Margin = new System.Windows.Forms.Padding(6);
            this.SifraK.Name = "SifraK";
            this.SifraK.Size = new System.Drawing.Size(204, 38);
            this.SifraK.TabIndex = 9;
            // 
            // UlicaTx
            // 
            this.UlicaTx.Location = new System.Drawing.Point(1084, 523);
            this.UlicaTx.Margin = new System.Windows.Forms.Padding(6);
            this.UlicaTx.Name = "UlicaTx";
            this.UlicaTx.Size = new System.Drawing.Size(402, 38);
            this.UlicaTx.TabIndex = 10;
            // 
            // BrojTx
            // 
            this.BrojTx.Location = new System.Drawing.Point(1084, 577);
            this.BrojTx.Margin = new System.Windows.Forms.Padding(6);
            this.BrojTx.Name = "BrojTx";
            this.BrojTx.Size = new System.Drawing.Size(402, 38);
            this.BrojTx.TabIndex = 11;
            // 
            // ReonTx
            // 
            this.ReonTx.FormattingEnabled = true;
            this.ReonTx.Location = new System.Drawing.Point(1084, 465);
            this.ReonTx.Margin = new System.Windows.Forms.Padding(6);
            this.ReonTx.Name = "ReonTx";
            this.ReonTx.Size = new System.Drawing.Size(402, 39);
            this.ReonTx.TabIndex = 12;
            this.ReonTx.SelectedIndexChanged += new System.EventHandler(this.ReonTx_SelectedIndexChanged);
            // 
            // UslugaTx
            // 
            this.UslugaTx.FormattingEnabled = true;
            this.UslugaTx.Location = new System.Drawing.Point(1744, 465);
            this.UslugaTx.Margin = new System.Windows.Forms.Padding(6);
            this.UslugaTx.Name = "UslugaTx";
            this.UslugaTx.Size = new System.Drawing.Size(494, 39);
            this.UslugaTx.TabIndex = 13;
            this.UslugaTx.SelectedIndexChanged += new System.EventHandler(this.UslugaTx_SelectedIndexChanged);
            // 
            // PrioritetTx
            // 
            this.PrioritetTx.FormattingEnabled = true;
            this.PrioritetTx.Location = new System.Drawing.Point(1744, 523);
            this.PrioritetTx.Margin = new System.Windows.Forms.Padding(6);
            this.PrioritetTx.Name = "PrioritetTx";
            this.PrioritetTx.Size = new System.Drawing.Size(494, 39);
            this.PrioritetTx.TabIndex = 14;
            // 
            // ImeS
            // 
            this.ImeS.Location = new System.Drawing.Point(190, 59);
            this.ImeS.Margin = new System.Windows.Forms.Padding(6);
            this.ImeS.Name = "ImeS";
            this.ImeS.Size = new System.Drawing.Size(196, 38);
            this.ImeS.TabIndex = 15;
            // 
            // PrezimeS
            // 
            this.PrezimeS.Location = new System.Drawing.Point(190, 114);
            this.PrezimeS.Margin = new System.Windows.Forms.Padding(6);
            this.PrezimeS.Name = "PrezimeS";
            this.PrezimeS.Size = new System.Drawing.Size(196, 38);
            this.PrezimeS.TabIndex = 16;
            this.PrezimeS.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 32);
            this.label2.TabIndex = 18;
            this.label2.Text = "Име :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 32);
            this.label3.TabIndex = 19;
            this.label3.Text = "Презиме :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 155);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 32);
            this.label4.TabIndex = 20;
            this.label4.Text = "Шифра :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(954, 479);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 32);
            this.label5.TabIndex = 21;
            this.label5.Text = "Реон :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(954, 525);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 32);
            this.label6.TabIndex = 22;
            this.label6.Text = "Улица :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(954, 577);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 32);
            this.label7.TabIndex = 23;
            this.label7.Text = "Број :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1560, 467);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 32);
            this.label8.TabIndex = 24;
            this.label8.Text = "Услуга :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1560, 521);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 32);
            this.label9.TabIndex = 25;
            this.label9.Text = "Приоритет :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 62);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 32);
            this.label10.TabIndex = 26;
            this.label10.Text = "Име :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 114);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(148, 32);
            this.label11.TabIndex = 27;
            this.label11.Text = "Презиме :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(478, 262);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(137, 32);
            this.label12.TabIndex = 28;
            this.label12.Text = "Изабери:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(2492, 262);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(266, 32);
            this.label13.TabIndex = 29;
            this.label13.Text = "Датум Пријаве Од:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(2444, 335);
            this.label14.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(303, 32);
            this.label14.TabIndex = 30;
            this.label14.Text = "Датум Решавања Од:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3044, 262);
            this.label15.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 32);
            this.label15.TabIndex = 31;
            this.label15.Text = "До:";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3044, 335);
            this.label16.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 32);
            this.label16.TabIndex = 32;
            this.label16.Text = "До:";
            // 
            // KvarTx
            // 
            this.KvarTx.FormattingEnabled = true;
            this.KvarTx.Location = new System.Drawing.Point(1744, 578);
            this.KvarTx.Margin = new System.Windows.Forms.Padding(6);
            this.KvarTx.Name = "KvarTx";
            this.KvarTx.Size = new System.Drawing.Size(494, 39);
            this.KvarTx.TabIndex = 33;
            this.KvarTx.SelectedIndexChanged += new System.EventHandler(this.KvarTx_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(1560, 579);
            this.label17.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(96, 32);
            this.label17.TabIndex = 34;
            this.label17.Text = "Квар :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.imeK);
            this.groupBox1.Controls.Add(this.prezimeK);
            this.groupBox1.Controls.Add(this.SifraK);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(484, 424);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(400, 215);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Korisnik";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ImeS);
            this.groupBox2.Controls.Add(this.PrezimeS);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(2308, 446);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(400, 194);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Сервисер";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // Pretrazi
            // 
            this.Pretrazi.Location = new System.Drawing.Point(2988, 461);
            this.Pretrazi.Margin = new System.Windows.Forms.Padding(6);
            this.Pretrazi.Name = "Pretrazi";
            this.Pretrazi.Size = new System.Drawing.Size(212, 145);
            this.Pretrazi.TabIndex = 37;
            this.Pretrazi.Text = "Претражи";
            this.Pretrazi.UseVisualStyleBackColor = true;
            this.Pretrazi.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3244, 461);
            this.button2.Margin = new System.Windows.Forms.Padding(6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 147);
            this.button2.TabIndex = 38;
            this.button2.Text = "Обриши";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabelaPrikaz
            // 
            this.tabelaPrikaz.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabelaPrikaz.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.tabelaPrikaz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabelaPrikaz.DefaultCellStyle = dataGridViewCellStyle8;
            this.tabelaPrikaz.Location = new System.Drawing.Point(98, 750);
            this.tabelaPrikaz.Margin = new System.Windows.Forms.Padding(6);
            this.tabelaPrikaz.Name = "tabelaPrikaz";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabelaPrikaz.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.tabelaPrikaz.RowHeadersWidth = 51;
            this.tabelaPrikaz.RowTemplate.Height = 24;
            this.tabelaPrikaz.Size = new System.Drawing.Size(3880, 969);
            this.tabelaPrikaz.TabIndex = 39;
            // 
            // Generisi_PDF
            // 
            this.Generisi_PDF.Location = new System.Drawing.Point(3674, 653);
            this.Generisi_PDF.Margin = new System.Windows.Forms.Padding(6);
            this.Generisi_PDF.Name = "Generisi_PDF";
            this.Generisi_PDF.Size = new System.Drawing.Size(304, 66);
            this.Generisi_PDF.TabIndex = 40;
            this.Generisi_PDF.Text = "Генериши_PDF";
            this.Generisi_PDF.UseVisualStyleBackColor = true;
            this.Generisi_PDF.Click += new System.EventHandler(this.Generisi_PDF_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(3844, 1722);
            this.Controls.Add(this.Generisi_PDF);
            this.Controls.Add(this.tabelaPrikaz);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Pretrazi);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.KvarTx);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PrioritetTx);
            this.Controls.Add(this.UslugaTx);
            this.Controls.Add(this.ReonTx);
            this.Controls.Add(this.BrojTx);
            this.Controls.Add(this.UlicaTx);
            this.Controls.Add(this.dateTimePicker4);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Glavni);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "ФИЛТРИРАЊЕ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaPrikaz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Glavni;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.TextBox imeK;
        private System.Windows.Forms.TextBox prezimeK;
        private System.Windows.Forms.TextBox SifraK;
        private System.Windows.Forms.TextBox UlicaTx;
        private System.Windows.Forms.TextBox BrojTx;
        private System.Windows.Forms.ComboBox ReonTx;
        private System.Windows.Forms.ComboBox UslugaTx;
        private System.Windows.Forms.ComboBox PrioritetTx;
        private System.Windows.Forms.TextBox ImeS;
        private System.Windows.Forms.TextBox PrezimeS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox KvarTx;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Pretrazi;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView tabelaPrikaz;
        private System.Windows.Forms.Button Generisi_PDF;
    }
}


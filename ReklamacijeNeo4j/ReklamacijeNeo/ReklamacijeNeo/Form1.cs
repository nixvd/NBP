using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Neo4j.Driver;
using iTextSharp;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;
using Cyrillic.Convert;
using System.Text.RegularExpressions;

namespace ReklamacijeNeo
{
    public partial class Form1 : Form
    {
        IDriver _driver;


        public Form1()
        {
            InitializeComponent();
            //IDriver _driver;
            //_driver = GraphDatabase.Driver("bolt://localhost:1497", AuthTokens.Basic("neo4j", "joca93"));
            //using (var session = _driver.Session())
            // {
            //     //session.Run("CREATE (a:Person {name:'Nikola', title:'Bogavac'})");
            //     var result = session.Run("MATCH (k:Korisnik) WHERE k.Ime = 'Новица' RETURN k.Ime AS name LIMIT 1");
            //     var resUsluga = session.Run("MATCH (n:Usluga) RETURN n.NazivUsluge as usluga");
            //     AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
            //     //foreach (var record in result)
            //     //      imeK.Text = ($"{record["name"].As<string>()}");
            //     foreach (var record in resUsluga)
            //         //imeK.Text = ($"{record["name"].As<string>()}");
            //         MyCollection.Add($"{record["usluga"].As<string>()}");

            //     UslugaTx.AutoCompleteCustomSource = MyCollection;

            // }

            _driver = GraphDatabase.Driver("bolt://localhost:7687", AuthTokens.Basic("neo4j", "joca93"));
        }
            
        private void Form1_Load(object sender, EventArgs e)
        {
            
            using (var session = _driver.Session())
            {
                
                //var result = session.Run("MATCH (k:Korisnik) WHERE k.Ime = 'Новица' RETURN k.Ime AS name LIMIT 1");
                var resUsluga = session.Run("MATCH (n:Usluga) RETURN n.NazivUsluge as usluga");
                
               
                //AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
                //foreach (var record in result)
                //      imeK.Text = ($"{record["name"].As<string>()}");
                foreach (var record in resUsluga)
                    //imeK.Text = ($"{record["name"].As<string>()}");
                    UslugaTx.Items.Add($"{record["usluga"].As<string>()}");

                var resPrioritet = session.Run("MATCH (n:Prioritet) RETURN n.NazivPrioriteta as prioritet");
                foreach (var pri in resPrioritet)
                    //imeK.Text = ($"{record["name"].As<string>()}");
                    PrioritetTx.Items.Add($"{pri["prioritet"].As<string>()}");

                var resReon = session.Run("MATCH (n:Reon) RETURN n.Naziv as reon");
                foreach (var re in resReon)
                    //imeK.Text = ($"{record["name"].As<string>()}");
                    ReonTx.Items.Add($"{re["reon"].As<string>()}");
                //string sUsluga=this.UslugaTx.GetItemText(this.UslugaTx.SelectedItem);
                //MessageBox.Show(sUsluga);

                //UslugaTx.Items.Add(MyCollection.);
                
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void UslugaTx_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sUsluga = this.UslugaTx.GetItemText(this.UslugaTx.SelectedItem);
            
            string querry = $"MATCH (:Usluga{{NazivUsluge:'{sUsluga}'}})--(k:Kvar) return k.NazivKvara as kvar";
            MessageBox.Show(querry);
            KvarTx.Items.Clear();
            using (var session = _driver.Session())
            {
                //MATCH (:Usluga{NazivUsluge:"КДС"})--(k:Kvar) return k.NazivKvara
                
                var rKvar = session.Run(querry) ;
                foreach (var pr in rKvar)
                    KvarTx.Items.Add($"{pr["kvar"].As<string>()}");

            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        public String leadingZ(string n)
        {
            if (n.Length == 1)
            { return "0" + n; }
            else
            { return n; }
        }
        public String normalizeInput(string n)
        {
            if (Regex.IsMatch(n, "^[a-zA-Zа-шА-Ш]*$"))
            {

                char[] a = n.ToLower().ToCharArray();
                a[0] = char.ToUpper(a[0]);
                return new string(a).ToSerbianCyrilic();

            }
            else
                return "";
            

            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string sifraKorisnika = ".*";
            string imeKorisnika = ".*";
            string prezimeKorisnika = ".*";
            string reonNaziv = ".*";
            string ulicaNaziv = ".*";
            string broj = ".*";
            string uslugaNaziv = ".*";
            string prioritetNaziv = ".*";
            string kvarNaziv = ".*";
            string imeServisera = ".*";
            string prezimeServisera = ".*";
            string datumPrijaveOd = "1900/01/01";
            string datumPrijaveDo = "9999/01/01";
            string datumZavrsetkaOd = "1900/01/01";
            string datumZavrsetkaDo = "9999/01/01";

            if (Glavni.SelectedIndex>-1)
            {

                var m = Glavni.SelectedItem;
                if (imeK.Text.Length > 0)
                {
                    imeKorisnika = normalizeInput(imeK.Text);
                }
                if (SifraK.Text.Length > 0)
                {
                    sifraKorisnika = SifraK.Text;
                }
                if (prezimeK.Text.Length>0)
                {
                    prezimeKorisnika =normalizeInput(prezimeK.Text);
                }
                if (ReonTx.Text.Length > 0)
                {
                    reonNaziv = ReonTx.Text;
                }
                if (UlicaTx.Text.Length > 0)
                {
                    ulicaNaziv = UlicaTx.Text;
                }
                if (BrojTx.Text.Length > 0)
                {
                    broj = BrojTx.Text;
                }
                if (UslugaTx.Text.Length > 0)
                {
                    uslugaNaziv = UslugaTx.Text;
                }
                if (PrioritetTx.Text.Length>0)
                {
                    prioritetNaziv = PrioritetTx.Text;
                }
                if (KvarTx.Text.Length>0)
                {
                    kvarNaziv = KvarTx.Text;
                }    
                if (ImeS.Text.Length >0)
                {
                    imeServisera = normalizeInput(ImeS.Text);
                }
                if (PrezimeS.Text.Length>0)
                {
                    prezimeServisera =normalizeInput(PrezimeS.Text);
                }
                if(dateTimePicker1.Checked)
                {
                    datumPrijaveOd = dateTimePicker1.Value.Year.ToString() + '-' + leadingZ(dateTimePicker1.Value.Month.ToString()) + '-' + leadingZ(dateTimePicker1.Value.Day.ToString()) + ' ' + "00:00:00";
                    //dateTimePicker1.Checked = false;
                }
                else { datumPrijaveOd = "1900/01/01"; }
                if (dateTimePicker4.Checked)
                {
                    datumPrijaveDo = dateTimePicker4.Value.Year.ToString() + '-' + leadingZ(dateTimePicker4.Value.Month.ToString()) + '-' + leadingZ(dateTimePicker4.Value.Day.ToString())+' '+"23:59:59" ;
                }
                else { datumPrijaveDo = "9999/01/01"; }
                if (dateTimePicker3.Checked)
                {
                    datumZavrsetkaOd = dateTimePicker3.Value.Year.ToString() + '-' + leadingZ(dateTimePicker3.Value.Month.ToString())+ '-' + leadingZ(dateTimePicker3.Value.Day.ToString()) + ' ' + "00:00:00";
                }
                else { datumZavrsetkaOd = "1900/01/01"; }
                if (dateTimePicker2.Checked)
                {
                    datumZavrsetkaDo = dateTimePicker2.Value.Year.ToString() + '-' + leadingZ(dateTimePicker2.Value.Month.ToString()) + '-' + leadingZ(dateTimePicker2.Value.Day.ToString()) + ' ' + "23:59:59";                 
                }
                else { datumZavrsetkaDo = "9999/01/01"; }
                ///nastavi
                if (m.ToString()=="Reklamacije")
                {
                    

                    //MessageBox.Show("Odabrali ste reklamacije");
                    string query = $"MATCH (re:Reon) <-[JE_U]- (a:Adresa) <-[ZIVI_U]-(k:Korisnik)-[OSTAVLJA]-> (r:Reklamacija) -[IMA]->(pr:Prioritet),(r) -[SADRZI]->(kv: Kvar) -[JE_ZA]->(u: Usluga),(r)< -[RESIO] - (s: Serviser) WHERE r.DatumPrijave >= '{datumPrijaveOd}' AND r.DatumPrijave <= '{datumPrijaveDo}' AND r.DatumZavrsetka >= '{datumZavrsetkaOd}' AND r.DatumZavrsetka <= '{datumZavrsetkaDo}'  AND k.IdKorisnika =~'{sifraKorisnika}' AND k.Ime =~'{imeKorisnika}' AND k.Prezime =~'{prezimeKorisnika}' AND s.ImeServisera =~'{imeServisera}' AND s.PrezimeServisera =~'{prezimeServisera}' AND u.NazivUsluge =~'{uslugaNaziv}' AND pr.NazivPrioriteta =~'{prioritetNaziv}' AND kv.NazivKvara =~'{kvarNaziv}' AND re.Naziv =~'{reonNaziv}' AND a.Ulica =~'{ulicaNaziv}' AND a.Broj =~'{broj}' return r.IdReklamacije,r.DatumPrijave,r.DatumZavrsetka,u.NazivUsluge,pr.NazivPrioriteta,kv.NazivKvara,s.ImeServisera as Resio, re.Naziv,a.Ulica,a.Broj LIMIT 1000";
                    MessageBox.Show(query);
                    using (var session = _driver.Session())
                    {
                        //r.IdReklamacije,r.DatumPrijave,r.DatumZavrsetka,u.NazivUsluge,pr.NazivPrioriteta,kv.NazivKvara,s.ImeServisera as Resio, re.Naziv,a.Ulica,a.Broj LIMIT 25 
                        var reklResult = session.Run(query);
                        DataTable db1 = new DataTable();
                        db1.Columns.Add("IdReklamacije");
                        db1.Columns.Add("DatumPrijave");
                        db1.Columns.Add("DatumZavrsetka");
                        db1.Columns.Add("Usluga");
                        db1.Columns.Add("Prioritet");
                        db1.Columns.Add("Kvar");
                        db1.Columns.Add("Resio");
                        db1.Columns.Add("Reon");
                        db1.Columns.Add("Ulica");
                        db1.Columns.Add("Broj");
                        foreach (var rek in reklResult)
                        {
                            var row = db1.NewRow();
                            row[0] = $"{rek["r.IdReklamacije"].As<string>()}";
                            row[1] = $"{rek["r.DatumPrijave"].As<string>()}";
                            row[2] = $"{rek["r.DatumZavrsetka"].As<string>()}";
                            row[3] = $"{rek["u.NazivUsluge"].As<string>()}";
                            row[4] = $"{rek["pr.NazivPrioriteta"].As<string>()}";
                            row[5] = $"{rek["kv.NazivKvara"].As<string>()}";
                            row[6] = $"{rek["Resio"].As<string>()}";
                            row[7] = $"{rek["re.Naziv"].As<string>()}";
                            row[8] = $"{rek["a.Ulica"].As<string>()}";
                            row[9] = $"{rek["a.Broj"].As<string>()}";

                            db1.Rows.Add(row);
                        }
                        


                        tabelaPrikaz.DataSource=db1;
                    }
                    
                }
                else if(m.ToString() == "Korisnici")
                {
                    string query = $"MATCH (re:Reon) <-[JE_U]- (a:Adresa) <-[ZIVI_U]-(k:Korisnik)-[OSTAVLJA]-> (r:Reklamacija) -[IMA]->(pr:Prioritet),(r) -[SADRZI]->(kv: Kvar) -[JE_ZA]->(u: Usluga),(r)< -[RESIO] - (s: Serviser) WHERE r.DatumPrijave >= '{datumPrijaveOd}' AND r.DatumPrijave <= '{datumPrijaveDo}' AND r.DatumZavrsetka >= '{datumZavrsetkaOd}' AND r.DatumZavrsetka <= '{datumZavrsetkaDo}'  AND k.IdKorisnika =~'{sifraKorisnika}' AND k.Ime =~'{imeKorisnika}' AND k.Prezime =~'{prezimeKorisnika}' AND s.ImeServisera =~'{imeServisera}' AND s.PrezimeServisera =~'{prezimeServisera}' AND u.NazivUsluge =~'{uslugaNaziv}' AND pr.NazivPrioriteta =~'{prioritetNaziv}' AND kv.NazivKvara =~'{kvarNaziv}' AND re.Naziv =~'{reonNaziv}' AND a.Ulica =~'{ulicaNaziv}' AND a.Broj =~'{broj}' return k.Ime,k.Prezime,re.Naziv,a.Ulica,a.Broj,r.DatumPrijave,r.DatumZavrsetka,kv.NazivKvara,s.ImeServisera as Resio LIMIT 1000";
                    MessageBox.Show(query);
                    using (var session = _driver.Session())
                    {
                        //r.IdReklamacije,r.DatumPrijave,r.DatumZavrsetka,u.NazivUsluge,pr.NazivPrioriteta,kv.NazivKvara,s.ImeServisera as Resio, re.Naziv,a.Ulica,a.Broj LIMIT 25 
                        var korResult = session.Run(query);
                        DataTable db1 = new DataTable();
                        db1.Columns.Add("ImeKorisnika");
                        db1.Columns.Add("PrezimeKorisnika");
                        db1.Columns.Add("Reon");
                        db1.Columns.Add("Ulica");
                        db1.Columns.Add("Broj");
                        db1.Columns.Add("DatumPrijave");
                        db1.Columns.Add("DatumZavrsetka");
                        db1.Columns.Add("Kvar");
                        db1.Columns.Add("Resio");
                      
                        foreach (var rek in korResult)
                        {
                            var row = db1.NewRow();
                            row[0] = $"{rek["k.Ime"].As<string>()}";
                            row[1] = $"{rek["k.Prezime"].As<string>()}";
                            row[2] = $"{rek["re.Naziv"].As<string>()}";
                            row[3] = $"{rek["a.Ulica"].As<string>()}";
                            row[4] = $"{rek["a.Broj"].As<string>()}";
                            row[5] = $"{rek["r.DatumPrijave"].As<string>()}";
                            row[6] = $"{rek["r.DatumZavrsetka"].As<string>()}";
                            row[7] = $"{rek["kv.NazivKvara"].As<string>()}";
                            row[8] = $"{rek["Resio"].As<string>()}";
                            

                            db1.Rows.Add(row);
                        }



                        tabelaPrikaz.DataSource = db1;
                    }
                }
                else if(m.ToString()== "Serviseri")
                {
                   
                    string query = $"MATCH (s:Serviser) -[RESIO]->(r:Reklamacija)-[IMA]->(p:Prioritet) WHERE r.DatumPrijave >= '{datumPrijaveOd}' AND r.DatumPrijave <= '{datumPrijaveDo}' AND r.DatumZavrsetka >= '{datumZavrsetkaOd}' AND r.DatumZavrsetka <= '{datumZavrsetkaDo}' AND s.ImeServisera=~ '{imeServisera}' and s.PrezimeServisera=~ '{prezimeServisera}' and p.NazivPrioriteta=~ '{prioritetNaziv}' return s.ImeServisera, s.PrezimeServisera, p.NazivPrioriteta,count(*) as brr";                   
                    MessageBox.Show(query);
                    using (var session = _driver.Session())
                    {
                        //r.IdReklamacije,r.DatumPrijave,r.DatumZavrsetka,u.NazivUsluge,pr.NazivPrioriteta,kv.NazivKvara,s.ImeServisera as Resio, re.Naziv,a.Ulica,a.Broj LIMIT 25 
                        var serResult = session.Run(query);
                        DataTable db1 = new DataTable();
                        db1.Columns.Add("ImeServisera");
                        db1.Columns.Add("PrezimeServisera");
                        db1.Columns.Add("Prioritet");
                        db1.Columns.Add("BrojReklamacija");
                      
                        foreach (var rek in serResult)
                        {
                            var row = db1.NewRow();
                            row[0] = $"{rek["s.ImeServisera"].As<string>()}";
                            row[1] = $"{rek["s.PrezimeServisera"].As<string>()}";
                            row[2] = $"{rek["p.NazivPrioriteta"].As<string>()}";
                            row[3] = $"{rek["brr"].As<string>()}";
                   
                            db1.Rows.Add(row);
                        }



                        tabelaPrikaz.DataSource = db1;
                    }
                }
                else if(m.ToString()=="Ponovljene reklamacije")
                {

                }
                else 
                {
                    MessageBox.Show("Niste odabrali validan kriterijum");
                }
            }
            else
            {
                MessageBox.Show("Niste odabrali kriterijum za pretragu");
            }
        }

        private void Generisi_PDF_Click(object sender, EventArgs e)
        {
            var dateAndTime = DateTime.Now;
            
            if (tabelaPrikaz.RowCount>0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                string kriterijum = Glavni.SelectedItem.ToString();
                sfd.FileName = kriterijum+".pdf";
                bool fileError = false;
                BaseFont bf = BaseFont.CreateFont(Environment.GetEnvironmentVariable("windir") + @"\fonts\Arial.ttf", BaseFont.IDENTITY_H, true);
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Nije moguce sacuvati fajl" + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            //title
                            iTextSharp.text.Font titleFont = FontFactory.GetFont("ArialBold", 20);
                            Paragraph title;
                            title = new Paragraph(kriterijum+"\n\n", titleFont);
                            title.Alignment = Element.ALIGN_CENTER;
                            Paragraph datum;
                            datum = new Paragraph("Datum štampe: "+ dateAndTime.ToString("dd/MM/yyyy") +"\n\n");
                            datum.Alignment = Element.ALIGN_RIGHT;
                            PdfPTable pdfTable = new PdfPTable(tabelaPrikaz.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
                            iTextSharp.text.Font font = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.NORMAL);
                            //iTextSharp.text.pdf.PdfPCell cell = new iTextSharp.text.pdf.PdfPCell(new Phrase(12, cellText, font));

                            foreach (DataGridViewColumn column in tabelaPrikaz.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in tabelaPrikaz.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    if (cell.Value == null)
                                    {
                                        pdfTable.AddCell("");
                                    }
                                    else
                                    {
                                        PdfPCell cellD = new PdfPCell(new Phrase(12, cell.Value.ToString(),font));
                                        pdfTable.AddCell(cellD);
                                    }
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(new RectangleReadOnly(842, 595), 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(title);
                                pdfDoc.Add(datum);
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Podaci uspesno sacuvani", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Greska :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Nema podataka  !!!", "Info");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            imeK.Clear();
            SifraK.Clear();
            prezimeK.Clear();
            //ReonTx.SelectedIndex= ReonTx.Items.Count - 1;
            UlicaTx.Clear();
            BrojTx.Clear();
            //KvarTx.SelectedIndex = KvarTx.Items.Count - 1;
            UslugaTx.SelectedIndex = UslugaTx.Items.Count-1;
            PrioritetTx.SelectedIndex = PrioritetTx.Items.Count - 1;
            KvarTx.SelectedIndex = KvarTx.Items.Count-1;
            ImeS.Clear();
            PrezimeS.Clear();
            dateTimePicker1.Checked = false;
            dateTimePicker2.Checked = false;
            dateTimePicker3.Checked = false;
            dateTimePicker4.Checked = false;
            
        }

        private void Glavni_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Glavni.SelectedItem =="Serviseri")
            {
                ReonTx.Enabled = false;
                KvarTx.Enabled = false;
                imeK.Enabled = false;
                prezimeK.Enabled = false;
                SifraK.Enabled = false;
                UlicaTx.Enabled = false;
                BrojTx.Enabled = false;
                UslugaTx.Enabled = false;
            }
        }

        private void ReonTx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void KvarTx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

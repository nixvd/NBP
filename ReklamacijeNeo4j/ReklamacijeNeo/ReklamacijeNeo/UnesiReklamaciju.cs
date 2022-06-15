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
    public partial class UnesiReklamaciju : Form
    {

        IDriver _driver;
        public UnesiReklamaciju()
        {
            InitializeComponent();

            _driver = GraphDatabase.Driver("bolt://localhost:7687", AuthTokens.Basic("neo4j", "joca93"));
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

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
        public String leadingZ(string n)
        {
            if (n.Length == 1)
            { return "0" + n; }
            else
            { return n; }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string sifraKorisnika = "";
            string imeKorisnika = "";
            string prezimeKorisnika = "";
            string reonNaziv = "";
            string ulicaNaziv = "";
            string broj = "";
            string uslugaNaziv = "";
            string prioritetNaziv = "";
            string kvarNaziv = "";
            string imeServisera = "";
            string prezimeServisera = "";
            string datumPrijave = "";
            string datumZavrsetka = "";

            if (imeU.Text.Length > 0)
            {
                imeKorisnika = normalizeInput(imeU.Text);
            }
            else
            {
                MessageBox.Show("Niste uneli ime korisnika");
            }
            if (prezimeU.Text.Length > 0)
            {
                prezimeKorisnika = normalizeInput(prezimeU.Text);
            }
            else
            {
                MessageBox.Show("Niste uneli prezime korisnika");
            }
            if (sifraU.Text.Length > 0)
            {
                sifraKorisnika = sifraU.Text;
            }
            if (ulicaU.Text.Length > 0)
            {
                ulicaNaziv = ulicaU.Text;
            }
            if (brojuliceU.Text.Length > 0)
            {
                broj = brojuliceU.Text;
            }
            if (reonU.Text.Length > 0)
            {
                reonNaziv = reonU.Text;
            }
            if (kvarU.Text.Length > 0)
            {
                kvarNaziv = kvarU.Text;
            }
            if (prioritetU.Text.Length > 0)
            {
                prioritetNaziv = prioritetU.Text;
            }
            if (uslugaU.Text.Length > 0)
            {
                uslugaNaziv = uslugaU.Text;
            }
            if (imeserviseraU.Text.Length > 0)
            {
                imeServisera = normalizeInput(imeserviseraU.Text);
            }
            if (prezimeserviseraU.Text.Length > 0)
            {
                prezimeServisera = normalizeInput(prezimeserviseraU.Text);
            }
            if (datumprijaveU.Checked)
            {
                datumPrijave = datumprijaveU.Value.Year.ToString() + '-' + leadingZ(datumprijaveU.Value.Month.ToString()) + '-' + leadingZ(datumprijaveU.Value.Day.ToString());
                //dateTimePicker1.Checked = false;
            }
            else { MessageBox.Show("Unesi datum prijave!"); }

            if (datumzavrsetkaU.Checked)
            {
                datumZavrsetka = datumzavrsetkaU.Value.Year.ToString() + '-' + leadingZ(datumzavrsetkaU.Value.Month.ToString()) + '-' + leadingZ(datumzavrsetkaU.Value.Day.ToString());
                //dateTimePicker1.Checked = false;
            }
            else { MessageBox.Show("Unesi datum zavrsetka!"); }



            //MessageBox.Show("Odabrali ste reklamacije");
            string query = $"CREATE (ko: Korisnik {{ Ime: '{ imeKorisnika}', Prezime: '{ prezimeKorisnika}', IdKorisnika: '{ sifraKorisnika}' }}), (a: Adresa {{ Broj: '{ broj}', Ulica: '{ ulicaNaziv}' }}), (s: Serviser {{ ImeServisera: '{ imeServisera}', PrezimeServisera: '{ prezimeServisera}' }}), (rek: Reklamacija {{ datumPrijave: '{ datumPrijave}', DatumZavrsetka: '{ datumZavrsetka}' }}), (p: Prioritet {{ NazivPrioriteta: '{prioritetNaziv}' }}), (u: Usluga {{ NazivUsluge: '{ uslugaNaziv}' }}), (kv: Kvar {{ NazivKvara: '{ kvarNaziv}' }}), (reo: Reon {{ Naziv: '{ reonNaziv}' }}), (ko) -[:ZIVI_U]->(a), (rek) -[:IMA]->(p), (a) -[:JE_U]->(reo), (rek) -[:JE_ZA]->(u), (kv) -[:NA]->(u), (ko) -[:OSTAVLJA]->(rek), (s) -[:RESIO]->(rek), (rek) -[:SADRZI]->(kv) RETURN ko; ";
            MessageBox.Show(query);
            using (var session = _driver.Session())
            {
                //r.IdReklamacije,r.DatumPrijave,r.DatumZavrsetka,u.NazivUsluge,pr.NazivPrioriteta,kv.NazivKvara,s.ImeServisera as Resio, re.Naziv,a.Ulica,a.Broj LIMIT 25 
                var reklResult = session.Run(query);
             


            }



            imeU.Clear();
            sifraU.Clear();
            prezimeU.Clear();
            //ReonTx.SelectedIndex= ReonTx.Items.Count - 1;
            ulicaU.Clear();
            brojuliceU.Clear();
            //KvarTx.SelectedIndex = KvarTx.Items.Count - 1;
            uslugaU.SelectedIndex = uslugaU.Items.Count - 1;
            prioritetU.SelectedIndex = prioritetU.Items.Count - 1;
            kvarU.SelectedIndex = kvarU.Items.Count - 1;
            imeserviseraU.Clear();
            prezimeserviseraU.Clear();
            datumprijaveU.Checked = false;
            datumzavrsetkaU.Checked = false;
        }

        private void UnesiReklamaciju_Load_1(object sender, EventArgs e)
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
                    uslugaU.Items.Add($"{record["usluga"].As<string>()}");

                var resPrioritet = session.Run("MATCH (n:Prioritet) RETURN n.NazivPrioriteta as prioritet");
                foreach (var pri in resPrioritet)
                    //imeK.Text = ($"{record["name"].As<string>()}");
                    prioritetU.Items.Add($"{pri["prioritet"].As<string>()}");

                var resReon = session.Run("MATCH (n:Reon) RETURN n.Naziv as reon");
                foreach (var re in resReon)
                    //imeK.Text = ($"{record["name"].As<string>()}");
                    reonU.Items.Add($"{re["reon"].As<string>()}");
                //string sUsluga=this.UslugaTx.GetItemText(this.UslugaTx.SelectedItem);
                //MessageBox.Show(sUsluga);

                //UslugaTx.Items.Add(MyCollection.);

            }
        }

        private void uslugaU_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sUsluga = this.uslugaU.GetItemText(this.uslugaU.SelectedItem);
            MessageBox.Show(sUsluga);
            string querry = $"MATCH (:Usluga{{NazivUsluge:'{sUsluga}'}})--(k:Kvar) return k.NazivKvara as kvar";
            MessageBox.Show(querry);
            kvarU.Items.Clear();
            using (var session = _driver.Session())
            {
                //MATCH (:Usluga{NazivUsluge:"КДС"})--(k:Kvar) return k.NazivKvara

                var rKvar = session.Run(querry);
                foreach (var pr in rKvar)
                    kvarU.Items.Add($"{pr["kvar"].As<string>()}");

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

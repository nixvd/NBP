using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Builders;
using MongoDB.Driver.Linq;
using FakultetskiOrganizator.Model;

namespace FakultetskiOrganizator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MongoDatabase database;

        private void Form1_Load_1(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            MongoClient client = new MongoClient(connectionString);
            var server = client.GetServer();
            database = server.GetDatabase("fakultet");

            var collection = database.GetCollection<Student>("studenti");

            MongoCursor<Student> studenti = collection.FindAll();

            /*foreach (Student s in studenti.ToArray<Student>())
            {
                MessageBox.Show(s.Ime);
            }*/
        }

        private void dodajStudenta_Click(object sender, EventArgs e)
        {
            var collection = database.GetCollection<Student>("studenti");
            var collection1 = database.GetCollection<Predmet>("predmeti");

            Student s = new Student();
            string imeStudenta = tbImeStudenta.Text;
            string prezimeStudenta = tbPrezStudenta.Text;
            string brojIndeksa = tbBrInd.Text;
            int brIndeksa = Int32.Parse(brojIndeksa);
            string listaOcena = tbListaOcena.Text;
            string listaPredmeta = tbListaPredmeta.Text;
            double prosekStudenta = 0;

            string[] pojedinacneOcene = listaOcena.Split(',');
            for (int i = 0; i < pojedinacneOcene.Length; i++)
            {
                try
                {
                    s.listaOcena.Add(Int32.Parse(pojedinacneOcene[i]));
                    prosekStudenta += Int32.Parse(pojedinacneOcene[i]);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ocene i predmete odvojite znakom , !");
                }
            }

            prosekStudenta = prosekStudenta / pojedinacneOcene.Length;

            string[] predmetiStudenta = listaPredmeta.Split(',');
            
            for (int i = 0; i < predmetiStudenta.Length; i++)
            {
                predmetiStudenta[i] = predmetiStudenta[i].Trim();
                s.listaPredmeta.Add(predmetiStudenta[i]);
            }

            foreach (string predmet in s.listaPredmeta)
            {
                        var query = from pr in collection1.AsQueryable<Predmet>()
                                    where pr.nazivPredmeta == predmet 
                                    select pr;

                        foreach(Predmet pred in query)
                        {
                            var query1 = Query.EQ("brojStudenata", pred.brojStudenata);
                            pred.brojStudenata++;
                            var update = MongoDB.Driver.Builders.Update.Set("brojStudenata", BsonValue.Create(pred.brojStudenata++));

                            collection1.Update(query1, update);
                        }
            }

            if (pojedinacneOcene.Length != predmetiStudenta.Length)
            {
                MessageBox.Show("Ne podudara se broj ocena i unetih predmeta!");
            }
            else
            {
                Student student = new Student { Ime = imeStudenta, Prezime = prezimeStudenta, brojIndeksa = brIndeksa, prosek = prosekStudenta, listaOcena = s.listaOcena, listaPredmeta = s.listaPredmeta };
                collection.Insert(student);
            }

            foreach (Control c in studentTab.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }

            MessageBox.Show("Uspesno ste dodali studenta u bazu!");
        }

        private void dodajP_Click(object sender, EventArgs e)
        {
            var collection = database.GetCollection<Profesor>("profesori");

            string[] pred = pPredmeti.Text.Split(',');

            Profesor profesor = new Profesor();
            profesor.Ime = pIme.Text;
            profesor.Prezime = pPrezime.Text;

            for (int i = 0; i < pred.Length; i++)
            {
                try
                {
                    profesor.listaPredmeta.Add(pred[i]);
                }
                catch (Exception)
                {

                    MessageBox.Show("Predmete odvojite znakom , !");
                }
                
            }
            collection.Insert(profesor);

            foreach (Control c in profesorTab.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }

            MessageBox.Show("Uspesno ste dodali profesora u bazu!");
        }

        private void dodajPredmet_Click(object sender, EventArgs e)
        {
            var collection = database.GetCollection<Predmet>("predmeti");
            var collection1 = database.GetCollection<Student>("studenti");
            var collection2 = database.GetCollection<Profesor>("profesori");

            string nazivPredmeta = tbNaziv.Text;
            string brojBodova = comboEspb.Text;
            int brBodova = Int32.Parse(brojBodova);
            string asistentPredmeta = tbAsistent.Text;
            int brStudenata=0;

            foreach (Student s in collection1.FindAll())
            {
                for (int i = 0; i < s.listaPredmeta.Count; i++)
                {
                    if (s.listaPredmeta[i] == nazivPredmeta)
                        brStudenata++;
                }
            }

            MongoDBRef mdb = null;

            string[] profesorPredmeta = tbProfesor.Text.Split(' ');
            var query = from profa in collection2.AsQueryable<Profesor>()
                        where profa.Ime == profesorPredmeta[0] && profa.Prezime == profesorPredmeta[1]
                        select profa;
            Profesor p = new Profesor();
            foreach (Profesor pro in query)
                p = pro;

            if (query.Count() == 0)
            {
                MessageBox.Show("Ne postoji takav profesor");
                return;
            }
            else
            {
                ObjectId id;
                id = p.Id;
                mdb = new MongoDBRef("profesori", id);
                var query1 = from pr in collection2.AsQueryable<Profesor>()
                                 where pr.Id == id
                                 select pr;

                var update = MongoDB.Driver.Builders.Update.Push("listaPredmeta", BsonValue.Create(nazivPredmeta));

                var query2 = Query.EQ("_id", p.Id);

                collection2.Update(query2, update);



                Predmet predmet = new Predmet { nazivPredmeta = nazivPredmeta, brojESPB = brBodova, Asistent = asistentPredmeta, brojStudenata = brStudenata, Profesor = mdb };
                collection.Insert(predmet);

                foreach (Control c in predmetTab.Controls)
                {
                    if (c is TextBox)
                    {
                        c.Text = "";
                    }
                    else if (c is ComboBox)
                    {
                        ((ComboBox)c).Text = "";
                    }
                }
                MessageBox.Show("Uspesno ste dodali predmet u bazu!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PregledStudenata pregled = new PregledStudenata();
            pregled.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PregledProfesora pregled = new PregledProfesora();
            pregled.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PregledPredmeta pregled = new PregledPredmeta();
            pregled.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            var collection = database.GetCollection<Predmet>("predmeti");
            var collection1 = database.GetCollection<Student>("studenti");
            var collection2 = database.GetCollection<Profesor>("profesori");

            var query = from st in collection1.AsQueryable<Student>()
                        where st.brojIndeksa == Int32.Parse(indexT.Text)
                        select st;
            if (query.Count() == 0)
            {
                MessageBox.Show("Ne postoji student sa tim brojem indeksa.");
                return;
            }
            else
            {
                foreach (Student s in query)
                {
                    int d = 0;
                    string lpr = "";
                    for (int i = 0; i < s.listaPredmeta.Count; i++)
                    {
                        if (s.listaPredmeta[i] == predmetT.Text)
                            d++;

                        var query3 = from pr in collection.AsQueryable<Predmet>()
                                    where pr.nazivPredmeta == s.listaPredmeta[i]
                                    select pr;
                        foreach (Predmet p in query3)
                        {
                            if (p.Profesor != null)
                            {
                                Profesor pr = collection2.FindOneById(p.Profesor.Id);
                                lpr += p.nazivPredmeta + " - " + pr.Ime + " " + pr.Prezime;
                                if (i != s.listaPredmeta.Count - 1)
                                    lpr += ", ";
                            }
                            else
                            {
                                lpr += p.nazivPredmeta + " - ";
                                if (i != s.listaPredmeta.Count - 1)
                                    lpr += ", ";
                            }
                            rez.Text = lpr;
                        }

                    }
                    if (d == 0) {
                        var update = MongoDB.Driver.Builders.Update.Push("listaPredmeta", BsonValue.Create(predmetT.Text));

                        var query1 = Query.EQ("brojIndeksa", s.brojIndeksa);

                        collection1.Update(query1, update);
                    }
                    else
                    {
                        MessageBox.Show("Student je vec upisan na taj predmet.");
                        return;
                    }


                }
            }

            var query2 = from pr in collection.AsQueryable<Predmet>()
                         where pr.nazivPredmeta == predmetT.Text
                         select pr;

            if (query2.Count() == 0)
            {
                MessageBox.Show("Ne postoji takav predmet.");
                return;
            }
            else
            {
                foreach (Predmet p in query2)
                {
                    var query1 = Query.EQ("nazivPredmeta", predmetT.Text);
                    p.brojStudenata++;
                    var update = MongoDB.Driver.Builders.Update.Set("brojStudenata", BsonValue.Create(p.brojStudenata++));

                    collection.Update(query1, update);
                }
            }

            MessageBox.Show("Student upisan.");
        }

        private void imeLabel_Click(object sender, EventArgs e)
        {

        }

        private void listaOcenaLabel_Click(object sender, EventArgs e)
        {

        }

        private void profesorLabel_Click(object sender, EventArgs e)
        {

        }

        private void asistentLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

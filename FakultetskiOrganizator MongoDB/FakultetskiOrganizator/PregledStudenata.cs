using MongoDB.Driver;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FakultetskiOrganizator.Model;

namespace FakultetskiOrganizator
{
    public partial class PregledStudenata : Form
    {
        public PregledStudenata()
        {
            InitializeComponent();
        }

        MongoDatabase database;

        private void PregledStudenata_Load(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            MongoClient client = new MongoClient(connectionString);
            var server = client.GetServer();
            database = server.GetDatabase("fakultet");
            int i = 0;
            string predmetiOcene = "";

            var collection = database.GetCollection<Student>("studenti");

            MongoCursor<Student> studenti = collection.FindAll();

            foreach (Student s in studenti.ToArray<Student>())
            {
                this.dataGridView.Rows.Add();
                this.dataGridView.Rows[i].HeaderCell.Value = String.Format("{0}", dataGridView.Rows[i].Index + 1);
                this.dataGridView.Rows[i].Cells[0].Value = s.Ime;
                this.dataGridView.Rows[i].Cells[1].Value = s.Prezime;
                this.dataGridView.Rows[i].Cells[2].Value = s.brojIndeksa;
                this.dataGridView.Rows[i].Cells[3].Value = s.prosek;
                for(int j = 0; j < s.listaPredmeta.Count; j++)
                {
                    predmetiOcene += s.listaPredmeta[j] + " - " + s.listaOcena[j].ToString();
                    if (j != s.listaPredmeta.Count - 1)
                        predmetiOcene += ", ";
                }

                this.dataGridView.Rows[i].Cells[4].Value = predmetiOcene;
                predmetiOcene = "";
                i++;
            }
        }
    }
}

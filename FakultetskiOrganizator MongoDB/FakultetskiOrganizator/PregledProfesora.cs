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
    public partial class PregledProfesora : Form
    {
        public PregledProfesora()
        {
            InitializeComponent();
        }

        MongoDatabase database;

        private void PregledProfesora_Load(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            MongoClient client = new MongoClient(connectionString);
            var server = client.GetServer();
            database = server.GetDatabase("fakultet");
            int i = 0;
            string predmeti = "";

            var collection = database.GetCollection<Profesor>("profesori");

            MongoCursor<Profesor> profesori = collection.FindAll();

            foreach (Profesor p in profesori.ToArray<Profesor>())
            {
                this.dataGridView.Rows.Add();
                this.dataGridView.Rows[i].HeaderCell.Value = String.Format("{0}", dataGridView.Rows[i].Index + 1);
                this.dataGridView.Rows[i].Cells[0].Value = p.Ime;
                this.dataGridView.Rows[i].Cells[1].Value = p.Prezime;

                for (int j = 0; j < p.listaPredmeta.Count; j++)
                {
                    predmeti += p.listaPredmeta[j];
                    if (j != p.listaPredmeta.Count - 1)
                        predmeti += ", ";
                }

                this.dataGridView.Rows[i].Cells[2].Value = predmeti;
                predmeti = "";
                i++;
            }
        }
    }
}

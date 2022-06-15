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
using MongoDB.Driver.Linq;
using MongoDB.Driver.Builders;

namespace FakultetskiOrganizator
{
    public partial class PregledPredmeta : Form
    {
        public PregledPredmeta()
        {
            InitializeComponent();
        }

        MongoDatabase database;

        private void PregledPredmeta_Load(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            MongoClient client = new MongoClient(connectionString);
            var server = client.GetServer();
            database = server.GetDatabase("fakultet");
            int i = 0;
            string predmetiOcene = "";

            var collection = database.GetCollection<Predmet>("predmeti");
            var collection2 = database.GetCollection<Profesor>("profesori");

            MongoCursor<Predmet> predmeti = collection.FindAll();

            foreach (Predmet pr in predmeti.ToArray<Predmet>())
            {
                this.dataGridView.Rows.Add();
                this.dataGridView.Rows[i].HeaderCell.Value = String.Format("{0}", dataGridView.Rows[i].Index + 1);
                this.dataGridView.Rows[i].Cells[0].Value = pr.nazivPredmeta;
                this.dataGridView.Rows[i].Cells[1].Value = pr.brojESPB;
                this.dataGridView.Rows[i].Cells[2].Value = pr.Asistent;
                this.dataGridView.Rows[i].Cells[3].Value = pr.brojStudenata;

                
                //var entity = dbCollection.FindOne(query_id);

                foreach(Profesor profa in collection2.FindAll())
                {
                    Profesor pro = new Model.Profesor();
                    if (pr.Profesor!=null)
                        pro = database.FetchDBRefAs<Profesor>(pr.Profesor);
                    /*var query_id = Query.EQ("_id", ObjectId.Parse(profa.Id.ToString()));
                    var query = Query.EQ("Profesor : { $id", ObjectId.Parse(profa.Id.ToString()));
                    var entity = collection2.FindOne(query_id);*/
                    if (pro.Id == profa.Id)
                        this.dataGridView.Rows[i].Cells[4].Value = profa.Ime + " " + profa.Prezime;

                }

                /*var query = from profa in collection2.AsQueryable<Profesor>()
                            where profa.Id. == pr.Profesor.Id
                            select profa;*/

                /*foreach (Profesor profesor in query)
                {
                    this.dataGridView.Rows[i].Cells[4].Value = profesor.Ime + profesor.Prezime;
                }*/

                i++;
            }
        }
    }
}

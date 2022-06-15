using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MongoDB.Driver;
using MongoDB.Bson;

namespace FakultetskiOrganizator.Model
{
    class Student
    {
        public ObjectId Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int brojIndeksa { get; set; }
        public double prosek { get; set; }
        public List<int> listaOcena = new List<int>();

        public List<string> listaPredmeta = new List<string>();
    }
}

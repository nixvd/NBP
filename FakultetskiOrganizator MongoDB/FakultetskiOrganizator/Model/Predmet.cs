using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MongoDB.Driver;
using MongoDB.Bson;

namespace FakultetskiOrganizator.Model
{
    class Predmet
    {
        public ObjectId Id { get; set; }
        public string nazivPredmeta { get; set; }
        public int brojESPB { get; set; }
        public string Asistent { get; set; }
        public int brojStudenata { get; set; }
        public MongoDBRef Profesor { get; set; }
    }
}

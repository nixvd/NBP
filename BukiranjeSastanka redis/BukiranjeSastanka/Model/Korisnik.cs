using ServiceStack.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BukiranjeSastanka.Model
{
    class Korisnik
    {
        public string ime { get; set; }
        public string prezime { get; set; }
        public string[] email { get; set; }
        public string[] brTel { get; set; }

        public Korisnik()
        {

        }

        public Korisnik(string ime, string prezime, string[] email, string[] brTel)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.email = email;
            this.brTel = brTel;
        }

        public string ToJsonString()
        {
            return JsonSerializer.SerializeToString<Korisnik>(this);
        }
    }
}

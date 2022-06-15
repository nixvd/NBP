using ServiceStack.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BukiranjeSastanka.Model
{
    class Sastanak
    {
        public string datum { get; set; }
        public string vreme { get; set; }
        public string mesto { get; set; }
        public string korisnik { get; set; }

        public Sastanak()
        {

        }

        public Sastanak(string datum, string vreme, string mesto, string korisnik)
        {
            this.datum = datum;
            this.vreme = vreme;
            this.mesto = mesto;
            this.korisnik = korisnik;
        }

        public string ToJsonString()
        {
            return JsonSerializer.SerializeToString<Sastanak>(this);
        }
    }
}

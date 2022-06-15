using ServiceStack.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BukiranjeSastanka.Model
{
    class Konferencija
    {
        public string datum { get; set; }
        public string vreme { get; set; }
        public string mesto { get; set; }
        public string tip { get; set; }

        public Konferencija()
        {

        }

        public Konferencija(string datum, string vreme, string mesto, string tip)
        {
            this.datum = datum;
            this.vreme = vreme;
            this.mesto = mesto;
            this.tip = tip;
        }

        public string ToJsonString()
        {
            return JsonSerializer.SerializeToString<Konferencija>(this);
        }
    }
}

using ServiceStack.Redis;
using ServiceStack.Text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BukiranjeSastanka.Model;

namespace BukiranjeSastanka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
        }

        public RedisClient redis = new RedisClient(Config.SingleHost);

        string[] ms = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
        int test1 = 0;
        int test2 = 0;
        int id = 0;
        int idKonferencije = 0;
        int sid = 0;

        private void dodajTextBoxEmail(int p)
        {
            brTelLabel.Location = new Point(brTelLabel.Location.X, brTelLabel.Location.Y + 25);
            brTelTb1.Location = new Point(brTelTb1.Location.X, brTelTb1.Location.Y + 25);
            dodajBroj.Location = new Point(brTelTb1.Location.X, brTelTb1.Location.Y + 25);

            TextBox txt = new TextBox();
            txt.Name = "dodatTbEmail" + p.ToString();
            txt.Width = emailTb1.Width;
            txt.Location = new Point(emailTb1.Location.X, emailTb1.Location.Y + p * 25);
            dodajEmail.Location = new Point(txt.Location.X, txt.Location.Y + 25);
            pKorisnikTab.Controls.Add(txt);
            test1++;
        }

        private void dodajTextBoxBr(int p)
        {
            TextBox txt = new TextBox();
            txt.Name = "dodatTbBroj" + p.ToString(); //dodatTbBroj1, dodatTbBroj2...
            txt.Width = brTelTb1.Width;
            txt.Location = new Point(brTelTb1.Location.X, brTelTb1.Location.Y + p * 25);
            dodajBroj.Location = new Point(txt.Location.X, txt.Location.Y + 25);
            pKorisnikTab.Controls.Add(txt);
            test2++;
        }

        private void dodajBroj_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (test1 < 2)
            {
                dodajTextBoxEmail(test1 + 1);
            }
            else
            {
                MessageBox.Show("Ne mozete dodati vise od 3 email adrese!");
            }
                
        }

        private void dodajBroj_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(test2 < 2)
            {
                dodajTextBoxBr(test2 + 1);
            }
            else
                MessageBox.Show("Ne mozete dodati vise od 3 broja telefona!");
        }

        private void pSastanakTab_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //redis.FlushDb();

            id = redis.Get<int>("ppid");
            sid = redis.Get<int>("psid");
            idKonferencije = redis.Get<int>("idKonferencije");

            dateTimePicker.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Format = DateTimePickerFormat.Short;

            timePicker.Format = DateTimePickerFormat.Time;
            timePicker.ShowUpDown = true;
            timePicker2.Format = DateTimePickerFormat.Time;
            timePicker2.ShowUpDown = true;
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(dateTimePicker.Text);
        }

        private void timePicker_ValueChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(timePicker.Text);
        }

        int test = 0;

        private void pKorisnikDodaj_Click(object sender, EventArgs e)
        {
            foreach(Control c in pKorisnikTab.Controls)
            {
                if(c is TextBox)
                {
                    if(String.IsNullOrEmpty(c.Text))
                    {
                        test++;
                    }
                }
            }

            if(test <= 4 && test > 0)
            {
                MessageBox.Show("Morate uneti sve podatke!");
                test = 0;
            }
            else
            {
                test = 0;
                string ime = imeTb.Text;
                string prezime = prezimeTb.Text;
                string[] email = new string[3];
                email[0] = emailTb1.Text;

                string[] broj = new string[3];
                broj[0] = brTelTb1.Text;
                if (pKorisnikTab.Controls.Find("dodatTbEmail1", true).Length > 0)
                {
                    email[1] = pKorisnikTab.Controls.Find("dodatTbEmail1", true)[0].Text;
                }
                if (pKorisnikTab.Controls.Find("dodatTbEmail2", true).Length > 0)
                {
                    email[2] = pKorisnikTab.Controls.Find("dodatTbEmail2", true)[0].Text;
                }
                if (pKorisnikTab.Controls.Find("dodatTbBroj1", true).Length > 0)
                {
                    broj[1] = pKorisnikTab.Controls.Find("dodatTbBroj1", true)[0].Text;
                }
                if (pKorisnikTab.Controls.Find("dodatTbBroj2", true).Length > 0)
                {
                    broj[2] = pKorisnikTab.Controls.Find("dodatTbBroj2", true)[0].Text;
                }

                Korisnik pp = new Korisnik(ime, prezime, email, broj);

                Korisnik pp1 = new Korisnik();

                redis.Incr("ppid");
                id = redis.Get<int>("ppid");

                redis.Set("korisnik:" + id, pp.ToJsonString());

                string ppar = redis.Get<string>("korisnik:" + id);

                pp1 = (Korisnik)JsonSerializer.DeserializeFromString(ppar, typeof(Korisnik));

                MessageBox.Show(pp1.ime);

            }
        }

        private void pSastanakDodaj_Click(object sender, EventArgs e)
        {
            foreach (Control c in pSastanakTab.Controls)
            {
                if (c is TextBox)
                {
                    if (String.IsNullOrEmpty(c.Text))
                    {
                        test++;
                    }
                }
            }

            if (test <= 2 && test > 0)
            {
                MessageBox.Show("Morate uneti sve podatke!");
                test = 0;
            }
            else
            {
                test = 0;
                
                string datum = dateTimePicker.Text;
                string vreme = timePicker.Text;
                string mesto = mestoSTb.Text;
                string korisnik = comboBoxS.SelectedItem.ToString();

                for (int i = 1; i <= sid; i++)
                {
                    Sastanak psas = new Sastanak();
                    string ss = redis.Get<string>("sastanak:" + i);
                    psas = (Sastanak)JsonSerializer.DeserializeFromString(ss, typeof(Sastanak));
                    if (psas.datum == datum)
                    {
                        if(psas.vreme == vreme)
                        {
                            MessageBox.Show("Vec postoji zakazani sastanak za taj termin.");
                            return;
                        }
                    }
                }

                Sastanak ps = new Sastanak(datum, vreme, mesto, korisnik);

                Sastanak ps1 = new Sastanak();

                redis.Incr("psid");
                sid = redis.Get<int>("psid");

                redis.Set("sastanak:" + sid, ps.ToJsonString());

                string psar = redis.Get<string>("sastanak:" + sid);

                ps1 = (Sastanak)JsonSerializer.DeserializeFromString(psar, typeof(Sastanak));

                MessageBox.Show(ps1.korisnik);



                /*Sastanak ps = new Sastanak(datum, vreme, mesto, korisnik);

                redis.PushItemToList("sastanak", ps.ToJsonString());

                List<Sastanak> sastanak = new List<Sastanak>();

                foreach (string jsonSastanciString in redis.GetRangeFromList("sastanak", 0, 100))
                {
                    Sastanak s = (Sastanak)JsonSerializer.DeserializeFromString(jsonSastanciString, typeof(Sastanak));
                    sastanak.Add(s);
                }

                MessageBox.Show(sastanak[0].datum + " " + sastanak[0].vreme + " " + sastanak[0].mesto);*/
            }
            DodavanjeKorisnika dp = new DodavanjeKorisnika(id);
            dp.Show();
        }

        private void pKonfDodaj_Click(object sender, EventArgs e)
        {
            foreach (Control c in pKonferencijaTab.Controls)
            {
                if (c is TextBox)
                {
                    if (String.IsNullOrEmpty(c.Text))
                    {
                        test++;
                    }
                }
            }

            if (test <= 2 && test > 0)
            {
                MessageBox.Show("Morate uneti sve podatke!");
                test = 0;
            }
            else
            {
                test = 0;
                string datum = dateTimePicker2.Text;
                string vreme = timePicker2.Text;
                string mesto = mestoKTb.Text;
                string tipKonf = comboBoxK.SelectedItem.ToString();

                for (int i = 1; i <= idKonferencije; i++)
                {
                    Konferencija pkonf = new Konferencija();
                    string sk = redis.Get<string>("konferencija:" + i);
                    pkonf = (Konferencija)JsonSerializer.DeserializeFromString(sk, typeof(Konferencija));
                    if (pkonf.datum == datum)
                    {
                        if (pkonf.vreme == vreme)
                        {
                            MessageBox.Show("Vec postoji zakazana konferencija za taj termin.");
                            return;
                        }
                    }
                }

                Konferencija k = new Konferencija(datum, vreme, mesto, tipKonf);

                Konferencija k1 = new Konferencija();

                redis.Incr("idKonferencije");
                idKonferencije = redis.Get<int>("idKonferencije");

                redis.Set("konferencija:" + idKonferencije, k.ToJsonString());

                string pkar = redis.Get<string>("konferencija:" + idKonferencije);

                k1 = (Konferencija)JsonSerializer.DeserializeFromString(pkar, typeof(Konferencija));

                MessageBox.Show(k1.mesto);

            }

            DodavanjeKorisnika dp = new DodavanjeKorisnika(id);
            dp.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Korisnik> pPartneri = new List<Korisnik>();
            Korisnik p = new Korisnik();
            string s = "";

            for(int i = 2; i <= id; i++)
            {
                s = redis.Get<string>("korisnik:" + i);
                p = (Korisnik)JsonSerializer.DeserializeFromString(s, typeof(Korisnik));
                pPartneri.Add(p);
                MessageBox.Show(p.ime + " " + p.prezime);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Sastanak> pSas = new List<Sastanak>();
            Sastanak ps = new Sastanak();
            string s = "";

            for (int i = 1; i <= sid; i++)
            {
                s = redis.Get<string>("sastanak:" + i);
                ps = (Sastanak)JsonSerializer.DeserializeFromString(s, typeof(Sastanak));
                pSas.Add(ps);
                MessageBox.Show(ps.datum + " " + ps.mesto);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<Konferencija> pKonf = new List<Konferencija>();
            Konferencija pk = new Konferencija();
            string s = "";

            for (int i = 1; i <= idKonferencije; i++)
            {
                s = redis.Get<string>("konferencija:" + i);
                pk = (Konferencija)JsonSerializer.DeserializeFromString(s, typeof(Konferencija));
                pKonf.Add(pk);
                MessageBox.Show(pk.datum + " " + pk.mesto);

                List<Korisnik> korisnik = new List<Korisnik>();

                foreach (string par in redis.GetRangeFromList("konferencija:" + i + ":korisnik", 0, 100))
                {
                    Korisnik p = (Korisnik)JsonSerializer.DeserializeFromString(par, typeof(Korisnik));
                    korisnik.Add(p);
                    MessageBox.Show(p.ime + " " + p.prezime);
                }

            }
            for(int i=0; i<pKonf.Count-1;i++)
            {
                Konferencija konf = new Konferencija();
                string[] dsi = pKonf[i].datum.Split('-');
                string[] dsi1 = pKonf[i + 1].datum.Split('-');
                if (Int32.Parse(dsi[2]) > Int32.Parse(dsi1[2]))
                {
                    konf = pKonf[i];
                    pKonf[i] = pKonf[i + 1];
                    pKonf[i + 1] = pKonf[i];
                }

                //sortira po datumu
                if(Int32.Parse(dsi[2]) == Int32.Parse(dsi1[2]))
                {
                    int a=0, b=0;
                    for(int j=0; j < ms.Length; j++)
                    {
                        if (ms[j] == dsi[1])
                            a = j;
                        if (ms[j] == dsi1[1])
                            b = j;
                    }
                    if (a > b)
                    {
                        konf = pKonf[i];
                        pKonf[i] = pKonf[i + 1];
                        pKonf[i + 1] = pKonf[i];
                    }
                    if(a == b)
                    {
                        if (Int32.Parse(dsi[0]) > Int32.Parse(dsi1[0]))
                        {
                            konf = pKonf[i];
                            pKonf[i] = pKonf[i + 1];
                            pKonf[i + 1] = pKonf[i];
                        }
                        if(Int32.Parse(dsi[0]) == Int32.Parse(dsi1[0]))
                        {                                                
                            
                            string tti = pKonf[i].vreme;
                            string tti1 = pKonf[i + 1].vreme;

                            string[] tsi = tti.Split(':');
                            string[] tsi1 = tti1.Split(':');

                            if (Int32.Parse(tsi[0]) > Int32.Parse(tsi1[0]))
                            {
                                konf = pKonf[i];
                                pKonf[i] = pKonf[i + 1];
                                pKonf[i + 1] = pKonf[i];
                            }
                            if(Int32.Parse(tsi[0]) == Int32.Parse(tsi1[0]))
                            {
                                if(Int32.Parse(tsi[1]) > Int32.Parse(tsi1[1]))
                                {
                                    konf = pKonf[i];
                                    pKonf[i] = pKonf[i + 1];
                                    pKonf[i + 1] = pKonf[i];
                                }
                            }
                        }
                    }
                }
                //prikazuje prvih 10 ako ima ako ne koliko ima
                if (pKonf.Count >= 10)
                {
                    for (int k = 0; k < 10; k++)
                    {
                        MessageBox.Show(pKonf[k].datum + " " + pKonf[k].vreme + " " + pKonf[k].mesto);
                    }
                }
                else
                {
                    for (int k = 0; k < pKonf.Count; k++)
                    {
                        MessageBox.Show(pKonf[k].datum + " " + pKonf[k].vreme + " " + pKonf[k].mesto);
                    }
                }
                    
            }
        }
    }
}

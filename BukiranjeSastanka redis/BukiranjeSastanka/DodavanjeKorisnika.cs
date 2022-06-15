using ServiceStack.Redis;
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
using ServiceStack.Text;
using System.Text.RegularExpressions;

namespace BukiranjeSastanka
{
    public partial class DodavanjeKorisnika : Form
    {
        int ppid = 0;
        public DodavanjeKorisnika(int tmp)
        {
            this.ppid = tmp + 1;
            InitializeComponent();
        }

        RedisClient redis = new RedisClient(Config.SingleHost);

        private void dodajKorisnike_Click(object sender, EventArgs e)
        {
            if (korisnik1.SelectedItem == null)
                korisnik1.SelectedItem = "";
            if(korisnik2.SelectedItem == null)
                korisnik2.SelectedItem = "";
            if (korisnik3.SelectedItem == null)
                korisnik3.SelectedItem = "";


                if (korisnik1.SelectedItem == korisnik2.SelectedItem && korisnik1.SelectedItem != null || korisnik1.SelectedItem == korisnik3.SelectedItem && korisnik1.SelectedItem != null
                                                                   || korisnik2.SelectedItem == korisnik3.SelectedItem && korisnik2.SelectedItem != null)
                {
                    MessageBox.Show("Nazalost, ne mozete klonirati korisnika! :)");
                    return;
                }

            int idKonf = 0;
            int ppid = 0;
            Korisnik korisnik = new Korisnik();

            idKonf = redis.Get<int>("idKonferencije");
            ppid = korisnik1.Items.IndexOf(korisnik1.SelectedItem.ToString())+1;
            ppid++;

            string ppar = redis.Get<string>("korisnik:" + ppid);

            korisnik = (Korisnik)JsonSerializer.DeserializeFromString(ppar, typeof(Korisnik));

            redis.PushItemToList("konferencija:" + idKonf + ":korisnik", korisnik.ToJsonString());

            if (korisnik2.SelectedItem != null)
            {
                ppid = korisnik2.Items.IndexOf(korisnik2.SelectedItem.ToString())+1;
                ppid++;

                string ppar2 = redis.Get<string>("korisnik:" + ppid);

                korisnik = (Korisnik)JsonSerializer.DeserializeFromString(ppar2, typeof(Korisnik));

                redis.PushItemToList("konferencija:" + idKonf + ":korisnik", korisnik.ToJsonString());

            }

            if (korisnik3.SelectedItem != null)
            {

                ppid = korisnik3.Items.IndexOf(korisnik3.SelectedItem.ToString())+1;
                ppid++;

                string ppar3 = redis.Get<string>("korisnik:" + ppid);

                korisnik = (Korisnik)JsonSerializer.DeserializeFromString(ppar3, typeof(Korisnik));

                redis.PushItemToList("konferencija:" + idKonf + ":korisnik", korisnik.ToJsonString());

            }

        }

        private void DodavanjeKorisnika_Load(object sender, EventArgs e)
        {
            Korisnik korisnik = new Korisnik();
            string ime = "";
            for (int i = 2; i < ppid; i++)
            {
                string ppar = redis.Get<string>("korisnik:" + i);
                korisnik = (Korisnik)JsonSerializer.DeserializeFromString(ppar, typeof(Korisnik));
                ime = korisnik.ime + " " + korisnik.prezime;
                korisnik1.Items.Add(ime);
                korisnik2.Items.Add(ime);
                korisnik3.Items.Add(ime);
            }

            /*int i = 0;
            
            byte[][] test = null;
            
            string[] q = new string[ppid];
            
            while (i < ppid)
            {
                q[i] = "korisnik:" + i;
                i++;
            }

            test = redis.MGet(q);
            string[] niz = new string[test.Length - 1];
            niz[1] = System.Text.Encoding.UTF8.GetString(test[1]);
            niz[0] = System.Text.Encoding.Default.GetString(test[1]);*/
            /*for (int j = 1; j < test.Length; j++)
            {
                niz[j-1] = System.Text.Encoding.Default.GetString(test[j]);
                korisnik = (Korisnik)JsonSerializer.DeserializeFromString(niz[j - 1], typeof(Korisnik));
                ime = korisnik.ime + " " + korisnik.prezime;
                korisnik1.Items.Add(ime);
                korisnik2.Items.Add(ime);
                korisnik3.Items.Add(ime);
            }*/

            //string n1 = ToString(test[1]);
            //char[] niz1 = niz[0].ToCharArray();
            /* n1 += niz1[0].ToString().Replace(niz1[0], ' ');
             n1 += niz1[1].ToString().Replace(niz1[1], ' ');
             n1 += niz1[niz1.Length - 2].ToString().Replace(niz1[niz1.Length - 2], ' ');
             n1 += niz1[niz1.Length - 3].ToString().Replace(niz1[niz1.Length - 3], ' ');*/
            //niz1[0] = ' ';
            //niz1[1] = ' ';
            //niz1[niz1.Length - 1] = ' ';
            //niz1[niz1.Length - 3] = ' ';

            /*for (int p = 0; p < niz1.Length; p++)
            {
                if (niz1[p] == '\\')
                {
                    if(niz1[p+1] == '\\')
                    {
                        niz1[p + 1] = ' ';
                    }
                }
            }
            
            n1 = new string(niz1);
            n1 = Regex.Replace(n1, @"\s", "");
            Console.WriteLine(niz1[niz1.Length-1]);
            Console.WriteLine(niz1[niz1.Length - 2]);
            Console.WriteLine(niz1[niz1.Length - 3]);
            Console.WriteLine(niz1[niz1.Length - 4]);
            Console.WriteLine(niz1[niz1.Length - 5]);*/
            //string tmp = (string)JsonSerializer.DeserializeFromString(n1, typeof(string));


        }
    }
}

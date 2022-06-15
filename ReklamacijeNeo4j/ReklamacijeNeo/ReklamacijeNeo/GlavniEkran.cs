using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReklamacijeNeo
{
    public partial class GlavniEkran : Form
    {
        public GlavniEkran()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f4 = new Form1();
            f4.ShowDialog();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            UnesiReklamaciju f2 = new UnesiReklamaciju();
            f2.ShowDialog();
        }
    }
}

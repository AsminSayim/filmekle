using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace filmekle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void FilmEkle_Click(object sender, EventArgs e)
        {
            FormFilmEkle formFilmEkle = new FormFilmEkle();
            formFilmEkle.ShowDialog();
        }

        private void FilmListesi_Click(object sender, EventArgs e)
        {
            FormFilmListe formFilmListesi = new FormFilmListe();
            formFilmListesi.ShowDialog();
        }
    }
}

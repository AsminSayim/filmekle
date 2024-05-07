using MySql.Data.MySqlClient;
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
    public partial class FormFilmListe : Form
    {
        public FormFilmListe()
        {
            InitializeComponent();
        }
        string baglanti = "Server=localhost;Database=sinema_veritabani;Uid=root;Pwd=''";
        private void FormFilmListe_Load(object sender, EventArgs e)
        {
            VeriGetir();
        }

        private void VeriGetir()
        {
            using (MySqlConnection con = new MySqlConnection(baglanti))
            {

                string sql = "SELECT *FROM filmler";
                con.Open();

                MySqlCommand cmd = new MySqlCommand(sql, con);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvListe.DataSource = dt;
                dgvListe.Invalidate();
                dgvListe.Refresh();

            }
        }

        private void dgvListe_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvListe.CurrentRow.Cells["id"].Value.ToString();
            txtFilmAd.Text = dgvListe.CurrentRow.Cells["filmad"].Value.ToString();
            txtTur.Text = dgvListe.CurrentRow.Cells["tur"].Value.ToString();
            txtImdb.Text = dgvListe.CurrentRow.Cells["imdb_puan"].Value.ToString();
            txtYil.Text = dgvListe.CurrentRow.Cells["yil"].Value.ToString();
            txtOzet.Text = dgvListe.CurrentRow.Cells["ozet"].Value.ToString();
            pbPoster.ImageLocation = dgvListe.CurrentRow.Cells["film_posteri"].Value.ToString();


        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(baglanti))
            {
                string sql = "DELETE FROM filmler WHERE id=@id";
                int id = Convert.ToInt32(txtId.Text);

                con.Open();

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", id);



                DialogResult result = MessageBox.Show("Film silinsin mi?", "Film Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                    VeriGetir();
                }


            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(baglanti))
            {
                string sql = "UPDATE filmler SET filmad=@filmad, tur=@tur,yil=@yil,imdb_puan=@imdb_puan,film_posteri=@film_posteri,ozet=@ozet WHERE id=@id;";
                int id = Convert.ToInt32(txtId.Text);


                con.Open();

                MySqlCommand cmd = new MySqlCommand(sql, con);


                cmd.Parameters.AddWithValue("@filmad", txtFilmAd.Text);
                cmd.Parameters.AddWithValue("@tur", txtTur.Text);
                cmd.Parameters.AddWithValue("@yil", txtYil.Text);
                cmd.Parameters.AddWithValue("@imdb_puan", txtImdb.Text);
                cmd.Parameters.AddWithValue("@film_posteri","resimler\\1.jpg");
                cmd.Parameters.AddWithValue("@ozet", txtOzet.Text);
                cmd.Parameters.AddWithValue("@id", txtId.Text);




                DialogResult result = MessageBox.Show("Film güncellensin mi?", "Film Güncelle", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                    VeriGetir();
                }


            }

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Personel_Listesi
{
    public partial class FormAnaform : Form
    {
        public FormAnaform()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=BETšSPC\\SQLEXPRESS;Initial Catalog=Personel_dataBase1;Integrated Security=True");
        
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'personel_dataBase1DataSet1.Table_Personel' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            this.table_PersonelTableAdapter.Fill(this.personel_dataBase1DataSet1.Table_Personel);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("insert into Table_Personel (PerName,PerSN,Perproff, PerSal, persehir, Permarital) values (@p1,@p2,@p3,@p4,@p5, @p6) ", baglanti);

            komut.Parameters.AddWithValue("@p1", txtIsım.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyısım.Text);
            komut.Parameters.AddWithValue("@p3", txtMeslek.Text);
            komut.Parameters.AddWithValue("@p4", maas.Text);
            komut.Parameters.AddWithValue("@p5", sehircombo.Text);
            komut.Parameters.AddWithValue("@p6", label8.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel Bilgileri Eklendi.");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                label8.Text = "False";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label8.Text = "True";
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            void temizlee ()
            {
                txtIsım.Text = " ";
                txtSoyısım.Text = " ";
                txtID.Text = " ";
                txtMeslek.Text = " ";
                sehircombo.Text = " ";
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                maas.Text = " ";
                txtIsım.Focus();

            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtIsım.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSoyısım.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            sehircombo.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            maas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtMeslek.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
                
        }

        private void Form1_TextChanged(object sender, EventArgs e)
        {
            if (label8.Text == "True")
            {
                radioButton1.Checked = true;
            }
            if (label8.Text == "False")
            {
                radioButton2.Checked = true;
            }
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand SilmeKomudu = new SqlCommand("Delete from table_personel where PerID=@k1", baglanti);
            SilmeKomudu.Parameters.AddWithValue("@k1", txtID.Text);
            SilmeKomudu.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("Kayıt Silindi.");
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand GuncellemeKomudu = new SqlCommand("Update table_personel set PerName=@a1, persn=@a2, perproff=@a3, PerSal=@a4, Persehir=@a5, permarital=@a6 where perID=@a7", baglanti);
            GuncellemeKomudu.Parameters.AddWithValue("@a1", txtIsım.Text);
            GuncellemeKomudu.Parameters.AddWithValue("@a2", txtSoyısım.Text);
            GuncellemeKomudu.Parameters.AddWithValue("@a3", txtMeslek.Text);
            GuncellemeKomudu.Parameters.AddWithValue("@a4", maas.Text);
            GuncellemeKomudu.Parameters.AddWithValue("@a5", sehircombo.Text);
            GuncellemeKomudu.Parameters.AddWithValue("@a6", label8.Text);
            GuncellemeKomudu.Parameters.AddWithValue("@a7", txtID.Text);
            GuncellemeKomudu.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("Personel Bilgileri Güncellendi.");
        }

        private void btnIstatistik_Click(object sender, EventArgs e)
        {
            FormIstatistik fr = new FormIstatistik();
            fr.Show();
        }

        private void btnGrafik_Click(object sender, EventArgs e)
        {

        }
    }
}

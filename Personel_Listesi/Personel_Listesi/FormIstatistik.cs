using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Personel_Listesi
{
    public partial class FormIstatistik : Form
    {
        public FormIstatistik()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=BETšSPC\\SQLEXPRESS;Initial Catalog=Personel_dataBase1;Integrated Security=True");

        private void FormIstatistik_Load(object sender, EventArgs e)
        {
            //Toplam Personel Sayısı

            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("Select count(*) from table_personel", baglanti);

            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                lbltoplam.Text = dr1[0].ToString();
            }

            baglanti.Close();

            //Evli Persobel Sayısı
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select count(*) from table_personel where permarital=1", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                lblevli.Text = dr2[0].ToString();

            } baglanti.Close();

            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Select count(*) from table_personel where permarital=0", baglanti);
            IDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                lblbekar.Text = dr3[0].ToString();
            } baglanti.Close();

            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select count(distinct(PerSehir)) from Table_Personel", baglanti);
            IDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                lblsehirsayisi.Text = dr4[0].ToString();
            } baglanti.Close();

            //Toplam Maaş
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("Select sum(PerSal) from Table_Personel", baglanti);
            IDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                lblTopMaas.Text = dr5[0].ToString();
            }
            baglanti.Close();

            //Ortalama Maaş

            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("Select avg(PerSal) from table_personel", baglanti);
            IDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                lblOrtMaas.Text = dr6[0].ToString();
            }

        }



        private void label1_Click(object sender, EventArgs e)
        {
           
        }
    }
}

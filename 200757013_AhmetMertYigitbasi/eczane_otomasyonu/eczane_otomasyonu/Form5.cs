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

namespace eczane_otomasyonu
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-0P5P493\\SQLEXPRESS;Initial Catalog=Eczane;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("SELECT urun_kodu, urun_adi, alinan_adet,ucret,alinan_adet * ucret as Toplam FROM Tbl_ilac_alis", con);
            SqlDataAdapter da = new SqlDataAdapter(komut);  //sql sorgusunu çalıştırır. gelen çıktıları DataTable fonksiyonuna aktarır.
            DataTable dt = new DataTable(); // datatable tanımlama
            da.Fill(dt); //da verilerini dtye tanımlama
            dataGridView1.DataSource = dt;// yeni veri kaynağı dt
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("SELECT urun_kodu, urun_adi, satilan_adet,ucret,satilan_adet * ucret as Toplam FROM Tbl_ilac_satis", con);
            SqlDataAdapter da = new SqlDataAdapter(komut);  //sql sorgusunu çalıştırır. gelen çıktıları DataTable fonksiyonuna aktarır.
            DataTable dt = new DataTable(); // datatable tanımlama
            da.Fill(dt); //da verilerini dtye tanımlama
            dataGridView1.DataSource = dt;// yeni veri kaynağı dt
        }
    }
}


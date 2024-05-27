//reçeteyle satın alımlarda yüzde 20 toplam indirim yap.
//veritabanından hasta bilgilerini (en azından sira, ad soyad reçete tarihi ve ilaç) çek
//combobox'tan hastayı seç. butona tıkla. ilaçların olduğu combobox'ta sadece seçilen kişinin alacağı ilacı getir. her ilaçtan bir adet alınabilir reçetedekilerden.
//ilacı seç ve işlemi tamamla. satış başarılı
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
    public partial class reçete : Form
    {
        public reçete()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-0P5P493\\SQLEXPRESS;Initial Catalog=Eczane;Integrated Security=True");
        private void reçete_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("SELECT dbo.func_recetedeki_ilac(@hasta_adi_soyadi)", con);
            komut.Parameters.AddWithValue("@hasta_adi_soyadi", textBox1.Text);
            con.Open();
            string ilac = komut.ExecuteScalar() as string;
            textBox2.Text = ilac;
            con.Close();

        }
        //15 gün olayını ayarla. 1 fonksiyon eksik ve 3 trigger kullanmak zorundayım.
        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("SELECT dbo.func_ilac_ucreti(@ilac)", con);
            komut1.Parameters.AddWithValue("@ilac", textBox2.Text);
            con.Open();
            int ucret = (int)komut1.ExecuteScalar(); // SQL'den dönen integer tipi veriyi al
            textBox3.Text = ucret.ToString();
            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //burada view kullanabilirsen kullan. iki tabloyu birleştir. hasta adi, alerji falan al diğer tablodan ilaçlarla ilgili bilgiler
            con.Open();
            SqlCommand komut = new SqlCommand("select * from vw_hasta_ilac_tablosu order by sira", con);
            SqlDataAdapter da = new SqlDataAdapter(komut);  //sql sorgusunu çalıştırır. gelen çıktıları DataTable fonksiyonuna aktarır.
            DataTable dt = new DataTable(); // datatable tanımlama
            da.Fill(dt); //da verilerini dtye tanımlama
            dataGridView1.DataSource = dt;// yeni veri kaynağı dt
            
            con.Close();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            //trigger çalışıyor.
            if (!string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("reçete doğrulandı. 15 gün henüz geçmemiş. 1 adet ilaç alabilir.");
            }
            else
            {
                MessageBox.Show("reçetenin süresi dolmuştur. ilaç satışı yapılamaz.");
                // satış işleminde bu kısma göre işlem yapılsın
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlCommand komut1 = new SqlCommand("sp_ilac_satis", con))
            {
                // buradaki stored procedure çalışmak için ürün koduna ihtiyaç duymaktadır. ürün kodu olmadan azaltma işlemi yapılamaz. stok miktarını bir azalt
                komut1.CommandType = CommandType.StoredProcedure;// bu şekilde stored procedure entegre edilmiştir.
                komut1.Parameters.AddWithValue("@urun_adi", textBox2.Text);
                komut1.Parameters.AddWithValue("@miktar", 1);
                con.Open();
                komut1.ExecuteNonQuery();
                //MessageBox.Show("satış bitti."); birer birer azaltıyor.
                con.Close() ;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = false;

        }
    }
}

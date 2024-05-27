// çeşitli sıkıntılar var. ekleyebilirsem ilaç sınırlaması getireceğim. ücretlerde indirim olmayacak
// bir adet stored proscedure oluştur reçetesiz alınacak ilaçları listele( mesela ağrılar için alınacak ilaçlar ). sonra bunu bir trigger ile listbox'a eklemeyi dene
// ya da satış işlemi yapıldıktan sonra trigger ile stoğu 1 azalt.
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace eczane_otomasyonu
{
    public partial class reçetesiz : Form
    {
        public reçetesiz()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-0P5P493\\SQLEXPRESS;Initial Catalog=Eczane;Integrated Security=True");

        private void reçetesiz_Load(object sender, EventArgs e)
        {

            // ilaç veritabanını al.
            // reçetesiz olarak satılacak ilaçları belirle.
            // combobox üzerinden birkaç tane seçenek sun.
            // seçilen ilaç listelensin. ilaç adı ücret ve stok miktari
            // satış tuşuna basıldığı zaman stoklardan eksiltme yap.
        }



        private void button1_Click(object sender, EventArgs e)
        {

//Okunan ücret değerini stringden int'e çevirdik
//Adet değerini textbox'tan alıp int'e çevirdik
//Çarpma işlemi yapıp toplamı bir değişkene atadık
//Sonuçları kullanıcıya gösterdik
            con.Open();
            SqlCommand komut = new SqlCommand("select ucret, stok_miktari from Tbl_ilac where urun_adi=@urun_adi",con);
            komut.Parameters.AddWithValue("@urun_adi", comboBox1.SelectedItem.ToString());
            SqlDataReader reader = komut.ExecuteReader();//ücreti burada okutmak için
            if (reader.Read())
            {
                string stok=reader["stok_miktari"].ToString();
                int stok_miktari = Convert.ToInt32(stok);
                string ucret = reader["ucret"].ToString();
                int ucrett = Convert.ToInt32(ucret);
                int adet = Convert.ToInt32(textBox2.Text);
                int toplam = ucrett * adet;
                if(adet < stok_miktari)
                {
                    MessageBox.Show("Toplam ücret: " + toplam);
                    textBox3.Text = toplam.ToString();
                }
                else
                {
                    MessageBox.Show("stok miktari adetten küçük olmak zorundadır.");

                }
            }
            reader.Close();
            con.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)//0 ve 10 arasında değer alabilir.
        {
            using (SqlCommand komut1 = new SqlCommand("sp_ilac_satis", con))
            {
                int adet = Convert.ToInt32(textBox2.Text);
                if (0 < adet && adet < 10)
                {
                    komut1.CommandType = CommandType.StoredProcedure;
                    komut1.Parameters.AddWithValue("@urun_adi", comboBox1.SelectedItem.ToString());
                    komut1.Parameters.AddWithValue("@miktar", textBox2.Text);
                    con.Open();
                    komut1.ExecuteNonQuery();
                    MessageBox.Show("satış başarılı. stoklar adet kadar azaltıldı.");
                    con.Close();
                }
                else
                {
                    MessageBox.Show("satış başarısız. stoklar değişmedi.");

                }



            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            string secilenilac = comboBox1.SelectedItem.ToString();
            SqlCommand komut2 = new SqlCommand("select * from Tbl_ilac where urun_adi=@urun_adi",con);
            komut2.Parameters.AddWithValue("@urun_adi", secilenilac);
            SqlDataAdapter daa = new SqlDataAdapter(komut2);  //sql sorgusunu çalıştırır. gelen çıktıları DataTable fonksiyonuna aktarır.
            DataTable dtt = new DataTable(); // datatable tanımlama
            daa.Fill(dtt); //da verilerini dtye tanımlama
            dataGridView1.DataSource = dtt;// yeni veri kaynağı dt
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tbl_ilacTableAdapter.FillBy1(this.eczaneDataSet.Tbl_ilac);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }




        /*using (SqlCommand komut1 = new SqlCommand("sp_ilacsatis", con))
                    {

                    }
        */

    }
}

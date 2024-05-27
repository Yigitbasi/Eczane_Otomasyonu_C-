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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//reçete verilirken bir combobox üzerinden ilaçlar gösterilebilir. ve oradan seçilebilir. ona göre ilaçları reçeteyle alabilir.
namespace eczane_otomasyonu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-0P5P493\\SQLEXPRESS;Initial Catalog=Eczane;Integrated Security=True");

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'eczaneDataSet6.Tbl_hasta' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.tbl_hastaTableAdapter2.Fill(this.eczaneDataSet6.Tbl_hasta);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();// bağlantı açtım. 
            SqlCommand komut = new SqlCommand("SELECT * FROM dbo.Tbl_hasta ORDER BY sira", con); // virgülden sonra con eklemek önemli yoksa nereden bakacağını bilemiyor.
            SqlDataAdapter da = new SqlDataAdapter(komut);  //sql sorgusunu çalıştırır. gelen çıktıları DataTable fonksiyonuna aktarır.
            DataTable dt = new DataTable(); // datatable tanımlama
            da.Fill(dt); //da verilerini dtye tanımlama
            dataGridView1.DataSource = dt;// yeni veri kaynağı dt
            //listeleme işlemi 
            // TODO: Bu kod satırı 'eczaneDataSet4.Tbl_hasta' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.tbl_hastaTableAdapter.Fill(this.eczaneDataSet4.Tbl_hasta);
            // hastaları listelemem gerek.
            // reçete olayını eklemem gerek.
            // reçetesiz alınmayacak ilaçlar olacak
            // 15 gün kuralı
            con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO Tbl_hasta(sira,hasta_adi_soyadi,hasta_tc,sikayet,recetenin_tarihi,alerjiler,kronik_hastaliklar,recete,ilac) values(@sira,@hasta_adi_soyadi,@hasta_tc,@sikayet,@recetenin_tarihi,@alerjiler,@kronik_hastaliklar,@recete,@ilac)",con);
            komut.Parameters.AddWithValue("@sira", textBox7.Text);
            komut.Parameters.AddWithValue("@hasta_adi_soyadi", textBox1.Text);
            komut.Parameters.AddWithValue("@hasta_tc", textBox2.Text);
            komut.Parameters.AddWithValue("@sikayet", textBox3.Text);
            komut.Parameters.AddWithValue("@recetenin_tarihi", DateTime.Now);
            komut.Parameters.AddWithValue("@alerjiler", textBox4.Text);
            komut.Parameters.AddWithValue("@kronik_hastaliklar", textBox5.Text);
            komut.Parameters.AddWithValue("@recete", comboBox1.SelectedItem.ToString());
            komut.Parameters.AddWithValue("@ilac", textBox6.Text);
            komut.ExecuteNonQuery();

            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand komut = new SqlCommand("DELETE From Tbl_hasta where sira=@s1", con);
            komut.Parameters.AddWithValue("@s1", textBox7.Text);
            komut.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Hasta silinmiştir."); // Hasta silmek için textboxa ürün kodunun değerini girmek gerekiyor.
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            comboBox1.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
        }
        //
        private void button5_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand komut = new SqlCommand("UPDATE Tbl_hasta SET sira=@sira,hasta_adi_soyadi=@hasta_adi_soyadi,hasta_tc=@hasta_tc, sikayet=@sikayet, alerjiler=@alerjiler, kronik_hastaliklar=@kronik_hastaliklar,ilac=@ilac WHERE hasta_adi_soyadi=@hasta_adi_soyadi", con);
            komut.Parameters.AddWithValue("@sira", textBox7.Text);
            komut.Parameters.AddWithValue("@hasta_adi_soyadi", textBox1.Text);
            komut.Parameters.AddWithValue("@hasta_tc", textBox2.Text);
            komut.Parameters.AddWithValue("@sikayet", textBox3.Text);
            //komut.Parameters.AddWithValue("@recetenin_tarihi", DateTime.Now);
            komut.Parameters.AddWithValue("@alerjiler", textBox4.Text);
            komut.Parameters.AddWithValue("@kronik_hastaliklar", textBox5.Text);
            //komut.Parameters.AddWithValue("@recete", comboBox1.SelectedItem.ToString());
            komut.Parameters.AddWithValue("@ilac", textBox6.Text);

            komut.ExecuteNonQuery();

            con.Close();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

// güncelleme ve reçeteye ilaç yazma kaldı. güncelleme kısmında update komutunu kullanarak con.open() sqlcommandlı işlemler yapacağım. executenonquery() unutma. bağlantıyı kapat
// reçeteye ilaç yazmak için c# üzerinden sql'de bir sütun daha oluşturmam gerekiyor. burada reçetede olan ilaçlar yazacak. reçetesi olan herkese ilaç gitmeli.
// reçeteli satış bölümünde reçeteye yazılmış ilaçlar satın alınacak sadece. buna uygun indirim de yapılabilir reçeteden dolayı.



/*            if (comboBox1.SelectedItem != null && comboBox1.SelectedItem.ToString() == "1")
            {
                // ComboBox'tan seçilen değere göre bit değerini atama
                SqlCommand recetedurumu = new SqlCommand("insert into Tbl_hasta(recetenin_tarihi,recete) values(@recetenin_tarihi, @recete)", con);
                recetedurumu.Parameters.AddWithValue("@recetenin_tarihi", DateTime.Now);// gün ay yıl olarak reçetenin verildiği tarih
                recetedurumu.Parameters.AddWithValue("@recete", comboBox1.SelectedItem);// Reçete vermek için 1 veya 0 seçilmeli. bu da bit veri yapısına göre sql'e geçer
                recetedurumu.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("reçete verildi ve hasta eklendi.");

            }

            else
            {
                SqlCommand recetedurumu = new SqlCommand("insert into Tbl_hasta(recetenin_tarihi,recete) values(@recetenin_tarihi, @recete)", con);
                recetedurumu.Parameters.AddWithValue("@recetenin_tarihi", "NULL");// gün ay yıl olarak reçetenin verildiği tarih
                recetedurumu.Parameters.AddWithValue("@recete", comboBox1.SelectedItem);// Reçete vermek için 1 veya 0 seçilmeli. bu da bit veri yapısına göre sql'e geçer
                recetedurumu.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("reçete verilmeden kaydedildi");
            }


 */
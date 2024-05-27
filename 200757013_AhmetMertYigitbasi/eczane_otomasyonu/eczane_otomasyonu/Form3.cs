//ana uygulamadan geçiş yapılacak başka bir form kısmı oluşturuldu. ilaç ekleme ve listeleme özellikleri eklendi. 
// burası güzel çalışıyor.
using System;
using System.Collections;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-0P5P493\\SQLEXPRESS;Initial Catalog=Eczane;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            //con.Open();
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    using (SqlCommand komut1 = new SqlCommand("sp_ilacekle", con))
                    {
                        // buradaki stored procedure çalışmak için ilaç bilgilerine ihtiyaç duymaktadır. 
                        komut1.CommandType = CommandType.StoredProcedure;// bu şekilde stored procedure entegre edilmiştir.
                        komut1.Parameters.AddWithValue("@urun_kodu", textBox1.Text);//sql'deki kullanıcıdan işlem yapmak için istenen değişken
                        komut1.Parameters.AddWithValue("@urun_adi", textBox2.Text);
                        komut1.Parameters.AddWithValue("@stok_miktari", textBox3.Text);
                        komut1.Parameters.AddWithValue("@ucret", textBox4.Text);
                        komut1.Parameters.AddWithValue("talimatlar", textBox5.Text);
                        komut1.Parameters.AddWithValue("sikayet", textBox6.Text);
                        komut1.Parameters.AddWithValue("marka", textBox7.Text);
                        con.Open();
                        komut1.ExecuteNonQuery();
                        MessageBox.Show("ilaç ekleme başarılı.");
                        con.Close();

                        con.Open();

                        //SP öncesi yazmış olduğum kod
                        /*
                        //stored procedure kullanılıp yapılabilir.
                        string kayit = "INSERT INTO Tbl_ilac(urun_kodu,urun_adi,stok_miktari,ucret,talimatlar,sikayet,marka) values (@urun_kodu,@urun_adi,@stok_miktari,@ucret,@talimatlar,@sikayet,@marka)";
                        SqlCommand komut = new SqlCommand(kayit, con);
                        komut.Parameters.AddWithValue("@urun_kodu", textBox1.Text);
                        komut.Parameters.AddWithValue("@urun_adi", textBox2.Text);
                        komut.Parameters.AddWithValue("@stok_miktari", textBox3.Text);
                        komut.Parameters.AddWithValue("@ucret", textBox4.Text);
                        komut.Parameters.AddWithValue("talimatlar", textBox5.Text);
                        komut.Parameters.AddWithValue("sikayet", textBox6.Text);
                        komut.Parameters.AddWithValue("marka", textBox7.Text);

                        komut.ExecuteNonQuery();
                        MessageBox.Show("İlaç eklenmiştir.");
                        */
                    }
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("veritabanında hata" + hata.Message);// hatayı geri döndürüyor eğer olası bir hata varsa onu yakalar.
            }
            finally
            {
                con.Close();
            }


        }
        public void kayitlari_getir()
        {
            try
            {
                con.Open();// bağlantı açtım. 
                SqlCommand komut = new SqlCommand("SELECT * FROM dbo.Tbl_ilac", con); // virgülden sonra con eklemek önemli yoksa nereden bakacağını bilemiyor.
                SqlDataAdapter da = new SqlDataAdapter(komut);  //sql sorgusunu çalıştırır. gelen çıktıları DataTable fonksiyonuna aktarır.
                DataTable dt = new DataTable(); // datatable tanımlama
                da.Fill(dt); //da verilerini dtye tanımlama
                dataGridView1.DataSource = dt;// yeni veri kaynağı dt
            }
            catch (Exception hata)
            {
                MessageBox.Show("Veritabanında bir hata olabilir" + hata.Message);
            }
            finally
            {
                con.Close();// kapatmayı unutma
            }
        }
        public void kayitlari_sil()// yazıları siler. textboxtakiler falan
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // bir trigger oluştur ve bu trigger her güncellemeden(ekleme ya da silme de olur) sonra listeleme işlemini otomatik yapabilsin.
            kayitlari_getir();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Eğer bir hücre içeriğine tıklanıldığında yapılacak işlemleri buraya ekleyebilirsiniz.
            kayitlari_sil();
        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            kayitlari_sil();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (SqlCommand komut1 = new SqlCommand("sp_ilacsil", con))
            {
                // buradaki stored procedure çalışmak için ilaç bilgilerine ihtiyaç duymaktadır. 
                komut1.CommandType = CommandType.StoredProcedure;// bu şekilde stored procedure entegre edilmiştir.
                komut1.Parameters.AddWithValue("@urun_kodu", textBox1.Text);//sql'deki kullanıcıdan işlem yapmak için istenen değişken
                con.Open();
                komut1.ExecuteNonQuery();
                MessageBox.Show("İlaç silinmiştir."); // ilaç silmek için textboxa ürün kodunun değerini girmek gerekiyor.
                con.Close();

            }
            /*con.Open();
            SqlCommand komut = new SqlCommand("DELETE From Tbl_ilac where urun_kodu=@s1", con);
            komut.Parameters.AddWithValue("@s1", textBox1.Text);
            komut.ExecuteNonQuery();
            con.Close();
            */
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (SqlCommand komut1 = new SqlCommand("sp_stokazalt", con))
            {
                // buradaki stored procedure çalışmak için ürün koduna ihtiyaç duymaktadır. ürün kodu olmadan azaltma işlemi yapılamaz. stok miktarını bir azalt
                komut1.CommandType = CommandType.StoredProcedure;// bu şekilde stored procedure entegre edilmiştir.
                komut1.Parameters.AddWithValue("@urun_kodu", textBox1.Text);//sql'deki kullanıcıdan işlem yapmak için istenen değişken
                //trigger oluştur. 0 altına düşerse diye.
                con.Open();
                komut1.ExecuteNonQuery();
                MessageBox.Show("Stok azaltma işlemi başarılı.");
                con.Close();

            }
            //stored procedure öncesi böyle bir kod yazmıştım. burayı da açıklama satırı olarak belirtmek istedim. bunu başka yerlerde de yaptım
            /*con.Open();
            //sp_stokazalt kullan
            SqlCommand komut = new SqlCommand("SELECT stok_miktari FROM Tbl_ilac where urun_kodu=@s1", con);//stoklarla ilgili olduğundan select stok_miktari yazdik.
            // burada yapılacak işlemlerin ürün kodu üzerinden yapılmasını istedim.
            komut.Parameters.AddWithValue("@s1", textBox1.Text);
            int stok = Convert.ToInt32(komut.ExecuteScalar()); // stok_miktari değerini integer'a çevir. execute.scalar() sorgudan gelen çıktıyı alır. o olmadan çalışmaz.
            if (stok >= 1)
            {
                stok = stok - 1; // her tıklamada 1 azalacak
                SqlCommand komut1 = new SqlCommand("UPDATE Tbl_ilac SET stok_miktari=@stok where urun_kodu=@s1", con);
                komut1.Parameters.AddWithValue("@stok", stok);
                komut1.Parameters.AddWithValue("@s1", textBox1.Text);
                komut1.ExecuteNonQuery();
               MessageBox.Show("Stok miktarı 1 azaltıldı. Yeni stok miktarı: " + stok);
            }
            
            else if(stok<=0)
            {
                MessageBox.Show("İlaç bitti. Depodan sipariş etmelisiniz.");
            } 
            con.Close();*/
            //
        }
        // stok miktarı 0 altına düşerse trigger çalıştır. 0 olduğunu belirtsin.
        private void button5_Click(object sender, EventArgs e)
        {
            using (SqlCommand komut = new SqlCommand("sp_stokarttir", con))
            {
                // buradaki stored procedure çalışmak için ürün koduna ihtiyaç duymaktadır. ürün kodu olmadan sipariş işlemi yapılamaz. stok miktarını 20 arttır
                komut.CommandType = CommandType.StoredProcedure;// bu şekilde stored procedure entegre edilmiştir.
                komut.Parameters.AddWithValue("@urun_kodu", textBox1.Text);//sql'deki kullanıcıdan işlem yapmak için istenen değişken

                con.Open();
                komut.ExecuteNonQuery();
                MessageBox.Show("Stok arttırma (depodan sipariş) işlemi başarılı.");
                con.Close();

                //sp öncesi yazmış olduğum kod.
                //con.Open();
                //sp_stokarttir kullanabilirim
                /*SqlCommand komut = new SqlCommand("SELECT stok_miktari FROM Tbl_ilac where urun_kodu=@s1",con);// stok verisini sql üzerinden alıyor
                komut.Parameters.AddWithValue("@s1", textBox1.Text);
                int stok = Convert.ToInt32(komut. ExecuteScalar());
                stok= stok + 20;
                SqlCommand komut1 = new SqlCommand("UPDATE Tbl_ilac SET stok_miktari=@stok WHERE urun_kodu=@s1",con);//stok_miktari verisini burada elde edilen stok verisinden elde ediyor.
                komut1.Parameters.AddWithValue("stok",stok);
                komut1.Parameters.AddWithValue("@s1", textBox1.Text);
                komut1.ExecuteNonQuery();
                MessageBox.Show("20 adet ilaç eklemesi yapıldı.");
                con.Close();*/
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            using (SqlCommand komut1 = new SqlCommand("SELECT * FROM func_azalan_stoklar()", con))//eşik değerin altındaki ilaçları getirir.
            {
                con.Open();
                using (SqlDataReader reader = komut1.ExecuteReader())
                {
                    if (reader.HasRows) //veri varsa alttaki satırları işler.
                    {
                        DataTable dtt = new DataTable(); // data table oluştur
                        dtt.Load(reader); // Data reader data tableye verileri aktarıyor
                        dataGridView1.DataSource = dtt; //dgv verilerini datatable'den alır.
                    }
                }
                con.Close(); 
            }

        }
    }
}

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


namespace eczane_otomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-0P5P493\\SQLEXPRESS;Initial Catalog=Eczane;Integrated Security=True");

        private void label2_Click(object sender, EventArgs e)
        {
            // gereken yerlerde con.open. veritabanında değişiklik yapılacak yerlerde. ayrıca con.close unutma
            // veritabanına ilaç ekleme, reçete düzenleme, müşteri bilgilerini güncelleme. bunlar için iki ya da 3 arayüz gerekiyor.
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            //this.Hide();

            // burada hasta bilgileri ve hasta databasesi ile ilgili işlemler
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // burada ilaç ekleme işlemi ve ilaç databasesi
            Form3 form3 = new Form3();
            form3.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // reçete oluşturma
            Form4 form4 = new Form4();
            form4.Show();

        }
    }
}

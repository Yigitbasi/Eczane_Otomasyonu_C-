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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            reçete form5 = new reçete();// reçeteli ilaç satmak
            form5.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            reçetesiz form6 = new reçetesiz();// reçetesiz ilaç satmak
            form6.Show();
        }
    }
}

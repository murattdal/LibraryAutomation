using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryOtomation
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public void Listele()
        {
            LibraryOtomationEntities dl = new LibraryOtomationEntities();
            var kullanicilar = dl.KullanicilarTablosu.ToList();
            dataGridView1.DataSource = kullanicilar.ToList();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

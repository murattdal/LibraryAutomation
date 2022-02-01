using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryOtomation.Kullanici
{
    public partial class KullaniciSilFormu : Form
    {
        public KullaniciSilFormu()
        {
            InitializeComponent();
        }
        LibraryOtomationEntities dl = new LibraryOtomationEntities();
        public void Listele()
        {

            var kullanicilar = dl.KullanicilarTablosu.ToList();
            dataGridView1.DataSource = kullanicilar.ToList();
        }
        private void KullaniciSilFormu_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void giriskapatmabutonu_Click(object sender, EventArgs e)
        {
            

                this.Close();
                Application.Exit();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int secilenId = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            var kullanici = dl.KullanicilarTablosu.Where(x => x.kullanici_id == secilenId).FirstOrDefault();
            dl.KullanicilarTablosu.Remove(kullanici);
            dl.SaveChanges();
            Listele();
            MessageBox.Show("Başarıyla Silindi!!!");
        }
    }
}

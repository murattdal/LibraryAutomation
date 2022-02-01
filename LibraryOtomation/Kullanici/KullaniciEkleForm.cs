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
    public partial class KullaniciEkleForm : Form
    {
        public KullaniciEkleForm()
        {
            InitializeComponent();
        }
        LibraryOtomationEntities dl = new LibraryOtomationEntities();
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            KullanicilarTablosu kullanicilar = new KullanicilarTablosu();
            kullanicilar.kullanici_ad = kullaniciAdText.Text;
            kullanicilar.kullanici_soyad = kullaniciSoyadText.Text;
            kullanicilar.kullanici_tc = kullaniciTCText.Text;
            kullanicilar.kullanici_tel = kullaniciTelText.Text;
            kullanicilar.kullanici_mail = kullaniciMailText.Text;
            kullanicilar.kullanici_ceza = Convert.ToDouble(kullaniciCezaText.Text);
            if (radioE.Checked == true)
                kullanicilar.kullanici_cinsiyet = "E";
            else if (radioK.Checked == true)
                kullanicilar.kullanici_cinsiyet = "K";
            dl.KullanicilarTablosu.Add(kullanicilar);
            dl.SaveChanges();
            Listele();
            foreach(Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox tbox = (TextBox)item;
                    tbox.Clear();
                }
            }
            radioE.Checked = false;
            radioK.Checked = false;
        }
        public void Listele()
        {
           
            var kullanicilar = dl.KullanicilarTablosu.ToList();
            dataGridView1.DataSource = kullanicilar.ToList();
        }
        private void KullaniciEkleForm_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void giriskapatmabutonu_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        
    }
}

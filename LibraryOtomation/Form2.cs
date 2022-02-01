using LibraryOtomation.kitaplar;
using LibraryOtomation.Kullanici;
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
    public partial class form2 : Form
    {
        public form2()
        {
            InitializeComponent();
        }
        LibraryOtomationEntities mrt = new LibraryOtomationEntities();
        private void form2_Load(object sender, EventArgs e)
        {
            //kullanıcı butonları girişte kapalıdır

            ekleKullanicibtn.Visible = false;
            guncelleKullanicibtn.Visible = false;
            silkullanicibtn.Visible = false;

            //kitaplar butonları girişte kapalıdır
           
            kitapekle.Visible = false;
            kitapguncelle.Visible = false;
            kitapsil.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(ekleKullanicibtn.Visible ==false)
            {
                ekleKullanicibtn.Visible = true;
                guncelleKullanicibtn.Visible = true;
                silkullanicibtn.Visible = true;
            }
            else
            {
                ekleKullanicibtn.Visible = false;
                guncelleKullanicibtn.Visible = false;
                silkullanicibtn.Visible = false;
            }
            Form3 kullaniciListeForm = new Form3();
            kullaniciListeForm.MdiParent = this;
            kullaniciListeForm.Show();
        }

        private void ekleKullanicibtn_Click(object sender, EventArgs e)
        {
            KullaniciEkleForm ekleForm = new KullaniciEkleForm();
            ekleForm.MdiParent = this;
            ekleForm.Show();
        }

        private void silkullanicibtn_Click(object sender, EventArgs e)
        {
            KullaniciSilFormu ksil = new KullaniciSilFormu();
            ksil.MdiParent = this;
            ksil.Show();
        }

        private void guncelleKullanicibtn_Click(object sender, EventArgs e)
        {
            KullaniciGuncelle kguncel = new KullaniciGuncelle();
            kguncel.MdiParent = this;
            kguncel.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(kitapekle.Visible==false)
            {
                kitapekle.Visible = true;
                kitapguncelle.Visible = true;
                kitapsil.Visible = true;
            }
            else
            {
                kitapekle.Visible = false;
                kitapguncelle.Visible = false;
                kitapsil.Visible = false;
            }


            KitaplarListeForm kliste = new KitaplarListeForm();
            kliste.MdiParent = this;
            kliste.Show();
        }
    }
}

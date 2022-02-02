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
    public partial class form1 : Form
    {
        LibraryOtomationEntities mrt = new LibraryOtomationEntities();
        public form1()
        {
            InitializeComponent();
        }
        


        private void PersonelGirisBtn_Click(object sender, EventArgs e)
        {
            
            
            string personelgirisad = AdGiristxt.Text;
            string PersonelSifre = SifreGiristxt.Text;

            //linq sorgusu
            var personel = mrt.Personeller.Where(x => x.personel_ad.Equals(personelgirisad) && x.personel_sifre.Equals(PersonelSifre)).FirstOrDefault();
            if(personel==null)
                MessageBox.Show("Kullanıcı adı veya Şifre hatalı");
            else
            {
                MessageBox.Show("Giriş Başarılı");
                form2 panel = new form2();
                panel.Show();
                this.Hide();
            }
              
      
        }

        private void giriskapatmabutonu_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminKayit fr = new AdminKayit();

            this.Hide();
            fr.Show();
        }
    }
}

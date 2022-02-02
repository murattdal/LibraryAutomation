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
    public partial class AdminKayit : Form
    {
        public AdminKayit()
        {
            InitializeComponent();
        }

        private void giriskapatmabutonu_Click(object sender, EventArgs e)
        {
            form1 frm = new form1();
            frm.Show();
            this.Hide();
        }
    }
}

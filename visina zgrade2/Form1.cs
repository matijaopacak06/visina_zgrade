using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace visina_zgrade2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIzracunaj_Click(object sender, EventArgs e)
         
        {
            try // preko try smo postavili da se moze pojaviti neku gresku 
            {
                Neboder neboder = new Neboder();    // stvorili smo novi objekt pod nazivom neboder.//
                neboder.BrojKatova = Convert.ToInt32(txtBrojKatova.Text); // konvertali smo iz strina u int tako da pretvara brojke.//
                txtVisinaZgrade.Text = neboder.IzracunajVisinu(neboder.BrojKatova).ToString();// ispisati ce visinu zgrade.//
            }
            catch // pomocu catch smo uhvatili tu gresku //
            {
                MessageBox.Show("upisali ste pogresan format!", "greska unosa!", MessageBoxButtons.OK, MessageBoxIcon.Error); // postavili smo message box koji ce ukoliko se desi greska da ispisuje zadani tekst koji smo napisali i da postavi error ikonu i message ikonu.//
            }

          
            
                
            
            
        }
    }
}

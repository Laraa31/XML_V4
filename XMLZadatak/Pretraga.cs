using System;
using System.Xml.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace XMLZadatak
{
    public partial class Pretraga : Form
    {

        public Pretraga()
        {
            InitializeComponent();
        }

        private void btnPretraziKnj_Click(object sender, EventArgs e)
        {

            rtbIspis.Clear();
            string path1 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string datoteka1 = "Knjige.xml";
            string datoteka2 = "Stanje.xml";
            string pathKnjige = Path.Combine(path1, datoteka1);
            string pathStanje = Path.Combine(path1, datoteka2);




            if (txtNazivKnj.Text != "")
            {
                XDocument doc = XDocument.Load(pathKnjige);
                XElement root=doc.Root;

                var rez= root.Elements("Knjiga").FirstOrDefault(m=>m.Element("Naziv").Value==txtNazivKnj.Text);
                rtbIspis.AppendText(rez.ToString());
            }
            else if(txtAutor.Text != "")
            {
                XDocument doc = XDocument.Load(pathKnjige);
                XElement root = doc.Root;

                var rez = root.Elements("Knjiga").FirstOrDefault(m => m.Element("Autor").Value == txtAutor.Text);
                rtbIspis.AppendText(rez.ToString());

            }
            else if(txtKolicina.Text != "")
            {
                XDocument doc = XDocument.Load(pathStanje);
                XElement root = doc.Root;

                var rez = root.Elements("Stanje").FirstOrDefault(m => m.Element("Kolicina").Value == txtKolicina.Text);
                rtbIspis.AppendText(rez.ToString());

            }
            else if(txtISBN.Text != "")
            {
                XDocument doc = XDocument.Load(pathKnjige);
                XElement root = doc.Root;

                var rez = root.Elements("Knjiga").FirstOrDefault(m => m.Element("ISBN").Value == txtISBN.Text);
                rtbIspis.AppendText(rez.ToString());

            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Ništa niste upisali! Upišite parametar po kojem želite pretražiti knjigu.", "Pretraga", MessageBoxButtons.OK, MessageBoxIcon.Error);
           
            }

            txtNazivKnj.Clear();
            txtKolicina.Clear();
            txtAutor.Clear();
            txtISBN.Clear();

        }

        private void btnPretraziKor_Click(object sender, EventArgs e)
        {
            rtbIspis.Clear();
            string path1 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string datoteka1 = "Korisnici.xml";
            string pathKorisnici = Path.Combine(path1, datoteka1);


            if (txtImeKor.Text != "")
            {
                XDocument doc = XDocument.Load(pathKorisnici);
                XElement root = doc.Root;

                var rez = root.Elements("Korisnik").FirstOrDefault(m => m.Element("Ime").Value == txtImeKor.Text);
                rtbIspis.AppendText(rez.ToString());
            }
            else if(txtPrezime.Text != ""){ 
                XDocument doc = XDocument.Load(pathKorisnici);
                XElement root = doc.Root;

                var rez = root.Elements("Korisnik").FirstOrDefault(m => m.Element("Prezime").Value == txtPrezime.Text);
                rtbIspis.AppendText(rez.ToString());
            }
            else if(txtOIB.Text != "")
            {
                XDocument doc = XDocument.Load(pathKorisnici);
                XElement root = doc.Root;

                var rez = root.Elements("Korisnik").FirstOrDefault(m => m.Element("OIB").Value == txtOIB.Text);
                rtbIspis.AppendText(rez.ToString());
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Ništa niste upisali! Upišite parametar po kojem želite pretražiti korisnika.", "Pretraga", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            txtImeKor.Clear();
            txtPrezime.Clear();
            txtOIB.Clear();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPsoudi_Click(object sender, EventArgs e)
        {


        }

        private void btnVrati_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtImeKor_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtPrezime_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtOIB_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}

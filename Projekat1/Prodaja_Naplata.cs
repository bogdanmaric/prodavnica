using MySql.Data.MySqlClient;
using Projekat1.Klase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using WindowsFormsApp4;

namespace Projekat1
{
    public partial class Prodaja_Naplata : Form
    {
        public Račun račun;
        public ArtikalRačun odabran;
        public List<ArtikalRačun> lista_artikla;
        public Dictionary<string, string> id;

        public Prodaja_Naplata()
        {
            InitializeComponent();
        }

        private void Prodaja_Naplata_Load(object sender, EventArgs e)
        {
            lista_artikla = new List<ArtikalRačun>();
            lUplataLista.Controls.Clear();
            try
            {
                var podaci = Database.select("SELECT * FROM kategorije_artikla", new Dictionary<string, string>());
                DataTable tabela = new DataTable();
                tabela.Load(podaci);
                

                if (tabela.Rows.Count > 0)
                {
                    var pozicijaX = 3;
                    foreach (DataRow item in tabela.Rows)
                    {
                        var dugme_kategorija = new System.Windows.Forms.Button();
                        this.pKategorije.Controls.Add(dugme_kategorija);
                        dugme_kategorija.Location = new System.Drawing.Point(pozicijaX, 17);
                        dugme_kategorija.Name = $"{item.ItemArray[0]}";
                        dugme_kategorija.Size = new System.Drawing.Size(87, 55);
                        pozicijaX += 87;
                        dugme_kategorija.TabIndex = 0;
                        dugme_kategorija.Text = $"{item.ItemArray[1]}";
                        dugme_kategorija.UseVisualStyleBackColor = true;
                        dugme_kategorija.Click += new System.EventHandler(this.Dugme_Kategorija);

                    }


                }
                Database.closeConnection();

            }
            catch (MySqlException sql_exception)
            {
                if (sql_exception.Message.ToString().Contains("Unable to connect"))
                    MessageBox.Show("Niste povezani sa bazom podataka");
            }
        }






        private void Dugme_Kategorija(object sender, EventArgs e) {
            flpArtikli.Controls.Clear();

            foreach (var item in pKategorije.Controls)
            {
                ((Button)item).BackColor = Color.Transparent;
            }

            ((Button)sender).BackColor = Color.Red;

            var kategorija = new Dictionary<string, string>();
            kategorija.Add("@kategorija_id", ((Button)sender).Name);
            var podaci = Database.select("SELECT * FROM artikli WHERE Kategorije_artikla_id = @kategorija_id", kategorija);
            DataTable tabela = new DataTable();
            tabela.Load(podaci);

            if (tabela.Rows.Count > 0)
            {
                var pozicijaX = 3;
                foreach (DataRow item in tabela.Rows)
                {

                    var dugme_kategorija = new System.Windows.Forms.Button();
                    flpArtikli.Controls.Add(dugme_kategorija);
                    dugme_kategorija.Location = new System.Drawing.Point(pozicijaX, 17);
                    dugme_kategorija.Name = $"{item.ItemArray[0]}";
                    dugme_kategorija.Size = new System.Drawing.Size(87, 55);
                    pozicijaX += 87;
                    dugme_kategorija.TabIndex = 0;
                    dugme_kategorija.Text = $"{item.ItemArray[1]}";
                    dugme_kategorija.UseVisualStyleBackColor = true;
                    dugme_kategorija.Click += new System.EventHandler(this.Dugme_Artikal);
                   
                }
                
            }
            Database.closeConnection();


        }


        private void Dugme_Artikal(object sender, EventArgs e) {

     
            foreach (var item in flpArtikli.Controls)
            {
                ((Button)item).BackColor = Color.Transparent;
            }

         
            id = new Dictionary<string, string>(){
                { "@id", ((Button)sender).Name }
            };

            ((Button)sender).BackColor = Color.LightBlue;

        }

    
        private void azuriranjeUnosa() {
            lUplataLista.Items.Clear();


            foreach (var item in lista_artikla)
            {
                lUplataLista.Items.Add(item);
            }
        }

   
        private void azuriranjeUkupneCene()
        {
            var ukupno = 0;
            var valuta = " RSD";
            foreach (var item in lista_artikla)
            {
                ukupno += item.KonačnaCena();
            }

            lCena.Text = ukupno.ToString() + valuta;
        }



        private void tbKoličina_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

       
        private void btn0_Click(object sender, EventArgs e)
        {
            if(tbKoličina.Text != string.Empty)
                tbKoličina.Text += 0;
            else
            {
                MessageBox.Show("Prvi broj ne može biti 0.");
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            tbKoličina.Text += 1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            tbKoličina.Text += 2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            tbKoličina.Text += 3;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            tbKoličina.Text += 4;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            tbKoličina.Text += 5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            tbKoličina.Text += 6;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            tbKoličina.Text += 7;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            tbKoličina.Text += 8;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            tbKoličina.Text += 9;
        }

        private void btnBrišiZadnjuCifru_Click(object sender, EventArgs e)
        {
            if(tbKoličina.Text != string.Empty)
                tbKoličina.Text = tbKoličina.Text.Remove(tbKoličina.Text.Length - 1);
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            
            var podatak = Database.select("SELECT * FROM artikli WHERE id=@id", id);
            DataTable tabela = new DataTable();
            tabela.Load(podatak);
            Database.closeConnection();

            foreach (DataRow item in tabela.Rows)
            {
                odabran = new ArtikalRačun(
                    int.Parse(item["id"].ToString()),
                    item["Naziv_artikla"].ToString(),
                    int.Parse(item["Cena_artikla"].ToString()),
                    item["Jedinica_artikla"].ToString(),
                    1
                );
            }
            if (tbKoličina.Text != string.Empty)
                odabran.Količina = int.Parse(tbKoličina.Text);

            lista_artikla.Add(odabran);
            azuriranjeUnosa();
            azuriranjeUkupneCene();
            resetovanjeKategorijeArtiklaKoličine();


        }

        private void resetovanjeKategorijeArtiklaKoličine() {

            tbKoličina.Text = "";

            flpArtikli.Controls.Clear();

            foreach (var item in pKategorije.Controls)
            {
                ((Button)item).BackColor = Color.Transparent;
            }
        }

        private void btnObrisiSve_Click(object sender, EventArgs e)
        {
            lista_artikla.Clear();
            azuriranjeUnosa();
            azuriranjeUkupneCene();

        }

        private void btnObrišiOdabran_Click(object sender, EventArgs e)
        {
            if (lUplataLista.SelectedIndex > -1)
            {
                var v = ((Artikal)lUplataLista.SelectedItem).IdArtikla;
                var item_to_remove = lista_artikla.Single(r => r.IdArtikla == v);
                lista_artikla.Remove(item_to_remove);

                lUplataLista.Items.Clear();
                azuriranjeUnosa();
                azuriranjeUkupneCene();
            }
            else
            {
                MessageBox.Show("Potrebno je da odaberete artikal koji želite da obrišete.");
            }
             
        }


        private void btnPoništiRačun_Click(object sender, EventArgs e)
        {
            resetovanjeKategorijeArtiklaKoličine();
            tabcUplataFiksalni.SelectedTab = tabUplataObrada;
            lUplataLista.Items.Clear();
            lCena.Text = "0";
            lista_artikla = new List<ArtikalRačun>();
        }

        private void tabcUplataFiksalni_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabcUplataFiksalni.SelectedTab == tabcUplataFiksalni.TabPages["tabFiksalniRacun"])
            {
                resetovanjeKategorijeArtiklaKoličine();
                btnPotvrdi.Enabled = false;
                račun = new Račun(DateTime.Now, lista_artikla);
                lbRačun.Items.Add("Datum kreiranja računa: " + račun.DatumKreiranjaRačuna.ToString("dd/MM/yyyy"));
                lbRačun.Items.Add(string.Format("{0,-20}", "#########################"));
                lbRačun.Items.Add(string.Format("{0,-20}{1,10}", "Artikli", "Cena"));
                lbRačun.Items.Add(string.Format("{0,-20}", "====================="));
                foreach (var item in račun.Artikli)
                {
                    lbRačun.Items.Add(string.Format("{0,-20}{1,6}", item.NazivArtikla, item.KonačnaCena()));
                    lbRačun.Items.Add("------------------------------------------");

                }
                
                lbRačun.Items.Add("Ukupna Cena: " + lCena.Text);
            }
            else
            {
                lbRačun.Items.Clear();
                btnPotvrdi.Enabled = true;
            }
        }

        private void btnSačuvajRačun_Click(object sender, EventArgs e)
        {
            var putanja_foldera = "računi\\";
            if (!Directory.Exists(putanja_foldera)) {
                Directory.CreateDirectory(putanja_foldera);
            }
            var naziv_fajla = račun.DatumKreiranjaRačuna.ToString("dd_MM_yyyy") + ".dat";
            var putanja = putanja_foldera + naziv_fajla;


            using (StreamWriter zapisivanje = new StreamWriter(putanja)) {

                XmlSerializer serilizacija = new XmlSerializer(typeof(Račun));
                serilizacija.Serialize(zapisivanje, račun);
                MessageBox.Show("Vaš račun je uspešno sačuvan.");
            }

            btnPoništiRačun_Click(new object(), new EventArgs());

        }
    }
}

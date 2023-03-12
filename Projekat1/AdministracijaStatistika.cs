using MySql.Data.MySqlClient;
using Projekat1.Klase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using WindowsFormsApp4;

namespace Projekat1
{
    public partial class AdministracijaStatistika : Form
    {
        public AdministracijaStatistika()
        {
            InitializeComponent();
        }

        private void tabAzuriranjeKategorija_Enter(object sender, EventArgs e)
        {
            lbPrikazKategorija.DataSource = null;
            lbPrikazKategorija.Items.Clear();
            try
            {
                var podaci = Database.select("SELECT * FROM kategorije_artikla", new Dictionary<string, string>());
                DataTable tabela = new DataTable();
                tabela.Load(podaci);

                if (tabela.Rows.Count > 0)
                {
                    lbPrikazKategorija.DataSource = tabela;
                    lbPrikazKategorija.DisplayMember = "Naziv_kategorije";
                    lbPrikazKategorija.ValueMember = "id";
                }
                Database.closeConnection();

            }
            catch (MySqlException sql_exception)
            {
                if (sql_exception.Message.ToString().Contains("Unable to connect"))
                    MessageBox.Show("Niste povezani sa bazom podataka");
            }
        }


        private void btnDodajKategoriju_Click(object sender, EventArgs e)
        {

            try
            {
                if (tbNazivKategorije.Text == string.Empty)
                {
                    throw (new IzuzetakPrazanInput());
                }
                else
                {
                    var podaci = new Dictionary<string, string>();
                    podaci.Add("@kategorija", tbNazivKategorije.Text);
                    Database.insert("INSERT INTO kategorije_artikla (Naziv_kategorije) VALUES (@kategorija);", podaci);
                    tabAzuriranjeKategorija_Enter(new object(), new EventArgs());
                    tbNazivKategorije.Text = "";
                }

            }


            catch (IzuzetakPrazanInput prazan_box)
            {
                MessageBox.Show(prazan_box.ToString());
            }
    
            catch (MySqlException sql_exception) {
                if(sql_exception.Message.ToString().Contains("Duplicate"))
                    MessageBox.Show("Kategoriju koju ste upisali već postoji.");
                else if(sql_exception.Message.ToString().Contains("Unable to connect"))
                {
                    MessageBox.Show("Niste povezani sa bazom podataka");
                }
            }

           
        }

   
        private void btnIzmeniKategoriju_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbNazivKategorije.Text == string.Empty)
                {
                    throw (new IzuzetakPrazanInput());
                }
                else
                {
                    var podaci = new Dictionary<string, string>();
                    podaci.Add("@id", lbPrikazKategorija.SelectedValue.ToString());
                    podaci.Add("@kategorija", tbNazivKategorije.Text);

                    Database.update("UPDATE kategorije_artikla SET Naziv_kategorije = @kategorija WHERE kategorije_artikla.id = @id;", podaci);
                    tbNazivKategorije.Text = "";
                    tabAzuriranjeKategorija_Enter(new object(), new EventArgs());
                    
                }
            }

            catch (IzuzetakPrazanInput prazan_box)
            {
                MessageBox.Show(prazan_box.ToString());
            }
            catch (MySqlException sql_exception)
            {
                if (sql_exception.Message.ToString().Contains("Unable to connect"))
                    MessageBox.Show("Niste povezani sa bazom podataka");
            }

        }


        private void btnObrišiKategoriju_Click(object sender, EventArgs e)
        {
            try
            {
                var podaci = new Dictionary<string, string>();      
                podaci.Add("@id", lbPrikazKategorija.SelectedValue.ToString());
                Database.delete("DELETE FROM kategorije_artikla WHERE kategorije_artikla.id = @id", podaci);
                tabAzuriranjeKategorija_Enter(new object(), new EventArgs());
            }

            catch (MySqlException sql_exception)
            {
                if (sql_exception.Message.ToString().Contains("constraint"))
                {
                    MessageBox.Show("Nije moguce obrisati kategiriju jer postoji artikal sa ovom kategorijom.");
                }
                else if (sql_exception.Message.ToString().Contains("Unable to connect"))
                {
                    MessageBox.Show("Niste povezani sa bazom podataka");
                }
            }
            
        }


        private void tabAzuriranjeArtikala_Enter(object sender, EventArgs e)
        {
            
 
            lbAzuriranjeArtikala.Items.Clear();
            tbNazivArtikla.Text = "";
            tbCenaArtikla.Text = "";
            tbJedinicaArtikla.Text = "";
            cbKategorija.ValueMember = "id";


            var podaci = Database.select("SELECT * FROM kategorije_artikla", new Dictionary<string, string>());
            DataTable tabela_kategorije = new DataTable();
            tabela_kategorije.Load(podaci);

            if (tabela_kategorije.Rows.Count > 0)
            {
                cbKategorija.DataSource = tabela_kategorije;
                cbKategorija.DisplayMember = "Naziv_kategorije";
            }


            podaci = Database.select(
                "SELECT artikli.id, Naziv_artikla, Naziv_kategorije, Cena_artikla, Jedinica_artikla" +
                " FROM artikli" +
                " INNER JOIN kategorije_artikla" +
                " WHERE artikli.Kategorije_artikla_id = kategorije_artikla.id;",
                new Dictionary<string, string>());

            DataTable tabela_artikli = new DataTable();
            tabela_artikli.Load(podaci);


            foreach (DataRow item in tabela_artikli.Rows)
            {
                lbAzuriranjeArtikala.Items.Add(new Artikal(
                    int.Parse(item["id"].ToString()),
                    item["Naziv_artikla"].ToString(),
                    int.Parse(item["Cena_artikla"].ToString()),
                    item["Jedinica_artikla"].ToString(),
                    item["Naziv_kategorije"].ToString()
                    ));
            }

            Database.closeConnection();
        }


        private void btnDodajArtikal_Click(object sender, EventArgs e)
        {

            try
            {
                if (tbNazivArtikla.Text == string.Empty || tbCenaArtikla.Text == string.Empty || tbJedinicaArtikla.Text == string.Empty)
                {
                    throw (new IzuzetakPrazanInput());
                }
                else
                {
                    var podaci = new Dictionary<string, string>();
                    podaci.Add("@Naziv_artikla", tbNazivArtikla.Text);
                    podaci.Add("@Kategorije_artikla_id", cbKategorija.SelectedValue.ToString());
                    podaci.Add("@Cena_artikla", tbCenaArtikla.Text);
                    podaci.Add("@Jedinica_artikla", tbJedinicaArtikla.Text);
                    Database.insert("INSERT INTO artikli (Naziv_artikla, Kategorije_artikla_id, Cena_artikla, Jedinica_artikla) VALUES(" +
                        "@Naziv_artikla, @Kategorije_artikla_id, @Cena_artikla, @Jedinica_artikla);", podaci);
                    tabAzuriranjeArtikala_Enter(new object(), new EventArgs());
                    tbNazivKategorije.Text = "";
                    
                }
  
            }

            catch (IzuzetakPrazanInput prazan_box)
            {
                MessageBox.Show(prazan_box.ToString());
            }

        }


        private void btnIzmeniArtikal_Click(object sender, EventArgs e)
        {

            try
            {

                if (lbAzuriranjeArtikala.SelectedIndex == -1) {
                    throw new IzuzetakSelektovanaStavka();
                }

                var podaci = new Dictionary<string, string>();
                if (tbNazivArtikla.Text == string.Empty){
                    podaci.Add("@Naziv_artikla", ((Artikal)lbAzuriranjeArtikala.SelectedItem).NazivArtikla);
                }
                else
                {
                    podaci.Add("@Naziv_artikla", tbNazivArtikla.Text);
                }


                if (tbCenaArtikla.Text == string.Empty)
                {
                    podaci.Add("@Cena_artikla", (((Artikal)lbAzuriranjeArtikala.SelectedItem).CenaArtikla).ToString());
                }
                else
                {
                    podaci.Add("@Cena_artikla", tbCenaArtikla.Text);
                }


    
                podaci.Add("@Kategorije_artikla_id", cbKategorija.SelectedValue.ToString());
                podaci.Add("@id", ((Artikal)lbAzuriranjeArtikala.SelectedItem).IdArtikla.ToString());


                if (tbJedinicaArtikla.Text == string.Empty){
                    podaci.Add("@Jedinica_artikla", ((Artikal)lbAzuriranjeArtikala.SelectedItem).JedinicaPoMeriArtikla);
                }
                else {
                    podaci.Add("@Jedinica_artikla", tbJedinicaArtikla.Text);
                }


                Database.update("UPDATE artikli SET Naziv_artikla = @Naziv_artikla," +
                    " Kategorije_artikla_id = @Kategorije_artikla_id," +
                    " Cena_artikla = @Cena_artikla," +
                    " Jedinica_artikla = @Jedinica_artikla" +
                    " WHERE artikli.id = @id;", podaci);
                tabAzuriranjeArtikala_Enter(new object(), new EventArgs());
                tbNazivKategorije.Text = "";
                tbNazivArtikla.Text = "";
                tbCenaArtikla.Text = "";

            }

            catch (IzuzetakSelektovanaStavka nije_selektovan)
            {
                MessageBox.Show(nije_selektovan.ToString());
            }
        }

        private void btnObrišiArtikal_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbAzuriranjeArtikala.SelectedIndex == -1)
                {
                    throw new IzuzetakSelektovanaStavka();
                }
                var podaci = new Dictionary<string, string>();
                podaci.Add("@id", ((Artikal)lbAzuriranjeArtikala.SelectedItem).IdArtikla.ToString());
                Database.delete("DELETE FROM artikli WHERE artikli.id = @id", podaci);
                tabAzuriranjeArtikala_Enter(new object(), new EventArgs());
            }

            catch (IzuzetakSelektovanaStavka nije_selektovan)
            {
                MessageBox.Show(nije_selektovan.ToString());
            }
        }

        public List<string> artikli_imena = new List<string>();
        private void dtpPočetnoVreme_ValueChanged(object sender, EventArgs e)
        {
           
            flpPanelStatistike.Controls.Clear();

            artikli_imena = new List<string>();
            DirectoryInfo dir2 = new DirectoryInfo("računi");
            var fajlovi = dir2.GetFiles("*.dat", SearchOption.AllDirectories);

            foreach (var fajl in fajlovi)
            {
                Račun račun = null;
                using (StreamReader citanje = new StreamReader(fajl.FullName)) {
                    XmlSerializer deserijalizacija = new XmlSerializer(typeof(Račun));
                    račun = (Račun)deserijalizacija.Deserialize(citanje);
                }

                if (račun.DatumKreiranjaRačuna <= dtpPočetnoVreme.Value) {

                    foreach (var item in račun.Artikli)
                    {
                        if (!artikli_imena.Contains(item.NazivArtikla)) {
                            var artikal = new System.Windows.Forms.Label();
                            flpPanelStatistike.Controls.Add(artikal);
                            var grafički_stubić = new System.Windows.Forms.ProgressBar();
                            flpPanelStatistike.Controls.Add(grafički_stubić);
                            var kolicina = new System.Windows.Forms.Label();
                            flpPanelStatistike.Controls.Add(kolicina);

                            artikal.AutoSize = true;
                            artikal.Location = new System.Drawing.Point(3, 0);
                            artikal.Name = item.NazivArtikla + "ln";
                            artikal.Size = new System.Drawing.Size(25, 17);
                            artikal.TabIndex = 4;
                            artikal.Text = "" + item.NazivArtikla;

                            grafički_stubić.Location = new System.Drawing.Point(34, 3);
                            grafički_stubić.Name = item.NazivArtikla + "pb";
                            grafički_stubić.Size = new System.Drawing.Size(243, 40);
                            grafički_stubić.TabIndex = 5;
                            grafički_stubić.Value = 1;

                            flpPanelStatistike.SetFlowBreak(kolicina, true);
                            kolicina.AutoSize = true;
                            kolicina.Location = new System.Drawing.Point(3, 0);
                            kolicina.Name = "" + item.NazivArtikla+"lk";
                            kolicina.Size = new System.Drawing.Size(25, 17);
                            kolicina.TabIndex = 4;
                            kolicina.Text = "" + item.Količina;

                            artikli_imena.Add(item.NazivArtikla);
                        }
                        else
                        {
                            var pb = flpPanelStatistike.Controls.Find(item.NazivArtikla+"pb", false);
                            var lk = flpPanelStatistike.Controls.Find(item.NazivArtikla+"lk", false);
                            ((ProgressBar)pb[0]).Value += item.Količina;
                            ((Label)lk[0]).Text = (int.Parse(((Label)lk[0]).Text) + item.Količina).ToString();
                        }
                    }

                }

            }

        }

        private void tabAdministracijeStatistike_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (tabAdministracijeStatistike.SelectedTab == tabPregledStatistike) {
                artikli_imena = new List<string>();
                flpPanelStatistike.Controls.Clear();
            }
        }
    }
}

namespace Projekat1
{
    partial class AdministracijaStatistika
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabAdministracijeStatistike = new System.Windows.Forms.TabControl();
            this.tabAzuriranjeKategorija = new System.Windows.Forms.TabPage();
            this.lbPrikazKategorija = new System.Windows.Forms.ListBox();
            this.gbKategorija = new System.Windows.Forms.GroupBox();
            this.btnObrišiKategoriju = new System.Windows.Forms.Button();
            this.labNazivKategorije = new System.Windows.Forms.Label();
            this.btnIzmeniKategoriju = new System.Windows.Forms.Button();
            this.tbNazivKategorije = new System.Windows.Forms.TextBox();
            this.btnDodajKategoriju = new System.Windows.Forms.Button();
            this.tabAzuriranjeArtikala = new System.Windows.Forms.TabPage();
            this.lbAzuriranjeArtikala = new System.Windows.Forms.ListBox();
            this.gbAzuriranjeArtiklaKomande = new System.Windows.Forms.GroupBox();
            this.btnObrišiArtikal = new System.Windows.Forms.Button();
            this.btnIzmeniArtikal = new System.Windows.Forms.Button();
            this.btnDodajArtikal = new System.Windows.Forms.Button();
            this.tbJedinicaArtikla = new System.Windows.Forms.TextBox();
            this.labKategorija = new System.Windows.Forms.Label();
            this.cbKategorija = new System.Windows.Forms.ComboBox();
            this.labNazivArtikla = new System.Windows.Forms.Label();
            this.labCenaArtikla = new System.Windows.Forms.Label();
            this.tbCenaArtikla = new System.Windows.Forms.TextBox();
            this.labJedinicaMereArtikla = new System.Windows.Forms.Label();
            this.tbNazivArtikla = new System.Windows.Forms.TextBox();
            this.tabPregledStatistike = new System.Windows.Forms.TabPage();
            this.lIzaberiDatum = new System.Windows.Forms.Label();
            this.flpPanelStatistike = new System.Windows.Forms.FlowLayoutPanel();
            this.dtpPočetnoVreme = new System.Windows.Forms.DateTimePicker();
            this.tabAdministracijeStatistike.SuspendLayout();
            this.tabAzuriranjeKategorija.SuspendLayout();
            this.gbKategorija.SuspendLayout();
            this.tabAzuriranjeArtikala.SuspendLayout();
            this.gbAzuriranjeArtiklaKomande.SuspendLayout();
            this.tabPregledStatistike.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabAdministracijeStatistike
            // 
            this.tabAdministracijeStatistike.Controls.Add(this.tabAzuriranjeKategorija);
            this.tabAdministracijeStatistike.Controls.Add(this.tabAzuriranjeArtikala);
            this.tabAdministracijeStatistike.Controls.Add(this.tabPregledStatistike);
            this.tabAdministracijeStatistike.Location = new System.Drawing.Point(12, 12);
            this.tabAdministracijeStatistike.Name = "tabAdministracijeStatistike";
            this.tabAdministracijeStatistike.SelectedIndex = 0;
            this.tabAdministracijeStatistike.Size = new System.Drawing.Size(776, 426);
            this.tabAdministracijeStatistike.TabIndex = 0;
            this.tabAdministracijeStatistike.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabAdministracijeStatistike_Selecting);
            // 
            // tabAzuriranjeKategorija
            // 
            this.tabAzuriranjeKategorija.Controls.Add(this.lbPrikazKategorija);
            this.tabAzuriranjeKategorija.Controls.Add(this.gbKategorija);
            this.tabAzuriranjeKategorija.Location = new System.Drawing.Point(4, 25);
            this.tabAzuriranjeKategorija.Name = "tabAzuriranjeKategorija";
            this.tabAzuriranjeKategorija.Padding = new System.Windows.Forms.Padding(3);
            this.tabAzuriranjeKategorija.Size = new System.Drawing.Size(768, 397);
            this.tabAzuriranjeKategorija.TabIndex = 0;
            this.tabAzuriranjeKategorija.Text = "Azuriranje kategorija";
            this.tabAzuriranjeKategorija.UseVisualStyleBackColor = true;
            this.tabAzuriranjeKategorija.Enter += new System.EventHandler(this.tabAzuriranjeKategorija_Enter);
            // 
            // lbPrikazKategorija
            // 
            this.lbPrikazKategorija.FormattingEnabled = true;
            this.lbPrikazKategorija.ItemHeight = 16;
            this.lbPrikazKategorija.Location = new System.Drawing.Point(415, 38);
            this.lbPrikazKategorija.Name = "lbPrikazKategorija";
            this.lbPrikazKategorija.Size = new System.Drawing.Size(336, 324);
            this.lbPrikazKategorija.TabIndex = 11;
            // 
            // gbKategorija
            // 
            this.gbKategorija.Controls.Add(this.btnObrišiKategoriju);
            this.gbKategorija.Controls.Add(this.labNazivKategorije);
            this.gbKategorija.Controls.Add(this.btnIzmeniKategoriju);
            this.gbKategorija.Controls.Add(this.tbNazivKategorije);
            this.gbKategorija.Controls.Add(this.btnDodajKategoriju);
            this.gbKategorija.Location = new System.Drawing.Point(12, 38);
            this.gbKategorija.Name = "gbKategorija";
            this.gbKategorija.Size = new System.Drawing.Size(361, 320);
            this.gbKategorija.TabIndex = 9;
            this.gbKategorija.TabStop = false;
            // 
            // btnObrišiKategoriju
            // 
            this.btnObrišiKategoriju.Location = new System.Drawing.Point(36, 261);
            this.btnObrišiKategoriju.Name = "btnObrišiKategoriju";
            this.btnObrišiKategoriju.Size = new System.Drawing.Size(277, 39);
            this.btnObrišiKategoriju.TabIndex = 4;
            this.btnObrišiKategoriju.Text = "Obrisi kategoriju";
            this.btnObrišiKategoriju.UseVisualStyleBackColor = true;
            this.btnObrišiKategoriju.Click += new System.EventHandler(this.btnObrišiKategoriju_Click);
            // 
            // labNazivKategorije
            // 
            this.labNazivKategorije.AutoSize = true;
            this.labNazivKategorije.Location = new System.Drawing.Point(33, 34);
            this.labNazivKategorije.Name = "labNazivKategorije";
            this.labNazivKategorije.Size = new System.Drawing.Size(113, 17);
            this.labNazivKategorije.TabIndex = 0;
            this.labNazivKategorije.Text = "Naziv kategorije:";
            // 
            // btnIzmeniKategoriju
            // 
            this.btnIzmeniKategoriju.Location = new System.Drawing.Point(36, 196);
            this.btnIzmeniKategoriju.Name = "btnIzmeniKategoriju";
            this.btnIzmeniKategoriju.Size = new System.Drawing.Size(277, 39);
            this.btnIzmeniKategoriju.TabIndex = 3;
            this.btnIzmeniKategoriju.Text = "Izmeni kategoriju";
            this.btnIzmeniKategoriju.UseVisualStyleBackColor = true;
            this.btnIzmeniKategoriju.Click += new System.EventHandler(this.btnIzmeniKategoriju_Click);
            // 
            // tbNazivKategorije
            // 
            this.tbNazivKategorije.Location = new System.Drawing.Point(36, 63);
            this.tbNazivKategorije.Name = "tbNazivKategorije";
            this.tbNazivKategorije.Size = new System.Drawing.Size(277, 22);
            this.tbNazivKategorije.TabIndex = 1;
            // 
            // btnDodajKategoriju
            // 
            this.btnDodajKategoriju.Location = new System.Drawing.Point(36, 132);
            this.btnDodajKategoriju.Name = "btnDodajKategoriju";
            this.btnDodajKategoriju.Size = new System.Drawing.Size(277, 39);
            this.btnDodajKategoriju.TabIndex = 2;
            this.btnDodajKategoriju.Text = "Dodaj kategoriju";
            this.btnDodajKategoriju.UseVisualStyleBackColor = true;
            this.btnDodajKategoriju.Click += new System.EventHandler(this.btnDodajKategoriju_Click);
            // 
            // tabAzuriranjeArtikala
            // 
            this.tabAzuriranjeArtikala.Controls.Add(this.lbAzuriranjeArtikala);
            this.tabAzuriranjeArtikala.Controls.Add(this.gbAzuriranjeArtiklaKomande);
            this.tabAzuriranjeArtikala.Location = new System.Drawing.Point(4, 25);
            this.tabAzuriranjeArtikala.Name = "tabAzuriranjeArtikala";
            this.tabAzuriranjeArtikala.Padding = new System.Windows.Forms.Padding(3);
            this.tabAzuriranjeArtikala.Size = new System.Drawing.Size(768, 397);
            this.tabAzuriranjeArtikala.TabIndex = 1;
            this.tabAzuriranjeArtikala.Text = "Azuriranje artikala";
            this.tabAzuriranjeArtikala.UseVisualStyleBackColor = true;
            this.tabAzuriranjeArtikala.Enter += new System.EventHandler(this.tabAzuriranjeArtikala_Enter);
            // 
            // lbAzuriranjeArtikala
            // 
            this.lbAzuriranjeArtikala.FormattingEnabled = true;
            this.lbAzuriranjeArtikala.ItemHeight = 16;
            this.lbAzuriranjeArtikala.Location = new System.Drawing.Point(394, 6);
            this.lbAzuriranjeArtikala.Name = "lbAzuriranjeArtikala";
            this.lbAzuriranjeArtikala.Size = new System.Drawing.Size(368, 388);
            this.lbAzuriranjeArtikala.TabIndex = 10;
            // 
            // gbAzuriranjeArtiklaKomande
            // 
            this.gbAzuriranjeArtiklaKomande.Controls.Add(this.btnObrišiArtikal);
            this.gbAzuriranjeArtiklaKomande.Controls.Add(this.btnIzmeniArtikal);
            this.gbAzuriranjeArtiklaKomande.Controls.Add(this.btnDodajArtikal);
            this.gbAzuriranjeArtiklaKomande.Controls.Add(this.tbJedinicaArtikla);
            this.gbAzuriranjeArtiklaKomande.Controls.Add(this.labKategorija);
            this.gbAzuriranjeArtiklaKomande.Controls.Add(this.cbKategorija);
            this.gbAzuriranjeArtiklaKomande.Controls.Add(this.labNazivArtikla);
            this.gbAzuriranjeArtiklaKomande.Controls.Add(this.labCenaArtikla);
            this.gbAzuriranjeArtiklaKomande.Controls.Add(this.tbCenaArtikla);
            this.gbAzuriranjeArtiklaKomande.Controls.Add(this.labJedinicaMereArtikla);
            this.gbAzuriranjeArtiklaKomande.Controls.Add(this.tbNazivArtikla);
            this.gbAzuriranjeArtiklaKomande.Location = new System.Drawing.Point(6, 6);
            this.gbAzuriranjeArtiklaKomande.Name = "gbAzuriranjeArtiklaKomande";
            this.gbAzuriranjeArtiklaKomande.Size = new System.Drawing.Size(382, 388);
            this.gbAzuriranjeArtiklaKomande.TabIndex = 9;
            this.gbAzuriranjeArtiklaKomande.TabStop = false;
            // 
            // btnObrišiArtikal
            // 
            this.btnObrišiArtikal.Location = new System.Drawing.Point(66, 339);
            this.btnObrišiArtikal.Name = "btnObrišiArtikal";
            this.btnObrišiArtikal.Size = new System.Drawing.Size(210, 33);
            this.btnObrišiArtikal.TabIndex = 10;
            this.btnObrišiArtikal.Text = "Obriši artikal";
            this.btnObrišiArtikal.UseVisualStyleBackColor = true;
            this.btnObrišiArtikal.Click += new System.EventHandler(this.btnObrišiArtikal_Click);
            // 
            // btnIzmeniArtikal
            // 
            this.btnIzmeniArtikal.Location = new System.Drawing.Point(66, 291);
            this.btnIzmeniArtikal.Name = "btnIzmeniArtikal";
            this.btnIzmeniArtikal.Size = new System.Drawing.Size(210, 33);
            this.btnIzmeniArtikal.TabIndex = 9;
            this.btnIzmeniArtikal.Text = "Izmeni artikal";
            this.btnIzmeniArtikal.UseVisualStyleBackColor = true;
            this.btnIzmeniArtikal.Click += new System.EventHandler(this.btnIzmeniArtikal_Click);
            // 
            // btnDodajArtikal
            // 
            this.btnDodajArtikal.Location = new System.Drawing.Point(66, 242);
            this.btnDodajArtikal.Name = "btnDodajArtikal";
            this.btnDodajArtikal.Size = new System.Drawing.Size(210, 34);
            this.btnDodajArtikal.TabIndex = 8;
            this.btnDodajArtikal.Text = "Dodaj artikal";
            this.btnDodajArtikal.UseVisualStyleBackColor = true;
            this.btnDodajArtikal.Click += new System.EventHandler(this.btnDodajArtikal_Click);
            // 
            // tbJedinicaArtikla
            // 
            this.tbJedinicaArtikla.Location = new System.Drawing.Point(66, 197);
            this.tbJedinicaArtikla.Name = "tbJedinicaArtikla";
            this.tbJedinicaArtikla.Size = new System.Drawing.Size(210, 22);
            this.tbJedinicaArtikla.TabIndex = 6;
            // 
            // labKategorija
            // 
            this.labKategorija.AutoSize = true;
            this.labKategorija.Location = new System.Drawing.Point(66, 12);
            this.labKategorija.Name = "labKategorija";
            this.labKategorija.Size = new System.Drawing.Size(76, 17);
            this.labKategorija.TabIndex = 0;
            this.labKategorija.Text = "Kategorija:";
            // 
            // cbKategorija
            // 
            this.cbKategorija.FormattingEnabled = true;
            this.cbKategorija.Location = new System.Drawing.Point(66, 33);
            this.cbKategorija.Name = "cbKategorija";
            this.cbKategorija.Size = new System.Drawing.Size(210, 24);
            this.cbKategorija.TabIndex = 7;
            // 
            // labNazivArtikla
            // 
            this.labNazivArtikla.AutoSize = true;
            this.labNazivArtikla.Location = new System.Drawing.Point(66, 67);
            this.labNazivArtikla.Name = "labNazivArtikla";
            this.labNazivArtikla.Size = new System.Drawing.Size(85, 17);
            this.labNazivArtikla.TabIndex = 1;
            this.labNazivArtikla.Text = "Naziv artikla";
            // 
            // labCenaArtikla
            // 
            this.labCenaArtikla.AutoSize = true;
            this.labCenaArtikla.Location = new System.Drawing.Point(66, 121);
            this.labCenaArtikla.Name = "labCenaArtikla";
            this.labCenaArtikla.Size = new System.Drawing.Size(83, 17);
            this.labCenaArtikla.TabIndex = 2;
            this.labCenaArtikla.Text = "Cena artikla";
            // 
            // tbCenaArtikla
            // 
            this.tbCenaArtikla.Location = new System.Drawing.Point(66, 141);
            this.tbCenaArtikla.Name = "tbCenaArtikla";
            this.tbCenaArtikla.Size = new System.Drawing.Size(210, 22);
            this.tbCenaArtikla.TabIndex = 5;
            // 
            // labJedinicaMereArtikla
            // 
            this.labJedinicaMereArtikla.AutoSize = true;
            this.labJedinicaMereArtikla.Location = new System.Drawing.Point(66, 177);
            this.labJedinicaMereArtikla.Name = "labJedinicaMereArtikla";
            this.labJedinicaMereArtikla.Size = new System.Drawing.Size(138, 17);
            this.labJedinicaMereArtikla.TabIndex = 3;
            this.labJedinicaMereArtikla.Text = "Jedinica mere artikla";
            // 
            // tbNazivArtikla
            // 
            this.tbNazivArtikla.Location = new System.Drawing.Point(66, 88);
            this.tbNazivArtikla.Name = "tbNazivArtikla";
            this.tbNazivArtikla.Size = new System.Drawing.Size(210, 22);
            this.tbNazivArtikla.TabIndex = 4;
            // 
            // tabPregledStatistike
            // 
            this.tabPregledStatistike.Controls.Add(this.lIzaberiDatum);
            this.tabPregledStatistike.Controls.Add(this.flpPanelStatistike);
            this.tabPregledStatistike.Controls.Add(this.dtpPočetnoVreme);
            this.tabPregledStatistike.Location = new System.Drawing.Point(4, 25);
            this.tabPregledStatistike.Name = "tabPregledStatistike";
            this.tabPregledStatistike.Padding = new System.Windows.Forms.Padding(3);
            this.tabPregledStatistike.Size = new System.Drawing.Size(768, 397);
            this.tabPregledStatistike.TabIndex = 2;
            this.tabPregledStatistike.Text = "Pregled statistike";
            this.tabPregledStatistike.UseVisualStyleBackColor = true;
            // 
            // lIzaberiDatum
            // 
            this.lIzaberiDatum.AutoSize = true;
            this.lIzaberiDatum.Location = new System.Drawing.Point(355, 19);
            this.lIzaberiDatum.Name = "lIzaberiDatum";
            this.lIzaberiDatum.Size = new System.Drawing.Size(98, 17);
            this.lIzaberiDatum.TabIndex = 2;
            this.lIzaberiDatum.Text = "Početni datum";
            // 
            // flpPanelStatistike
            // 
            this.flpPanelStatistike.AutoScroll = true;
            this.flpPanelStatistike.Location = new System.Drawing.Point(6, 84);
            this.flpPanelStatistike.Name = "flpPanelStatistike";
            this.flpPanelStatistike.Size = new System.Drawing.Size(756, 307);
            this.flpPanelStatistike.TabIndex = 1;
            // 
            // dtpPočetnoVreme
            // 
            this.dtpPočetnoVreme.Location = new System.Drawing.Point(288, 39);
            this.dtpPočetnoVreme.Name = "dtpPočetnoVreme";
            this.dtpPočetnoVreme.Size = new System.Drawing.Size(225, 22);
            this.dtpPočetnoVreme.TabIndex = 0;
            this.dtpPočetnoVreme.ValueChanged += new System.EventHandler(this.dtpPočetnoVreme_ValueChanged);
            // 
            // AdministracijaStatistika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabAdministracijeStatistike);
            this.MaximizeBox = false;
            this.Name = "AdministracijaStatistika";
            this.Text = "Administracija Statistika";
            this.tabAdministracijeStatistike.ResumeLayout(false);
            this.tabAzuriranjeKategorija.ResumeLayout(false);
            this.gbKategorija.ResumeLayout(false);
            this.gbKategorija.PerformLayout();
            this.tabAzuriranjeArtikala.ResumeLayout(false);
            this.gbAzuriranjeArtiklaKomande.ResumeLayout(false);
            this.gbAzuriranjeArtiklaKomande.PerformLayout();
            this.tabPregledStatistike.ResumeLayout(false);
            this.tabPregledStatistike.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabAdministracijeStatistike;
        private System.Windows.Forms.TabPage tabAzuriranjeKategorija;
        private System.Windows.Forms.TabPage tabAzuriranjeArtikala;
        private System.Windows.Forms.TabPage tabPregledStatistike;
        private System.Windows.Forms.GroupBox gbKategorija;
        private System.Windows.Forms.Button btnObrišiKategoriju;
        private System.Windows.Forms.Label labNazivKategorije;
        private System.Windows.Forms.Button btnIzmeniKategoriju;
        private System.Windows.Forms.TextBox tbNazivKategorije;
        private System.Windows.Forms.Button btnDodajKategoriju;
        private System.Windows.Forms.ComboBox cbKategorija;
        private System.Windows.Forms.TextBox tbJedinicaArtikla;
        private System.Windows.Forms.TextBox tbCenaArtikla;
        private System.Windows.Forms.TextBox tbNazivArtikla;
        private System.Windows.Forms.Label labJedinicaMereArtikla;
        private System.Windows.Forms.Label labCenaArtikla;
        private System.Windows.Forms.Label labNazivArtikla;
        private System.Windows.Forms.Label labKategorija;
        private System.Windows.Forms.GroupBox gbAzuriranjeArtiklaKomande;
        private System.Windows.Forms.Button btnObrišiArtikal;
        private System.Windows.Forms.Button btnIzmeniArtikal;
        private System.Windows.Forms.Button btnDodajArtikal;
        private System.Windows.Forms.ListBox lbPrikazKategorija;
        private System.Windows.Forms.ListBox lbAzuriranjeArtikala;
        private System.Windows.Forms.DateTimePicker dtpPočetnoVreme;
        private System.Windows.Forms.Label lIzaberiDatum;
        private System.Windows.Forms.FlowLayoutPanel flpPanelStatistike;
    }
}
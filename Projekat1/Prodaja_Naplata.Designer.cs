namespace Projekat1
{
    partial class Prodaja_Naplata
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
            this.pKategorije = new System.Windows.Forms.Panel();
            this.gUplataRačun = new System.Windows.Forms.GroupBox();
            this.tabcUplataFiksalni = new System.Windows.Forms.TabControl();
            this.tabUplataObrada = new System.Windows.Forms.TabPage();
            this.lCena = new System.Windows.Forms.Label();
            this.lOznakaCena = new System.Windows.Forms.Label();
            this.btnObrisiSve = new System.Windows.Forms.Button();
            this.btnObrišiOdabran = new System.Windows.Forms.Button();
            this.lUplataLista = new System.Windows.Forms.ListBox();
            this.tabFiksalniRacun = new System.Windows.Forms.TabPage();
            this.lbRačun = new System.Windows.Forms.ListBox();
            this.btnPoništiRačun = new System.Windows.Forms.Button();
            this.btnSačuvajRačun = new System.Windows.Forms.Button();
            this.gUnos = new System.Windows.Forms.GroupBox();
            this.btnBrišiZadnjuCifru = new System.Windows.Forms.Button();
            this.lOznakaKoličina = new System.Windows.Forms.Label();
            this.tbKoličina = new System.Windows.Forms.TextBox();
            this.btnPotvrdi = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.flpArtikli = new System.Windows.Forms.FlowLayoutPanel();
            this.gUplataRačun.SuspendLayout();
            this.tabcUplataFiksalni.SuspendLayout();
            this.tabUplataObrada.SuspendLayout();
            this.tabFiksalniRacun.SuspendLayout();
            this.gUnos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pKategorije
            // 
            this.pKategorije.AutoScroll = true;
            this.pKategorije.Location = new System.Drawing.Point(13, 13);
            this.pKategorije.Name = "pKategorije";
            this.pKategorije.Size = new System.Drawing.Size(387, 100);
            this.pKategorije.TabIndex = 0;
            // 
            // gUplataRačun
            // 
            this.gUplataRačun.Controls.Add(this.tabcUplataFiksalni);
            this.gUplataRačun.Location = new System.Drawing.Point(406, 12);
            this.gUplataRačun.Name = "gUplataRačun";
            this.gUplataRačun.Size = new System.Drawing.Size(382, 212);
            this.gUplataRačun.TabIndex = 1;
            this.gUplataRačun.TabStop = false;
            // 
            // tabcUplataFiksalni
            // 
            this.tabcUplataFiksalni.Controls.Add(this.tabUplataObrada);
            this.tabcUplataFiksalni.Controls.Add(this.tabFiksalniRacun);
            this.tabcUplataFiksalni.Location = new System.Drawing.Point(6, 15);
            this.tabcUplataFiksalni.Name = "tabcUplataFiksalni";
            this.tabcUplataFiksalni.SelectedIndex = 0;
            this.tabcUplataFiksalni.Size = new System.Drawing.Size(370, 197);
            this.tabcUplataFiksalni.TabIndex = 12;
            this.tabcUplataFiksalni.SelectedIndexChanged += new System.EventHandler(this.tabcUplataFiksalni_SelectedIndexChanged);
            // 
            // tabUplataObrada
            // 
            this.tabUplataObrada.Controls.Add(this.lCena);
            this.tabUplataObrada.Controls.Add(this.lOznakaCena);
            this.tabUplataObrada.Controls.Add(this.btnObrisiSve);
            this.tabUplataObrada.Controls.Add(this.btnObrišiOdabran);
            this.tabUplataObrada.Controls.Add(this.lUplataLista);
            this.tabUplataObrada.Location = new System.Drawing.Point(4, 25);
            this.tabUplataObrada.Name = "tabUplataObrada";
            this.tabUplataObrada.Padding = new System.Windows.Forms.Padding(3);
            this.tabUplataObrada.Size = new System.Drawing.Size(362, 168);
            this.tabUplataObrada.TabIndex = 0;
            this.tabUplataObrada.Text = "Uplata/Obrada";
            this.tabUplataObrada.UseVisualStyleBackColor = true;
            // 
            // lCena
            // 
            this.lCena.AutoSize = true;
            this.lCena.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCena.Location = new System.Drawing.Point(129, 139);
            this.lCena.Name = "lCena";
            this.lCena.Size = new System.Drawing.Size(18, 20);
            this.lCena.TabIndex = 14;
            this.lCena.Text = "0";
            // 
            // lOznakaCena
            // 
            this.lOznakaCena.AutoSize = true;
            this.lOznakaCena.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lOznakaCena.Location = new System.Drawing.Point(6, 139);
            this.lOznakaCena.Name = "lOznakaCena";
            this.lOznakaCena.Size = new System.Drawing.Size(111, 20);
            this.lOznakaCena.TabIndex = 13;
            this.lOznakaCena.Text = "Ukupna cena:";
            // 
            // btnObrisiSve
            // 
            this.btnObrisiSve.Location = new System.Drawing.Point(264, 6);
            this.btnObrisiSve.Name = "btnObrisiSve";
            this.btnObrisiSve.Size = new System.Drawing.Size(92, 55);
            this.btnObrisiSve.TabIndex = 12;
            this.btnObrisiSve.Text = "Obrisi sve";
            this.btnObrisiSve.UseVisualStyleBackColor = true;
            this.btnObrisiSve.Click += new System.EventHandler(this.btnObrisiSve_Click);
            // 
            // btnObrišiOdabran
            // 
            this.btnObrišiOdabran.Location = new System.Drawing.Point(264, 81);
            this.btnObrišiOdabran.Name = "btnObrišiOdabran";
            this.btnObrišiOdabran.Size = new System.Drawing.Size(92, 55);
            this.btnObrišiOdabran.TabIndex = 11;
            this.btnObrišiOdabran.Text = "Obriši odabran";
            this.btnObrišiOdabran.UseVisualStyleBackColor = true;
            this.btnObrišiOdabran.Click += new System.EventHandler(this.btnObrišiOdabran_Click);
            // 
            // lUplataLista
            // 
            this.lUplataLista.FormattingEnabled = true;
            this.lUplataLista.HorizontalScrollbar = true;
            this.lUplataLista.ItemHeight = 16;
            this.lUplataLista.Location = new System.Drawing.Point(3, 4);
            this.lUplataLista.Name = "lUplataLista";
            this.lUplataLista.Size = new System.Drawing.Size(255, 132);
            this.lUplataLista.TabIndex = 0;
            // 
            // tabFiksalniRacun
            // 
            this.tabFiksalniRacun.Controls.Add(this.lbRačun);
            this.tabFiksalniRacun.Controls.Add(this.btnPoništiRačun);
            this.tabFiksalniRacun.Controls.Add(this.btnSačuvajRačun);
            this.tabFiksalniRacun.Location = new System.Drawing.Point(4, 25);
            this.tabFiksalniRacun.Name = "tabFiksalniRacun";
            this.tabFiksalniRacun.Padding = new System.Windows.Forms.Padding(3);
            this.tabFiksalniRacun.Size = new System.Drawing.Size(362, 168);
            this.tabFiksalniRacun.TabIndex = 1;
            this.tabFiksalniRacun.Text = "Fiksalni račun";
            this.tabFiksalniRacun.UseVisualStyleBackColor = true;
            // 
            // lbRačun
            // 
            this.lbRačun.FormattingEnabled = true;
            this.lbRačun.HorizontalScrollbar = true;
            this.lbRačun.ItemHeight = 16;
            this.lbRačun.Location = new System.Drawing.Point(7, 7);
            this.lbRačun.Name = "lbRačun";
            this.lbRačun.Size = new System.Drawing.Size(269, 148);
            this.lbRačun.TabIndex = 3;
            // 
            // btnPoništiRačun
            // 
            this.btnPoništiRačun.Location = new System.Drawing.Point(282, 7);
            this.btnPoništiRačun.Name = "btnPoništiRačun";
            this.btnPoništiRačun.Size = new System.Drawing.Size(74, 69);
            this.btnPoništiRačun.TabIndex = 2;
            this.btnPoništiRačun.Text = "Poništi Račun";
            this.btnPoništiRačun.UseVisualStyleBackColor = true;
            this.btnPoništiRačun.Click += new System.EventHandler(this.btnPoništiRačun_Click);
            // 
            // btnSačuvajRačun
            // 
            this.btnSačuvajRačun.Location = new System.Drawing.Point(282, 86);
            this.btnSačuvajRačun.Name = "btnSačuvajRačun";
            this.btnSačuvajRačun.Size = new System.Drawing.Size(74, 69);
            this.btnSačuvajRačun.TabIndex = 1;
            this.btnSačuvajRačun.Text = "Sačuvaj Račun";
            this.btnSačuvajRačun.UseVisualStyleBackColor = true;
            this.btnSačuvajRačun.Click += new System.EventHandler(this.btnSačuvajRačun_Click);
            // 
            // gUnos
            // 
            this.gUnos.Controls.Add(this.btnBrišiZadnjuCifru);
            this.gUnos.Controls.Add(this.lOznakaKoličina);
            this.gUnos.Controls.Add(this.tbKoličina);
            this.gUnos.Controls.Add(this.btnPotvrdi);
            this.gUnos.Controls.Add(this.btn9);
            this.gUnos.Controls.Add(this.btn8);
            this.gUnos.Controls.Add(this.btn7);
            this.gUnos.Controls.Add(this.btn6);
            this.gUnos.Controls.Add(this.btn5);
            this.gUnos.Controls.Add(this.btn4);
            this.gUnos.Controls.Add(this.btn3);
            this.gUnos.Controls.Add(this.btn2);
            this.gUnos.Controls.Add(this.btn1);
            this.gUnos.Controls.Add(this.btn0);
            this.gUnos.Location = new System.Drawing.Point(406, 230);
            this.gUnos.Name = "gUnos";
            this.gUnos.Size = new System.Drawing.Size(382, 208);
            this.gUnos.TabIndex = 2;
            this.gUnos.TabStop = false;
            // 
            // btnBrišiZadnjuCifru
            // 
            this.btnBrišiZadnjuCifru.Location = new System.Drawing.Point(295, 18);
            this.btnBrišiZadnjuCifru.Name = "btnBrišiZadnjuCifru";
            this.btnBrišiZadnjuCifru.Size = new System.Drawing.Size(55, 28);
            this.btnBrišiZadnjuCifru.TabIndex = 13;
            this.btnBrišiZadnjuCifru.Text = "del";
            this.btnBrišiZadnjuCifru.UseVisualStyleBackColor = true;
            this.btnBrišiZadnjuCifru.Click += new System.EventHandler(this.btnBrišiZadnjuCifru_Click);
            // 
            // lOznakaKoličina
            // 
            this.lOznakaKoličina.AutoSize = true;
            this.lOznakaKoličina.Location = new System.Drawing.Point(31, 24);
            this.lOznakaKoličina.Name = "lOznakaKoličina";
            this.lOznakaKoličina.Size = new System.Drawing.Size(61, 17);
            this.lOznakaKoličina.TabIndex = 12;
            this.lOznakaKoličina.Text = "Količina:";
            // 
            // tbKoličina
            // 
            this.tbKoličina.Location = new System.Drawing.Point(98, 21);
            this.tbKoličina.Name = "tbKoličina";
            this.tbKoličina.Size = new System.Drawing.Size(187, 22);
            this.tbKoličina.TabIndex = 11;
            this.tbKoličina.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbKoličina_KeyPress);
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.Location = new System.Drawing.Point(32, 157);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(318, 45);
            this.btnPotvrdi.TabIndex = 10;
            this.btnPotvrdi.Text = "Potvrdi";
            this.btnPotvrdi.UseVisualStyleBackColor = true;
            this.btnPotvrdi.Click += new System.EventHandler(this.btnPotvrdi_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(295, 106);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(55, 45);
            this.btn9.TabIndex = 9;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(230, 106);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(55, 45);
            this.btn8.TabIndex = 8;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(164, 106);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(55, 45);
            this.btn7.TabIndex = 7;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(98, 106);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(55, 45);
            this.btn6.TabIndex = 6;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(32, 106);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(55, 45);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(295, 55);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(55, 45);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(230, 55);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(55, 45);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(164, 55);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(55, 45);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(98, 55);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(55, 45);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(32, 55);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(55, 45);
            this.btn0.TabIndex = 0;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // flpArtikli
            // 
            this.flpArtikli.Location = new System.Drawing.Point(13, 124);
            this.flpArtikli.Name = "flpArtikli";
            this.flpArtikli.Size = new System.Drawing.Size(387, 314);
            this.flpArtikli.TabIndex = 0;
            // 
            // Prodaja_Naplata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flpArtikli);
            this.Controls.Add(this.gUnos);
            this.Controls.Add(this.gUplataRačun);
            this.Controls.Add(this.pKategorije);
            this.Name = "Prodaja_Naplata";
            this.Text = "Prodaja/Naplata";
            this.Load += new System.EventHandler(this.Prodaja_Naplata_Load);
            this.gUplataRačun.ResumeLayout(false);
            this.tabcUplataFiksalni.ResumeLayout(false);
            this.tabUplataObrada.ResumeLayout(false);
            this.tabUplataObrada.PerformLayout();
            this.tabFiksalniRacun.ResumeLayout(false);
            this.gUnos.ResumeLayout(false);
            this.gUnos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pKategorije;
        private System.Windows.Forms.GroupBox gUplataRačun;
        private System.Windows.Forms.GroupBox gUnos;
        private System.Windows.Forms.TabControl tabcUplataFiksalni;
        private System.Windows.Forms.TabPage tabUplataObrada;
        private System.Windows.Forms.TabPage tabFiksalniRacun;
        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.ListBox lUplataLista;
        private System.Windows.Forms.Label lCena;
        private System.Windows.Forms.Label lOznakaCena;
        private System.Windows.Forms.Button btnObrisiSve;
        private System.Windows.Forms.Button btnObrišiOdabran;
        private System.Windows.Forms.TextBox tbKoličina;
        private System.Windows.Forms.FlowLayoutPanel flpArtikli;
        private System.Windows.Forms.Label lOznakaKoličina;
        private System.Windows.Forms.Button btnBrišiZadnjuCifru;
        private System.Windows.Forms.Button btnPoništiRačun;
        private System.Windows.Forms.Button btnSačuvajRačun;
        private System.Windows.Forms.ListBox lbRačun;
    }
}
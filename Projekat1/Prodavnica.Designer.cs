namespace Projekat1
{
    partial class Prodavnica
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
            this.components = new System.ComponentModel.Container();
            this.btnAdministracijaStatistika = new System.Windows.Forms.Button();
            this.btnProdajaNaplata = new System.Windows.Forms.Button();
            this.btnOsveži = new System.Windows.Forms.Button();
            this.epKonekcijaBaza = new System.Windows.Forms.ErrorProvider(this.components);
            this.labStatusBazePodataka = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.epKonekcijaBaza)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdministracijaStatistika
            // 
            this.btnAdministracijaStatistika.Location = new System.Drawing.Point(137, 125);
            this.btnAdministracijaStatistika.Name = "btnAdministracijaStatistika";
            this.btnAdministracijaStatistika.Size = new System.Drawing.Size(335, 61);
            this.btnAdministracijaStatistika.TabIndex = 1;
            this.btnAdministracijaStatistika.Text = "Aministracija i statistika";
            this.btnAdministracijaStatistika.UseVisualStyleBackColor = true;
            this.btnAdministracijaStatistika.Click += new System.EventHandler(this.btnAdministracijaStatistika_Click);
            // 
            // btnProdajaNaplata
            // 
            this.btnProdajaNaplata.Location = new System.Drawing.Point(137, 211);
            this.btnProdajaNaplata.Name = "btnProdajaNaplata";
            this.btnProdajaNaplata.Size = new System.Drawing.Size(335, 61);
            this.btnProdajaNaplata.TabIndex = 2;
            this.btnProdajaNaplata.Text = "Prodaja/Naplata";
            this.btnProdajaNaplata.UseVisualStyleBackColor = true;
            this.btnProdajaNaplata.Click += new System.EventHandler(this.btnProdajaNaplata_Click);
            // 
            // btnOsveži
            // 
            this.btnOsveži.Location = new System.Drawing.Point(234, 50);
            this.btnOsveži.Name = "btnOsveži";
            this.btnOsveži.Size = new System.Drawing.Size(144, 38);
            this.btnOsveži.TabIndex = 3;
            this.btnOsveži.Text = "Osveži konekciju";
            this.btnOsveži.UseVisualStyleBackColor = true;
            this.btnOsveži.Click += new System.EventHandler(this.btnOsveži_Click);
            // 
            // epKonekcijaBaza
            // 
            this.epKonekcijaBaza.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.epKonekcijaBaza.ContainerControl = this;
            // 
            // labStatusBazePodataka
            // 
            this.labStatusBazePodataka.AutoSize = true;
            this.labStatusBazePodataka.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labStatusBazePodataka.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labStatusBazePodataka.Location = new System.Drawing.Point(152, 18);
            this.labStatusBazePodataka.Name = "labStatusBazePodataka";
            this.labStatusBazePodataka.Size = new System.Drawing.Size(0, 29);
            this.labStatusBazePodataka.TabIndex = 4;
            // 
            // Prodavnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 375);
            this.Controls.Add(this.labStatusBazePodataka);
            this.Controls.Add(this.btnOsveži);
            this.Controls.Add(this.btnProdajaNaplata);
            this.Controls.Add(this.btnAdministracijaStatistika);
            this.MaximizeBox = false;
            this.Name = "Prodavnica";
            this.Text = "Prodavnica";
            this.Load += new System.EventHandler(this.Prodavnica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epKonekcijaBaza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdministracijaStatistika;
        private System.Windows.Forms.Button btnProdajaNaplata;
        private System.Windows.Forms.Button btnOsveži;
        private System.Windows.Forms.ErrorProvider epKonekcijaBaza;
        private System.Windows.Forms.Label labStatusBazePodataka;
    }
}


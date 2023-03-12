using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp4;

namespace Projekat1
{
    public partial class Prodavnica : Form
    {
        public Prodavnica()
        {
            InitializeComponent();
        }

        private void btnAdministracijaStatistika_Click(object sender, EventArgs e)
        {
            AdministracijaStatistika forma = new AdministracijaStatistika();
            forma.ShowDialog();
        }

        private void Prodavnica_Load(object sender, EventArgs e)
        {
            try {
                Database.createConnection();
                labStatusBazePodataka.Text = "Povezani ste sa bazom podataka";
                labStatusBazePodataka.ForeColor = Color.FromArgb(0, 0, 200);
                btnOsveži.Enabled = false;
                btnAdministracijaStatistika.Enabled = true;
            }
            catch (Exception mysql_exception) {
                labStatusBazePodataka.Text = "Niste povezani sa bazom podataka";
                labStatusBazePodataka.ForeColor = Color.FromArgb(200,0,0);
                btnAdministracijaStatistika.Enabled = false;
                btnOsveži.Enabled = true;
            }
        }

        private void btnOsveži_Click(object sender, EventArgs e)
        {
            Prodavnica_Load(new object(), new EventArgs());
        }

        private void btnProdajaNaplata_Click(object sender, EventArgs e)
        {
            Prodaja_Naplata form = new Prodaja_Naplata();
            form.ShowDialog();
        }
    }
}

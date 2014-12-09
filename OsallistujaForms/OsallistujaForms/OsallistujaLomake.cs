using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OsallistujaForms
{
    public partial class OsallistujaLomake : Form
    {
        public Osallistuja osallistuja { get; set; }
        public OsallistujaLomake()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            // lue tiedot textboxeista ja radiobuttoneista
            string etunimi = textBoxEtunimi.Text;
            string sukunimi = textBoxSukunimi.Text;
            string puh = textBoxPuhelinnumero.Text;
            bool mies = radioButtonMies.Checked;
            // luo Osallistuja-olio
            osallistuja = new Osallistuja(sukunimi, etunimi, puh, mies);

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void buttonPeruuta_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void OsallistujaLomake_Load(object sender, EventArgs e)
        {
            if (osallistuja != null)
            {
                textBoxEtunimi.Text = osallistuja.Etunimi;
                textBoxSukunimi.Text = osallistuja.Sukunimi;
                textBoxPuhelinnumero.Text = osallistuja.Sukunimi;
                radioButtonMies.Checked = osallistuja.Sukupuoli;
                radioButtonNainen.Checked = !osallistuja.Sukupuoli;
            }
        }
    }
}

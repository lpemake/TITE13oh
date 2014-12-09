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
    public partial class OsallistujaLista : Form
    {
        // lista osallistujista
        private List<Osallistuja> osallistujat
            = new List<Osallistuja>();

        public OsallistujaLista()
        {
            InitializeComponent();
        }

        private void buttonLisaa_Click(object sender, EventArgs e)
        {
            // 1. Luodaan Lomake-luokan olio
            OsallistujaLomake lomake = new OsallistujaLomake();
            // 2. Näytetään osallistuja-lomake
            DialogResult result = lomake.ShowDialog();

            // 3. otetaan talteen lomakkeen tiedot
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                // talletaan uusi osallistuja
                Osallistuja o = lomake.osallistuja;
                // a) osallistujat-listaan ja
                osallistujat.Add(o);
                // b) ListBoxiin
                listBoxOsallistujat.Items.Add(o);
            }
        }

        private void buttonMuuta_Click(object sender, EventArgs e)
        {
            // hae valittu indeksi listBoxista (mikä rivi on valittu)
            int indeksi = listBoxOsallistujat.SelectedIndex;

            // jos indeksi >= 0 haetaan Osallistuja-olio osallistujat-Lististä
            if (indeksi >= 0)
            {
                Osallistuja o = osallistujat[indeksi];
                // luodaan osallistuja-lomake
                OsallistujaLomake lomake = new OsallistujaLomake();
                // kopioidaan listasta valittu osallistuja lomakkeen osallistuja-propertyyn
                lomake.osallistuja = o;
                // avataan osallistuja-lomake (katso mallia LisaaClick-metodista)
                // 2. Näytetään osallistuja-lomake
                DialogResult result = lomake.ShowDialog();

                // 3. otetaan talteen lomakkeen tiedot
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    // talletaan uusi osallistuja
                    o = lomake.osallistuja;

                    listBoxOsallistujat.Items.RemoveAt(indeksi);
                    listBoxOsallistujat.Items.Insert(indeksi, o);
                }
            }
        }
    }
}

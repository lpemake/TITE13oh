using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FormsPisteet
{
    public partial class Form1 : Form
    {
        private List<Point> pisteet;

        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string filename = dialog.FileName;
                StreamReader sr = File.OpenText(filename);

                pisteet = new List<Point>();

                string row;
                while ((row = sr.ReadLine()) != null)
                {
                    string[] palaset = row.Split();
                    string nimi = palaset[0];
                    double x = double.Parse(palaset[1]);
                    double y = double.Parse(palaset[2]);

                    Point p = new Point(nimi, x, y);
                    pisteet.Add(p);
                    listBoxPisteet.Items.Add(p);
                }
                //listBoxPisteet.DataSource = pisteet;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // talleta textBoxeihin muutetut tiedot listaan
            // lue tiedot textBoxeista
            string name = textBoxName.Text;
            double x = double.Parse(textBoxX.Text);
            double y = double.Parse(textBoxY.Text);

            int index = listBoxPisteet.SelectedIndex;
            if (index >= 0)
            {
                pisteet[index].Name = name;
                pisteet[index].X = x;
                pisteet[index].Y = y;
            }
            /*
            listBoxPisteet.DisplayMember = "";
            listBoxPisteet.DisplayMember = "He";
            listBoxPisteet.Refresh();
             * */
            //listBoxPisteet.DataSource = null;
            //listBoxPisteet.DataSource = pisteet;
            // luo piste-olio tai muuta olemassa olevan olion tietoja listassa
        }

        private void listBoxPisteet_SelectedIndexChanged(object sender, EventArgs e)
        {
            // on klikattu riviä
            int index = listBoxPisteet.SelectedIndex;
            Point p = pisteet[index];

            textBoxName.Text = p.Name;
            textBoxX.Text = p.X.ToString();
            textBoxY.Text = p.Y.ToString();
        }
    }
}

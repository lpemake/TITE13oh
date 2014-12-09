using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraafisetKuviot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            drawing1.DrawE = true;
            drawing1.Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            drawing1.DrawR = true;
            drawing1.Invalidate();
        }
    }
}

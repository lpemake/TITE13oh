using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraafisetKuviot
{
    public partial class Drawing : UserControl
    {
        public bool DrawR { get; set; }
        public bool DrawE { get; set; }

        public Drawing()
        {
            InitializeComponent();
        }

        private void Drawing_Paint(object sender, PaintEventArgs e)
        {
            if (DrawE)
                DrawEllipse();
            if (DrawR)
                DrawRectangle();
        }

        private void DrawEllipse()
        {
            System.Drawing.Pen myPen = new System.Drawing.Pen(System.Drawing.Color.Red);
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            formGraphics.DrawEllipse(myPen, new Rectangle(0, 0, 50, 50));
            myPen.Dispose();
            formGraphics.Dispose();
        }

        private void DrawRectangle()
        {
            System.Drawing.Pen myPen = new System.Drawing.Pen(System.Drawing.Color.Red);
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            formGraphics.DrawRectangle(myPen, new Rectangle(100, 100, 30, 30));
            myPen.Dispose();
            formGraphics.Dispose();
        }


    }
}

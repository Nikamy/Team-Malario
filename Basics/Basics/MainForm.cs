using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basics
{
    public partial class MainForm : Form
    {
        int ix0 = 0, iy0 = 400, ix1, iy1;
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the painting on the MainForm.
        /// </summary>
        /// <param name="e">Contains the graphics object needed to paint.</param>
        protected override void OnPaint(PaintEventArgs e)
        { 
            // Has always to be the first line of the overriden OnPaint-Method.
            Graphics graphics = e.Graphics;
            base.OnPaint(e);
            Malario_Child_Standing(ref graphics, ref ix0, ref iy0);




        }

    

        //Ein Bit : Braucht Füllfarbe, X-/Y-Coordinaten, Randfarbe
        public void Bit(ref Graphics graphics, ref int ix1, ref int iy1, ref Color GraficColor, ref Color PenColor)
        {

            SolidBrush Brush = new SolidBrush(GraficColor);
            Pen pen = new Pen(PenColor);
            Rectangle Bit = new Rectangle(ix1, iy1, 4, 4);
            Graphics formGraphics;
            formGraphics = this.CreateGraphics();

            graphics.DrawRectangle(pen, Bit);
            formGraphics.FillRectangle(Brush, Bit);
        }



        protected void Malario_Child_Standing(ref Graphics graphics,ref int ix0, ref int iy0)
        {
            ix1 = ix0;
            iy1 = iy0;
            Color GraficColor;
            Color PenColor;
            GraficColor = Color.Brown;
            PenColor = Color.Brown;

            Bit(ref graphics, ref ix1, ref iy1, ref GraficColor, ref PenColor);
        }



        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
                    switch (e.KeyCode)
                    {
                        case Keys.D:
                            ix0++;
                            break;
                        case Keys.A:
                            if (ix0 > 0){ix0--;}
                            break;
                        default:
                        case Keys.Z:
                            break;
                    }
            this.Invalidate();
        }
    }
}


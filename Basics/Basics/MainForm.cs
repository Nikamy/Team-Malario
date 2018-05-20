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
        int ix0 = 0, iy0 = 400, ix1, iy1, ixMMultiplier0 = 4, itJump0 = 0;
            bool M_Right = false, M_Left = false, M_Crouch = false, M_Jump = false;

        

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
            Malario_Child_Standing_Right(ref graphics, ref ix0, ref iy0, ref ixMMultiplier0);
        }

        //Ein Bit : Braucht Füllfarbe, X-/Y-Coordinaten, Randfarbe
        public void Bit(ref Graphics graphics, ref int ix1, ref int iy1, ref Color GraficColor, ref Color PenColor,ref int ixMMultiplier0)
        {

            SolidBrush Brush = new SolidBrush(GraficColor);
            Pen pen = new Pen(PenColor);
            Rectangle Bit = new Rectangle(ix1, iy1, ixMMultiplier0, ixMMultiplier0);
            Graphics formGraphics;
            formGraphics = CreateGraphics();

            graphics.DrawRectangle(pen, Bit);
            formGraphics.FillRectangle(Brush, Bit);
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        protected void Malario_Child_Standing_Right(ref Graphics graphics,ref int ix0, ref int iy0,ref int ixMMultiplier0)
        {
            ix1 = ix0;
            iy1 = iy0;
            Color GraficColor;
            Color PenColor;
            GraficColor = Color.Brown;
            PenColor = Color.Brown;

            //Schuh links
            //Erste Ebene
            Bit(ref graphics, ref ix1, ref iy1, ref GraficColor, ref PenColor, ref ixMMultiplier0);
            ix1 = ix1 + ixMMultiplier0;
            Bit(ref graphics, ref ix1, ref iy1, ref GraficColor, ref PenColor, ref ixMMultiplier0);
            ix1 = ix1 + ixMMultiplier0;
            Bit(ref graphics, ref ix1, ref iy1, ref GraficColor, ref PenColor, ref ixMMultiplier0);
            ix1 = ix1 + ixMMultiplier0;
            Bit(ref graphics, ref ix1, ref iy1, ref GraficColor, ref PenColor, ref ixMMultiplier0);
            //Zweite Ebene
            ix1 = ix1 - (ixMMultiplier0 * 2);
            iy1 = iy1 - ixMMultiplier0;
            Bit(ref graphics, ref ix1, ref iy1, ref GraficColor, ref PenColor, ref ixMMultiplier0);
            ix1 = ix1 + ixMMultiplier0;
            Bit(ref graphics, ref ix1, ref iy1, ref GraficColor, ref PenColor, ref ixMMultiplier0);
            ix1 = ix1 + ixMMultiplier0;
            Bit(ref graphics, ref ix1, ref iy1, ref GraficColor, ref PenColor, ref ixMMultiplier0);
            

            //Schuh rechts
            //Erste Ebene
            ix1 = ix1 + (ixMMultiplier0 * 5);
            iy1 = iy1 + ixMMultiplier0;
            Bit(ref graphics, ref ix1, ref iy1, ref GraficColor, ref PenColor, ref ixMMultiplier0);
            ix1 = ix1 + ixMMultiplier0;
            Bit(ref graphics, ref ix1, ref iy1, ref GraficColor, ref PenColor, ref ixMMultiplier0);
            ix1 = ix1 + ixMMultiplier0;
            Bit(ref graphics, ref ix1, ref iy1, ref GraficColor, ref PenColor, ref ixMMultiplier0);
            ix1 = ix1 + ixMMultiplier0;
            Bit(ref graphics, ref ix1, ref iy1, ref GraficColor, ref PenColor, ref ixMMultiplier0);
            //Zweite Ebene
            ix1 = ix1 - (ixMMultiplier0 * 3);
            iy1 = iy1 - ixMMultiplier0;
            Bit(ref graphics, ref ix1, ref iy1, ref GraficColor, ref PenColor, ref ixMMultiplier0);
            ix1 = ix1 + ixMMultiplier0;
            Bit(ref graphics, ref ix1, ref iy1, ref GraficColor, ref PenColor, ref ixMMultiplier0);
            ix1 = ix1 + ixMMultiplier0;
            Bit(ref graphics, ref ix1, ref iy1, ref GraficColor, ref PenColor, ref ixMMultiplier0);


            //Hose
            PenColor = Color.Blue;
            GraficColor = Color.Blue;
            //Dritte Ebene
            ix1 = ix1 - (ixMMultiplier0 * 8);
            iy1 = iy1 - ixMMultiplier0;
            Bit(ref graphics, ref ix1, ref iy1, ref GraficColor, ref PenColor, ref ixMMultiplier0);
            ix1 = ix1 + ixMMultiplier0;
            Bit(ref graphics, ref ix1, ref iy1, ref GraficColor, ref PenColor, ref ixMMultiplier0);
            ix1 = ix1 + ixMMultiplier0;
            Bit(ref graphics, ref ix1, ref iy1, ref GraficColor, ref PenColor, ref ixMMultiplier0);
            ix1 = ix1 + (ixMMultiplier0 * 3);
            Bit(ref graphics, ref ix1, ref iy1, ref GraficColor, ref PenColor, ref ixMMultiplier0);
            ix1 = ix1 + ixMMultiplier0;
            Bit(ref graphics, ref ix1, ref iy1, ref GraficColor, ref PenColor, ref ixMMultiplier0);
            ix1 = ix1 + ixMMultiplier0;
            Bit(ref graphics, ref ix1, ref iy1, ref GraficColor, ref PenColor, ref ixMMultiplier0);
            //Vierte Ebene
            ix1 = ix1 - (ixMMultiplier0 * 7);
            iy1 = iy1 - ixMMultiplier0;
            Bit(ref graphics, ref ix1, ref iy1, ref GraficColor, ref PenColor, ref ixMMultiplier0);
            ix1 = ix1 + ixMMultiplier0;
            Bit(ref graphics, ref ix1, ref iy1, ref GraficColor, ref PenColor, ref ixMMultiplier0);
            ix1 = ix1 + ixMMultiplier0;
            Bit(ref graphics, ref ix1, ref iy1, ref GraficColor, ref PenColor, ref ixMMultiplier0);
            ix1 = ix1 + ixMMultiplier0;
            Bit(ref graphics, ref ix1, ref iy1, ref GraficColor, ref PenColor, ref ixMMultiplier0);
            ix1 = ix1 + ixMMultiplier0;
            Bit(ref graphics, ref ix1, ref iy1, ref GraficColor, ref PenColor, ref ixMMultiplier0);
            ix1 = ix1 + ixMMultiplier0;
            Bit(ref graphics, ref ix1, ref iy1, ref GraficColor, ref PenColor, ref ixMMultiplier0);
            ix1 = ix1 + ixMMultiplier0;
            Bit(ref graphics, ref ix1, ref iy1, ref GraficColor, ref PenColor, ref ixMMultiplier0);
            ix1 = ix1 + ixMMultiplier0;
            Bit(ref graphics, ref ix1, ref iy1, ref GraficColor, ref PenColor, ref ixMMultiplier0);
            //Fünfte Ebene
            ix1 = ix1 - (ixMMultiplier0 * 6);
            iy1 = iy1 - ixMMultiplier0;
            Bit(ref graphics, ref ix1, ref iy1, ref GraficColor, ref PenColor, ref ixMMultiplier0);
            ix1 = ix1 + ixMMultiplier0;
            Bit(ref graphics, ref ix1, ref iy1, ref GraficColor, ref PenColor, ref ixMMultiplier0);
            ix1 = ix1 + ixMMultiplier0;
            Bit(ref graphics, ref ix1, ref iy1, ref GraficColor, ref PenColor, ref ixMMultiplier0);
            ix1 = ix1 + ixMMultiplier0;
            Bit(ref graphics, ref ix1, ref iy1, ref GraficColor, ref PenColor, ref ixMMultiplier0);
            ix1 = ix1 + ixMMultiplier0;
            Bit(ref graphics, ref ix1, ref iy1, ref GraficColor, ref PenColor, ref ixMMultiplier0);
            ix1 = ix1 + ixMMultiplier0;
            Bit(ref graphics, ref ix1, ref iy1, ref GraficColor, ref PenColor, ref ixMMultiplier0);
            //Sechste Ebene
            ix1 = ix1 - (ixMMultiplier0 * 5);
            iy1 = iy1 - ixMMultiplier0;
            Bit(ref graphics, ref ix1, ref iy1, ref GraficColor, ref PenColor, ref ixMMultiplier0);
            ix1 = ix1 + ixMMultiplier0;
            PenColor = Color.Yellow;
            GraficColor = Color.Yellow;
            Bit(ref graphics, ref ix1, ref iy1, ref GraficColor, ref PenColor, ref ixMMultiplier0);
            PenColor = Color.Blue;
            GraficColor = Color.Blue;
            ix1 = ix1 + ixMMultiplier0;
            Bit(ref graphics, ref ix1, ref iy1, ref GraficColor, ref PenColor, ref ixMMultiplier0);
            ix1 = ix1 + ixMMultiplier0;
            Bit(ref graphics, ref ix1, ref iy1, ref GraficColor, ref PenColor, ref ixMMultiplier0);
            ix1 = ix1 + ixMMultiplier0;
            PenColor = Color.Yellow;
            GraficColor = Color.Yellow;
            Bit(ref graphics, ref ix1, ref iy1, ref GraficColor, ref PenColor, ref ixMMultiplier0);
            PenColor = Color.Blue;
            GraficColor = Color.Blue;
            ix1 = ix1 + ixMMultiplier0;
            Bit(ref graphics, ref ix1, ref iy1, ref GraficColor, ref PenColor, ref ixMMultiplier0);
            //Siebte Ebene 
            ix1 = ix1 - (ixMMultiplier0 * 4);
            iy1 = iy1 - ixMMultiplier0;
            Bit(ref graphics, ref ix1, ref iy1, ref GraficColor, ref PenColor, ref ixMMultiplier0);
            ix1 = ix1 + ixMMultiplier0;
            Bit(ref graphics, ref ix1, ref iy1, ref GraficColor, ref PenColor, ref ixMMultiplier0);
            ix1 = ix1 + ixMMultiplier0;
            Bit(ref graphics, ref ix1, ref iy1, ref GraficColor, ref PenColor, ref ixMMultiplier0);
            ix1 = ix1 + ixMMultiplier0;
            Bit(ref graphics, ref ix1, ref iy1, ref GraficColor, ref PenColor, ref ixMMultiplier0);
            //Achte Ebene
            ix1 = ix1 - (ixMMultiplier0 * 3);
            iy1 = iy1 - ixMMultiplier0;
            Bit(ref graphics, ref ix1, ref iy1, ref GraficColor, ref PenColor, ref ixMMultiplier0);
            ix1 = ix1 + (ixMMultiplier0 * 3);
            Bit(ref graphics, ref ix1, ref iy1, ref GraficColor, ref PenColor, ref ixMMultiplier0);
            //Neunte Ebene
            ix1 = ix1 - (ixMMultiplier0 * 3);
            iy1 = iy1 - ixMMultiplier0;
            Bit(ref graphics, ref ix1, ref iy1, ref GraficColor, ref PenColor, ref ixMMultiplier0);


            //T-Shit
            //Sechste Ebene
            PenColor = Color.Red;
            GraficColor = Color.Red;
            ix1 = ix1 - (ixMMultiplier0 * 2);
            iy1 = iy1 + ixMMultiplier0 * 3;
            Bit(ref graphics, ref ix1, ref iy1, ref GraficColor, ref PenColor, ref ixMMultiplier0);
            ix1 = ix1 + (ixMMultiplier0 * 7);
            Bit(ref graphics, ref ix1, ref iy1, ref GraficColor, ref PenColor, ref ixMMultiplier0);
            //Siebte Ebene
            ix1 = ix1 - (ixMMultiplier0 * 9);
            iy1 = iy1 - ixMMultiplier0;
            Bit(ref graphics, ref ix1, ref iy1, ref GraficColor, ref PenColor, ref ixMMultiplier0);
            ix1 = ix1 + ixMMultiplier0;
            Bit(ref graphics, ref ix1, ref iy1, ref GraficColor, ref PenColor, ref ixMMultiplier0);
            ix1 = ix1 + ixMMultiplier0;
            Bit(ref graphics, ref ix1, ref iy1, ref GraficColor, ref PenColor, ref ixMMultiplier0);
            ix1 = ix1 + ixMMultiplier0;
            Bit(ref graphics, ref ix1, ref iy1, ref GraficColor, ref PenColor, ref ixMMultiplier0);
            ix1 = ix1 + ixMMultiplier0 * 5;
            Bit(ref graphics, ref ix1, ref iy1, ref GraficColor, ref PenColor, ref ixMMultiplier0);
            ix1 = ix1 + ixMMultiplier0;
            Bit(ref graphics, ref ix1, ref iy1, ref GraficColor, ref PenColor, ref ixMMultiplier0);
            ix1 = ix1 + ixMMultiplier0;
            Bit(ref graphics, ref ix1, ref iy1, ref GraficColor, ref PenColor, ref ixMMultiplier0);
            ix1 = ix1 + ixMMultiplier0;
            Bit(ref graphics, ref ix1, ref iy1, ref GraficColor, ref PenColor, ref ixMMultiplier0);
        }



        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        private void MMovement_Check_Tick(object sender, EventArgs e)
        {
            
            Timer tJump0 = new Timer();
            if (M_Right == true)
            {
                ix0 = ix0 + 2;
                this.Invalidate();

            }
            if(M_Left == true && ix0 > 0)
            {
                ix0 = ix0 - 2;
                this.Invalidate();
            }
            if (M_Jump == true)
            {
                
                tJump0.Interval = 1;
                tJump0.Tick += new EventHandler(MJump_1Bit_Up);
                tJump0.Start();
                itJump0 = 0;
                
                
                
            
            }
        }
        private void MJump_1Bit_Up(object sender, EventArgs e)
        {
            if (itJump0 < 100)
            {
                iy0--;
                itJump0++;
                this.Invalidate();
            }
        }
        private void MJump_1Bit_Down(object sender, EventArgs e)
        {
            if (itJump0 < 100)
            {
                iy0++;
                itJump0++;
                this.Invalidate();
            }
        }
        private void TJump0_Tick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
                    switch (e.KeyCode)
                    {
                        case Keys.D:
                    M_Right = true;
                            break;
                        case Keys.A:
                    M_Left = true;
                            break;
                        case Keys.W:
                    M_Jump = true;
                            break;
                    }
        }
        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D:
                    M_Right = false;
                    break;
                case Keys.A:
                    M_Left = false;
                    break;
                case Keys.W:
                    M_Jump = false;
                    break;
            }
        }
    }
}


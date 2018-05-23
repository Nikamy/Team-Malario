using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDI_Malario
{
    class Malario:Grundmethoden
    {
        public static void malen_Malario(ref Graphics graphics)
        {
            int x_Coordinate1 = 0, y_Coordinate1 = 0, x_Bit_Multiplier0 = 2, y_Bit_Multiplier0 =2;
            Color grafikfarbe = Color.Brown;
            Color stiftfarbe = Color.Brown;


            y_Coordinate1 = y_Coordinate1 + (y_Bit_Multiplier0 * 16);
            //Schuh links
            //Erste Ebene
            Grundmethoden grundmethoden = new Grundmethoden();
            x_Coordinate1 = x_Coordinate1 + x_Bit_Multiplier0;
            grundmethoden.malen_Bit(ref graphics, ref  x_Coordinate1, ref  y_Coordinate1, ref grafikfarbe, ref stiftfarbe, ref  x_Bit_Multiplier0, ref  y_Bit_Multiplier0);
            x_Coordinate1 = x_Coordinate1 + x_Bit_Multiplier0;
            grundmethoden.malen_Bit(ref graphics, ref  x_Coordinate1, ref  y_Coordinate1, ref grafikfarbe, ref stiftfarbe, ref  x_Bit_Multiplier0, ref  y_Bit_Multiplier0);
            x_Coordinate1 = x_Coordinate1 + x_Bit_Multiplier0;
            grundmethoden.malen_Bit(ref graphics, ref  x_Coordinate1, ref  y_Coordinate1, ref grafikfarbe, ref stiftfarbe, ref  x_Bit_Multiplier0, ref  y_Bit_Multiplier0);
            x_Coordinate1 = x_Coordinate1 + x_Bit_Multiplier0;
            grundmethoden.malen_Bit(ref graphics, ref  x_Coordinate1, ref  y_Coordinate1, ref grafikfarbe, ref stiftfarbe, ref  x_Bit_Multiplier0, ref  y_Bit_Multiplier0);
            //Zweite Ebene
            x_Coordinate1 = x_Coordinate1 - (x_Bit_Multiplier0 * 2);
            y_Coordinate1 = y_Coordinate1 - y_Bit_Multiplier0;
            grundmethoden.malen_Bit(ref graphics, ref  x_Coordinate1, ref  y_Coordinate1, ref grafikfarbe, ref stiftfarbe, ref  x_Bit_Multiplier0, ref  y_Bit_Multiplier0);
            x_Coordinate1 = x_Coordinate1 + x_Bit_Multiplier0;
            grundmethoden.malen_Bit(ref graphics, ref  x_Coordinate1, ref  y_Coordinate1, ref grafikfarbe, ref stiftfarbe, ref  x_Bit_Multiplier0, ref  y_Bit_Multiplier0);
            x_Coordinate1 = x_Coordinate1 + x_Bit_Multiplier0;
            grundmethoden.malen_Bit(ref graphics, ref  x_Coordinate1, ref  y_Coordinate1, ref grafikfarbe, ref stiftfarbe, ref  x_Bit_Multiplier0, ref  y_Bit_Multiplier0);


            //Schuh rechts
            //Erste Ebene
            x_Coordinate1 = x_Coordinate1 + (x_Bit_Multiplier0 * 5);
            y_Coordinate1 = y_Coordinate1 + y_Bit_Multiplier0;
            grundmethoden.malen_Bit(ref graphics, ref  x_Coordinate1, ref  y_Coordinate1, ref grafikfarbe, ref stiftfarbe, ref  x_Bit_Multiplier0, ref  y_Bit_Multiplier0);
            x_Coordinate1 = x_Coordinate1 + x_Bit_Multiplier0;
            grundmethoden.malen_Bit(ref graphics, ref  x_Coordinate1, ref  y_Coordinate1, ref grafikfarbe, ref stiftfarbe, ref  x_Bit_Multiplier0, ref  y_Bit_Multiplier0);
            x_Coordinate1 = x_Coordinate1 + x_Bit_Multiplier0;
            grundmethoden.malen_Bit(ref graphics, ref  x_Coordinate1, ref  y_Coordinate1, ref grafikfarbe, ref stiftfarbe, ref  x_Bit_Multiplier0, ref  y_Bit_Multiplier0);
            x_Coordinate1 = x_Coordinate1 + x_Bit_Multiplier0;
            grundmethoden.malen_Bit(ref graphics, ref  x_Coordinate1, ref  y_Coordinate1, ref grafikfarbe, ref stiftfarbe, ref  x_Bit_Multiplier0, ref  y_Bit_Multiplier0);
            //Zweite Ebene
            x_Coordinate1 = x_Coordinate1 - (x_Bit_Multiplier0 * 3);
            y_Coordinate1 = y_Coordinate1 - y_Bit_Multiplier0;
            grundmethoden.malen_Bit(ref graphics, ref  x_Coordinate1, ref  y_Coordinate1, ref grafikfarbe, ref stiftfarbe, ref  x_Bit_Multiplier0, ref  y_Bit_Multiplier0);
            x_Coordinate1 = x_Coordinate1 + x_Bit_Multiplier0;
            grundmethoden.malen_Bit(ref graphics, ref  x_Coordinate1, ref  y_Coordinate1, ref grafikfarbe, ref stiftfarbe, ref  x_Bit_Multiplier0, ref  y_Bit_Multiplier0);
            x_Coordinate1 = x_Coordinate1 + x_Bit_Multiplier0;
            grundmethoden.malen_Bit(ref graphics, ref  x_Coordinate1, ref  y_Coordinate1, ref grafikfarbe, ref stiftfarbe, ref  x_Bit_Multiplier0, ref  y_Bit_Multiplier0);


            //Hose
            stiftfarbe = Color.Blue;
            grafikfarbe = Color.Blue;
            //Dritte Ebene
            x_Coordinate1 = x_Coordinate1 - (x_Bit_Multiplier0 * 8);
            y_Coordinate1 = y_Coordinate1 - y_Bit_Multiplier0;
            grundmethoden.malen_Bit(ref graphics, ref  x_Coordinate1, ref  y_Coordinate1, ref grafikfarbe, ref stiftfarbe, ref  x_Bit_Multiplier0, ref  y_Bit_Multiplier0);
            x_Coordinate1 = x_Coordinate1 + x_Bit_Multiplier0;
            grundmethoden.malen_Bit(ref graphics, ref  x_Coordinate1, ref  y_Coordinate1, ref grafikfarbe, ref stiftfarbe, ref  x_Bit_Multiplier0, ref  y_Bit_Multiplier0);
            x_Coordinate1 = x_Coordinate1 + x_Bit_Multiplier0;
            grundmethoden.malen_Bit(ref graphics, ref  x_Coordinate1, ref  y_Coordinate1, ref grafikfarbe, ref stiftfarbe, ref  x_Bit_Multiplier0, ref  y_Bit_Multiplier0);
            x_Coordinate1 = x_Coordinate1 + (x_Bit_Multiplier0 * 3);
            grundmethoden.malen_Bit(ref graphics, ref  x_Coordinate1, ref  y_Coordinate1, ref grafikfarbe, ref stiftfarbe, ref  x_Bit_Multiplier0, ref  y_Bit_Multiplier0);
            x_Coordinate1 = x_Coordinate1 + x_Bit_Multiplier0;
            grundmethoden.malen_Bit(ref graphics, ref  x_Coordinate1, ref  y_Coordinate1, ref grafikfarbe, ref stiftfarbe, ref  x_Bit_Multiplier0, ref  y_Bit_Multiplier0);
            x_Coordinate1 = x_Coordinate1 + x_Bit_Multiplier0;
            grundmethoden.malen_Bit(ref graphics, ref  x_Coordinate1, ref  y_Coordinate1, ref grafikfarbe, ref stiftfarbe, ref  x_Bit_Multiplier0, ref  y_Bit_Multiplier0);
            //Vierte Ebene
            x_Coordinate1 = x_Coordinate1 - (x_Bit_Multiplier0 * 7);
            y_Coordinate1 = y_Coordinate1 - y_Bit_Multiplier0;
            grundmethoden.malen_Bit(ref graphics, ref  x_Coordinate1, ref  y_Coordinate1, ref grafikfarbe, ref stiftfarbe, ref  x_Bit_Multiplier0, ref  y_Bit_Multiplier0);
            x_Coordinate1 = x_Coordinate1 + x_Bit_Multiplier0;
            grundmethoden.malen_Bit(ref graphics, ref  x_Coordinate1, ref  y_Coordinate1, ref grafikfarbe, ref stiftfarbe, ref  x_Bit_Multiplier0, ref  y_Bit_Multiplier0);
            x_Coordinate1 = x_Coordinate1 + x_Bit_Multiplier0;
            grundmethoden.malen_Bit(ref graphics, ref  x_Coordinate1, ref  y_Coordinate1, ref grafikfarbe, ref stiftfarbe, ref  x_Bit_Multiplier0, ref  y_Bit_Multiplier0);
            x_Coordinate1 = x_Coordinate1 + x_Bit_Multiplier0;
            grundmethoden.malen_Bit(ref graphics, ref  x_Coordinate1, ref  y_Coordinate1, ref grafikfarbe, ref stiftfarbe, ref  x_Bit_Multiplier0, ref  y_Bit_Multiplier0);
            x_Coordinate1 = x_Coordinate1 + x_Bit_Multiplier0;
            grundmethoden.malen_Bit(ref graphics, ref  x_Coordinate1, ref  y_Coordinate1, ref grafikfarbe, ref stiftfarbe, ref  x_Bit_Multiplier0, ref  y_Bit_Multiplier0);
            x_Coordinate1 = x_Coordinate1 + x_Bit_Multiplier0;
            grundmethoden.malen_Bit(ref graphics, ref  x_Coordinate1, ref  y_Coordinate1, ref grafikfarbe, ref stiftfarbe, ref  x_Bit_Multiplier0, ref  y_Bit_Multiplier0);
            x_Coordinate1 = x_Coordinate1 + x_Bit_Multiplier0;
            grundmethoden.malen_Bit(ref graphics, ref  x_Coordinate1, ref  y_Coordinate1, ref grafikfarbe, ref stiftfarbe, ref  x_Bit_Multiplier0, ref  y_Bit_Multiplier0);
            x_Coordinate1 = x_Coordinate1 + x_Bit_Multiplier0;
            grundmethoden.malen_Bit(ref graphics, ref  x_Coordinate1, ref  y_Coordinate1, ref grafikfarbe, ref stiftfarbe, ref  x_Bit_Multiplier0, ref  y_Bit_Multiplier0);
            //Fünfte Ebene
            x_Coordinate1 = x_Coordinate1 - (x_Bit_Multiplier0 * 6);
            y_Coordinate1 = y_Coordinate1 - y_Bit_Multiplier0;
            grundmethoden.malen_Bit(ref graphics, ref  x_Coordinate1, ref  y_Coordinate1, ref grafikfarbe, ref stiftfarbe, ref  x_Bit_Multiplier0, ref  y_Bit_Multiplier0);
            x_Coordinate1 = x_Coordinate1 + x_Bit_Multiplier0;
            grundmethoden.malen_Bit(ref graphics, ref  x_Coordinate1, ref  y_Coordinate1, ref grafikfarbe, ref stiftfarbe, ref  x_Bit_Multiplier0, ref  y_Bit_Multiplier0);
            x_Coordinate1 = x_Coordinate1 + x_Bit_Multiplier0;
            grundmethoden.malen_Bit(ref graphics, ref  x_Coordinate1, ref  y_Coordinate1, ref grafikfarbe, ref stiftfarbe, ref  x_Bit_Multiplier0, ref  y_Bit_Multiplier0);
            x_Coordinate1 = x_Coordinate1 + x_Bit_Multiplier0;
            grundmethoden.malen_Bit(ref graphics, ref  x_Coordinate1, ref  y_Coordinate1, ref grafikfarbe, ref stiftfarbe, ref  x_Bit_Multiplier0, ref  y_Bit_Multiplier0);
            x_Coordinate1 = x_Coordinate1 + x_Bit_Multiplier0;
            grundmethoden.malen_Bit(ref graphics, ref  x_Coordinate1, ref  y_Coordinate1, ref grafikfarbe, ref stiftfarbe, ref  x_Bit_Multiplier0, ref  y_Bit_Multiplier0);
            x_Coordinate1 = x_Coordinate1 + x_Bit_Multiplier0;
            grundmethoden.malen_Bit(ref graphics, ref  x_Coordinate1, ref  y_Coordinate1, ref grafikfarbe, ref stiftfarbe, ref  x_Bit_Multiplier0, ref  y_Bit_Multiplier0);
            //Sechste Ebene
            x_Coordinate1 = x_Coordinate1 - (x_Bit_Multiplier0 * 5);
            y_Coordinate1 = y_Coordinate1 - y_Bit_Multiplier0;
            grundmethoden.malen_Bit(ref graphics, ref  x_Coordinate1, ref  y_Coordinate1, ref grafikfarbe, ref stiftfarbe, ref  x_Bit_Multiplier0, ref  y_Bit_Multiplier0);
            x_Coordinate1 = x_Coordinate1 + x_Bit_Multiplier0;
            stiftfarbe = Color.Yellow;
            grafikfarbe = Color.Yellow;
            grundmethoden.malen_Bit(ref graphics, ref  x_Coordinate1, ref  y_Coordinate1, ref grafikfarbe, ref stiftfarbe, ref  x_Bit_Multiplier0, ref  y_Bit_Multiplier0);
            stiftfarbe = Color.Blue;
            grafikfarbe = Color.Blue;
            x_Coordinate1 = x_Coordinate1 + x_Bit_Multiplier0;
            grundmethoden.malen_Bit(ref graphics, ref  x_Coordinate1, ref  y_Coordinate1, ref grafikfarbe, ref stiftfarbe, ref  x_Bit_Multiplier0, ref  y_Bit_Multiplier0);
            x_Coordinate1 = x_Coordinate1 + x_Bit_Multiplier0;
            grundmethoden.malen_Bit(ref graphics, ref  x_Coordinate1, ref  y_Coordinate1, ref grafikfarbe, ref stiftfarbe, ref  x_Bit_Multiplier0, ref  y_Bit_Multiplier0);
            x_Coordinate1 = x_Coordinate1 + x_Bit_Multiplier0;
            stiftfarbe = Color.Yellow;
            grafikfarbe = Color.Yellow;
            grundmethoden.malen_Bit(ref graphics, ref  x_Coordinate1, ref  y_Coordinate1, ref grafikfarbe, ref stiftfarbe, ref  x_Bit_Multiplier0, ref  y_Bit_Multiplier0);
            stiftfarbe = Color.Blue;
            grafikfarbe = Color.Blue;
            x_Coordinate1 = x_Coordinate1 + x_Bit_Multiplier0;
            grundmethoden.malen_Bit(ref graphics, ref  x_Coordinate1, ref  y_Coordinate1, ref grafikfarbe, ref stiftfarbe, ref  x_Bit_Multiplier0, ref  y_Bit_Multiplier0);
            //Siebte Ebene 
            x_Coordinate1 = x_Coordinate1 - (x_Bit_Multiplier0 * 4);
            y_Coordinate1 = y_Coordinate1 - y_Bit_Multiplier0;
            grundmethoden.malen_Bit(ref graphics, ref  x_Coordinate1, ref  y_Coordinate1, ref grafikfarbe, ref stiftfarbe, ref  x_Bit_Multiplier0, ref  y_Bit_Multiplier0);
            x_Coordinate1 = x_Coordinate1 + x_Bit_Multiplier0;
            grundmethoden.malen_Bit(ref graphics, ref  x_Coordinate1, ref  y_Coordinate1, ref grafikfarbe, ref stiftfarbe, ref  x_Bit_Multiplier0, ref  y_Bit_Multiplier0);
            x_Coordinate1 = x_Coordinate1 + x_Bit_Multiplier0;
            grundmethoden.malen_Bit(ref graphics, ref  x_Coordinate1, ref  y_Coordinate1, ref grafikfarbe, ref stiftfarbe, ref  x_Bit_Multiplier0, ref  y_Bit_Multiplier0);
            x_Coordinate1 = x_Coordinate1 + x_Bit_Multiplier0;
            grundmethoden.malen_Bit(ref graphics, ref  x_Coordinate1, ref  y_Coordinate1, ref grafikfarbe, ref stiftfarbe, ref  x_Bit_Multiplier0, ref  y_Bit_Multiplier0);
            //Achte Ebene
            x_Coordinate1 = x_Coordinate1 - (x_Bit_Multiplier0 * 3);
            y_Coordinate1 = y_Coordinate1 - y_Bit_Multiplier0;
            grundmethoden.malen_Bit(ref graphics, ref  x_Coordinate1, ref  y_Coordinate1, ref grafikfarbe, ref stiftfarbe, ref  x_Bit_Multiplier0, ref  y_Bit_Multiplier0);
            x_Coordinate1 = x_Coordinate1 + (x_Bit_Multiplier0 * 3);
            grundmethoden.malen_Bit(ref graphics, ref  x_Coordinate1, ref  y_Coordinate1, ref grafikfarbe, ref stiftfarbe, ref  x_Bit_Multiplier0, ref  y_Bit_Multiplier0);
            //Neunte Ebene
            x_Coordinate1 = x_Coordinate1 - (x_Bit_Multiplier0 * 3);
            y_Coordinate1 = y_Coordinate1 - y_Bit_Multiplier0;
            grundmethoden.malen_Bit(ref graphics, ref  x_Coordinate1, ref  y_Coordinate1, ref grafikfarbe, ref stiftfarbe, ref  x_Bit_Multiplier0, ref  y_Bit_Multiplier0);


            //T-Shit
            //Sechste Ebene
            stiftfarbe = Color.Red;
            grafikfarbe = Color.Red;
            x_Coordinate1 = x_Coordinate1 - (x_Bit_Multiplier0 * 2);
            y_Coordinate1 = y_Coordinate1 + y_Bit_Multiplier0 * 3;
            grundmethoden.malen_Bit(ref graphics, ref  x_Coordinate1, ref  y_Coordinate1, ref grafikfarbe, ref stiftfarbe, ref  x_Bit_Multiplier0, ref  y_Bit_Multiplier0);
            x_Coordinate1 = x_Coordinate1 + (x_Bit_Multiplier0 * 7);
            grundmethoden.malen_Bit(ref graphics, ref  x_Coordinate1, ref  y_Coordinate1, ref grafikfarbe, ref stiftfarbe, ref  x_Bit_Multiplier0, ref  y_Bit_Multiplier0);
            //Siebte Ebene
            x_Coordinate1 = x_Coordinate1 - (x_Bit_Multiplier0 * 9);
            y_Coordinate1 = y_Coordinate1 - y_Bit_Multiplier0;
            grundmethoden.malen_Bit(ref graphics, ref  x_Coordinate1, ref  y_Coordinate1, ref grafikfarbe, ref stiftfarbe, ref  x_Bit_Multiplier0, ref  y_Bit_Multiplier0);
            x_Coordinate1 = x_Coordinate1 + x_Bit_Multiplier0;
            grundmethoden.malen_Bit(ref graphics, ref  x_Coordinate1, ref  y_Coordinate1, ref grafikfarbe, ref stiftfarbe, ref  x_Bit_Multiplier0, ref  y_Bit_Multiplier0);
            x_Coordinate1 = x_Coordinate1 + x_Bit_Multiplier0;
            grundmethoden.malen_Bit(ref graphics, ref  x_Coordinate1, ref  y_Coordinate1, ref grafikfarbe, ref stiftfarbe, ref  x_Bit_Multiplier0, ref  y_Bit_Multiplier0);
            x_Coordinate1 = x_Coordinate1 + x_Bit_Multiplier0;
            grundmethoden.malen_Bit(ref graphics, ref  x_Coordinate1, ref  y_Coordinate1, ref grafikfarbe, ref stiftfarbe, ref  x_Bit_Multiplier0, ref  y_Bit_Multiplier0);
            x_Coordinate1 = x_Coordinate1 + x_Bit_Multiplier0 * 5;
            grundmethoden.malen_Bit(ref graphics, ref  x_Coordinate1, ref  y_Coordinate1, ref grafikfarbe, ref stiftfarbe, ref  x_Bit_Multiplier0, ref  y_Bit_Multiplier0);
            x_Coordinate1 = x_Coordinate1 + x_Bit_Multiplier0;
            grundmethoden.malen_Bit(ref graphics, ref  x_Coordinate1, ref  y_Coordinate1, ref grafikfarbe, ref stiftfarbe, ref  x_Bit_Multiplier0, ref  y_Bit_Multiplier0);
            x_Coordinate1 = x_Coordinate1 + x_Bit_Multiplier0;
            grundmethoden.malen_Bit(ref graphics, ref  x_Coordinate1, ref  y_Coordinate1, ref grafikfarbe, ref stiftfarbe, ref  x_Bit_Multiplier0, ref  y_Bit_Multiplier0);
            x_Coordinate1 = x_Coordinate1 + x_Bit_Multiplier0;
            grundmethoden.malen_Bit(ref graphics, ref  x_Coordinate1, ref  y_Coordinate1, ref grafikfarbe, ref stiftfarbe, ref  x_Bit_Multiplier0, ref  y_Bit_Multiplier0);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Panel_Malario
            // 
            this.Panel_Malario.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Malario_Paint);
            // 
            // Malario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(464, 441);
            this.Name = "Malario";
            this.ResumeLayout(false);

        }

        private void Panel_Malario_Paint(object sender, PaintEventArgs e)
        {

        }
        public void Malen_Gamba(ref Graphics graphics)
        {
            int x_Koordinate = 0, y_Koordinate = 0, x_Bit_Multiplier = 2, y_Bit_Multiplier = 2;
            Color füllfarbe = Color.Blue;
            Color stiftfarbe = Color.Blue;
            y_Koordinate = y_Koordinate + (y_Bit_Multiplier * 16);
            Grundmethoden.
        }
    }
}
}

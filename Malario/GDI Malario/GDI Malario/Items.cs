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
    class Items : Grundmethoden
    {
        //Hit-Box ist größer als das Item.
        //Heißt es werden die X/Y Pos für oben links für ein 24X24 Item gegeben das Item benuzt aber nur 12X12
        public static void malen_Energy(Graphics graphics, int x_Pos0, int y_Pos0)
        {
            int x_Pos = x_Pos0, y_Pos = y_Pos0;
            int xLänge, yLänge;
            Color color1 = Color.Black;
            Color color2 = Color.DarkGray;
            Color color3 = Color.LimeGreen;
            Grundmethoden grundmethoden = new Grundmethoden();

            //oberer Dosendeckel
            y_Pos += 3;
            x_Pos += 12;
            xLänge = 6;
            yLänge = 3;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color2, color2, xLänge, yLänge);

            //unterer Dosen Deckel
            y_Pos += 18;
            xLänge = 6;
            yLänge = 3;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color2, color2, xLänge, yLänge);

            //Mittlere Dose
            y_Pos -= 15;
            x_Pos -= 3;
            xLänge = 12;
            yLänge = 15;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color1, color1, xLänge, yLänge);



            //Monster Logo

        }
    }
}

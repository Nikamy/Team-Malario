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
            y_Pos += 4;
            xLänge = 4;
            yLänge = 1;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color3, color3, xLänge, yLänge);
            x_Pos += 4;
            xLänge = 4;
            yLänge = 1;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color3, color3, xLänge, yLänge);
            x_Pos += 4;
            xLänge = 3;
            yLänge = 1;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color3, color3, xLänge, yLänge);

            x_Pos -= 7;
            y_Pos += 1;
            xLänge = 2;
            yLänge = 2;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color3, color3, xLänge, yLänge);
            x_Pos += 5;
            xLänge = 2;
            yLänge = 2;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color3, color3, xLänge, yLänge);
            x_Pos += 5;
            xLänge = 2;
            yLänge = 2;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color3, color3, xLänge, yLänge);

            x_Pos -= 10;
            y_Pos += 1;
            xLänge = 1;
            yLänge = 6;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color3, color3, xLänge, yLänge);
            x_Pos += 5;
            xLänge = 1;
            yLänge = 6;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color3, color3, xLänge, yLänge);
            x_Pos += 5;
            xLänge = 1;
            yLänge = 6;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color3, color3, xLänge, yLänge);
        }

        public static void malen_Coin(Graphics graphics, int x_Pos0, int y_Pos0)
        {
            int x_Pos = x_Pos0, y_Pos = y_Pos0;
            int xLänge, yLänge;
            Color color1 = Color.Chocolate;
            Color color2 = Color.Gold;
            Grundmethoden grundmethoden = new Grundmethoden();

            //aüßerer Rand
            x_Pos += 8;
            xLänge = 8;
            yLänge = 22;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color1, color1, xLänge, yLänge);

            y_Pos += 2;
            x_Pos -= 2;
            xLänge = 12;
            yLänge = 18;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color1, color1, xLänge, yLänge);

            y_Pos += 2;
            x_Pos -= 2;
            xLänge = 16;
            yLänge = 14;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color1, color1, xLänge, yLänge);

            // aüßeres Gelb
            y_Pos -= 2;
            x_Pos += 4;
            xLänge = 8;
            yLänge = 18;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color2, color2, xLänge, yLänge);

            y_Pos += 2;
            x_Pos -= 2;
            xLänge = 12;
            yLänge = 14;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color2, color2, xLänge, yLänge);

            //innerer Rand
            x_Pos += 4;
            xLänge = 4;
            yLänge = 14;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color1, color1, xLänge, yLänge);

            y_Pos += 2;
            x_Pos -= 2;
            xLänge = 8;
            yLänge = 10;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color1, color1, xLänge, yLänge);

            //inneres Gelb
            x_Pos += 2;
            xLänge = 4;
            yLänge = 10;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color2, color2, xLänge, yLänge);
        }
        public static void malen_LaserGun(Graphics graphics, int x_Pos0, int y_Pos0)
        {
            int x_Pos = x_Pos0, y_Pos = y_Pos0;
            int xLänge, yLänge;
            Color color1 = Color.DarkGray;
            Grundmethoden grundmethoden = new Grundmethoden();

            //Scope
            y_Pos += 4;
            x_Pos += 6;
            xLänge = 10;
            yLänge = 2;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color1, color1, xLänge, yLänge);

            y_Pos += 2;
            x_Pos += 2;
            xLänge = 2;
            yLänge = 2;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color1, color1, xLänge, yLänge);

            //Lauf
            y_Pos += 2;
            x_Pos -= 4;
            xLänge = 22;
            yLänge = 2;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color1, color1, xLänge, yLänge);

            y_Pos += 2;
            xLänge = 2;
            yLänge = 2;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color1, color1, xLänge, yLänge);

            x_Pos += 4;
            xLänge = 2;
            yLänge = 6;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color1, color1, xLänge, yLänge);

            x_Pos += 2;
            xLänge = 3;
            yLänge = 1;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color1, color1, xLänge, yLänge);

            x_Pos += 3;
            xLänge = 1;
            yLänge = 3;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color1, color1, xLänge, yLänge);

            y_Pos += 3;
            x_Pos -= 3;
            xLänge = 3;
            yLänge = 1;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color1, color1, xLänge, yLänge);

            y_Pos -= 4;
            x_Pos += 10;
            xLänge = 2;
            yLänge = 5;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color1, color1, xLänge, yLänge);
        }
    }
}

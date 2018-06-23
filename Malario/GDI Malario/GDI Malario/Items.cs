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
            int Bit_Multiplier0 = 3;
            Color color1 = Color.LightGray;
            Color color2 = Color.DarkGray;
            Grundmethoden grundmethoden = new Grundmethoden();

            //Oberste Zeile
            y_Pos += 21;
            x_Pos += 0;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color1, color1, Bit_Multiplier0, Bit_Multiplier0);
            x_Pos += 3;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color1, color1, Bit_Multiplier0, Bit_Multiplier0);
            x_Pos += 3;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color1, color1, Bit_Multiplier0, Bit_Multiplier0);
            x_Pos += 3;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color2, color2, Bit_Multiplier0, Bit_Multiplier0);
            x_Pos += 3;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color2, color2, Bit_Multiplier0, Bit_Multiplier0);
            x_Pos += 3;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color2, color2, Bit_Multiplier0, Bit_Multiplier0);
            x_Pos += 3;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color2, color2, Bit_Multiplier0, Bit_Multiplier0);
            x_Pos += 3;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color1, color1, Bit_Multiplier0, Bit_Multiplier0);
        }
    }
}

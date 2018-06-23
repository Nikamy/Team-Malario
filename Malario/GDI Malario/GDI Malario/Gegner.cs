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
    class Gegner : Grundmethoden
    {
        public static void malen_Goethe(Graphics graphics, int x_Koordinate, int y_Koordinate, char direction)
        {
            int x_Pos = x_Koordinate, y_Pos = y_Koordinate, Bit_Multiplier0 = 2;
            Color colour = Color.SaddleBrown;

            y_Pos = y_Pos + (Bit_Multiplier0 * 15);
            Grundmethoden grundmethoden = new Grundmethoden();


            //Nächste Zeile und verschiedene Augen je nach Richtung in die er läuft
            if (direction == 'r')
            {
                

            }
            else if (direction == 'l')
            {
                
            }
            
            }
        }
    }
}

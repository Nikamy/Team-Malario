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
            Grundmethoden grundmethoden = new Grundmethoden();
            x_Pos = x_Koordinate + 5 * Bit_Multiplier0;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, colour, colour, 4 * Bit_Multiplier0, Bit_Multiplier0);

            y_Pos = y_Koordinate + Bit_Multiplier0;
            x_Pos = x_Koordinate + 3 * Bit_Multiplier0;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, colour, colour, 8 * Bit_Multiplier0, 12 * Bit_Multiplier0);

            y_Pos = y_Koordinate + 2 * Bit_Multiplier0;
            x_Pos = x_Koordinate + 2 * Bit_Multiplier0;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, colour, colour, 10 * Bit_Multiplier0, Bit_Multiplier0);

            y_Pos = y_Koordinate + 3 * Bit_Multiplier0;
            x_Pos = x_Koordinate + Bit_Multiplier0;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, colour, colour, 12 * Bit_Multiplier0, 10 * Bit_Multiplier0);

            y_Pos = y_Koordinate + 6 * Bit_Multiplier0;
            x_Pos = x_Koordinate;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, colour, colour, 14 * Bit_Multiplier0, 7 * Bit_Multiplier0);

            y_Pos = y_Koordinate + 13 * Bit_Multiplier0;
            x_Pos = x_Koordinate;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, colour, colour, 2 * Bit_Multiplier0, Bit_Multiplier0);
            x_Pos = x_Koordinate + 3 * Bit_Multiplier0;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, colour, colour, 4 * Bit_Multiplier0, Bit_Multiplier0);
            x_Pos = x_Koordinate + 8 * Bit_Multiplier0;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, colour, colour, 2 * Bit_Multiplier0, 2 * Bit_Multiplier0);
            x_Pos = x_Koordinate + 10 * Bit_Multiplier0;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, colour, colour, Bit_Multiplier0, Bit_Multiplier0);
            x_Pos = x_Koordinate + 12 * Bit_Multiplier0;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, colour, colour, 2 * Bit_Multiplier0, Bit_Multiplier0);

            y_Pos = y_Koordinate + 14 * Bit_Multiplier0;
            x_Pos = x_Koordinate;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, colour, colour, Bit_Multiplier0, Bit_Multiplier0);
            x_Pos = x_Koordinate + 3 * Bit_Multiplier0;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, colour, colour, 2 * Bit_Multiplier0, Bit_Multiplier0);
            x_Pos = x_Koordinate + 12 * Bit_Multiplier0;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, colour, colour, Bit_Multiplier0, Bit_Multiplier0);
            //Nächste Zeilen = verschiedene Augen je nach Richtung in die er läuft/schaut
            colour = Color.LightGray;

            y_Pos = y_Koordinate + 3 * Bit_Multiplier0;
            if (direction == 'r') x_Pos = x_Koordinate + 4 * Bit_Multiplier0;
            else if (direction == 'l') x_Pos = x_Koordinate + 2 * Bit_Multiplier0;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, colour, colour, 2 * Bit_Multiplier0, 5 * Bit_Multiplier0);
            if (direction == 'r') x_Pos = x_Koordinate + 10 * Bit_Multiplier0;
            else if (direction == 'l') x_Pos = x_Koordinate + 8 * Bit_Multiplier0;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, colour, colour, 2 * Bit_Multiplier0, 5 * Bit_Multiplier0);

            y_Pos = y_Koordinate + 4 * Bit_Multiplier0;
            if (direction == 'r') x_Pos = x_Koordinate + 3 * Bit_Multiplier0;
            else if (direction == 'l') x_Pos = x_Koordinate + Bit_Multiplier0;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, colour, colour, 4 * Bit_Multiplier0, 3 * Bit_Multiplier0);


            if (direction == 'r') x_Pos = x_Koordinate + 9 * Bit_Multiplier0;
            else if (direction == 'l') x_Pos = x_Koordinate + 7 * Bit_Multiplier0;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, colour, colour, 4 * Bit_Multiplier0, 3 * Bit_Multiplier0);
            //Pupillen
            colour = Color.Blue;

            y_Pos = y_Koordinate + 5 * Bit_Multiplier0;
            if (direction == 'r') x_Pos = x_Koordinate + 5 * Bit_Multiplier0;
            else if (direction == 'l') x_Pos = x_Koordinate + Bit_Multiplier0;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, colour, colour, 2 * Bit_Multiplier0, 2 * Bit_Multiplier0);

            if (direction == 'r') x_Pos = x_Koordinate + 11 * Bit_Multiplier0;
            else if (direction == 'l') x_Pos = x_Koordinate + 7 * Bit_Multiplier0;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, colour, colour, 2 * Bit_Multiplier0, 2 * Bit_Multiplier0);
        }
        public static void laufen_Goethe(Graphics graphics, int x_Koordinate, int y_Koordinate); //mehr?? bin müde, GutNacht.
    }
}

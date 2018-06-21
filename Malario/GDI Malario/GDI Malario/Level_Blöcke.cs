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
    class Level_Blöcke : Grundmethoden
    {
        public static void malen_MauerBlock(Graphics graphics, int x_Coordinate1, int y_Coordinate1)
        {
            int y_Bit_Multiplier_GanzerBlock = 24,
                x_Bit_Multiplier0 = (y_Bit_Multiplier_GanzerBlock - 4) / 2,
                y_Bit_Multiplier0 = (y_Bit_Multiplier_GanzerBlock - 8) / 4,
                Block_Spalenbreite = y_Bit_Multiplier_GanzerBlock / 12;

            Color grafikfarbe = Color.Brown,
                  stiftfarbe = Color.Brown;

            Grundmethoden grundmethoden = new Grundmethoden();
            grundmethoden.malen_Bit(graphics, x_Coordinate1, y_Coordinate1, grafikfarbe, stiftfarbe, x_Bit_Multiplier0, y_Bit_Multiplier0);
            x_Coordinate1 += x_Bit_Multiplier0 + Block_Spalenbreite;
            grundmethoden.malen_Bit(graphics, x_Coordinate1, y_Coordinate1, grafikfarbe, stiftfarbe, x_Bit_Multiplier0, y_Bit_Multiplier0);

            y_Coordinate1 += y_Bit_Multiplier0 + Block_Spalenbreite;
            x_Coordinate1 -= (x_Bit_Multiplier0 + Block_Spalenbreite);

            x_Bit_Multiplier0 -= (x_Bit_Multiplier0 / 2);
            grundmethoden.malen_Bit(graphics, x_Coordinate1, y_Coordinate1, grafikfarbe, stiftfarbe, x_Bit_Multiplier0, y_Bit_Multiplier0);
            x_Bit_Multiplier0 += (x_Bit_Multiplier0);
            x_Coordinate1 += (x_Bit_Multiplier0 / 2) + Block_Spalenbreite;
            grundmethoden.malen_Bit(graphics, x_Coordinate1, y_Coordinate1, grafikfarbe, stiftfarbe, x_Bit_Multiplier0, y_Bit_Multiplier0);
            x_Coordinate1 += (x_Bit_Multiplier0 + Block_Spalenbreite);
            x_Bit_Multiplier0 -= (x_Bit_Multiplier0 / 2);
            grundmethoden.malen_Bit(graphics, x_Coordinate1, y_Coordinate1, grafikfarbe, stiftfarbe, x_Bit_Multiplier0, y_Bit_Multiplier0);
            x_Bit_Multiplier0 += (x_Bit_Multiplier0);

            y_Coordinate1 += y_Bit_Multiplier0 + Block_Spalenbreite;
            x_Coordinate1 -= (x_Bit_Multiplier0 / 2) + x_Bit_Multiplier0 + 2 * Block_Spalenbreite;

            grundmethoden.malen_Bit(graphics, x_Coordinate1, y_Coordinate1, grafikfarbe, stiftfarbe, x_Bit_Multiplier0, y_Bit_Multiplier0);
            x_Coordinate1 += x_Bit_Multiplier0 + Block_Spalenbreite;
            grundmethoden.malen_Bit(graphics, x_Coordinate1, y_Coordinate1, grafikfarbe, stiftfarbe, x_Bit_Multiplier0, y_Bit_Multiplier0);

            y_Coordinate1 += y_Bit_Multiplier0 + Block_Spalenbreite;
            x_Coordinate1 -= (x_Bit_Multiplier0 + Block_Spalenbreite);

            x_Bit_Multiplier0 -= (x_Bit_Multiplier0 / 2);
            grundmethoden.malen_Bit(graphics, x_Coordinate1, y_Coordinate1, grafikfarbe, stiftfarbe, x_Bit_Multiplier0, y_Bit_Multiplier0);
            x_Bit_Multiplier0 += (x_Bit_Multiplier0);
            x_Coordinate1 += (x_Bit_Multiplier0 / 2) + Block_Spalenbreite;
            grundmethoden.malen_Bit(graphics, x_Coordinate1, y_Coordinate1, grafikfarbe, stiftfarbe, x_Bit_Multiplier0, y_Bit_Multiplier0);
            x_Coordinate1 += (x_Bit_Multiplier0 + Block_Spalenbreite);
            x_Bit_Multiplier0 -= (x_Bit_Multiplier0 / 2);
            grundmethoden.malen_Bit(graphics, x_Coordinate1, y_Coordinate1, grafikfarbe, stiftfarbe, x_Bit_Multiplier0, y_Bit_Multiplier0);
            x_Bit_Multiplier0 += (x_Bit_Multiplier0);

            y_Coordinate1 += y_Bit_Multiplier0 + Block_Spalenbreite;
            x_Coordinate1 -= (x_Bit_Multiplier0 / 2) + x_Bit_Multiplier0 + 2 * Block_Spalenbreite;

        }

            public static void malen_BodenBlock(Graphics graphics, int x_Pos0, int y_Pos0)
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
            //2.Zeile
            y_Pos -= 3;
            x_Pos -= 21;
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
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color2, color2, Bit_Multiplier0, Bit_Multiplier0);
            x_Pos += 3;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color1, color1, Bit_Multiplier0, Bit_Multiplier0);
            //3.Zeile
            y_Pos -= 3;
            x_Pos -= 21;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color2, color2, Bit_Multiplier0, Bit_Multiplier0);
            x_Pos += 3;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color1, color1, Bit_Multiplier0, Bit_Multiplier0);
            x_Pos += 3;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color1, color1, Bit_Multiplier0, Bit_Multiplier0);
            x_Pos += 3;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color1, color1, Bit_Multiplier0, Bit_Multiplier0);
            x_Pos += 3;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color1, color1, Bit_Multiplier0, Bit_Multiplier0);
            x_Pos += 3;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color1, color1, Bit_Multiplier0, Bit_Multiplier0);
            x_Pos += 3;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color2, color2, Bit_Multiplier0, Bit_Multiplier0);
            x_Pos += 3;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color2, color2, Bit_Multiplier0, Bit_Multiplier0);
            //4.Zeile
            y_Pos -= 3;
            x_Pos -= 21;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color2, color2, Bit_Multiplier0, Bit_Multiplier0);
            x_Pos += 3;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color2, color2, Bit_Multiplier0, Bit_Multiplier0);
            x_Pos += 3;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color2, color2, Bit_Multiplier0, Bit_Multiplier0);
            x_Pos += 3;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color2, color2, Bit_Multiplier0, Bit_Multiplier0);
            x_Pos += 3;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color1, color1, Bit_Multiplier0, Bit_Multiplier0);
            x_Pos += 3;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color1, color1, Bit_Multiplier0, Bit_Multiplier0);
            x_Pos += 3;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color2, color2, Bit_Multiplier0, Bit_Multiplier0);
            x_Pos += 3;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color2, color2, Bit_Multiplier0, Bit_Multiplier0);
            //5.Zeile
            y_Pos -= 3;
            x_Pos -= 21;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color2, color2, Bit_Multiplier0, Bit_Multiplier0);
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
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color2, color2, Bit_Multiplier0, Bit_Multiplier0);
            x_Pos += 3;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color2, color2, Bit_Multiplier0, Bit_Multiplier0);
            //6.Zeile
            y_Pos -= 3;
            x_Pos -= 21;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color2, color2, Bit_Multiplier0, Bit_Multiplier0);
            x_Pos += 3;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color2, color2, Bit_Multiplier0, Bit_Multiplier0);
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
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color2, color2, Bit_Multiplier0, Bit_Multiplier0);
            //7.Zeile
            y_Pos -= 3;
            x_Pos -= 21;
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
            x_Pos += 3;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color1, color1, Bit_Multiplier0, Bit_Multiplier0);
            x_Pos += 3;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color1, color1, Bit_Multiplier0, Bit_Multiplier0);
            //8.Zeile
            y_Pos -= 3;
            x_Pos -= 21;
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
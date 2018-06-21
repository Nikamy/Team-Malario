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
        //noch das gleiche wie drüber
        public static void malen_BodenBlock(Graphics graphics, int x_Coordinate1, int y_Coordinate1)
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

    }
}
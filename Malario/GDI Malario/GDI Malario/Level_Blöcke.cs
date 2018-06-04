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
        public static void malen_MauerBlock( Graphics graphics,  int x_Coordinate1,  int y_Coordinate1)
        {
            int y_Bit_Multiplier_GanzerBlock = 24,
                x_Bit_Multiplier0 = (y_Bit_Multiplier_GanzerBlock - 4) / 2,
                y_Bit_Multiplier0 = (y_Bit_Multiplier_GanzerBlock - 8) / 4,
                Block_Spalenbreite = y_Bit_Multiplier_GanzerBlock / 12;

            Color grafikfarbe = Color.Brown,
                  stiftfarbe = Color.Brown;

            Grundmethoden grundmethoden = new Grundmethoden();
            grundmethoden.malen_Bit( graphics,  x_Coordinate1,  y_Coordinate1,  grafikfarbe,  stiftfarbe,  x_Bit_Multiplier0,  y_Bit_Multiplier0);
            x_Coordinate1 += x_Bit_Multiplier0 + Block_Spalenbreite;
            grundmethoden.malen_Bit( graphics,  x_Coordinate1,  y_Coordinate1,  grafikfarbe,  stiftfarbe,  x_Bit_Multiplier0,  y_Bit_Multiplier0);

            y_Coordinate1 += y_Bit_Multiplier0 + Block_Spalenbreite;
            x_Coordinate1 -= (x_Bit_Multiplier0 + Block_Spalenbreite);

            x_Bit_Multiplier0 -= (x_Bit_Multiplier0 / 2);
            grundmethoden.malen_Bit( graphics,  x_Coordinate1,  y_Coordinate1,  grafikfarbe,  stiftfarbe,  x_Bit_Multiplier0,  y_Bit_Multiplier0);
            x_Bit_Multiplier0 += (x_Bit_Multiplier0);
            x_Coordinate1 += (x_Bit_Multiplier0 / 2) + Block_Spalenbreite;
            grundmethoden.malen_Bit( graphics,  x_Coordinate1,  y_Coordinate1,  grafikfarbe,  stiftfarbe,  x_Bit_Multiplier0,  y_Bit_Multiplier0);
            x_Coordinate1 += (x_Bit_Multiplier0 + Block_Spalenbreite);
            x_Bit_Multiplier0 -= (x_Bit_Multiplier0 / 2);
            grundmethoden.malen_Bit( graphics,  x_Coordinate1,  y_Coordinate1,  grafikfarbe,  stiftfarbe,  x_Bit_Multiplier0,  y_Bit_Multiplier0);
            x_Bit_Multiplier0 += (x_Bit_Multiplier0);

            y_Coordinate1 += y_Bit_Multiplier0 + Block_Spalenbreite;
            x_Coordinate1 -= (x_Bit_Multiplier0 / 2) + x_Bit_Multiplier0 + 2 * Block_Spalenbreite;

            grundmethoden.malen_Bit( graphics,  x_Coordinate1,  y_Coordinate1,  grafikfarbe,  stiftfarbe,  x_Bit_Multiplier0,  y_Bit_Multiplier0);
            x_Coordinate1 += x_Bit_Multiplier0 + Block_Spalenbreite;
            grundmethoden.malen_Bit( graphics,  x_Coordinate1,  y_Coordinate1,  grafikfarbe,  stiftfarbe,  x_Bit_Multiplier0,  y_Bit_Multiplier0);

            y_Coordinate1 += y_Bit_Multiplier0 + Block_Spalenbreite;
            x_Coordinate1 -= (x_Bit_Multiplier0 + Block_Spalenbreite);

            x_Bit_Multiplier0 -= (x_Bit_Multiplier0 / 2);
            grundmethoden.malen_Bit( graphics,  x_Coordinate1,  y_Coordinate1,  grafikfarbe,  stiftfarbe,  x_Bit_Multiplier0,  y_Bit_Multiplier0);
            x_Bit_Multiplier0 += (x_Bit_Multiplier0);
            x_Coordinate1 += (x_Bit_Multiplier0 / 2) + Block_Spalenbreite;
            grundmethoden.malen_Bit( graphics,  x_Coordinate1,  y_Coordinate1,  grafikfarbe,  stiftfarbe,  x_Bit_Multiplier0,  y_Bit_Multiplier0);
            x_Coordinate1 += (x_Bit_Multiplier0 + Block_Spalenbreite);
            x_Bit_Multiplier0 -= (x_Bit_Multiplier0 / 2);
            grundmethoden.malen_Bit( graphics,  x_Coordinate1,  y_Coordinate1,  grafikfarbe,  stiftfarbe,  x_Bit_Multiplier0,  y_Bit_Multiplier0);
            x_Bit_Multiplier0 += (x_Bit_Multiplier0);

            y_Coordinate1 += y_Bit_Multiplier0 + Block_Spalenbreite;
            x_Coordinate1 -= (x_Bit_Multiplier0 / 2) + x_Bit_Multiplier0 + 2 * Block_Spalenbreite;
            
        }
        //noch das gleiche wie drüber
        public static void malen_BodenBlock( Graphics graphics)
        {
            int x_Pos = 0, y_Pos = 21;
            int Bit_Multiplier0 = 3;
            Color color1 = Color.LightGray;
            Color color2 = Color.DarkGray;
            Grundmethoden grundmethoden = new Grundmethoden();
            //unterste Zeile
            x_Pos = 0;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color1, color1, Bit_Multiplier0, Bit_Multiplier0);
            x_Pos = 3;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color1, color1, Bit_Multiplier0, Bit_Multiplier0);
            x_Pos = 6;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color1, color1, Bit_Multiplier0, Bit_Multiplier0);
            x_Pos = 9;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color2, color2, Bit_Multiplier0, Bit_Multiplier0);
            x_Pos = 12;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color2, color2, Bit_Multiplier0, Bit_Multiplier0);
            x_Pos = 15;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color2, color2, Bit_Multiplier0, Bit_Multiplier0);
            x_Pos = 18;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color2, color2, Bit_Multiplier0, Bit_Multiplier0);
            x_Pos = 21;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color1, color1, Bit_Multiplier0, Bit_Multiplier0);
            //2.Zeile
            y_Pos = 18;
            x_Pos = 0;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color1, color1, Bit_Multiplier0, Bit_Multiplier0);
            x_Pos = 3;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color1, color1, Bit_Multiplier0, Bit_Multiplier0);
            x_Pos = 6;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color2, color2, Bit_Multiplier0, Bit_Multiplier0);
            x_Pos = 9;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color2, color2, Bit_Multiplier0, Bit_Multiplier0);
            x_Pos = 12;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color2, color2, Bit_Multiplier0, Bit_Multiplier0);
            x_Pos = 15;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color2, color2, Bit_Multiplier0, Bit_Multiplier0);
            x_Pos = 18;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color2, color2, Bit_Multiplier0, Bit_Multiplier0);
            x_Pos = 21;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color1, color1, Bit_Multiplier0, Bit_Multiplier0);
            //3.Zeile
            y_Pos = 15;
            x_Pos = 0;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color2, color2, Bit_Multiplier0, Bit_Multiplier0);
            x_Pos = 3;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color1, color1, Bit_Multiplier0, Bit_Multiplier0);
            x_Pos = 6;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color1, color1, Bit_Multiplier0, Bit_Multiplier0);
            x_Pos = 9;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color1, color1, Bit_Multiplier0, Bit_Multiplier0);
            x_Pos = 12;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color1, color1, Bit_Multiplier0, Bit_Multiplier0);
            x_Pos = 15;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color1, color1, Bit_Multiplier0, Bit_Multiplier0);
            x_Pos = 18;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color2, color2, Bit_Multiplier0, Bit_Multiplier0);
            x_Pos = 21;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color2, color2, Bit_Multiplier0, Bit_Multiplier0);
            //4.Zeile
            y_Pos = 12;
            x_Pos = 0;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color2, color2, Bit_Multiplier0, Bit_Multiplier0);
            x_Pos = 3;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color2, color2, Bit_Multiplier0, Bit_Multiplier0);
            x_Pos = 6;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color2, color2, Bit_Multiplier0, Bit_Multiplier0);
            x_Pos = 9;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color2, color2, Bit_Multiplier0, Bit_Multiplier0);
            x_Pos = 12;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color1, color1, Bit_Multiplier0, Bit_Multiplier0);
            x_Pos = 15;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color1, color1, Bit_Multiplier0, Bit_Multiplier0);
            x_Pos = 18;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color2, color2, Bit_Multiplier0, Bit_Multiplier0);
            x_Pos = 21;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color2, color2, Bit_Multiplier0, Bit_Multiplier0);
            //5.Zeile
            y_Pos = 9;
            x_Pos = 0;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color2, color2, Bit_Multiplier0, Bit_Multiplier0);
            x_Pos = 3;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color1, color1, Bit_Multiplier0, Bit_Multiplier0);
            x_Pos = 6;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color2, color2, Bit_Multiplier0, Bit_Multiplier0);
            x_Pos = 9;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color2, color2, Bit_Multiplier0, Bit_Multiplier0);
            x_Pos = 12;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color2, color2, Bit_Multiplier0, Bit_Multiplier0);
            x_Pos = 15;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color2, color2, Bit_Multiplier0, Bit_Multiplier0);
            x_Pos = 18;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color2, color2, Bit_Multiplier0, Bit_Multiplier0);
            x_Pos = 21;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color2, color2, Bit_Multiplier0, Bit_Multiplier0);
            //6.Zeile
            y_Pos = 6;
            x_Pos = 0;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color2, color2, Bit_Multiplier0, Bit_Multiplier0);
            x_Pos = 3;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color2, color2, Bit_Multiplier0, Bit_Multiplier0);
            x_Pos = 6;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color1, color1, Bit_Multiplier0, Bit_Multiplier0);
            x_Pos = 9;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color2, color2, Bit_Multiplier0, Bit_Multiplier0);
            x_Pos = 12;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color2, color2, Bit_Multiplier0, Bit_Multiplier0);
            x_Pos = 15;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color2, color2, Bit_Multiplier0, Bit_Multiplier0);
            x_Pos = 18;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color2, color2, Bit_Multiplier0, Bit_Multiplier0);
            x_Pos = 21;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color2, color2, Bit_Multiplier0, Bit_Multiplier0);
            //7.Zeile
            y_Pos = 3;
            x_Pos = 0;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color1, color1, Bit_Multiplier0, Bit_Multiplier0);
            x_Pos = 3;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color2, color2, Bit_Multiplier0, Bit_Multiplier0);
            x_Pos = 6;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color2, color2, Bit_Multiplier0, Bit_Multiplier0);
            x_Pos = 9;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color2, color2, Bit_Multiplier0, Bit_Multiplier0);
            x_Pos = 12;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color2, color2, Bit_Multiplier0, Bit_Multiplier0);
            x_Pos = 15;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color1, color1, Bit_Multiplier0, Bit_Multiplier0);
            x_Pos = 18;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color1, color1, Bit_Multiplier0, Bit_Multiplier0);
            x_Pos = 21;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color1, color1, Bit_Multiplier0, Bit_Multiplier0);
            //8.Zeile
            y_Pos = 0;
            x_Pos = 0;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color1, color1, Bit_Multiplier0, Bit_Multiplier0);
            x_Pos = 3;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color1, color1, Bit_Multiplier0, Bit_Multiplier0);
            x_Pos = 6;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color1, color1, Bit_Multiplier0, Bit_Multiplier0);
            x_Pos = 9;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color2, color2, Bit_Multiplier0, Bit_Multiplier0);
            x_Pos = 12;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color2, color2, Bit_Multiplier0, Bit_Multiplier0);
            x_Pos = 15;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color2, color2, Bit_Multiplier0, Bit_Multiplier0);
            x_Pos = 18;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color2, color2, Bit_Multiplier0, Bit_Multiplier0);
            x_Pos = 21;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color1, color1, Bit_Multiplier0, Bit_Multiplier0);

        }
        public static void malen_Röhren_Kopf(Graphics graphics)
        {
            Grundmethoden grundmethoden = new Grundmethoden();
            int x_Rectangle = 0,
                y_Rectangle = 0,
                x_Coordinate = 0,
                y_Coordinate = 0,
                x55 = (55*2/3),
                y30 = 20;
            

            Color grafikfarbe = Color.Black,
                  stiftfarbe = Color.Black;


            //äußerer Rand des Kopfs

            grafikfarbe = Color.FromArgb(0, 0, 0);
            stiftfarbe = Color.FromArgb(0, 0, 0);
            //x_Coordinate += (3 / 55 * x55);
            //y_Coordinate += (3 / 55 * y30);
            x_Rectangle = x55;
            y_Rectangle = y30;
            x_Coordinate = 1;
            y_Coordinate = 1;
            grundmethoden.malen_Bit(graphics, x_Coordinate, y_Coordinate, grafikfarbe, stiftfarbe, x_Rectangle, y_Rectangle);

            //inneres Quadrat des Kopfs
            grafikfarbe = Color.FromArgb(59, 97, 32);
            stiftfarbe = Color.FromArgb(59, 97, 32);
            x_Coordinate += (3/55 * x55);
            y_Coordinate += (3/55 * y30);
            x_Rectangle -= 8;
            y_Rectangle = y30;
            grundmethoden.malen_Bit(graphics, x_Coordinate, y_Coordinate, grafikfarbe, stiftfarbe, x_Rectangle, y_Rectangle);

            //inneres 2tes Quadrat des Kopfs
            grafikfarbe = Color.FromArgb(47,115,47);
            stiftfarbe = Color.FromArgb(47, 115, 47);
            x_Coordinate += 9;
            y_Coordinate += 2;
            x_Rectangle = 30;
            y_Rectangle = 22;
            grundmethoden.malen_Bit(graphics, x_Coordinate, y_Coordinate, grafikfarbe, stiftfarbe, x_Rectangle, y_Rectangle);



        }
    }
}
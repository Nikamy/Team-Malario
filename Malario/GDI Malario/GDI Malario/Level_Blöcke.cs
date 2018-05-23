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
        public static void setzen_Boden(ref int x_Coordinate_PanelG)
        {
            int y_Coordinate_PanelG = 489, x_Panel_Size = 24, y_Panel_Size = 24 * 2;
            string Panel_Name = "Panel_Boden_";
            Color Hintergrundfarbe = Color.Gray;
            Grundmethoden grundmethoden = new Grundmethoden();
            grundmethoden.generiert_Panel(ref x_Coordinate_PanelG, ref y_Coordinate_PanelG, ref x_Panel_Size, ref y_Panel_Size, ref Hintergrundfarbe, ref Panel_Name);
            
        }
        public static void malen_MauerBlock(ref Graphics graphics, ref int zähler_Blöcke, ref int zähler_Block, ref int x_Coordinate1, ref int y_Coordinate1)
        {
            int y_Bit_Multiplier_GanzerBlock = 24,
                x_Bit_Multiplier0 = (y_Bit_Multiplier_GanzerBlock - 8) / 2,
                y_Bit_Multiplier0 = (y_Bit_Multiplier_GanzerBlock - 16) / 4,
                Block_Spalenbreite = y_Bit_Multiplier_GanzerBlock / 12;

            Color grafikfarbe = Color.Brown,
                  stiftfarbe = Color.Brown;

            Grundmethoden grundmethoden = new Grundmethoden();
            grundmethoden.malen_Bit(ref graphics, ref x_Coordinate1, ref y_Coordinate1, ref grafikfarbe, ref stiftfarbe, ref x_Bit_Multiplier0, ref y_Bit_Multiplier0);
            x_Coordinate1 += x_Bit_Multiplier0 + Block_Spalenbreite;
            grundmethoden.malen_Bit(ref graphics, ref x_Coordinate1, ref y_Coordinate1, ref grafikfarbe, ref stiftfarbe, ref x_Bit_Multiplier0, ref y_Bit_Multiplier0);

            y_Coordinate1 += y_Bit_Multiplier0 + Block_Spalenbreite;
            x_Coordinate1 -= (x_Bit_Multiplier0 + Block_Spalenbreite);

            x_Bit_Multiplier0 -= (x_Bit_Multiplier0 / 2);
            grundmethoden.malen_Bit(ref graphics, ref x_Coordinate1, ref y_Coordinate1, ref grafikfarbe, ref stiftfarbe, ref x_Bit_Multiplier0, ref y_Bit_Multiplier0);
            x_Bit_Multiplier0 += (x_Bit_Multiplier0);
            x_Coordinate1 += (x_Bit_Multiplier0 / 2) + Block_Spalenbreite;
            grundmethoden.malen_Bit(ref graphics, ref x_Coordinate1, ref y_Coordinate1, ref grafikfarbe, ref stiftfarbe, ref x_Bit_Multiplier0, ref y_Bit_Multiplier0);
            x_Coordinate1 += (x_Bit_Multiplier0 + Block_Spalenbreite);
            x_Bit_Multiplier0 -= (x_Bit_Multiplier0 / 2);
            grundmethoden.malen_Bit(ref graphics, ref x_Coordinate1, ref y_Coordinate1, ref grafikfarbe, ref stiftfarbe, ref x_Bit_Multiplier0, ref y_Bit_Multiplier0);
            x_Bit_Multiplier0 += (x_Bit_Multiplier0);

            y_Coordinate1 += y_Bit_Multiplier0 + Block_Spalenbreite;
            x_Coordinate1 -= (x_Bit_Multiplier0 / 2) + x_Bit_Multiplier0 + 2 * Block_Spalenbreite;

            grundmethoden.malen_Bit(ref graphics, ref x_Coordinate1, ref y_Coordinate1, ref grafikfarbe, ref stiftfarbe, ref x_Bit_Multiplier0, ref y_Bit_Multiplier0);
            x_Coordinate1 += x_Bit_Multiplier0 + Block_Spalenbreite;
            grundmethoden.malen_Bit(ref graphics, ref x_Coordinate1, ref y_Coordinate1, ref grafikfarbe, ref stiftfarbe, ref x_Bit_Multiplier0, ref y_Bit_Multiplier0);

            y_Coordinate1 += y_Bit_Multiplier0 + Block_Spalenbreite;
            x_Coordinate1 -= (x_Bit_Multiplier0 + Block_Spalenbreite);
        }
    }
}
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
        public void malen_MauerBlock(ref Graphics graphics, ref int zähler_Blöcke, ref int zähler_Block)
        {
            int y_Bit_Multiplier_GanzerBlock = 12,
                x_Coordinate1 = 0, y_Coordinate1 = 0, 
                x_Bit_Multiplier0 = (y_Bit_Multiplier_GanzerBlock - 4) / 4, 
                y_Bit_Multiplier0 = (y_Bit_Multiplier_GanzerBlock - 4) / 4;

            Color grafikfarbe = Color.Brown,
                  stiftfarbe = Color.Brown;
            
            Grundmethoden grundmethoden = new Grundmethoden();
            grundmethoden.malen_Bit(ref graphics, ref x_Coordinate1, ref y_Coordinate1, ref grafikfarbe, ref stiftfarbe, ref x_Bit_Multiplier0, ref y_Bit_Multiplier0);
            x_Coordinate1 += x_Bit_Multiplier0;
            

        }
    }
}

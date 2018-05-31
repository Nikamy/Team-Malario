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
    class Grundmethoden : Main_Form
    {
        public void malen_Bit(Graphics graphics, int x_Coordinate1, int y_Coordinate1, Color füllfarbe, Color stiftfarbe, int x_Bit_Multiplier0, int y_Bit_Multiplier0)

        {
            SolidBrush brush = new SolidBrush(füllfarbe);
            Pen stift = new Pen(stiftfarbe);
            Rectangle quadrat = new Rectangle(x_Coordinate1, y_Coordinate1, x_Bit_Multiplier0, y_Bit_Multiplier0);

            graphics.DrawRectangle(stift, quadrat);
            graphics.FillRectangle(brush, quadrat);
        }
    }
}

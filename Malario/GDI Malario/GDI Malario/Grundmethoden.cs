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
        int c = 0;
        public void malen_Bit(ref Graphics graphics, ref int x_Coordinate1, ref int y_Coordinate1, ref Color grafikfarbe, ref Color stiftfarbe, ref int x_Bit_Multiplier0, ref int y_Bit_Multiplier0)
        {
            SolidBrush brush = new SolidBrush(grafikfarbe);
            Pen stift = new Pen(stiftfarbe);
            Rectangle quadrat = new Rectangle(x_Coordinate1, y_Coordinate1, x_Bit_Multiplier0, y_Bit_Multiplier0);

            graphics.DrawRectangle(stift, quadrat);
            graphics.FillRectangle(brush, quadrat);
        }

        public void generiert_Panel(ref int x_Coordinate_PanelG, ref int y_Coordinate_PanelG, ref int x_Panel_Size, ref int y_Panel_Size, ref Color Hintergrundfarbe, ref string Panel_Name)
        {
            string b = Panel_Name + Convert.ToString(c);
            Panel a = new Panel();
            a.Name = b;
            a.BackColor = Hintergrundfarbe;
            a.Width = x_Panel_Size;
            a.Height = y_Panel_Size;
            a.Top = y_Coordinate_PanelG;
            a.Left = x_Coordinate_PanelG;
            c++;
        }
    }
}

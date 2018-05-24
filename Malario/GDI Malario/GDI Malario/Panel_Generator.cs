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
    class Panel_Generator : Main_Form
    {
        List<Panel> panellist = new List<Panel>();
        int Panelzähler = 1;


        public Panel Hinzufügen_Panel(ref int x_Coordinate_PanelG, ref int y_Coordinate_PanelG, ref int x_Panel_Size, ref int y_Panel_Size, ref Color Hintergrundfarbe, ref string Panel_Name, ref int Panelanzahl_Zähler)
        {
            Panel panel1 = new Panel();
            panellist.Add(panel1);
            panel1.Name = Panel_Name + Panelanzahl_Zähler.ToString();
            panel1.BackColor = Hintergrundfarbe;
            panel1.Width = x_Panel_Size;
            panel1.Height = x_Panel_Size;
            panel1.Top = y_Coordinate_PanelG;
            panel1.Left = x_Coordinate_PanelG;
            panel1.BringToFront();
            panel1.Visible = true;
            Panel_Game.Controls.Add(panel1);
            panel1.Refresh();
            //panel1.CreateGraphics();
            //Panel.Panel_Paint(panel1, e);
            Panelzähler++;

            return panel1;
        }
        public void Panel_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            base.OnPaint(e);

            int x_Coordinate1=0,
                y_Coordinate1=0;
            Level_Blöcke.malen_MauerBlock(ref graphics, ref x_Coordinate1, ref y_Coordinate1);
            //Gegner.malen_Goethe(ref graphics, 'r')
            //Lässt das Panel neuladen und anzeigen
            Panel_Malario.Paint += new PaintEventHandler(Panel_Paint);
            //Panel_Malario.Refresh();
        }
    }
}

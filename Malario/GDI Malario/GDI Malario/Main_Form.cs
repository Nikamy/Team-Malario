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
    public partial class Main_Form : Form
    {
        bool M_Right = false, M_Left = false, M_Crouch = false, M_Jump = false;
        int anziehungskraft, anziehungskaft_Wert = 15;

        int Panelanzahl_Zähler = 0;
        public Main_Form()
        {
            InitializeComponent();
        }
        private void Main_Form_Load(object sender, EventArgs e)
        {
            int x_Coordinate_PanelG = 214, y_Coordinate_PanelG = 309, x_Panel_Size = 24, y_Panel_Size = 24 * 2;
            string Panel_Name = "Panel_Boden_";
            Color Hintergrundfarbe = Color.Gray;

            int Panelanzahl_Zähler = 0;
            Hinzufügen_Panel(ref x_Coordinate_PanelG, ref y_Coordinate_PanelG, ref x_Panel_Size, ref y_Panel_Size, ref Hintergrundfarbe, ref Panel_Name, ref Panelanzahl_Zähler);
            
            Level_Blöcke level_blöcke = new Level_Blöcke();
            //level_blöcke.malen_MauerBlock(ref graphics, ref zähler_Blöcke, ref zähler_Block, ref x_Coordinate1, ref y_Coordinate1);
            
        }

        public Panel Hinzufügen_Panel(ref int x_Coordinate_PanelG, ref int y_Coordinate_PanelG, ref int x_Panel_Size, ref int y_Panel_Size, ref Color Hintergrundfarbe, ref string Panel_Name, ref int Panelanzahl_Zähler)
        {
            Panel panel = new Panel();
            panel.Name = Panel_Name + Panelanzahl_Zähler.ToString();
            panel.BackColor = Hintergrundfarbe;
            panel.Width = x_Panel_Size;
            panel.Height = x_Panel_Size;
            panel.Top = y_Coordinate_PanelG;
            panel.Left = x_Coordinate_PanelG;
            panel.Visible = true;
            panel.Focus();
            Panel_Game.Controls.Add(panel);
            return panel;
        }

        private void Main_Form_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D:
                    M_Right = true;
                    
                    break;
                case Keys.A:
                    M_Left = true;
                    break;
                case Keys.W:
                    if (M_Jump != true && M_Crouch != true)
                    {
                        M_Jump = true;
                    }
                    break;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (M_Right == true)
            {
                Panel_Malario.Left += 4;
            }
            if (M_Left == true)
            {
                Panel_Malario.Left -= 4;
            }
            if (M_Jump == true)
            {
                Panel_Malario.Top -= anziehungskraft;
                anziehungskraft -= 1;
            }
            if (Panel_Malario.Height + Panel_Malario.Top >= Panel_Game.Height - 32)
            {
                Panel_Malario.Top = Panel_Game.Height - Panel_Malario.Height - 32;
                M_Jump = false;
                anziehungskraft = anziehungskaft_Wert;
            }
        }
        private void Main_Form_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D:
                    M_Right = false;
                    break;
                case Keys.A:
                    M_Left = false;
                    break;
            }
        }

        private void Panel_Malario_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            base.OnPaint(e);
            Gegner.malen_Gambo(ref graphics,'r');
            //Lässt das Panel neuladen und anzeigen
            Panel_Malario.Paint += new PaintEventHandler(Panel_Malario_Paint);
            //Panel_Malario.Refresh();
        }
    }
}

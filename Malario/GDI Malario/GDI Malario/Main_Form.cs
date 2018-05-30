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
        List<Panel> panellist = new List<Panel>();
        int Panelanzahl_Zähler;
        bool M_Right = false, M_Left = false, M_Crouch = false, M_Jump = false;
        int anziehungskraft, anziehungskaft_Wert = 15;


        public Main_Form()
        {
            InitializeComponent();
            SetStyle(ControlStyles.DoubleBuffer, true);
        }
        private void Main_Form_Load(object sender, EventArgs e)
        {
            int x_Coordinate_PanelG = 0, y_Coordinate_PanelG = 432, x_Panel_Size = 480, y_Panel_Size = 48;
            string Panel_Name = "Panel_Boden_";
            Color Hintergrundfarbe = Color.Gray;
            
            do
            {
                //Panel hinzufügen
                Hinzufügen_Panel(x_Coordinate_PanelG, y_Coordinate_PanelG, x_Panel_Size, y_Panel_Size, Hintergrundfarbe, Panel_Name, Panelanzahl_Zähler);
                Panelanzahl_Zähler++;
                x_Coordinate_PanelG += 24;
                //Panel bemalen
                Rectangle rectangle = new Rectangle(x_Coordinate_PanelG,y_Coordinate_PanelG, x_Panel_Size, y_Panel_Size);
                Graphics graphics = panellist[panellist.Count - 1].CreateGraphics();
                PaintEventArgs pe = new PaintEventArgs(graphics, rectangle);
                panellist_Mauerblock_Paint(panellist.Count, pe);
            } while (Panelanzahl_Zähler != 1);
            label1.Text = panellist.Count.ToString();
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
                Panel_Malario.Invalidate();
                if(Panel_Malario.Left < (Panel_Game.Width / 2)){ Panel_Malario.Left += 4; }
                else {
                    int Bewegungs_Panel_Zähler = panellist.Count-1;
                    do
                    {
                        panellist[Bewegungs_Panel_Zähler].Left -= 4;
                        panellist[Bewegungs_Panel_Zähler].Invalidate();
                        Bewegungs_Panel_Zähler--;
                    } while(Bewegungs_Panel_Zähler>=0);
                }
            }
            if (M_Left == true && Panel_Malario.Left > 0)
            {
                Panel_Malario.Left -= 4;
            }
            if (M_Jump == true)
            {
                Panel_Malario.Top -= anziehungskraft;
                anziehungskraft -= 1;
            }
            if (Panel_Malario.Height + Panel_Malario.Top >= Panel_Game.Height - 50)
            {
                Panel_Malario.Top = Panel_Game.Height - Panel_Malario.Height - 50;
                M_Jump = false;
                anziehungskraft = anziehungskaft_Wert;
            }
        }

        private void Panel_Game_Paint(object sender, PaintEventArgs e)
        {

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

            Malario.malen_Malario(graphics); 
            //Lässt das Panel neuladen und anzeigen
            //Panel_Malario.Paint += new PaintEventHandler(Panel_Malario_Paint);
            //Panel_Malario.refresh();


            //nur zum testen

            //Level_Blöcke level_blöcke = new Level_Blöcke();
            //int zähler_Blöcke = 1;
            //int zähler_Block = 1;
            //int x_Coordinate1 = 1;
            //int y_Coordinate1 = 1;
            //Level_Blöcke.malen_MauerBlock(ref graphics, ref zähler_Blöcke, ref zähler_Block, ref x_Coordinate1, ref y_Coordinate1);


        }
        public Panel Hinzufügen_Panel( int x_Coordinate_PanelG,  int y_Coordinate_PanelG,  int x_Panel_Size,  int y_Panel_Size,  Color Hintergrundfarbe,  string Panel_Name,  int Panelanzahl_Zähler)
        {
            Panel panel1 = new Panel();
            panel1.Name = Panel_Name + Panelanzahl_Zähler.ToString();
            panel1.BackColor = Hintergrundfarbe;
            panel1.Width = x_Panel_Size;
            panel1.Height = y_Panel_Size;
            panel1.Top = y_Coordinate_PanelG;
            panel1.Left = x_Coordinate_PanelG;
            panel1.BringToFront();
            panel1.Visible = true;
            panellist.Add(panel1);
            
            panellist[panellist.Count - 1].Paint += new PaintEventHandler(panellist_Mauerblock_Paint);

            Panel_Game.Controls.Add(panel1);

            return panel1;
        }
        public void panellist_Mauerblock_Paint(object sender, PaintEventArgs pe)
        {
            int x_Coordinate1 = 0,
                y_Coordinate1 = 0;
            Graphics graphics = pe.Graphics;
            base.OnPaint(pe);

            do
            {
                Level_Blöcke.malen_MauerBlock(graphics, x_Coordinate1, y_Coordinate1);
                y_Coordinate1 += 24;
                Level_Blöcke.malen_MauerBlock(graphics, x_Coordinate1, y_Coordinate1);
                y_Coordinate1 -= 24;
                x_Coordinate1 += 24;
            } while (x_Coordinate1 < panellist[panellist.Count - 1].Width);
            
            //Lässt das Panel neuladen und anzeigen
            //panellist[panellist.Count - 1].Paint += new PaintEventHandler(panellist_Mauerblock_Paint);
        }
    }
}

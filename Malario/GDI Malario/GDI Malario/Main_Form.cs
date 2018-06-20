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
        List<int> gemalteslist_x_Pos = new List<int>();
        List<int> gemalteslist_y_Pos = new List<int>();
        List<int> gemalteslist_Blockart = new List<int>();
        bool M_Right = false, M_Left = false, M_Crouch = false, M_Jump = false, Startbildschirm = true;
        int anziehungskraft, anziehungskaft_Wert = 15, x_Pos_Malario = 0, y_Pos_Malario = 0, x_Pos_Block = 0, y_Pos_Block = 0;

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            base.OnPaint(e);



            label1counter.Text = Convert.ToString(gemalteslist_x_Pos.Count);
            Malario.malen_Malario(graphics, x_Pos_Malario, y_Pos_Malario);
            int Blocklist_Zähler = 0;

            if (Startbildschirm == true)
            {
                malen_Startmenü(graphics);
                Startbildschirm = false;
            }

            if (gemalteslist_x_Pos.Count > 0)
            {
                do
                {
                    if (gemalteslist_Blockart[Blocklist_Zähler] == 0)
                    {
                        Level_Blöcke.malen_BodenBlock(graphics, gemalteslist_x_Pos[Blocklist_Zähler], gemalteslist_y_Pos[Blocklist_Zähler]);
                        Level_Blöcke.malen_BodenBlock(graphics, gemalteslist_x_Pos[Blocklist_Zähler], gemalteslist_y_Pos[Blocklist_Zähler] + 24);
                        Blocklist_Zähler += 1;
                    }
                } while (Blocklist_Zähler < gemalteslist_Blockart.Count);
            }
        }
        private void Main_Form_Paint_1(object sender, PaintEventArgs e)
        {
        }

        public Main_Form()
        {
            InitializeComponent();
        }
        private void Main_Form_Load(object sender, EventArgs e)
        {
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
                Invalidate();

                if (x_Pos_Malario < (this.Width / 2)){ x_Pos_Malario += 4; }
               else {
                    
                    int Bewegungs_Panel_Zähler = gemalteslist_x_Pos.Count-1;
                    do
                    {
                        gemalteslist_x_Pos[Bewegungs_Panel_Zähler]-= 4;
                        Bewegungs_Panel_Zähler--;
                    } while(Bewegungs_Panel_Zähler>0);
               }
            }
            if (M_Left == true && x_Pos_Malario > 0)
            {
                Invalidate();
                x_Pos_Malario -= 4;
            }
            if (M_Jump == true)
            {
                Invalidate();
                y_Pos_Malario -= anziehungskraft;
                anziehungskraft -= 1;
            }
            if (y_Pos_Malario >= this.Height - 32 - 39 - 50)
            {
                y_Pos_Malario = this.Height - 32 - 39 - 50;

                // 32 = Malariogröße
                // 50 = der Boden unter Malario (Hardcode im Collisiongrit ändern!)
                M_Jump = false;
                anziehungskraft = anziehungskaft_Wert;
                Invalidate();
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
        private void malen_Startmenü(Graphics graphics)
        {
            x_Pos_Block = 0;
            y_Pos_Block = (this.Height - 39 - 48);
            do
            {
                Level_Blöcke.malen_BodenBlock(graphics, x_Pos_Block, y_Pos_Block);
                gemalteslist_Blockart.Add(0);
                gemalteslist_x_Pos.Add(x_Pos_Block);
                gemalteslist_y_Pos.Add(y_Pos_Block);
                y_Pos_Block += 24;

                Level_Blöcke.malen_BodenBlock(graphics, x_Pos_Block, y_Pos_Block);
                y_Pos_Block -= 24;
                x_Pos_Block += 24;
            } while (x_Pos_Block < 480);
            Invalidate();
        }
    }
}

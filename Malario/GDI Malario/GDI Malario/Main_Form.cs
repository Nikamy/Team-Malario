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
        int[] gemalteslist_x_Pos = new int[] { };
        int[] gemalteslist_y_Pos = new int[] { };
        int[] gemalteslist_Blockart = new int[] { };
        bool M_Right = false, M_Left = false, M_Richtung = false, M_Jump = true, Startbildschirm = true, M_Gehend = false;
        //Collsions
        bool C_Right = false, C_Left = false, C_Above = false, C_Underneath = false;
        int animation_ms, anziehungskraft, anziehungskaft_Wert = 15, x_Pos_Malario = 480 / 2 - 15, y_Pos_Malario = 519 - 30 - 39 - 48 - 300, x_Pos_Block = 0, y_Pos_Block = 0;

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            base.OnPaint(e);



            label1counter.Text = Convert.ToString(gemalteslist_x_Pos.Length);

            if (M_Left == true || M_Right == true)
            {
                Malario.malen_Malario(graphics, x_Pos_Malario, y_Pos_Malario, M_Richtung, M_Gehend);
            }
            else
            {
                M_Gehend = false;
                Malario.malen_Malario(graphics, x_Pos_Malario, y_Pos_Malario, M_Richtung, M_Gehend);
            }

            int Blocklist_Zähler = 0;

            if (Startbildschirm == true)
            {
                malen_Startmenü();
                Startbildschirm = false;
            }
            // malen_Startmenü(graphics);

            if (gemalteslist_x_Pos.Length > 0)
            {
                do
                {
                    if (gemalteslist_Blockart[Blocklist_Zähler] == 0)
                    {
                        x_Pos_Block = gemalteslist_x_Pos[Blocklist_Zähler];
                        y_Pos_Block = gemalteslist_y_Pos[Blocklist_Zähler];

                        Level_Blöcke.malen_BodenBlock(graphics, x_Pos_Block, y_Pos_Block);
                    }
                    else if (gemalteslist_Blockart[Blocklist_Zähler] == 1)
                    {
                        Level_Blöcke.malen_MauerBlock(graphics, x_Pos_Block, y_Pos_Block);
                    }
                    else if (gemalteslist_Blockart[Blocklist_Zähler] == 2)
                    {
                        x_Pos_Block = gemalteslist_x_Pos[Blocklist_Zähler];
                        y_Pos_Block = gemalteslist_y_Pos[Blocklist_Zähler];

                        Level_Blöcke.malen_RöhrenBlock_Kopf(graphics, x_Pos_Block, y_Pos_Block);
                    }
                    else if (gemalteslist_Blockart[Blocklist_Zähler] == 3)
                    {
                        x_Pos_Block = gemalteslist_x_Pos[Blocklist_Zähler];
                        y_Pos_Block = gemalteslist_y_Pos[Blocklist_Zähler];

                        Level_Blöcke.malen_RöhrenBlock_Hals(graphics, x_Pos_Block, y_Pos_Block);
                    }
                    Blocklist_Zähler++;
                } while (Blocklist_Zähler < gemalteslist_Blockart.Length);
            }
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
                    M_Richtung = false;
                    break;
                case Keys.A:
                    M_Left = true;
                    M_Richtung = true;
                    break;
                case Keys.W:
                    if (M_Jump != true)
                    {
                        M_Jump = true;
                    }
                    break;
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
        private void timer1_Tick(object sender, EventArgs e)
        {
            int i = 0;
            do
            {
                c_Right(x_Pos_Malario, y_Pos_Malario, 30, 30, gemalteslist_x_Pos[i], gemalteslist_y_Pos[i]);
                i++;
            } while (i < gemalteslist_x_Pos.Length);



            if (M_Right == true && C_Right == false)
            {
                animation_ms += 17;

                if (x_Pos_Malario < (Width / 2))
                {
                    x_Pos_Malario += 4;
                }
                else
                {
                    int Bewegungs_Panel_Zähler = gemalteslist_x_Pos.Length - 1;
                    do
                    {
                        gemalteslist_x_Pos[Bewegungs_Panel_Zähler] -= 4;
                        Bewegungs_Panel_Zähler--;
                    } while (Bewegungs_Panel_Zähler >= 0);
                }
            }
            else if (M_Left == true && x_Pos_Malario > 0)
            {
                x_Pos_Malario -= 4;
                animation_ms += 17;
            }
            if (M_Jump == true)
            {
                y_Pos_Malario -= anziehungskraft;
                anziehungskraft -= 1;
            }
            if (y_Pos_Malario >= Height - 30 - 39 - 48)
            {
                y_Pos_Malario = Height - 30 - 39 - 48;

                // 30 = Malariogröße
                // 48 = der Boden unter Malario (Hardcode im Collisiongrit ändern!)
                M_Jump = false;
                anziehungskraft = anziehungskaft_Wert;
            }
            if (animation_ms > 60)
            {
                if (M_Gehend == true) { M_Gehend = false; }
                else { M_Gehend = true; }
                animation_ms = 0;
            }
            if (M_Left == false && M_Right == false)
            {
                M_Gehend = false;
                animation_ms = 0;
            }
            Invalidate();
        }
        private void malen_Startmenü()
        {
            x_Pos_Block = 0;
            y_Pos_Block = (this.Height - 38 - 50);




            int Blockzähler = 0;
            do
            {
                Array.Resize(ref gemalteslist_x_Pos, gemalteslist_x_Pos.Length + 1);
                Array.Resize(ref gemalteslist_y_Pos, gemalteslist_y_Pos.Length + 1);
                Array.Resize(ref gemalteslist_Blockart, gemalteslist_Blockart.Length + 1);

                gemalteslist_Blockart[gemalteslist_x_Pos.Length - 1] = 0;
                gemalteslist_x_Pos[gemalteslist_x_Pos.Length - 1] = x_Pos_Block;
                gemalteslist_y_Pos[gemalteslist_x_Pos.Length - 1] = y_Pos_Block;

                y_Pos_Block += 24;

                Array.Resize(ref gemalteslist_x_Pos, gemalteslist_x_Pos.Length + 1);
                Array.Resize(ref gemalteslist_y_Pos, gemalteslist_y_Pos.Length + 1);
                Array.Resize(ref gemalteslist_Blockart, gemalteslist_Blockart.Length + 1);

                gemalteslist_Blockart[gemalteslist_x_Pos.Length - 1] = 0;
                gemalteslist_x_Pos[gemalteslist_x_Pos.Length - 1] = x_Pos_Block;
                gemalteslist_y_Pos[gemalteslist_x_Pos.Length - 1] = y_Pos_Block;

                y_Pos_Block -= 24;
                x_Pos_Block += 24;
                Blockzähler += 24;
            } while (Blockzähler < 480);
            // marvin block
            x_Pos_Block = 100;
            y_Pos_Block = (this.Height - 38 - 50 - 70);

            Array.Resize(ref gemalteslist_x_Pos, gemalteslist_x_Pos.Length + 1);
            Array.Resize(ref gemalteslist_y_Pos, gemalteslist_y_Pos.Length + 1);
            Array.Resize(ref gemalteslist_Blockart, gemalteslist_Blockart.Length + 1);

            gemalteslist_Blockart[gemalteslist_x_Pos.Length - 1] = 2;
            gemalteslist_x_Pos[gemalteslist_x_Pos.Length - 1] = x_Pos_Block;
            gemalteslist_y_Pos[gemalteslist_x_Pos.Length - 1] = y_Pos_Block;


            x_Pos_Block += 24;
            Array.Resize(ref gemalteslist_x_Pos, gemalteslist_x_Pos.Length + 1);
            Array.Resize(ref gemalteslist_y_Pos, gemalteslist_y_Pos.Length + 1);
            Array.Resize(ref gemalteslist_Blockart, gemalteslist_Blockart.Length + 1);

            gemalteslist_Blockart[gemalteslist_x_Pos.Length - 1] = 9999;
            gemalteslist_x_Pos[gemalteslist_x_Pos.Length - 1] = x_Pos_Block;
            gemalteslist_y_Pos[gemalteslist_x_Pos.Length - 1] = y_Pos_Block;



            x_Pos_Block -= 24;
            y_Pos_Block += 24;



            Array.Resize(ref gemalteslist_x_Pos, gemalteslist_x_Pos.Length + 1);
            Array.Resize(ref gemalteslist_y_Pos, gemalteslist_y_Pos.Length + 1);
            Array.Resize(ref gemalteslist_Blockart, gemalteslist_Blockart.Length + 1);

            gemalteslist_Blockart[gemalteslist_x_Pos.Length - 1] = 3;
            gemalteslist_x_Pos[gemalteslist_x_Pos.Length - 1] = x_Pos_Block;
            gemalteslist_y_Pos[gemalteslist_x_Pos.Length - 1] = y_Pos_Block;


            x_Pos_Block += 24;
            Array.Resize(ref gemalteslist_x_Pos, gemalteslist_x_Pos.Length + 1);
            Array.Resize(ref gemalteslist_y_Pos, gemalteslist_y_Pos.Length + 1);
            Array.Resize(ref gemalteslist_Blockart, gemalteslist_Blockart.Length + 1);

            gemalteslist_Blockart[gemalteslist_x_Pos.Length - 1] = 9999;
            gemalteslist_x_Pos[gemalteslist_x_Pos.Length - 1] = x_Pos_Block;
            gemalteslist_y_Pos[gemalteslist_x_Pos.Length - 1] = y_Pos_Block;
            // marvin block
        }

        private void c_Right(int char_x_Koor, int char_y_Koor, int char_Breite, int char_Höhe, int obj_x_Koor, int obj_y_Koor)
        {
            if ((char_y_Koor + char_Höhe) >= obj_y_Koor && char_y_Koor <= obj_y_Koor + 24)
            {
                if (char_x_Koor + char_Breite == obj_x_Koor && char_x_Koor + char_Breite <= obj_x_Koor)
                {
                    C_Right = true;
                }
                else
                {
                    C_Right = false;
                }
            }
            else
            {
                C_Right = false;
            }
        }
        private void c_Left(int char_x_Koor, int char_y_Koor, int char_Breite, int char_Höhe, int obj_x_Koor, int obj_y_Koor)
        {

        }
        private bool c_Above(int x, int y, int height)
        {
            if (false)
            {
                C_Above = false;
            }
            else if (true)
            {
                C_Above = true;
            }
            return C_Above;
        }
        private bool c_Underneath(int x, int y, int height)
        {
            if (false)
            {
                C_Underneath = false;
            }
            else if (true)
            {
                C_Underneath = true;
            }
            return C_Underneath;
        }
    }
}

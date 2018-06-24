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
        List<int> list_x_Pos_Obj = new List<int>();
        List<int> list_y_Pos_Obj = new List<int>();
        List<int> list_Typ_Obj = new List<int>();
        List<int> list_x_Pos_Items = new List<int>();
        List<int> list_y_Pos_Items = new List<int>();
        List<int> list_Typ_Items = new List<int>();
        List<int> list_x_Pos_Enemys = new List<int>();
        List<int> list_y_Pos_Enemys = new List<int>();
        List<int> list_Typ_Enemys = new List<int>();
        List<bool> list_RichtungLinks_Enemys = new List<bool>();

        bool M_Right = false, M_Left = false, M_Richtung = false, M_Jump = false, Startbildschirm = true, M_Gehend = false, M_Anziehungskraft = false, Goethe_AnziehungskraftBool = true;
        //Collsions
        bool C_Right = false, C_Left = false, C_Above = false, C_Underneath = false;

        //Items
        bool I_Energy, I_Laser, I_LaserActive, I_LaserAnimation = false;
        int animation_ms, LaserAnimation_ms, M_Bewegungskraft = 0, Block_Bewegungskraft = 0, anziehungskraft = 0, anziehungskraft_Steigen = -15, x_Pos_Malario = 0, y_Pos_Malario = 397, x_Pos_Block = 0, y_Pos_Block = 0, fall_Limit = 480, sprung_Limit = 0, rightlimit = 480, leftlimit = 0, M_Laufgeschwindigkeit = 6, Goethe_Geschwindigkeit = 3, Goethe_AnziehungskraftInt = 0;
        int M_Lives = 3;

        //Level_Generator
        int bodenhöhe = 432, bodenabstand, laufzähler = 0;

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            base.OnPaint(e);
            I_Laser = true;
            I_Energy = false;
            label1counter.Text = Convert.ToString(list_Typ_Obj.Count);
            label1.Text = Convert.ToString(laufzähler);
            label2.Text = Convert.ToString(x_Pos_Malario);
            label3.Text = Convert.ToString(y_Pos_Malario);

            //Item Wirkung
            //Energy
            if (I_Energy == true)
            {
                M_Laufgeschwindigkeit = 9;
            }

            else if (I_Energy == false)
            {
                M_Laufgeschwindigkeit = 6;
            }
            //Laser

            if (I_LaserAnimation == true)
            {
                int nextBlock = 0;
                if (M_Richtung == false)
                {
                    nextBlock = rightlimit - 27;
                }
                else if (M_Richtung == true)
                {
                    nextBlock = leftlimit + 2;
                }
                Items.malen_Laser(graphics, x_Pos_Malario, y_Pos_Malario, nextBlock, M_Richtung);
            }
            //Leben
            if (M_Lives == 0)
            {
                //Respawn und neu Laden
            }
            //Item Wirkung Ende

            if (M_Left == true || M_Right == true)
            {
                Malario.malen_Malario(graphics, x_Pos_Malario, y_Pos_Malario, M_Richtung, M_Gehend);
            }
            else
            {
                M_Gehend = false;
                Malario.malen_Malario(graphics, x_Pos_Malario, y_Pos_Malario, M_Richtung, M_Gehend);
            }


            if (Startbildschirm == true)
            {
                malen_Startmenü();
                Startbildschirm = false;
            }
            // malen_Startmenü(graphics);

            int Zähler = 0;
            if (list_x_Pos_Obj.Count > 0)
            {
                do
                {
                    x_Pos_Block = list_x_Pos_Obj[Zähler];
                    y_Pos_Block = list_y_Pos_Obj[Zähler];

                    if (list_Typ_Obj[Zähler] == 0 && x_Pos_Block < 504 && x_Pos_Block > -60)
                    {
                        Level_Blöcke.malen_BodenBlock(graphics, x_Pos_Block, y_Pos_Block);
                    }
                    else if (list_Typ_Obj[Zähler] == 1 && x_Pos_Block < 504 && x_Pos_Block > -60)
                    {
                        Level_Blöcke.malen_MauerBlock(graphics, x_Pos_Block, y_Pos_Block);
                    }
                    else if (list_Typ_Obj[Zähler] == 2 && x_Pos_Block < 504 && x_Pos_Block > -60)
                    {
                        Level_Blöcke.malen_RöhrenBlock_Kopf(graphics, x_Pos_Block, y_Pos_Block);
                    }
                    else if (list_Typ_Obj[Zähler] == 3 && x_Pos_Block < 504 && x_Pos_Block > -60)
                    {
                        Level_Blöcke.malen_RöhrenBlock_Hals(graphics, x_Pos_Block, y_Pos_Block);
                    }
                    else if (list_Typ_Obj[Zähler] == 4 && x_Pos_Block < 504 && x_Pos_Block > -60)
                    {
                        Level_Blöcke.malen_StahlBlock(graphics, x_Pos_Block, y_Pos_Block);
                    }
                    Zähler++;
                } while (Zähler < list_Typ_Obj.Count);
            }

            Zähler = 0;
            if (list_x_Pos_Items.Count > 0)
            {
                do
                {
                    x_Pos_Block = list_x_Pos_Items[Zähler];
                    y_Pos_Block = list_y_Pos_Items[Zähler];

                    if (list_Typ_Items[Zähler] == 0 && x_Pos_Block < 504 && x_Pos_Block > -60)
                    {
                        Items.malen_Coin(graphics, x_Pos_Block, y_Pos_Block);
                    }
                    else if (list_Typ_Items[Zähler] == 1 && x_Pos_Block < 504 && x_Pos_Block > -60)
                    {
                        Items.malen_Energy(graphics, x_Pos_Block, y_Pos_Block);
                    }
                    else if (list_Typ_Items[Zähler] == 2 && x_Pos_Block < 504 && x_Pos_Block > -60)
                    {
                        Items.malen_LaserGun(graphics, x_Pos_Block, y_Pos_Block);
                    }
                    else if (list_Typ_Items[Zähler] == 3 && x_Pos_Block < 504 && x_Pos_Block > -60)
                    {
                        Items.malen_Heart(graphics, x_Pos_Block, y_Pos_Block);
                    }

                    Zähler++;
                } while (Zähler < list_Typ_Items.Count);
            }

            Zähler = 0;
            if (list_x_Pos_Enemys.Count > 0)
            {
                do
                {
                    x_Pos_Block = list_x_Pos_Enemys[Zähler];
                    y_Pos_Block = list_y_Pos_Enemys[Zähler];
                    bool Richtung_Gegner = list_RichtungLinks_Enemys[Zähler];
                    if (list_Typ_Enemys[Zähler] == 0 && x_Pos_Block < 504 && x_Pos_Block > -60)
                    {
                        Gegner.malen_Goethe(graphics, x_Pos_Block, y_Pos_Block + 4, Richtung_Gegner);

                    }
                    else if (list_Typ_Enemys[Zähler] == 1 && x_Pos_Block < 504 && x_Pos_Block > -60)
                    {
                    }

                    Zähler++;
                } while (Zähler < list_Typ_Enemys.Count);
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
                case Keys.F:
                    if (I_Laser == true && I_LaserActive == false)
                    {
                        I_LaserActive = true;
                    }
                    break;
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
            int i = 0, UnderneathValue0 = 480, UnderneathValue1 = 480, AboveValue0 = 0, AboveValue1 = 0, RightValue0 = 480, RightValue1 = 480, LeftValue0 = 0, LeftValue1 = 0, Block_Zähler = list_x_Pos_Obj.Count - 1;
            C_Right = false;
            C_Left = false;
            C_Above = false;
            C_Underneath = false;
            #region Malario
            do
            {
                C_Above = false;
                C_Underneath = false;
                C_Right = false;
                C_Left = false;
                c_Right(x_Pos_Malario, y_Pos_Malario, 25, 28, list_x_Pos_Obj[i], list_y_Pos_Obj[i], 24, 24);
                c_Left(x_Pos_Malario, y_Pos_Malario, 25, 28, list_x_Pos_Obj[i], list_y_Pos_Obj[i], 24, 24);
                c_Above(x_Pos_Malario, y_Pos_Malario, 25, 28, list_x_Pos_Obj[i], list_y_Pos_Obj[i], 24, 24);
                c_Underneath(x_Pos_Malario, y_Pos_Malario, 25, 28, list_x_Pos_Obj[i], list_y_Pos_Obj[i], 24, 24);
                if (C_Underneath == true)
                {
                    UnderneathValue1 = list_y_Pos_Obj[i];
                    if (UnderneathValue0 > UnderneathValue1 && UnderneathValue1 > AboveValue1) UnderneathValue0 = UnderneathValue1;
                }
                if (C_Above == true)
                {
                    AboveValue1 = list_y_Pos_Obj[i] + 24;
                    if (AboveValue0 <= AboveValue1) AboveValue0 = AboveValue1;
                }
                if (C_Right == true)
                {
                    RightValue1 = list_x_Pos_Obj[i];
                    if (RightValue0 > RightValue1) RightValue0 = RightValue1;
                }
                if (C_Left == true)
                {
                    LeftValue1 = list_x_Pos_Obj[i] + 30;
                    if (LeftValue0 < LeftValue1) LeftValue0 = LeftValue1;
                }

                i++;
            } while (i < list_x_Pos_Obj.Count);
            fall_Limit = UnderneathValue0 - 29;
            sprung_Limit = AboveValue0;
            rightlimit = RightValue0;
            leftlimit = LeftValue0;
            //Malario Links, Rechts Bewegung + Collisionsverarbeitung
            M_Bewegungskraft = 0;
            Block_Bewegungskraft = 0;
            //Rechts
            if (x_Pos_Malario + 30 >= rightlimit && M_Right == true)
            {
                M_Bewegungskraft = 0;
                Block_Bewegungskraft = 0;
                M_Gehend = false;
                animation_ms = 0;
            }
            else
            {
                animation_ms += 17;
                if (M_Right == true && x_Pos_Malario < 255)
                {
                    M_Bewegungskraft = M_Laufgeschwindigkeit;
                }
                else if (M_Right == true)
                {
                    Block_Bewegungskraft = M_Laufgeschwindigkeit;
                    laufzähler += M_Laufgeschwindigkeit;
                }
            }
            //Links
            if (x_Pos_Malario <= leftlimit && M_Left == true)
            {
                M_Bewegungskraft = 0;
                Block_Bewegungskraft = 0;
                M_Gehend = false;
                animation_ms = 0;
            }
            else if (M_Left == true)
            {
                M_Bewegungskraft = -M_Laufgeschwindigkeit;
                animation_ms += 17;
            }
            x_Pos_Malario += M_Bewegungskraft;
            do
            {
                list_x_Pos_Obj[Block_Zähler] -= Block_Bewegungskraft;
                Block_Zähler--;
            } while (Block_Zähler >= 0);


            //Malario fällt
            if (y_Pos_Malario < fall_Limit)
            {
                M_Jump = true;
                if (anziehungskraft < 15)
                {
                    anziehungskraft++;
                }
                M_Anziehungskraft = true;
            }
            //Malario Boden Collision erkannt und behandelt
            else if (M_Anziehungskraft == true && y_Pos_Malario >= fall_Limit)
            {

                M_Jump = false;
                M_Anziehungskraft = false;
                anziehungskraft = 0;
                y_Pos_Malario = fall_Limit;

            }
            //Sprungkraft wird angewändet
            if (M_Jump == true && M_Anziehungskraft == false)
            {
                M_Anziehungskraft = true;
                anziehungskraft = anziehungskraft_Steigen;
            }
            //Malario Decken Collision erkannt und behandelt
            if (y_Pos_Malario <= sprung_Limit)
            {
                anziehungskraft = 1;
                y_Pos_Malario = sprung_Limit;
            }
            y_Pos_Malario += anziehungskraft;


            //Malario Animation
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

            //Laser Animation
            if (I_LaserActive == true && I_Laser == true && LaserAnimation_ms < 30)
            {
                LaserAnimation_ms += 17;
                I_LaserAnimation = true;
            }
            else if (LaserAnimation_ms > 30)
            {
                I_LaserAnimation = false;
                LaserAnimation_ms += 17;
                if (LaserAnimation_ms > 300)
                {
                    I_LaserActive = false;
                    LaserAnimation_ms = 0;
                }
            }
            #endregion
            ////////////////////////////////////////////////////////////////////////////////////////////
            //nach Rechts bewegen = false
            //nach Links bewegen = true
            #region Goethe
            i = 0;
            UnderneathValue0 = 480;
            UnderneathValue1 = 480;
            RightValue0 = 480;
            RightValue1 = 480;
            LeftValue0 = 0;
            LeftValue1 = 0;
            int j = 0;
            do
            {
                i = 0;
                do
                {
                    C_Underneath = false;
                    C_Right = false;
                    C_Left = false;
                    c_Right(list_x_Pos_Enemys[j], list_y_Pos_Enemys[j], 27, 30, list_x_Pos_Obj[i], list_y_Pos_Obj[i], 24, 24);
                    c_Left(list_x_Pos_Enemys[j], list_y_Pos_Enemys[j], 27, 30, list_x_Pos_Obj[i], list_y_Pos_Obj[i], 24, 24);
                    c_Underneath(list_x_Pos_Enemys[j], list_y_Pos_Enemys[j], 27, 30, list_x_Pos_Obj[i], list_y_Pos_Obj[i], 24, 24);
                    if (C_Underneath == true)
                    {
                        UnderneathValue1 = list_y_Pos_Obj[i] - 8;
                        if (UnderneathValue0 > UnderneathValue1 && UnderneathValue1 > AboveValue1) UnderneathValue0 = UnderneathValue1;
                    }
                    if (C_Right == true)
                    {
                        RightValue1 = list_x_Pos_Obj[i];
                        if (RightValue0 > RightValue1) RightValue0 = RightValue1;
                    }
                    if (C_Left == true)
                    {
                        LeftValue1 = list_x_Pos_Obj[i];
                        if (LeftValue0 < LeftValue1) LeftValue0 = LeftValue1;
                    }
                    i++;
                } while (i < list_x_Pos_Obj.Count);
                fall_Limit = UnderneathValue0 - 34;
                rightlimit = RightValue0;
                leftlimit = LeftValue0;
                if (list_Typ_Enemys[j] == 0)
                {
                    //Rechts-Bewegungen von Goethe

                    if (list_RichtungLinks_Enemys[j] == false && list_x_Pos_Enemys[j] + 32 >= rightlimit)
                    {
                        list_RichtungLinks_Enemys[j] = true;
                    }
                    else if (list_RichtungLinks_Enemys[j] == false)
                    {
                        list_x_Pos_Enemys[j] += Goethe_Geschwindigkeit;
                    }
                    //Links-Bewegungen von Goethe

                    if (list_RichtungLinks_Enemys[j] == true && list_x_Pos_Enemys[j] <= leftlimit + 26)
                    {
                        list_RichtungLinks_Enemys[j] = false;
                    }
                    else if (list_RichtungLinks_Enemys[j] == true)
                    {
                        list_x_Pos_Enemys[j] -= Goethe_Geschwindigkeit;
                    }
                    //Goethe fällt
                    if (Goethe_AnziehungskraftBool == true && list_y_Pos_Enemys[j] <= fall_Limit)
                    {
                        Goethe_AnziehungskraftInt++;
                        Goethe_AnziehungskraftBool = true;
                    }
                    else
                    {
                        Goethe_AnziehungskraftInt = 0;
                        Goethe_AnziehungskraftBool = false;
                    }
                }
                #endregion
                else if (list_Typ_Enemys[j] == 1)
                {
                    if (list_RichtungLinks_Enemys[j] == false)
                    {

                    }
                    else if (list_RichtungLinks_Enemys[j] == true)
                    {

                    }
                }

                list_y_Pos_Enemys[j] += Goethe_AnziehungskraftInt;
                j++;
            } while (j < list_Typ_Enemys.Count);

            Block_Zähler = list_Typ_Enemys.Count - 1;
            do
            {
                list_x_Pos_Enemys[Block_Zähler] -= Block_Bewegungskraft;
                Block_Zähler--;
            } while (Block_Zähler > 0);

            Invalidate();
        }
        private void malen_Startmenü()
        {
            generiert_Rechteck(480, 24, 0, 2, 9);
            x_Pos_Block = 0;
            y_Pos_Block = (this.Height - 39 - 48);


            int Blockzähler = 0;
            do
            {

                list_Typ_Obj.Add(4);
                list_x_Pos_Obj.Add(x_Pos_Block);
                list_y_Pos_Obj.Add(y_Pos_Block);

                y_Pos_Block += 24;

                list_Typ_Obj.Add(4);
                list_x_Pos_Obj.Add(x_Pos_Block);
                list_y_Pos_Obj.Add(y_Pos_Block);


                y_Pos_Block -= 24;
                x_Pos_Block += 24;
                Blockzähler += 24;
            } while (Blockzähler < 20000);



            x_Pos_Block = 96;
            y_Pos_Block = (this.Height - 39 - 48 - 24);

            list_Typ_Obj.Add(4);
            list_x_Pos_Obj.Add(x_Pos_Block);
            list_y_Pos_Obj.Add(y_Pos_Block);

            x_Pos_Block = 288;
            y_Pos_Block = (this.Height - 39 - 48 - 24);

            list_Typ_Obj.Add(4);
            list_x_Pos_Obj.Add(x_Pos_Block);
            list_y_Pos_Obj.Add(y_Pos_Block);
            x_Pos_Block += 24;
            list_Typ_Obj.Add(4);
            list_x_Pos_Obj.Add(x_Pos_Block);
            list_y_Pos_Obj.Add(y_Pos_Block);
            x_Pos_Block += 24;
            list_Typ_Obj.Add(4);
            list_x_Pos_Obj.Add(x_Pos_Block);
            list_y_Pos_Obj.Add(y_Pos_Block);
            y_Pos_Block -= 24;
            x_Pos_Block -= 24;

            list_Typ_Obj.Add(4);
            list_x_Pos_Obj.Add(x_Pos_Block);
            list_y_Pos_Obj.Add(y_Pos_Block);
            x_Pos_Block += 24;
            list_Typ_Obj.Add(4);
            list_x_Pos_Obj.Add(x_Pos_Block);
            list_y_Pos_Obj.Add(y_Pos_Block);
            y_Pos_Block -= 24;
            list_Typ_Obj.Add(4);
            list_x_Pos_Obj.Add(x_Pos_Block);
            list_y_Pos_Obj.Add(y_Pos_Block);

            y_Pos_Block -= 96;
            x_Pos_Block -= 150;


            list_Typ_Obj.Add(4);
            list_x_Pos_Obj.Add(x_Pos_Block);
            list_y_Pos_Obj.Add(y_Pos_Block);
            x_Pos_Block += 24;
            list_Typ_Obj.Add(4);
            list_x_Pos_Obj.Add(x_Pos_Block);
            list_y_Pos_Obj.Add(y_Pos_Block);
            x_Pos_Block += 24;
            list_Typ_Obj.Add(4);
            list_x_Pos_Obj.Add(x_Pos_Block);
            list_y_Pos_Obj.Add(y_Pos_Block);
            y_Pos_Block -= 24;

            x_Pos_Block -= 48;
            list_Typ_Obj.Add(4);
            list_x_Pos_Obj.Add(x_Pos_Block);
            list_y_Pos_Obj.Add(y_Pos_Block);

            // Pipe
            /*
            x_Pos_Block = 100;
            y_Pos_Block = (this.Height - 38 - 50 - 72);

            Array.Resize(ref list_x_Pos_Obj, list_x_Pos_Obj.Count + 1);
            Array.Resize(ref list_y_Pos_Obj, list_y_Pos_Obj.Count + 1);
            Array.Resize(ref list_Typ_Obj, list_Typ_Obj.Count + 1);
            list_Typ_Obj[list_x_Pos_Obj.Count - 1] = 2;
            list_x_Pos_Obj[list_x_Pos_Obj.Count - 1] = x_Pos_Block;
            list_y_Pos_Obj[list_x_Pos_Obj.Count - 1] = y_Pos_Block;
            
            x_Pos_Block += 24;

            Array.Resize(ref list_x_Pos_Obj, list_x_Pos_Obj.Count + 1);
            Array.Resize(ref list_y_Pos_Obj, list_y_Pos_Obj.Count + 1);
            Array.Resize(ref list_Typ_Obj, list_Typ_Obj.Count + 1);
            list_Typ_Obj[list_x_Pos_Obj.Count - 1] = 99999;
            list_x_Pos_Obj[list_x_Pos_Obj.Count - 1] = x_Pos_Block;
            list_y_Pos_Obj[list_x_Pos_Obj.Count - 1] = y_Pos_Block;

            
            x_Pos_Block -= 24;
            y_Pos_Block += 48;

            Array.Resize(ref list_x_Pos_Obj, list_x_Pos_Obj.Count + 1);
            Array.Resize(ref list_y_Pos_Obj, list_y_Pos_Obj.Count + 1);
            Array.Resize(ref list_Typ_Obj, list_Typ_Obj.Count + 1);
            list_Typ_Obj[list_x_Pos_Obj.Count - 1] = 3;
            list_x_Pos_Obj[list_x_Pos_Obj.Count - 1] = x_Pos_Block;
            list_y_Pos_Obj[list_x_Pos_Obj.Count - 1] = y_Pos_Block;
            x_Pos_Block += 24;

            Array.Resize(ref list_x_Pos_Obj, list_x_Pos_Obj.Count + 1);
            Array.Resize(ref list_y_Pos_Obj, list_y_Pos_Obj.Count + 1);
            Array.Resize(ref list_Typ_Obj, list_Typ_Obj.Count + 1);
            list_Typ_Obj[list_x_Pos_Obj.Count - 1] = 9999;
            list_x_Pos_Obj[list_x_Pos_Obj.Count - 1] = x_Pos_Block;
            list_y_Pos_Obj[list_x_Pos_Obj.Count - 1] = y_Pos_Block;
            */
            // Pipe
            list_Typ_Enemys.Add(0);
            list_RichtungLinks_Enemys.Add(false);
            list_x_Pos_Enemys.Add(200);
            list_y_Pos_Enemys.Add(380 - 48 - 32);
        }
        //CollisionPunkt_Abfragen_Start
        private void c_Right(int char_x_Koor, int char_y_Koor, int char_Breite, int char_Höhe, int obj_x_Koor, int obj_y_Koor, int obj_Breite, int obj_Höhe)
        {
            if (char_x_Koor + char_Breite <= obj_x_Koor && char_y_Koor + char_Höhe >= obj_y_Koor && char_y_Koor <= obj_y_Koor + obj_Höhe)
            {
                C_Right = true;
            }
        }
        private void c_Left(int char_x_Koor, int char_y_Koor, int char_Breite, int char_Höhe, int obj_x_Koor, int obj_y_Koor, int obj_Breite, int obj_Höhe)
        {
            if (char_x_Koor >= obj_x_Koor + obj_Breite && char_y_Koor + char_Höhe >= obj_y_Koor && char_y_Koor <= obj_y_Koor + obj_Höhe)
            {
                C_Left = true;
            }
        }
        private void c_Above(int char_x_Koor, int char_y_Koor, int char_Breite, int char_Höhe, int obj_x_Koor, int obj_y_Koor, int obj_Breite, int obj_Höhe)
        {
            if (char_y_Koor >= obj_y_Koor && char_x_Koor + char_Breite > obj_x_Koor && char_x_Koor < obj_x_Koor + obj_Breite + char_Breite / 4)
            {
                C_Above = true;
            }
        }
        private void c_Underneath(int char_x_Koor, int char_y_Koor, int char_Breite, int char_Höhe, int obj_x_Koor, int obj_y_Koor, int obj_Breite, int obj_Höhe)
        {
            if (char_x_Koor + char_Breite >= obj_x_Koor && char_x_Koor <= obj_x_Koor + obj_Breite && char_y_Koor + char_Höhe / 2 <= obj_y_Koor)
            {
                C_Underneath = true;
            }
        }
        private void c_Malario(int char_x_Koor, int char_y_Koor, int char_Breite, int char_Höhe, int M_x_Koor, int M_y_Koor, int M_Breite, int M_Höhe)
        {
            if ((char_x_Koor + char_Breite < M_x_Koor && char_y_Koor + char_Höhe > M_y_Koor && char_y_Koor < M_y_Koor + M_Höhe) || (char_x_Koor >= M_x_Koor + M_Breite && char_y_Koor + char_Höhe >= M_y_Koor && char_y_Koor <= M_y_Koor + M_Höhe) || (char_y_Koor >= M_y_Koor && char_x_Koor + char_Breite > M_x_Koor && char_x_Koor < M_x_Koor + M_Breite + char_Breite / 4) || (char_x_Koor + char_Breite >= M_x_Koor && char_x_Koor <= M_x_Koor + M_Breite && char_y_Koor + char_Höhe / 2 <= M_y_Koor))
            {
                M_Lives--;
            }
        }
        //CollisionPunkt_Abfragen_Stop

        //LevelGenerator
        private void generiert_LevelAbschnitt()
        {

        }
        private void generiert_BodenAbschnitt(int boden_Höhe, int boden_Länge, int x_Coor)
        {
            int x_Pos_Block = x_Coor,
            y_Pos_Block = 456;
            do
            {
                int Blockzähler = 0;
                do
                {
                    list_Typ_Obj.Add(0);
                    list_x_Pos_Obj.Add(x_Pos_Block);
                    list_y_Pos_Obj.Add(y_Pos_Block);
                    x_Pos_Block += 24;
                    Blockzähler += 24;
                } while (Blockzähler < boden_Länge);
                x_Pos_Block -= boden_Länge;
                y_Pos_Block -= 24;
            } while (y_Pos_Block >= boden_Höhe);
        }
        private void generiert_Röhre(int röhren_Höhe, int boden_Höhe, int x_Coor)
        {
            int x_Pos_Block = x_Coor,
            y_Pos_Block = röhren_Höhe;


            list_Typ_Obj.Add(2);
            list_x_Pos_Obj.Add(x_Pos_Block);
            list_y_Pos_Obj.Add(y_Pos_Block);
            x_Pos_Block += 24;
            list_Typ_Obj.Add(99);
            list_x_Pos_Obj.Add(x_Pos_Block);
            list_y_Pos_Obj.Add(y_Pos_Block);
            x_Pos_Block -= 24;
            y_Pos_Block += 24;
            x_Pos_Block += 24;
            list_Typ_Obj.Add(99);
            list_x_Pos_Obj.Add(x_Pos_Block);
            list_y_Pos_Obj.Add(y_Pos_Block);
            do
            {
                x_Pos_Block -= 24;
                y_Pos_Block += 24;
                list_Typ_Obj.Add(3);
                list_x_Pos_Obj.Add(x_Pos_Block);
                list_y_Pos_Obj.Add(y_Pos_Block);
                x_Pos_Block += 24;
                list_Typ_Obj.Add(99);
                list_x_Pos_Obj.Add(x_Pos_Block);
                list_y_Pos_Obj.Add(y_Pos_Block);
            } while (y_Pos_Block < boden_Höhe);
        }
        private void generiert_Rechteck(int x_Coor, int y_Choor, int blockArt, int block_Höhe, int block_Breite)
        {
            int x_Pos_Block = x_Coor,
            y_Pos_Block = y_Choor;
            int Zähler0 = 0,
                Zähler1 = 0;
            do
            {
                Zähler0 = 0;
                do
                {
                    y_Pos_Block += 24;
                    list_Typ_Obj.Add(blockArt);
                    list_x_Pos_Obj.Add(x_Pos_Block);
                    list_y_Pos_Obj.Add(y_Pos_Block);
                    Zähler0++;
                } while (Zähler0 < block_Höhe);
                y_Pos_Block -= 24 * block_Höhe;
                x_Pos_Block -= 24;
                Zähler1++;
            } while (Zähler1 < block_Breite);
        }
    }
}

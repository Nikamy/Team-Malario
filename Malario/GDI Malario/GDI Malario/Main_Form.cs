#region using
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#endregion

namespace GDI_Malario
{
    public partial class Main_Form : Form
    {
        #region Listen
        List<int> list_x_Pos_Obj = new List<int>();
        List<int> list_y_Pos_Obj = new List<int>();
        List<int> list_Typ_Obj = new List<int>();
        List<int> list_x_Pos_Items = new List<int>();
        List<int> list_y_Pos_Items = new List<int>();
        List<int> list_Typ_Items = new List<int>();
        List<int> list_x_Pos_Enemys = new List<int>();
        List<int> list_y_Pos_Enemys = new List<int>();
        List<int> list_Typ_Enemys = new List<int>();
        List<int> list_Anziehungskraft_Enemys = new List<int>();
        List<bool> list_RichtungLinks_Enemys = new List<bool>();
        #endregion
        #region Variablen
        bool M_Right = false, M_Left = false, M_Richtung = false, M_Jump = false, Startbildschirm = true, M_Gehend = false, M_Anziehungskraft = false, Goethe_AnziehungskraftBool = true;
        #region Collsions
        bool C_Right = false, C_Left = false, C_Above = false, C_Underneath = false;
        #endregion
        #region Items
        bool I_Energy = false, I_Laser = true, I_LaserActive = false, I_LaserAnimation = false;
        int M_Lives = 3,
            CoinCounter = 0,
            getöteteGegner_Counter = 0,
            ScoreZähler = 0;
        #endregion
        int animation_ms, interwall_GegnerSpawner = 300, interwall_RöhrenLaser,M_unkillable, LaserAnimation_ms, M_Bewegungskraft = 0, Block_Bewegungskraft = 0, anziehungskraft = 0, anziehungskraft_Steigen = -15, x_Pos_Malario = 48, y_Pos_Malario = 397, x_Pos_Block = 0, y_Pos_Block = 0, fall_Limit = 480, sprung_Limit = 0, rightlimit = 480, leftlimit = 0, M_Laufgeschwindigkeit = 3, Goethe_Geschwindigkeit = 3;
        int nextBlock = 0;
        #region Level_Generator
        int bodenhöhe = 432, bodenabstand, laufzähler = 1920;
        bool lvlGenerator_PipeLvl = false;
        #endregion
        #region Gegner
        bool RöhrenLaser_ist_da = false;
        #endregion
        #endregion

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            base.OnPaint(e);
            label1.Text = Convert.ToString(list_x_Pos_Obj.Count) + " Gegner getötet";
            label2.Text = Convert.ToString(M_Lives) + " Leben";
            label3.Text = Convert.ToString(CoinCounter) + " Münzen";


            if (Startbildschirm == true)
            {
                malen_Startmenü();
                Startbildschirm = false;
            }
            // malen_Startmenü(graphics);

            generiert_LevelAbschnitt();
            #region LevelObjekte werden gemalt
            int Zähler = 0;
            if (list_x_Pos_Obj.Count > 0)
            {
                do
                {
                    x_Pos_Block = list_x_Pos_Obj[Zähler];
                    y_Pos_Block = list_y_Pos_Obj[Zähler];

                    if (list_Typ_Obj[Zähler] == 0 && x_Pos_Block < Width + 24 && x_Pos_Block > -50)
                    {
                        Level_Blöcke.malen_BodenBlock(graphics, x_Pos_Block, y_Pos_Block);
                    }
                    else if (list_Typ_Obj[Zähler] == 1 && x_Pos_Block < Width + 24 && x_Pos_Block > -50)
                    {
                        Level_Blöcke.malen_MauerBlock(graphics, x_Pos_Block, y_Pos_Block);
                    }
                    else if (list_Typ_Obj[Zähler] == 2 && x_Pos_Block < Width + 24 && x_Pos_Block > -50)
                    {
                        Level_Blöcke.malen_RöhrenBlock_Kopf(graphics, x_Pos_Block, y_Pos_Block);
                    }
                    else if (list_Typ_Obj[Zähler] == 3 && x_Pos_Block < Width + 24 && x_Pos_Block > -50)
                    {
                        Level_Blöcke.malen_RöhrenBlock_Hals(graphics, x_Pos_Block, y_Pos_Block);
                    }
                    else if (list_Typ_Obj[Zähler] == 4 && x_Pos_Block < Width + 24 && x_Pos_Block > -50)
                    {
                        Level_Blöcke.malen_StahlBlock(graphics, x_Pos_Block, y_Pos_Block);
                    }
                    else if (list_Typ_Obj[Zähler] == 5 && x_Pos_Block < Width + 24 && x_Pos_Block > -1000)
                    {
                        Level_Blöcke.malen_Dungeonhintergrund(graphics, x_Pos_Block, y_Pos_Block);
                    }
                    Zähler++;
                } while (Zähler < list_Typ_Obj.Count);
            }
            #endregion
            #region LevelItems werden gemalt
            Zähler = 0;
            if (list_x_Pos_Items.Count > 0)
            {
                do
                {
                    x_Pos_Block = list_x_Pos_Items[Zähler];
                    y_Pos_Block = list_y_Pos_Items[Zähler];

                    if (list_Typ_Items[Zähler] == 0 && x_Pos_Block < Width + 24 && x_Pos_Block > -60)
                    {
                        Items.malen_Coin(graphics, x_Pos_Block, y_Pos_Block);
                    }
                    else if (list_Typ_Items[Zähler] == 1 && x_Pos_Block < Width + 24 && x_Pos_Block > -60)
                    {
                        Items.malen_Energy(graphics, x_Pos_Block, y_Pos_Block);
                    }
                    else if (list_Typ_Items[Zähler] == 2 && x_Pos_Block < Width + 24 && x_Pos_Block > -60)
                    {
                        Items.malen_LaserGun(graphics, x_Pos_Block, y_Pos_Block);
                    }
                    else if (list_Typ_Items[Zähler] == 3 && x_Pos_Block < Width + 24 && x_Pos_Block > -60)
                    {
                        Items.malen_Heart(graphics, x_Pos_Block, y_Pos_Block);
                    }

                    Zähler++;
                } while (Zähler < list_Typ_Items.Count);
            }
            #endregion
            #region LevelGegner werden gemalt
            Zähler = 0;
            if (list_x_Pos_Enemys.Count > 0)
            {
                do
                {
                    x_Pos_Block = list_x_Pos_Enemys[Zähler];
                    y_Pos_Block = list_y_Pos_Enemys[Zähler];
                    bool Richtung_Gegner = list_RichtungLinks_Enemys[Zähler];
                    if (list_Typ_Enemys[Zähler] == 0 && x_Pos_Block < Width + 24 && x_Pos_Block > -60)
                    {
                        Gegner.malen_Goethe(graphics, x_Pos_Block, y_Pos_Block + 4, Richtung_Gegner);
                    }
                    else if (list_Typ_Enemys[Zähler] == 1 && x_Pos_Block < Width + 24 && x_Pos_Block > -60)
                    {
                    }
                    else if (list_Typ_Enemys[Zähler] == 2 && x_Pos_Block < Width + 24 && x_Pos_Block > -60)
                    {
                        Gegner.malen_RöhrenLaser(graphics, x_Pos_Block, y_Pos_Block);
                    }

                    Zähler++;
                } while (Zähler < list_Typ_Enemys.Count);
            }
            #endregion
            #region Laser wird gemalt
            if (I_LaserAnimation == true)
            {
                Items.malen_Laser(graphics, x_Pos_Malario, y_Pos_Malario, nextBlock, M_Richtung);
            }
            #endregion
            #region Malario wird gemalt
            if (M_Left == true || M_Right == true)
            {
                Malario.malen_Malario(graphics, x_Pos_Malario, y_Pos_Malario, M_Richtung, M_Gehend);
            }
            else
            {
                M_Gehend = false;
                Malario.malen_Malario(graphics, x_Pos_Malario, y_Pos_Malario, M_Richtung, M_Gehend);
            }
            #endregion
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
            #region Heilung
            if (CoinCounter >= 100 && M_Lives <= 2)
            {
                CoinCounter -= 100;
                M_Lives++;
            }
            #endregion
            int i = 0, UnderneathValue0 = 6000, UnderneathValue1 = 6000, AboveValue0 = -4800, AboveValue1 = -4800, RightValue0 = 9600, RightValue1 = 9600, LeftValue0 = -4800, LeftValue1 = -4800, Block_Zähler = list_x_Pos_Obj.Count - 1;
            C_Right = false;
            C_Left = false;
            C_Above = false;
            C_Underneath = false;
            #region Verhindert das resizen der Höhe
            Height = 519;
            #endregion
            #region Malario
            #region Kollisionsdistanzermittlung
            do if (list_Typ_Obj.Count > 0)
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
                        LeftValue1 = list_x_Pos_Obj[i];
                        if (LeftValue0 < LeftValue1) LeftValue0 = LeftValue1;
                    }

                    i++;
                } while (i < list_x_Pos_Obj.Count);
            fall_Limit = UnderneathValue0 - 29;
            sprung_Limit = AboveValue0;
            rightlimit = RightValue0;
            leftlimit = LeftValue0;
            #endregion
            //Malario Links, Rechts Bewegung + Collisionsverarbeitung
            M_Bewegungskraft = 0;
            Block_Bewegungskraft = 0;
            #region Rechts
            if (x_Pos_Malario + 35 >= rightlimit && M_Right == true)
            {
                M_Bewegungskraft = 0;
                Block_Bewegungskraft = 0;
                M_Gehend = false;
                animation_ms = 0;
            }
            else
            {
                laufzähler += M_Laufgeschwindigkeit;
                animation_ms += 17;
                if (M_Right == true && x_Pos_Malario < Width / 2 -30)
                {
                    M_Bewegungskraft = M_Laufgeschwindigkeit;
                }
                else if (M_Right == true)
                {
                    Block_Bewegungskraft = -M_Laufgeschwindigkeit;
                    ScoreZähler += M_Laufgeschwindigkeit;
                }
            }
            #endregion
            #region Links
            if (x_Pos_Malario <= leftlimit + 35 && M_Left == true)
            {
                M_Bewegungskraft = 0;
                Block_Bewegungskraft = 0;
                M_Gehend = false;
                animation_ms = 0;
            }
            else
            {
                animation_ms += 17;
                if (M_Left == true && x_Pos_Malario > Width / 2 + 30)
                {
                    M_Bewegungskraft = -M_Laufgeschwindigkeit;
                }
                else if (M_Left == true)
                {
                    Block_Bewegungskraft = +M_Laufgeschwindigkeit;
                    laufzähler -= M_Laufgeschwindigkeit;
                }
            }
            #endregion
            #region Malarios bewegugnskraft wird angewändet
            x_Pos_Malario += M_Bewegungskraft;
            #region Objekte erhalten Bewegungskraft
            Block_Zähler = list_Typ_Obj.Count - 1;
            do if (list_Typ_Obj.Count > 0)
                {
                    list_x_Pos_Obj[Block_Zähler] += Block_Bewegungskraft;
                    Block_Zähler--;
                } while (Block_Zähler >= 0);
            #endregion
            #region Items erhalten Bewegungskraft
            Block_Zähler = list_Typ_Items.Count - 1;
            do if (list_Typ_Items.Count > 0)
                {
                    list_x_Pos_Items[Block_Zähler] += Block_Bewegungskraft;
                    Block_Zähler--;
                } while (Block_Zähler >= 0);

            #endregion
            #region Gegner erhalten Bewegungskraft
            Block_Zähler = list_Typ_Enemys.Count - 1;
            do if (list_Typ_Enemys.Count > 0)
                {
                    list_x_Pos_Enemys[Block_Zähler] += Block_Bewegungskraft;
                    Block_Zähler--;
                } while (Block_Zähler >= 0);
            #endregion
            #region Malario fällt
            if (y_Pos_Malario < fall_Limit)
            {
                M_Jump = true;
                if (anziehungskraft < 15)
                {
                    anziehungskraft++;
                }
                M_Anziehungskraft = true;
            }
            #endregion
            #endregion
            #region Malario Boden Collision erkannt und behandelt
            else if (M_Anziehungskraft == true && y_Pos_Malario >= fall_Limit)
            {
                M_Jump = false;
                M_Anziehungskraft = false;
                anziehungskraft = 0;
                y_Pos_Malario = fall_Limit;
            }
            #endregion
            #region Sprungkraft wird angewändet
            if (M_Jump == true && M_Anziehungskraft == false)
            {
                M_Anziehungskraft = true;
                anziehungskraft = anziehungskraft_Steigen;
            }
            #endregion
            #region Malario Decken Collision erkannt und behandelt
            if (y_Pos_Malario <= sprung_Limit)
            {
                anziehungskraft = 1;
                y_Pos_Malario = sprung_Limit;
            }
            y_Pos_Malario += anziehungskraft;
            #endregion
            #region  Malario Animation
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
            #endregion
            #region Malariokollision mit Gegner
            int Zähler = 0;
            do if (list_Typ_Enemys.Count > 0)
                {
                    c_Above(x_Pos_Malario, y_Pos_Malario, 30, 28, list_x_Pos_Enemys[Zähler], list_y_Pos_Enemys[Zähler], 30, 32); //char_y_Koor >= obj_y_Koor
                    c_Underneath(x_Pos_Malario, y_Pos_Malario, 30, 30, list_x_Pos_Enemys[Zähler], list_y_Pos_Enemys[Zähler], 30, 64); //char_y_Koor + char_Höhe / 2 <= obj_y_Koor

                    if (x_Pos_Malario + 30 >= list_x_Pos_Enemys[Zähler] && x_Pos_Malario <= list_x_Pos_Enemys[Zähler] + 30 && y_Pos_Malario + 30 > list_y_Pos_Enemys[Zähler] && y_Pos_Malario < list_y_Pos_Enemys[Zähler])
                    {
                        if (list_Typ_Enemys[Zähler] == 0)
                        {
                            kill_Gegner(Zähler);
                            getöteteGegner_Counter++;
                            CoinCounter += 5;
                        }
                        else if (list_Typ_Enemys[Zähler] == 2 && M_unkillable >= 100 || list_Typ_Enemys[Zähler] == 3 && M_unkillable >= 100)
                        {
                            M_Lives--;
                            M_unkillable = 0;
                        }
                        anziehungskraft = -8;

                    }
                    else if (x_Pos_Malario + 30 >= list_x_Pos_Enemys[Zähler] && x_Pos_Malario <= list_x_Pos_Enemys[Zähler] + 30 && y_Pos_Malario + 30 > list_y_Pos_Enemys[Zähler] + 32 && y_Pos_Malario < list_y_Pos_Enemys[Zähler] + 32)
                    {
                        if (list_Typ_Enemys[Zähler] == 0 && M_unkillable >= 100)
                        {
                            M_Lives--;
                            kill_Gegner(Zähler);
                        }
                        else if (list_Typ_Enemys[Zähler] == 2 && M_unkillable >= 100 || list_Typ_Enemys[Zähler] == 3 && M_unkillable >= 100)
                        {
                            M_Lives--;
                            M_unkillable = 0;
                        }
                    }
                    else if (y_Pos_Malario + 30 >= list_y_Pos_Enemys[Zähler] && y_Pos_Malario <= list_y_Pos_Enemys[Zähler] + 32 && x_Pos_Malario + 30 > list_x_Pos_Enemys[Zähler] && x_Pos_Malario + 30 < list_x_Pos_Enemys[Zähler] + 30)
                    {
                        if (list_Typ_Enemys[Zähler] == 0 && M_unkillable >= 100)
                        {
                            M_Lives--;
                            kill_Gegner(Zähler);
                        }
                        else if (list_Typ_Enemys[Zähler] == 2 && M_unkillable >= 100 || list_Typ_Enemys[Zähler] == 3 && M_unkillable >= 100)
                        {
                            M_Lives--;
                            M_unkillable = 0;
                        }
                    }
                    else if (y_Pos_Malario + 30 >= list_y_Pos_Enemys[Zähler] && y_Pos_Malario <= list_y_Pos_Enemys[Zähler] + 32 && x_Pos_Malario + 30 > list_x_Pos_Enemys[Zähler] + 30 && x_Pos_Malario < list_x_Pos_Enemys[Zähler])
                    {
                        if (list_Typ_Enemys[Zähler] == 0 && M_unkillable >= 100)
                        {
                            M_Lives--;
                            kill_Gegner(Zähler);
                        }
                        else if (list_Typ_Enemys[Zähler] == 2 && M_unkillable >= 100 || list_Typ_Enemys[Zähler] == 3 && M_unkillable >= 100)
                        {
                            M_Lives--;
                            M_unkillable = 0;
                        }
                    }
                    Zähler++;
                } while (Zähler < list_x_Pos_Enemys.Count);
            #endregion
            #endregion
            #region Items
            #region Laser
            #region Laser Animation
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
            #region Laser Kollision mit Gegnern

            UnderneathValue0 = 600;
            UnderneathValue1 = 600;
            RightValue0 = 960;
            RightValue1 = 960;
            LeftValue0 = -480;
            LeftValue1 = -480;
            int n = 0;
            do if (list_Typ_Enemys.Count > 0 )
                {
                    C_Above = false;
                    C_Underneath = false;
                    C_Right = false;
                    C_Left = false;
                    c_Above(x_Pos_Malario, y_Pos_Malario, 30, 30, list_x_Pos_Enemys[n], list_y_Pos_Enemys[n], 30, 32);
                    c_Underneath(x_Pos_Malario, y_Pos_Malario, 30, 30, list_x_Pos_Enemys[n], list_y_Pos_Enemys[n], 30, 32);

                    //Mario links vom gegner
                    if (x_Pos_Malario + 30 +nextBlock >= list_x_Pos_Enemys[n] && x_Pos_Malario <= list_x_Pos_Enemys[n] +30 && y_Pos_Malario <= list_y_Pos_Enemys[n] + 32 && y_Pos_Malario+30 >= list_y_Pos_Enemys[n])
                    {
                        if (M_Richtung == false && I_LaserAnimation == true)
                        {
                            kill_Gegner(n);
                            CoinCounter += 5;
                            getöteteGegner_Counter++;
                        }
                    }
                    //mario rechts vom gegmer
                    else if ( x_Pos_Malario - nextBlock <= list_x_Pos_Enemys[n] + 30 && y_Pos_Malario <= list_y_Pos_Enemys[n] + 32 && y_Pos_Malario + 30 >= list_y_Pos_Enemys[n])
                    {
                        if (M_Richtung == true && I_LaserAnimation == true)
                        {
                            kill_Gegner(n);
                            CoinCounter += 5;
                            getöteteGegner_Counter++;
                        }

                    }
                    
                    n++;
                } while (n < list_Typ_Enemys.Count);
            #endregion
            #region Laser Reichweite bestimmen

            if (M_Richtung == false)
            {
                nextBlock = rightlimit - x_Pos_Malario - 27;
            }
            else if (M_Richtung == true)
            {

                nextBlock = (x_Pos_Malario - leftlimit);
            }

            #endregion
            #endregion
            #region Energy Drink
            if (I_Energy == true)
            {
                M_Laufgeschwindigkeit = 9;
            }
            else if (I_Energy == false)
            {
                M_Laufgeschwindigkeit = 6;
            }
            #endregion
            #region Item Kollisions
            UnderneathValue0 = 600;
            UnderneathValue1 = 600;
            RightValue0 = 960;
            RightValue1 = 960;
            LeftValue0 = -480;
            LeftValue1 = -480;
            n = 0;
            do if (list_Typ_Items.Count > 0)
                {
                    C_Above = false;
                    C_Underneath = false;
                    C_Right = false;
                    C_Left = false;
                    c_Above(list_x_Pos_Items[n], list_y_Pos_Items[n], 24, 24, x_Pos_Malario, y_Pos_Malario, 30, 30);
                    c_Underneath(list_x_Pos_Items[n], list_y_Pos_Items[n], 24, 24, x_Pos_Malario, y_Pos_Malario, 30, 30);


                    if (x_Pos_Malario + 30 >= list_x_Pos_Items[n] && x_Pos_Malario <= list_x_Pos_Items[n] + 30 && y_Pos_Malario + 30 > list_y_Pos_Items[n] && y_Pos_Malario < list_y_Pos_Items[n])
                    {
                        if (list_Typ_Items[n] == 0)
                        {
                            CoinCounter++;
                        }
                        if (list_Typ_Items[n] == 1)
                        {
                            I_Energy = true;
                        }
                        if (list_Typ_Items[n] == 2)
                        {
                            I_Laser = true;
                        }
                        if (list_Typ_Items[n] == 3)
                        {
                            M_Lives++;
                        }
                        list_y_Pos_Items.RemoveAt(n);
                        list_x_Pos_Items.RemoveAt(n);
                        list_Typ_Items.RemoveAt(n);
                    }
                    else if (x_Pos_Malario + 30 >= list_x_Pos_Items[n] && x_Pos_Malario <= list_x_Pos_Items[n] + 30 && y_Pos_Malario + 30 > list_y_Pos_Items[n] + 32 && y_Pos_Malario < list_y_Pos_Items[n] + 32)
                    {
                        if (list_Typ_Items[n] == 0)
                        {
                            CoinCounter++;
                        }
                        if (list_Typ_Items[n] == 1)
                        {
                            I_Energy = true;
                        }
                        if (list_Typ_Items[n] == 2)
                        {
                            I_Laser = true;
                        }
                        if (list_Typ_Items[n] == 3)
                        {
                            M_Lives++;
                        }
                        list_y_Pos_Items.RemoveAt(n);
                        list_x_Pos_Items.RemoveAt(n);
                        list_Typ_Items.RemoveAt(n);
                    }
                    else if (y_Pos_Malario + 30 >= list_y_Pos_Items[n] && y_Pos_Malario <= list_y_Pos_Items[n] + 32 && x_Pos_Malario + 30 > list_x_Pos_Items[n] && x_Pos_Malario + 30 < list_x_Pos_Items[n] + 30)
                    {
                        if (list_Typ_Items[n] == 0)
                        {
                            CoinCounter++;
                        }
                        if (list_Typ_Items[n] == 1)
                        {
                            I_Energy = true;
                        }
                        if (list_Typ_Items[n] == 2)
                        {
                            I_Laser = true;
                        }
                        if (list_Typ_Items[n] == 3)
                        {
                            M_Lives++;
                        }
                        list_y_Pos_Items.RemoveAt(n);
                        list_x_Pos_Items.RemoveAt(n);
                        list_Typ_Items.RemoveAt(n);
                    }
                    else if (y_Pos_Malario + 30 >= list_y_Pos_Items[n] && y_Pos_Malario <= list_y_Pos_Items[n] + 32 && x_Pos_Malario + 30 > list_x_Pos_Items[n] + 30 && x_Pos_Malario < list_x_Pos_Items[n])
                    {
                        if (list_Typ_Items[n] == 0)
                        {
                            CoinCounter++;
                        }
                        if (list_Typ_Items[n] == 1)
                        {
                            I_Energy = true;
                        }
                        if (list_Typ_Items[n] == 2)
                        {
                            I_Laser = true;
                        }
                        if (list_Typ_Items[n] == 3)
                        {
                            M_Lives++;
                        }
                        list_y_Pos_Items.RemoveAt(n);
                        list_x_Pos_Items.RemoveAt(n);
                        list_Typ_Items.RemoveAt(n);
                    }
                    n++;

                } while (n < list_Typ_Items.Count);
            #endregion
            #endregion
            #region Leben
            #region Malario stirbt (respawn)
            if (M_Lives == 0)
            {
                M_Lives = 3;
                CoinCounter = 0;
                getöteteGegner_Counter = 0;
                laufzähler = 1920;
                x_Pos_Malario = 48;
                y_Pos_Malario = 397;
                list_x_Pos_Obj.Clear();
                list_y_Pos_Obj.Clear();
                list_Typ_Obj.Clear();
                list_x_Pos_Items.Clear();
                list_y_Pos_Items.Clear();
                list_Typ_Items.Clear();
                list_x_Pos_Enemys.Clear();
                list_y_Pos_Enemys.Clear();
                list_Typ_Enemys.Clear();
                list_RichtungLinks_Enemys.Clear();
                M_Lives = 3;
                Startbildschirm = true;
                M_Right = false;
                M_Left = false;
                M_Richtung = false;
                M_Jump = false;
                Startbildschirm = true;
                M_Gehend = false;
                M_Anziehungskraft = false;
                Goethe_AnziehungskraftBool = true;
                C_Right = false;
                C_Left = false;
                C_Above = false;
                C_Underneath = false;
                I_Energy = false;
                I_Laser = false;
                I_LaserActive = false;
                I_LaserAnimation = false;
                M_Bewegungskraft = 0;
                Block_Bewegungskraft = 0;
                anziehungskraft = 0;
                anziehungskraft_Steigen = -15;
                x_Pos_Block = 0;
                y_Pos_Block = 0;
                fall_Limit = 480;
                sprung_Limit = 0;
                rightlimit = 480;
                leftlimit = 0;
                M_Laufgeschwindigkeit = 6;
                Goethe_Geschwindigkeit = 3;
                list_Anziehungskraft_Enemys.Clear();
                nextBlock = 0;
                M_Lives = 3;
                CoinCounter = 0;
                bodenhöhe = 432;
            }
            #endregion
            #region Malario stirbt durch zu tiefes fallen
            if (y_Pos_Malario >= 550)
            {
                M_Lives = 0;
            }
            #endregion
            #endregion
            #region Gegner

            //nach Rechts bewegen = false
            //nach Links bewegen = true
            interwall_GegnerSpawner += 3;
            interwall_RöhrenLaser += 2;
            M_unkillable += 3;
            i = 0;
            int j = 0;
            bool Interwall_GegnerSpawner_zurücksetzen = false;
            bool Interwall_RöhrenLaser_zurücksetzen = false;
            do if (list_Typ_Enemys.Count > 0)
                {
                    UnderneathValue0 = 6000;
                    UnderneathValue1 = 6000;
                    RightValue0 = 9600;
                    RightValue1 = 9600;
                    LeftValue0 = -4800;
                    LeftValue1 = -4800;
                    i = 0;
                    #region Kollisionsabfragen des Gegners j
                    do if (list_Typ_Enemys.Count > 0)
                        {
                            C_Underneath = false;
                            C_Right = false;
                            C_Left = false;
                            c_Right(list_x_Pos_Enemys[j], list_y_Pos_Enemys[j], 32, 32, list_x_Pos_Obj[i], list_y_Pos_Obj[i], 24, 24);
                            c_Left(list_x_Pos_Enemys[j], list_y_Pos_Enemys[j], 32, 32, list_x_Pos_Obj[i], list_y_Pos_Obj[i], 24, 24);
                            c_Underneath(list_x_Pos_Enemys[j], list_y_Pos_Enemys[j], 32, 32, list_x_Pos_Obj[i], list_y_Pos_Obj[i], 24, 24);
                            if (C_Underneath == true)
                            {
                                UnderneathValue1 = list_y_Pos_Obj[i] - 20;
                                if (UnderneathValue0 > UnderneathValue1) UnderneathValue0 = UnderneathValue1;
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
                    //Die jeweiligen Limits werden gespeichert für 
                    //die Weiterverarbeitung der Bewegungen des Gegners j
                    fall_Limit = UnderneathValue0 - 34;
                    rightlimit = RightValue0;
                    leftlimit = LeftValue0;
                    #endregion
                    #region Gegner-Typ 0 alias Goethe
                    if (list_Typ_Enemys[j] == 0)
                    {
                        #region Rechts-Bewegungen von Goethe
                        if (list_RichtungLinks_Enemys[j] == false && list_x_Pos_Enemys[j] + 40 >= rightlimit)
                        {
                            list_RichtungLinks_Enemys[j] = true;
                        }
                        else if (list_RichtungLinks_Enemys[j] == false)
                        {
                            list_x_Pos_Enemys[j] += Goethe_Geschwindigkeit;
                        }
                        #endregion
                        #region Links-Bewegungen von Goethe
                        if (list_RichtungLinks_Enemys[j] == true && list_x_Pos_Enemys[j] <= leftlimit + 40)
                        {
                            list_RichtungLinks_Enemys[j] = false;
                        }
                        else if (list_RichtungLinks_Enemys[j] == true)
                        {
                            list_x_Pos_Enemys[j] -= Goethe_Geschwindigkeit;
                        }
                        #endregion
                        #region Goethe fällt
                        if (list_y_Pos_Enemys[j] <= fall_Limit && list_Anziehungskraft_Enemys[j] < 10)
                        {
                            list_Anziehungskraft_Enemys[j]++;
                        }
                        else if (list_y_Pos_Enemys[j] >= fall_Limit)
                        {
                            list_Anziehungskraft_Enemys[j] = 0;
                        }
                        list_y_Pos_Enemys[j] += list_Anziehungskraft_Enemys[j];
                        #endregion
                        #region Todesbedingungen
                        if (list_y_Pos_Enemys[j] >= 500)
                        {
                            kill_Gegner(j);
                        }
                        #endregion
                    }
                    #endregion
                    #region Gegner-Typ 1 GegnerSpawner
                    else if (list_Typ_Enemys[j] == 1 && interwall_GegnerSpawner >= 300)
                    {
                        Interwall_GegnerSpawner_zurücksetzen = true;
                        generiert_Gegner(0, list_x_Pos_Enemys[j], list_y_Pos_Enemys[j], list_RichtungLinks_Enemys[j]);
                    }
                    #endregion
                    #region Gegner-Typ 2 RöhrenLaser
                    else if (list_Typ_Enemys[j] == 2 && interwall_RöhrenLaser >= 300)
                    {
                        Interwall_RöhrenLaser_zurücksetzen = true;
                        if (RöhrenLaser_ist_da == true)
                        {
                            list_y_Pos_Enemys[j] += 960;
                            RöhrenLaser_ist_da = false;
                        }
                        else if(RöhrenLaser_ist_da == false)
                        {
                            list_y_Pos_Enemys[j] -= 960;
                            RöhrenLaser_ist_da = true;
                        }
                    }
                    #endregion
                    #region Gegner-Typ 3 CollisionsPlatzhalter
                    else if (list_Typ_Enemys[j] == 3 && interwall_RöhrenLaser >= 300)
                    {
                        Interwall_RöhrenLaser_zurücksetzen = true;
                        if (RöhrenLaser_ist_da == true)
                        {
                            list_y_Pos_Enemys[j] += 960;
                            RöhrenLaser_ist_da = false;
                        }
                        else if (RöhrenLaser_ist_da == false)
                        {
                            list_y_Pos_Enemys[j] -= 960;
                            RöhrenLaser_ist_da = true;
                        }
                    }
                    #endregion
                    j++;
                } while (j < list_Typ_Enemys.Count);
            if (Interwall_GegnerSpawner_zurücksetzen == true) interwall_GegnerSpawner = 0;
            if (Interwall_RöhrenLaser_zurücksetzen == true) interwall_RöhrenLaser = 0;
            #endregion
            Invalidate();
        }
        private void malen_Startmenü()
        {
            x_Pos_Block = 0;
            y_Pos_Block = (this.Height - 39 - 48);
            generiert_Rechteck(-216, 0, 1, 20, 10);
            generiert_BodenAbschnitt(432, 960, 24);
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
            if (char_x_Koor >= obj_x_Koor + (obj_Breite / 2) && char_y_Koor + char_Höhe >= obj_y_Koor && char_y_Koor <= obj_y_Koor + obj_Höhe)
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
        //CollisionPunkt_Abfragen_Stop
        private void kill_Gegner(int j)
        {
            list_y_Pos_Enemys.RemoveAt(j);
            list_x_Pos_Enemys.RemoveAt(j);
            list_Typ_Enemys.RemoveAt(j);
            list_RichtungLinks_Enemys.RemoveAt(j);
        }
        private void generiert_Gegner(int Art, int x_Coor, int y_Coor, bool richtung)
        {
            list_y_Pos_Enemys.Add(y_Coor);
            list_x_Pos_Enemys.Add(x_Coor);
            list_Typ_Enemys.Add(Art);
            list_RichtungLinks_Enemys.Add(richtung);
            list_Anziehungskraft_Enemys.Add(0);
        }
        private void generiert_Item(int x_Coor, int y_Coor)
        {
            Random random = new Random();
            list_y_Pos_Items.Add(y_Coor);
            list_x_Pos_Items.Add(x_Coor);
            list_Typ_Items.Add(random.Next(-1, 3));
        }
        private void generiert_Coin(int x_Coor, int y_Coor)
        {
            list_y_Pos_Items.Add(y_Coor);
            list_x_Pos_Items.Add(x_Coor);
            list_Typ_Items.Add(0);
        }
        //LevelGenerator
        private void generiert_LevelAbschnitt()
        {
            if (laufzähler >= 960)
            {
                #region Randomisor
                Random random = new Random();
                int abstand_ist_da = random.Next(1, 2),
                    obj_vor_lücke = random.Next(0, 3),
                    obj_Höhe = random.Next(2, 3),
                    xabstand = random.Next(0, 3),
                    yabstand = random.Next(-2, 2),
                    lvlabschnitt_Art = random.Next(0, 2),
                    letzter_Block_x;
                #endregion
                int Zähler0 = 0, x_Value0 = 0, x_Value1 = 0;

                #region Letzter Block ermitteln (X-Coordinate)
                //Coordinaten des rechtesten Blockes ermitteln
                do if (list_x_Pos_Obj.Count > 0)
                    {
                        x_Value1 = list_x_Pos_Obj[Zähler0];
                        if (x_Value0 < x_Value1) x_Value0 = x_Value1;
                        Zähler0++;
                    } while (Zähler0 < list_x_Pos_Obj.Count);
                //x Position der letzten Blockreihe
                letzter_Block_x = x_Value0;
                #endregion
                if (abstand_ist_da == 1 && lvlGenerator_PipeLvl == false)
                {
                    #region Objekte vor den Lücken
                    #region Kein Objekt vor der Lücke
                    if (obj_vor_lücke == 0)
                    {
                        generiert_Rechteck(letzter_Block_x + 24, bodenhöhe, 1, (480 - bodenhöhe) / 24, 1);
                    }
                    letzter_Block_x += 24;
                    #endregion
                    #region Halbe Pyramide vor dem Graben
                    if (obj_vor_lücke == 1)
                    {
                        int pyramidenhöhe0 = 4 * 24;
                        if (yabstand >= 0)
                        {
                            pyramidenhöhe0 = ((yabstand + obj_Höhe) * 24);
                        }
                        generiert_Treppe(letzter_Block_x - pyramidenhöhe0, bodenhöhe - pyramidenhöhe0 - 24, 1, pyramidenhöhe0 / 24);
                        generiert_Rechteck(letzter_Block_x, bodenhöhe, 1, (480 - bodenhöhe) / 24, 1);
                        //letzter_Block_x += 24 * obj_Höhe;
                    }
                    #endregion
                    #region Röhre vor der Lücke
                    if (obj_vor_lücke == 2)
                    {
                        generiert_Rechteck(letzter_Block_x, bodenhöhe, 0, (480 - bodenhöhe) / 24, 1);
                        generiert_Röhre(bodenhöhe - (24 * obj_Höhe), 480, letzter_Block_x);
                    }
                    letzter_Block_x += 24;
                    #endregion
                    #region Rechteck vor der Lücke
                    if (obj_vor_lücke == 3)
                    {
                        generiert_Rechteck(letzter_Block_x - 144, bodenhöhe - 24 * obj_Höhe, 4, obj_Höhe, 1);
                        generiert_Rechteck(letzter_Block_x - 120, bodenhöhe - 24 * obj_Höhe, 0, obj_Höhe, 4);
                        generiert_Rechteck(letzter_Block_x - 24, bodenhöhe - 24 * obj_Höhe, 1, obj_Höhe + 4, 1);
                    }
                    #endregion
                    #endregion
                    #region Überprüft ob die neue Bodenhöhe im Gewünschten Bereich liegt, wenn nein dann wird er verändert
                    if (bodenhöhe + (24 * yabstand) < 408) yabstand = 1;
                    if (bodenhöhe + (yabstand * 24) > 456) yabstand = -1;
                    #endregion
                    #region Spalten Arten
                    if (yabstand == 0 || yabstand == 1) letzter_Block_x += 24 * 8;
                    else if (yabstand <= -1 && yabstand >= -3) letzter_Block_x += 24 * 7;
                    else if (yabstand >= 2 && yabstand <= 4) letzter_Block_x += 24 * 8;
                    else if (yabstand <= -5) letzter_Block_x += 24 * 4;
                    else if (yabstand <= -4) letzter_Block_x += 24 * 6;
                    else if (yabstand >= 5) letzter_Block_x += 24 * 8;
                    bodenhöhe += yabstand * 24;
                    #endregion
                    generiert_Rechteck(letzter_Block_x, bodenhöhe, 1, (480 - bodenhöhe) / 24, 1);
                    letzter_Block_x += 24;
                }
                #region Levelarten
                #region Leveltyp 1
                if (lvlabschnitt_Art == 0)
                {
                    int Blockbreite = random.Next(1, 6),
                        BlockAbstand = random.Next(1, 4);
                    generiert_BodenAbschnitt(bodenhöhe, 24 * 20, letzter_Block_x);
                    generiert_BodenAbschnitt(bodenhöhe, 24 * 16, letzter_Block_x + (24 * 24));
                    #region  Rechteck am Anfang
                    generiert_Rechteck(letzter_Block_x + 24, bodenhöhe - 96, 4, 4, 1);
                    generiert_Rechteck(letzter_Block_x + 48, bodenhöhe - 96, 0, 4, 4);
                    generiert_Rechteck(letzter_Block_x + 144, bodenhöhe - 96, 4, 4, 1);
                    #endregion
                    #region Ebene 1
                    generiert_Rechteck(letzter_Block_x + 240, bodenhöhe - 120, 4, 1, Blockbreite + 1 * 2);
                    generiert_Rechteck(letzter_Block_x + 504 + 24, bodenhöhe - 120, 4, 1, Blockbreite + (12 - Blockbreite));
                    #endregion
                    #region Ebene 2
                    generiert_Rechteck(letzter_Block_x - 24, bodenhöhe - 240, 4, 1, 6);
                    Blockbreite = 6 - Blockbreite + 1;
                    generiert_Rechteck(letzter_Block_x + 240 + (24 * BlockAbstand), bodenhöhe - 216, 4, 1, Blockbreite + 1 * 2);
                    generiert_Rechteck(letzter_Block_x + 240 + (24 * (Blockbreite + 6)), bodenhöhe - 216, 4, 1, 1);
                    generiert_Rechteck(letzter_Block_x + 504 + (24 * (BlockAbstand + 5)), bodenhöhe - 216, 4, 1, Blockbreite + (4 - Blockbreite));
                    #endregion
                    #region Ebene 3
                    generiert_Rechteck(letzter_Block_x - 24, bodenhöhe - 240, 4, 1, 6);
                    Blockbreite = 6 - Blockbreite + 1;
                    generiert_Rechteck(letzter_Block_x + 144 + (24 * BlockAbstand), bodenhöhe - 312, 4, 1, 4 + (Blockbreite));
                    generiert_Rechteck(letzter_Block_x + 144 + (24 * BlockAbstand), bodenhöhe - 336, 4, 1, 1);
                    generiert_Rechteck(letzter_Block_x + 144 + (48 * (BlockAbstand + 2 + (Blockbreite))), bodenhöhe - 360, 4, 1, 6);
                    generiert_Item(letzter_Block_x + 144 + (48 * (BlockAbstand + 4 + (Blockbreite))), bodenhöhe - 360 - 24);
                    #endregion
                    #region Generiert GeistSpawner
                    generiert_Gegner(1, letzter_Block_x + 144 + (24 * BlockAbstand), -24, true);
                    generiert_Gegner(1, letzter_Block_x + 144 + (24 * BlockAbstand), -24, false);
                    #endregion
                    #region Generiert Coins
                    generiert_CoinRechteck(letzter_Block_x + 168, bodenhöhe - 96, 2, 10);
                    generiert_CoinRechteck(letzter_Block_x + 168 + (24 * BlockAbstand), bodenhöhe - 336, 1, 3 + (Blockbreite));
                    #endregion
                    lvlGenerator_PipeLvl = false;
                }
                #endregion
                #region Leveltyp 2
                else if (lvlabschnitt_Art == 1)
                {
                    generiert_Rechteck(letzter_Block_x, bodenhöhe, 1, (480 - bodenhöhe) / 24, 1);
                    generiert_Röhre(bodenhöhe, 480, letzter_Block_x);
                    int Zähler = 0;
                    Zähler0 = 1;
                    do
                    {
                        yabstand = random.Next(-4, 3);
                        #region Überprüft ob die neue Bodenhöhe im Gewünschten Bereich liegt, wenn nein dann wird er verändert
                        if (bodenhöhe + (24 * yabstand) < 200) yabstand = 1;
                        if (bodenhöhe + (yabstand * 24) > 456) yabstand = -1;
                        #endregion
                        #region Spalten Arten
                        if (yabstand == 0 || yabstand == 1) letzter_Block_x += 24 * 7;
                        else if (yabstand <= -1 && yabstand >= -3) letzter_Block_x += 24 * 6;
                        else if (yabstand >= 2 && yabstand <= 4) letzter_Block_x += 24 * 7;
                        else if (yabstand <= -4) letzter_Block_x += 48;
                        else if (yabstand >= 5) letzter_Block_x += 24 * 7;
                        bodenhöhe += yabstand * 24;
                        #endregion
                        #region Generiert sichere Insel
                        if (Zähler0 == random.Next(2, 3))
                        {
                            generiert_Rechteck(letzter_Block_x, bodenhöhe, 4, 1, 3);
                            generiert_CoinRechteck(letzter_Block_x, bodenhöhe - 24, 1, 3);
                            letzter_Block_x += 24 * 3;
                            Zähler0 = 0;
                        }
                        #endregion
                        else
                        {
                            generiert_Röhre(bodenhöhe, 480, letzter_Block_x);
                        }
                        Zähler0++;
                        Zähler += 48 + (24 * yabstand);
                    } while (Zähler <= 960);
                    generiert_Röhre(bodenhöhe, 480, letzter_Block_x);
                    lvlGenerator_PipeLvl = true;
                }
                #endregion
                #region Leveltyp 3
                else if (lvlabschnitt_Art == 2)
                {
                    bodenhöhe = 456;
                    #region Rahmen des Dungeons
                    generiert_Rechteck(letzter_Block_x + 120, 0, 5, 1, 1);
                    generiert_Rechteck(letzter_Block_x, bodenhöhe, 1, 1, 20);
                    generiert_Rechteck(letzter_Block_x + (24 * 25), bodenhöhe, 1, 1, 15);
                    generiert_Rechteck(letzter_Block_x + 120, 0, 1, 14, 2);
                    generiert_Rechteck(letzter_Block_x + 216, 0, 1, 1, 31);
                    generiert_Rechteck(letzter_Block_x + 912, 72, 1, 17, 2);
                    #endregion
                    #region  Rechteck am Anfang
                    generiert_Rechteck(letzter_Block_x, bodenhöhe - 72, 4, 3, 1);
                    generiert_Rechteck(letzter_Block_x + 24, bodenhöhe - 72, 1, 3, 5);
                    generiert_Rechteck(letzter_Block_x + 144, bodenhöhe - 48, 4, 2, 1);
                    #endregion
                    #region Erste Ebene
                    generiert_Rechteck(letzter_Block_x + 144, bodenhöhe - 72, 1, 1, 4);
                    generiert_CoinRechteck(letzter_Block_x + +(24 * 25), bodenhöhe - 96, 4, 5);
                    #endregion
                    #region Zweite Ebene
                    generiert_Rechteck(letzter_Block_x + 312, bodenhöhe - 168 + 24, 1, 1, 25);
                    generiert_CoinRechteck(letzter_Block_x + 240, bodenhöhe - 336, 2, 20);
                    #endregion
                    #region Dritte Ebene
                    generiert_Rechteck(letzter_Block_x + 168, bodenhöhe - 288 + 24, 1, 1, 28);
                    generiert_CoinRechteck(letzter_Block_x + 240, bodenhöhe - 216, 2, 20);
                    #endregion
                    #region Vierte Ebene
                    generiert_Rechteck(letzter_Block_x + 240, bodenhöhe - 408 + 24, 1, 1, 28);
                    generiert_CoinRechteck(letzter_Block_x + 336, bodenhöhe - 432, 2, 10);
                    #endregion
                    #region Generiert GeistSpawner
                    generiert_Gegner(1, letzter_Block_x + 216, -24, true);
                    #endregion
                }
                #endregion
                #endregion
                letzter_Block_x += 24 * 40;
                laufzähler -= 960;
            }
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
                y_Pos_Block = röhren_Höhe,
                Zähler0 = 0;
            #region Generiert RöhrenLaser

            generiert_Gegner(2, x_Pos_Block, y_Pos_Block, false);
            do
            {
                generiert_Gegner(3, x_Pos_Block, y_Pos_Block, false);
                generiert_Gegner(3, x_Pos_Block + 24, y_Pos_Block, false);
                y_Pos_Block -= 24;
                Zähler0++;
            } while (Zähler0 >= 20);
            #endregion
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
                    list_Typ_Obj.Add(blockArt);
                    list_x_Pos_Obj.Add(x_Pos_Block);
                    list_y_Pos_Obj.Add(y_Pos_Block);
                    y_Pos_Block += 24;
                    Zähler0++;
                } while (Zähler0 < block_Höhe);
                y_Pos_Block -= 24 * block_Höhe;
                x_Pos_Block += 24;
                Zähler1++;
            } while (Zähler1 < block_Breite);
        }
        private void generiert_CoinRechteck(int x_Coor, int y_Choor, int block_Höhe, int block_Breite)
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
                    generiert_Coin(x_Pos_Block, y_Pos_Block);
                    y_Pos_Block += 24;
                    Zähler0++;
                } while (Zähler0 < block_Höhe);
                y_Pos_Block -= 24 * block_Höhe;
                x_Pos_Block += 24;
                Zähler1++;
            } while (Zähler1 < block_Breite);
        }
        //Links = 1;0  ===  1=y;0=n
        private void generiert_Treppe(int x_Coor, int y_Choor, int Links, int treppen_Höhe)
        {
            int x_Pos_Block = x_Coor,
            y_Pos_Block = y_Choor,
            höhenZähler = 0,
            breitenZähler = 0;

            x_Pos_Block += (Links * 24 * treppen_Höhe);
            do
            {
                höhenZähler++;
                breitenZähler = 0;
                do
                {
                    list_Typ_Obj.Add(4);
                    list_x_Pos_Obj.Add(x_Pos_Block);
                    list_y_Pos_Obj.Add(y_Pos_Block);
                    x_Pos_Block += 24;

                    breitenZähler++;
                } while (breitenZähler < höhenZähler);
                y_Pos_Block += 24;
                x_Pos_Block += (-1 * 24 * (breitenZähler + Links));
            } while (höhenZähler <= treppen_Höhe);

        }

    }
}
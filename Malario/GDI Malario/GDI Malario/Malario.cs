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
    class Malario : Grundmethoden
    {
        public static void malen_Malario(Graphics graphics, int x_Pos_Malario, int y_Pos_Malario, bool Sichtrichtung, bool gehen_Animation)
        {
            int x_Bit_Multiplier0 = 2, y_Bit_Multiplier0 = 2;
            Color füllfarbe = Color.GreenYellow;
            Color stiftfarbe = Color.GreenYellow;
            Grundmethoden grundmethoden = new Grundmethoden();

            if (Sichtrichtung == true)
            {
                //Körper_Stehend_Links_Gelb
                if (gehen_Animation == true)
                {
                    x_Pos_Malario += (2 * x_Bit_Multiplier0);
                    y_Pos_Malario += (2 * y_Bit_Multiplier0);
                }
                else
                {
                    x_Pos_Malario += (2 * x_Bit_Multiplier0);
                    y_Pos_Malario += (3 * y_Bit_Multiplier0);
                }
                grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 7 * x_Bit_Multiplier0, 10 * y_Bit_Multiplier0);
                x_Pos_Malario += (7 * x_Bit_Multiplier0);
                y_Pos_Malario -= (1 * y_Bit_Multiplier0);
                grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 3 * x_Bit_Multiplier0, 10 * y_Bit_Multiplier0);
                x_Pos_Malario -= (3 * x_Bit_Multiplier0);
                grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 8 * x_Bit_Multiplier0, 2 * y_Bit_Multiplier0);
                x_Pos_Malario -= (5 * x_Bit_Multiplier0);
                y_Pos_Malario += (4 * y_Bit_Multiplier0);
                grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 12 * x_Bit_Multiplier0, 2 * y_Bit_Multiplier0);

                //Körper_Stehend_Links_Schwarz
                füllfarbe = Color.Black;
                stiftfarbe = Color.Black;
                //Auge
                x_Pos_Malario += (2 * x_Bit_Multiplier0);
                y_Pos_Malario -= (1 * y_Bit_Multiplier0);
                grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 1 * x_Bit_Multiplier0, 1 * y_Bit_Multiplier0);
                //Hand
                y_Pos_Malario += (4 * y_Bit_Multiplier0);
                grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 1 * x_Bit_Multiplier0, 2 * y_Bit_Multiplier0);
                x_Pos_Malario += (1 * x_Bit_Multiplier0);
                y_Pos_Malario += (1 * y_Bit_Multiplier0);
                grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 1 * x_Bit_Multiplier0, 1 * y_Bit_Multiplier0);

                x_Pos_Malario -= (3 * x_Bit_Multiplier0);
                y_Pos_Malario -= (2 * y_Bit_Multiplier0);
                grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 1 * x_Bit_Multiplier0, 4 * y_Bit_Multiplier0);
                x_Pos_Malario += (1 * x_Bit_Multiplier0);
                y_Pos_Malario += (4 * y_Bit_Multiplier0);
                grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 2 * x_Bit_Multiplier0, 1 * y_Bit_Multiplier0);
                x_Pos_Malario += (2 * x_Bit_Multiplier0);
                y_Pos_Malario += (1 * y_Bit_Multiplier0);
                grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 3 * x_Bit_Multiplier0, 1 * y_Bit_Multiplier0);
                x_Pos_Malario += (3 * x_Bit_Multiplier0);
                y_Pos_Malario -= (1 * y_Bit_Multiplier0);
                grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 2 * x_Bit_Multiplier0, 1 * y_Bit_Multiplier0);
                x_Pos_Malario += (2 * x_Bit_Multiplier0);
                y_Pos_Malario -= (1 * y_Bit_Multiplier0);
                grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 3 * x_Bit_Multiplier0, 1 * y_Bit_Multiplier0);
                x_Pos_Malario += (3 * x_Bit_Multiplier0);
                y_Pos_Malario -= (1 * y_Bit_Multiplier0);
                grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 1 * x_Bit_Multiplier0, 1 * y_Bit_Multiplier0);
                x_Pos_Malario += (1 * x_Bit_Multiplier0);
                y_Pos_Malario -= (1 * y_Bit_Multiplier0);
                grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 1 * x_Bit_Multiplier0, 1 * y_Bit_Multiplier0);
                x_Pos_Malario -= (1 * x_Bit_Multiplier0);
                y_Pos_Malario -= (1 * y_Bit_Multiplier0);
                grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 1 * x_Bit_Multiplier0, 1 * y_Bit_Multiplier0);
                x_Pos_Malario += (1 * x_Bit_Multiplier0);
                y_Pos_Malario -= (2 * y_Bit_Multiplier0);
                grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 1 * x_Bit_Multiplier0, 2 * y_Bit_Multiplier0);
                x_Pos_Malario -= (1 * x_Bit_Multiplier0);
                y_Pos_Malario -= (0 * y_Bit_Multiplier0);
                grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 1 * x_Bit_Multiplier0, 1 * y_Bit_Multiplier0);
                x_Pos_Malario -= (1 * x_Bit_Multiplier0);
                y_Pos_Malario -= (1 * y_Bit_Multiplier0);
                grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 1 * x_Bit_Multiplier0, 2 * y_Bit_Multiplier0);
                x_Pos_Malario += (1 * x_Bit_Multiplier0);
                y_Pos_Malario -= (1 * y_Bit_Multiplier0);
                grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 1 * x_Bit_Multiplier0, 1 * y_Bit_Multiplier0);
                x_Pos_Malario += (1 * x_Bit_Multiplier0);
                y_Pos_Malario -= (1 * y_Bit_Multiplier0);
                grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 1 * x_Bit_Multiplier0, 1 * y_Bit_Multiplier0);
                x_Pos_Malario += (1 * x_Bit_Multiplier0);
                y_Pos_Malario -= (2 * y_Bit_Multiplier0);
                grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 1 * x_Bit_Multiplier0, 2 * y_Bit_Multiplier0);
                x_Pos_Malario -= (8 * x_Bit_Multiplier0);
                y_Pos_Malario -= (0 * y_Bit_Multiplier0);
                grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 8 * x_Bit_Multiplier0, 1 * y_Bit_Multiplier0);
                x_Pos_Malario += (2 * x_Bit_Multiplier0);
                y_Pos_Malario -= (1 * y_Bit_Multiplier0);
                grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 2 * x_Bit_Multiplier0, 1 * y_Bit_Multiplier0);
                //Innen_Hinten
                x_Pos_Malario -= (1 * x_Bit_Multiplier0);
                y_Pos_Malario += (2 * y_Bit_Multiplier0);
                grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 3 * x_Bit_Multiplier0, 1 * y_Bit_Multiplier0);
                x_Pos_Malario += (1 * x_Bit_Multiplier0);
                y_Pos_Malario += (1 * y_Bit_Multiplier0);
                grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 1 * x_Bit_Multiplier0, 2 * y_Bit_Multiplier0);
                x_Pos_Malario -= (1 * x_Bit_Multiplier0);
                y_Pos_Malario += (1 * y_Bit_Multiplier0);
                grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 1 * x_Bit_Multiplier0, 2 * y_Bit_Multiplier0);
                x_Pos_Malario += (1 * x_Bit_Multiplier0);
                y_Pos_Malario += (2 * y_Bit_Multiplier0);
                grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 1 * x_Bit_Multiplier0, 2 * y_Bit_Multiplier0);
                //Rest_Außen
                x_Pos_Malario -= (5 * x_Bit_Multiplier0);
                y_Pos_Malario -= (4 * y_Bit_Multiplier0);
                grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 3 * x_Bit_Multiplier0, 1 * y_Bit_Multiplier0);
                x_Pos_Malario -= (1 * x_Bit_Multiplier0);
                y_Pos_Malario += (1 * y_Bit_Multiplier0);
                grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 1 * x_Bit_Multiplier0, 1 * y_Bit_Multiplier0);
                x_Pos_Malario -= (1 * x_Bit_Multiplier0);
                y_Pos_Malario += (1 * y_Bit_Multiplier0);
                grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 1 * x_Bit_Multiplier0, 2 * y_Bit_Multiplier0);
                x_Pos_Malario -= (1 * x_Bit_Multiplier0);
                y_Pos_Malario += (2 * y_Bit_Multiplier0);
                grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 1 * x_Bit_Multiplier0, 2 * y_Bit_Multiplier0);
                //Roter Wangenpunkt
                füllfarbe = Color.DarkBlue;
                stiftfarbe = Color.DarkBlue;
                x_Pos_Malario += (5 * x_Bit_Multiplier0);
                y_Pos_Malario += (1 * y_Bit_Multiplier0);
                grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 1 * x_Bit_Multiplier0, 1 * y_Bit_Multiplier0);
                //Browner Schweif
                füllfarbe = Color.Brown;
                stiftfarbe = Color.Brown;
                x_Pos_Malario += (2 * x_Bit_Multiplier0);
                y_Pos_Malario += (1 * y_Bit_Multiplier0);
                grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 5 * x_Bit_Multiplier0, 1 * y_Bit_Multiplier0);
                x_Pos_Malario += (0 * x_Bit_Multiplier0);
                y_Pos_Malario += (2 * y_Bit_Multiplier0);
                grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 5 * x_Bit_Multiplier0, 1 * y_Bit_Multiplier0);
                x_Pos_Malario += (2 * x_Bit_Multiplier0);
                y_Pos_Malario -= (1 * y_Bit_Multiplier0);
                grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 4 * x_Bit_Multiplier0, 1 * y_Bit_Multiplier0);


                if (gehen_Animation == true)
                {

                    füllfarbe = Color.GreenYellow;
                    stiftfarbe = Color.GreenYellow;
                    x_Pos_Malario -= (8 * x_Bit_Multiplier0);
                    y_Pos_Malario += (3 * y_Bit_Multiplier0);
                    grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 10 * x_Bit_Multiplier0, 1 * y_Bit_Multiplier0);
                    x_Pos_Malario += (7 * x_Bit_Multiplier0);
                    y_Pos_Malario += (1 * y_Bit_Multiplier0);
                    grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 2 * x_Bit_Multiplier0, 1 * y_Bit_Multiplier0);
                    //Schwarz
                    füllfarbe = Color.Black;
                    stiftfarbe = Color.Black;
                    x_Pos_Malario -= (0 * x_Bit_Multiplier0);
                    y_Pos_Malario += (1 * y_Bit_Multiplier0);
                    grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 2 * x_Bit_Multiplier0, 1 * y_Bit_Multiplier0);
                    x_Pos_Malario += (2 * x_Bit_Multiplier0);
                    y_Pos_Malario -= (1 * y_Bit_Multiplier0);
                    grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 1 * x_Bit_Multiplier0, 1 * y_Bit_Multiplier0);
                    x_Pos_Malario += (1 * x_Bit_Multiplier0);
                    y_Pos_Malario -= (1 * y_Bit_Multiplier0);
                    grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 1 * x_Bit_Multiplier0, 1 * y_Bit_Multiplier0);
                    x_Pos_Malario -= (3 * x_Bit_Multiplier0);
                    y_Pos_Malario -= (0 * y_Bit_Multiplier0);
                    grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 2 * x_Bit_Multiplier0, 1 * y_Bit_Multiplier0);
                    x_Pos_Malario -= (4 * x_Bit_Multiplier0);
                    y_Pos_Malario += (1 * y_Bit_Multiplier0);
                    grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 4 * x_Bit_Multiplier0, 1 * y_Bit_Multiplier0);
                    x_Pos_Malario -= (1 * x_Bit_Multiplier0);
                    y_Pos_Malario -= (1 * y_Bit_Multiplier0);
                    grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 1 * x_Bit_Multiplier0, 1 * y_Bit_Multiplier0);
                    x_Pos_Malario -= (2 * x_Bit_Multiplier0);
                    y_Pos_Malario += (1 * y_Bit_Multiplier0);
                    grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 2 * x_Bit_Multiplier0, 1 * y_Bit_Multiplier0);
                    x_Pos_Malario -= (1 * x_Bit_Multiplier0);
                    y_Pos_Malario -= (1 * y_Bit_Multiplier0);
                    grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 1 * x_Bit_Multiplier0, 1 * y_Bit_Multiplier0);
                    x_Pos_Malario += (1 * x_Bit_Multiplier0);
                    y_Pos_Malario -= (1 * y_Bit_Multiplier0);
                    grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 2 * x_Bit_Multiplier0, 1 * y_Bit_Multiplier0);

                }
            }
            else
            {
                //RECHTS
                //Körper_Stehend_Rechts_Gelb
                füllfarbe = Color.GreenYellow;
                stiftfarbe = Color.GreenYellow;

                if (gehen_Animation == true)
                {
                    x_Pos_Malario += (5 * x_Bit_Multiplier0);
                    y_Pos_Malario += (2 * y_Bit_Multiplier0);
                }
                else
                {
                    x_Pos_Malario += (5 * x_Bit_Multiplier0);
                    y_Pos_Malario += (3 * y_Bit_Multiplier0);
                }
                grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 7 * x_Bit_Multiplier0, 10 * y_Bit_Multiplier0);
                x_Pos_Malario -= (4 * x_Bit_Multiplier0);
                y_Pos_Malario -= (0 * y_Bit_Multiplier0);
                grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 4 * x_Bit_Multiplier0, 2 * y_Bit_Multiplier0);
                x_Pos_Malario -= (1 * x_Bit_Multiplier0);
                y_Pos_Malario -= (1 * y_Bit_Multiplier0);
                grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 8 * x_Bit_Multiplier0, 1 * y_Bit_Multiplier0);
                x_Pos_Malario += (3 * x_Bit_Multiplier0);
                y_Pos_Malario += (3 * y_Bit_Multiplier0);
                grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 2 * x_Bit_Multiplier0, 1 * y_Bit_Multiplier0);
                x_Pos_Malario -= (2 * x_Bit_Multiplier0);
                y_Pos_Malario += (1 * y_Bit_Multiplier0);
                grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 12 * x_Bit_Multiplier0, 2 * y_Bit_Multiplier0);
                //Körper_Stehend_Rechts_Schwarz
                füllfarbe = Color.Black;
                stiftfarbe = Color.Black;
                x_Pos_Malario += (12 * x_Bit_Multiplier0);
                y_Pos_Malario += (0 * y_Bit_Multiplier0);
                grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 1 * x_Bit_Multiplier0, 2 * y_Bit_Multiplier0);
                x_Pos_Malario -= (3 * x_Bit_Multiplier0);
                y_Pos_Malario -= (1 * y_Bit_Multiplier0);
                grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 1 * x_Bit_Multiplier0, 1 * y_Bit_Multiplier0);
                x_Pos_Malario += (2 * x_Bit_Multiplier0);
                y_Pos_Malario += (3 * y_Bit_Multiplier0);
                grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 1 * x_Bit_Multiplier0, 4 * y_Bit_Multiplier0);
                x_Pos_Malario -= (3 * x_Bit_Multiplier0);
                y_Pos_Malario += (2 * y_Bit_Multiplier0);
                grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 2 * x_Bit_Multiplier0, 1 * y_Bit_Multiplier0);
                x_Pos_Malario += (1 * x_Bit_Multiplier0);
                y_Pos_Malario -= (1 * y_Bit_Multiplier0);
                grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 1 * x_Bit_Multiplier0, 1 * y_Bit_Multiplier0);
                x_Pos_Malario -= (0 * x_Bit_Multiplier0);
                y_Pos_Malario += (3 * y_Bit_Multiplier0);
                grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 2 * x_Bit_Multiplier0, 1 * y_Bit_Multiplier0);
                x_Pos_Malario -= (3 * x_Bit_Multiplier0);
                y_Pos_Malario += (1 * y_Bit_Multiplier0);
                grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 3 * x_Bit_Multiplier0, 1 * y_Bit_Multiplier0);
                x_Pos_Malario -= (2 * x_Bit_Multiplier0);
                y_Pos_Malario -= (1 * y_Bit_Multiplier0);
                grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 2 * x_Bit_Multiplier0, 1 * y_Bit_Multiplier0);
                x_Pos_Malario -= (3 * x_Bit_Multiplier0);
                y_Pos_Malario -= (1 * y_Bit_Multiplier0);
                grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 3 * x_Bit_Multiplier0, 1 * y_Bit_Multiplier0);
                x_Pos_Malario -= (1 * x_Bit_Multiplier0);
                y_Pos_Malario -= (1 * y_Bit_Multiplier0);
                grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 1 * x_Bit_Multiplier0, 1 * y_Bit_Multiplier0);
                x_Pos_Malario -= (1 * x_Bit_Multiplier0);
                y_Pos_Malario -= (1 * y_Bit_Multiplier0);
                grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 1 * x_Bit_Multiplier0, 1 * y_Bit_Multiplier0);
                x_Pos_Malario += (1 * x_Bit_Multiplier0);
                y_Pos_Malario -= (1 * y_Bit_Multiplier0);
                grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 1 * x_Bit_Multiplier0, 1 * y_Bit_Multiplier0);
                x_Pos_Malario -= (1 * x_Bit_Multiplier0);
                y_Pos_Malario -= (1 * y_Bit_Multiplier0);
                grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 1 * x_Bit_Multiplier0, 1 * y_Bit_Multiplier0);
                x_Pos_Malario -= (0 * x_Bit_Multiplier0);
                y_Pos_Malario -= (1 * y_Bit_Multiplier0);
                grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 3 * x_Bit_Multiplier0, 1 * y_Bit_Multiplier0);
                x_Pos_Malario += (2 * x_Bit_Multiplier0);
                y_Pos_Malario -= (1 * y_Bit_Multiplier0);
                grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 1 * x_Bit_Multiplier0, 1 * y_Bit_Multiplier0);
                x_Pos_Malario -= (1 * x_Bit_Multiplier0);
                y_Pos_Malario -= (1 * y_Bit_Multiplier0);
                grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 1 * x_Bit_Multiplier0, 1 * y_Bit_Multiplier0);
                x_Pos_Malario -= (1 * x_Bit_Multiplier0);
                y_Pos_Malario -= (1 * y_Bit_Multiplier0);
                grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 1 * x_Bit_Multiplier0, 1 * y_Bit_Multiplier0);
                x_Pos_Malario -= (1 * x_Bit_Multiplier0);
                y_Pos_Malario -= (1 * y_Bit_Multiplier0);
                grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 1 * x_Bit_Multiplier0, 1 * y_Bit_Multiplier0);
                x_Pos_Malario -= (0 * x_Bit_Multiplier0);
                y_Pos_Malario -= (1 * y_Bit_Multiplier0);
                grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 9 * x_Bit_Multiplier0, 1 * y_Bit_Multiplier0);
                x_Pos_Malario += (5 * x_Bit_Multiplier0);
                y_Pos_Malario -= (1 * y_Bit_Multiplier0);
                grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 2 * x_Bit_Multiplier0, 1 * y_Bit_Multiplier0);
                x_Pos_Malario += (0 * x_Bit_Multiplier0);
                y_Pos_Malario += (2 * y_Bit_Multiplier0);
                grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 3 * x_Bit_Multiplier0, 1 * y_Bit_Multiplier0);
                x_Pos_Malario += (1 * x_Bit_Multiplier0);
                y_Pos_Malario += (1 * y_Bit_Multiplier0);
                grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 1 * x_Bit_Multiplier0, 2 * y_Bit_Multiplier0);
                x_Pos_Malario += (1 * x_Bit_Multiplier0);
                y_Pos_Malario += (1 * y_Bit_Multiplier0);
                grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 1 * x_Bit_Multiplier0, 2 * y_Bit_Multiplier0);
                x_Pos_Malario -= (1 * x_Bit_Multiplier0);
                y_Pos_Malario += (2 * y_Bit_Multiplier0);
                grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 1 * x_Bit_Multiplier0, 2 * y_Bit_Multiplier0);
                x_Pos_Malario += (3 * x_Bit_Multiplier0);
                y_Pos_Malario -= (4 * y_Bit_Multiplier0);
                grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 3 * x_Bit_Multiplier0, 1 * y_Bit_Multiplier0);
                x_Pos_Malario += (3 * x_Bit_Multiplier0);
                y_Pos_Malario += (1 * y_Bit_Multiplier0);
                grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 1 * x_Bit_Multiplier0, 1 * y_Bit_Multiplier0);
                x_Pos_Malario += (1 * x_Bit_Multiplier0);
                y_Pos_Malario += (1 * y_Bit_Multiplier0);
                grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 1 * x_Bit_Multiplier0, 2 * y_Bit_Multiplier0);

                //Roter_Wangen_Punkt
                füllfarbe = Color.DarkBlue;
                stiftfarbe = Color.DarkBlue;

                x_Pos_Malario -= (4 * x_Bit_Multiplier0);
                y_Pos_Malario += (3 * y_Bit_Multiplier0);
                grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 1 * x_Bit_Multiplier0, 1 * y_Bit_Multiplier0);

                //Brauner_Schwanz
                füllfarbe = Color.Brown;
                stiftfarbe = Color.Brown;

                x_Pos_Malario -= (6 * x_Bit_Multiplier0);
                y_Pos_Malario += (1 * y_Bit_Multiplier0);
                grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 5 * x_Bit_Multiplier0, 1 * y_Bit_Multiplier0);
                x_Pos_Malario -= (1 * x_Bit_Multiplier0);
                y_Pos_Malario += (1 * y_Bit_Multiplier0);
                grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 4 * x_Bit_Multiplier0, 1 * y_Bit_Multiplier0);
                x_Pos_Malario += (1 * x_Bit_Multiplier0);
                y_Pos_Malario += (1 * y_Bit_Multiplier0);
                grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 5 * x_Bit_Multiplier0, 1 * y_Bit_Multiplier0);


                if (gehen_Animation == true)
                {
                    füllfarbe = Color.GreenYellow;
                    stiftfarbe = Color.GreenYellow;

                    x_Pos_Malario += (1 * x_Bit_Multiplier0);
                    y_Pos_Malario += (2 * y_Bit_Multiplier0);
                    grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 10 * x_Bit_Multiplier0, 1 * y_Bit_Multiplier0);
                    x_Pos_Malario += (1 * x_Bit_Multiplier0);
                    y_Pos_Malario += (1 * y_Bit_Multiplier0);
                    grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 2 * x_Bit_Multiplier0, 1 * y_Bit_Multiplier0);


                    füllfarbe = Color.Black;
                    stiftfarbe = Color.Black;
                    x_Pos_Malario += (0 * x_Bit_Multiplier0);
                    y_Pos_Malario -= (1 * y_Bit_Multiplier0);
                    grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 2 * x_Bit_Multiplier0, 1 * y_Bit_Multiplier0);
                    x_Pos_Malario -= (2 * x_Bit_Multiplier0);
                    y_Pos_Malario -= (0 * y_Bit_Multiplier0);
                    grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 1 * x_Bit_Multiplier0, 1 * y_Bit_Multiplier0);
                    x_Pos_Malario += (1 * x_Bit_Multiplier0);
                    y_Pos_Malario += (1 * y_Bit_Multiplier0);
                    grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 1 * x_Bit_Multiplier0, 1 * y_Bit_Multiplier0);
                    x_Pos_Malario += (1 * x_Bit_Multiplier0);
                    y_Pos_Malario += (1 * y_Bit_Multiplier0);
                    grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 2 * x_Bit_Multiplier0, 1 * y_Bit_Multiplier0);
                    x_Pos_Malario += (2 * x_Bit_Multiplier0);
                    y_Pos_Malario -= (1 * y_Bit_Multiplier0);
                    grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 4 * x_Bit_Multiplier0, 1 * y_Bit_Multiplier0);
                    x_Pos_Malario += (4 * x_Bit_Multiplier0);
                    y_Pos_Malario -= (1 * y_Bit_Multiplier0);
                    grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 1 * x_Bit_Multiplier0, 1 * y_Bit_Multiplier0);
                    x_Pos_Malario += (1 * x_Bit_Multiplier0);
                    y_Pos_Malario += (1 * y_Bit_Multiplier0);
                    grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 2 * x_Bit_Multiplier0, 1 * y_Bit_Multiplier0);
                    x_Pos_Malario += (2 * x_Bit_Multiplier0);
                    y_Pos_Malario -= (1 * y_Bit_Multiplier0);
                    grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 1 * x_Bit_Multiplier0, 1 * y_Bit_Multiplier0);
                    x_Pos_Malario -= (2 * x_Bit_Multiplier0);
                    y_Pos_Malario -= (1 * y_Bit_Multiplier0);
                    grundmethoden.malen_Bit(graphics, x_Pos_Malario, y_Pos_Malario, füllfarbe, stiftfarbe, 2 * x_Bit_Multiplier0, 1 * y_Bit_Multiplier0);

                }
            }
        }

        public static void malen_Banner(Graphics graphics, int x_Pos_Banner, int y_Pos_Banner)
        {
            int Bit_Multiplier0 = 4; //Pixelgröße definieren
            Color colour;
            Grundmethoden grundmethoden = new Grundmethoden();
            int xPos = x_Pos_Banner;
            int yPos = y_Pos_Banner;
            #region M_Letter
            colour = Color.SaddleBrown;
            grundmethoden.malen_Bit(graphics, xPos, yPos, colour, colour, 6 * Bit_Multiplier0, 15 * Bit_Multiplier0);
            yPos += 2 * Bit_Multiplier0;
            xPos += 6 * Bit_Multiplier0;
            grundmethoden.malen_Bit(graphics, xPos, yPos, colour, colour, 4 * Bit_Multiplier0, 7 * Bit_Multiplier0);
            yPos -= Bit_Multiplier0;
            grundmethoden.malen_Bit(graphics, xPos, yPos, colour, colour, Bit_Multiplier0, Bit_Multiplier0);
            xPos += 3 * Bit_Multiplier0;
            grundmethoden.malen_Bit(graphics, xPos, yPos, colour, colour, Bit_Multiplier0, Bit_Multiplier0);
            yPos += 8 * Bit_Multiplier0;
            xPos -= 2 * Bit_Multiplier0;
            grundmethoden.malen_Bit(graphics, xPos, yPos, colour, colour, 2 * Bit_Multiplier0, Bit_Multiplier0);
            yPos -= 9 * Bit_Multiplier0;
            xPos += 3 * Bit_Multiplier0;
            grundmethoden.malen_Bit(graphics, xPos, yPos, colour, colour, 6 * Bit_Multiplier0, 15 * Bit_Multiplier0);
            colour = Color.Yellow;
            xPos = x_Pos_Banner + Bit_Multiplier0;
            yPos = y_Pos_Banner + Bit_Multiplier0;
            grundmethoden.malen_Bit(graphics, xPos, yPos, colour, colour, 4 * Bit_Multiplier0, 13 * Bit_Multiplier0);
            xPos = x_Pos_Banner + 5 * Bit_Multiplier0;
            yPos = y_Pos_Banner + 3 * Bit_Multiplier0;
            grundmethoden.malen_Bit(graphics, xPos, yPos, colour, colour, 2 * Bit_Multiplier0, 5 * Bit_Multiplier0);
            yPos -= Bit_Multiplier0;
            grundmethoden.malen_Bit(graphics, xPos, yPos, colour, colour, Bit_Multiplier0, Bit_Multiplier0);
            xPos += 5 * Bit_Multiplier0;
            grundmethoden.malen_Bit(graphics, xPos, yPos, colour, colour, Bit_Multiplier0, Bit_Multiplier0);
            xPos -= Bit_Multiplier0;
            yPos += Bit_Multiplier0;
            grundmethoden.malen_Bit(graphics, xPos, yPos, colour, colour, 2 * Bit_Multiplier0, 5 * Bit_Multiplier0);
            yPos += Bit_Multiplier0;
            xPos -= 2 * Bit_Multiplier0;
            grundmethoden.malen_Bit(graphics, xPos, yPos, colour, colour, 2 * Bit_Multiplier0, 5 * Bit_Multiplier0);
            xPos = x_Pos_Banner + 11 * Bit_Multiplier0;
            yPos = y_Pos_Banner + Bit_Multiplier0;
            grundmethoden.malen_Bit(graphics, xPos, yPos, colour, colour, 4 * Bit_Multiplier0, 13 * Bit_Multiplier0);
            yPos = y_Pos_Banner;
            #endregion
            x_Pos_Banner += 17 * Bit_Multiplier0;//Neuen "Nullpunkt" für den Nächsten Buchstaben setzen
            #region A_Letter
            colour = Color.SaddleBrown;
            xPos = x_Pos_Banner;
            yPos = y_Pos_Banner + Bit_Multiplier0;
            grundmethoden.malen_Bit(graphics, xPos, yPos, colour, colour, 12 * Bit_Multiplier0, 9 * Bit_Multiplier0);
            grundmethoden.malen_Bit(graphics, xPos, yPos, colour, colour, 5 * Bit_Multiplier0, 14 * Bit_Multiplier0);
            xPos += 9 * Bit_Multiplier0;
            grundmethoden.malen_Bit(graphics, xPos, yPos, colour, colour, 5 * Bit_Multiplier0, 14 * Bit_Multiplier0);
            xPos = x_Pos_Banner + Bit_Multiplier0;
            yPos = y_Pos_Banner;
            grundmethoden.malen_Bit(graphics, xPos, yPos, colour, colour, 12 * Bit_Multiplier0, Bit_Multiplier0);
            colour = Color.Yellow;
            xPos = x_Pos_Banner + 2 * Bit_Multiplier0;
            yPos = y_Pos_Banner + Bit_Multiplier0;
            grundmethoden.malen_Bit(graphics, xPos, yPos, colour, colour, 10 * Bit_Multiplier0, 8 * Bit_Multiplier0);
            yPos += Bit_Multiplier0;
            xPos -= Bit_Multiplier0;
            grundmethoden.malen_Bit(graphics, xPos, yPos, colour, colour, 3 * Bit_Multiplier0, 12 * Bit_Multiplier0);
            xPos += 9 * Bit_Multiplier0;
            grundmethoden.malen_Bit(graphics, xPos, yPos, colour, colour, 3 * Bit_Multiplier0, 12 * Bit_Multiplier0);
            colour = Color.SaddleBrown;
            xPos = x_Pos_Banner + 5 * Bit_Multiplier0;
            yPos = y_Pos_Banner + 4 * Bit_Multiplier0;
            grundmethoden.malen_Bit(graphics, xPos, yPos, colour, colour, 4 * Bit_Multiplier0, 2 * Bit_Multiplier0);
            #endregion
            x_Pos_Banner += 15 * Bit_Multiplier0;//Neuen "Nullpunkt" für den Nächsten Buchstaben setzen
            #region L_Letter
            colour = Color.SaddleBrown;
            xPos = x_Pos_Banner;
            yPos = y_Pos_Banner;
            grundmethoden.malen_Bit(graphics, xPos, yPos, colour, colour, 12 * Bit_Multiplier0, 15 * Bit_Multiplier0);
            colour = Color.Yellow;
            xPos = x_Pos_Banner + Bit_Multiplier0;
            yPos = y_Pos_Banner + Bit_Multiplier0;
            grundmethoden.malen_Bit(graphics, xPos, yPos, colour, colour, 10 * Bit_Multiplier0, 13 * Bit_Multiplier0);
            colour = Color.SaddleBrown;
            xPos = x_Pos_Banner + 5 * Bit_Multiplier0;
            yPos = y_Pos_Banner;
            grundmethoden.malen_Bit(graphics, xPos, yPos, colour, colour, 6 * Bit_Multiplier0, 11 * Bit_Multiplier0);
            colour = Color.LightSkyBlue;
            xPos = x_Pos_Banner + 6 * Bit_Multiplier0;
            grundmethoden.malen_Bit(graphics, xPos, yPos, colour, colour, 6 * Bit_Multiplier0, 10 * Bit_Multiplier0);
            #endregion
            x_Pos_Banner += 13 * Bit_Multiplier0;//Neuen "Nullpunkt" für den Nächsten Buchstaben setzen
            #region A_Letter
            colour = Color.SaddleBrown;
            xPos = x_Pos_Banner;
            yPos = y_Pos_Banner + Bit_Multiplier0;
            grundmethoden.malen_Bit(graphics, xPos, yPos, colour, colour, 12 * Bit_Multiplier0, 9 * Bit_Multiplier0);
            grundmethoden.malen_Bit(graphics, xPos, yPos, colour, colour, 5 * Bit_Multiplier0, 14 * Bit_Multiplier0);
            xPos += 9 * Bit_Multiplier0;
            grundmethoden.malen_Bit(graphics, xPos, yPos, colour, colour, 5 * Bit_Multiplier0, 14 * Bit_Multiplier0);
            xPos = x_Pos_Banner + Bit_Multiplier0;
            yPos = y_Pos_Banner;
            grundmethoden.malen_Bit(graphics, xPos, yPos, colour, colour, 12 * Bit_Multiplier0, Bit_Multiplier0);
            colour = Color.Yellow;
            xPos = x_Pos_Banner + 2 * Bit_Multiplier0;
            yPos = y_Pos_Banner + Bit_Multiplier0;
            grundmethoden.malen_Bit(graphics, xPos, yPos, colour, colour, 10 * Bit_Multiplier0, 8 * Bit_Multiplier0);
            yPos += Bit_Multiplier0;
            xPos -= Bit_Multiplier0;
            grundmethoden.malen_Bit(graphics, xPos, yPos, colour, colour, 3 * Bit_Multiplier0, 12 * Bit_Multiplier0);
            xPos += 9 * Bit_Multiplier0;
            grundmethoden.malen_Bit(graphics, xPos, yPos, colour, colour, 3 * Bit_Multiplier0, 12 * Bit_Multiplier0);
            colour = Color.SaddleBrown;
            xPos = x_Pos_Banner + 5 * Bit_Multiplier0;
            yPos = y_Pos_Banner + 4 * Bit_Multiplier0;
            grundmethoden.malen_Bit(graphics, xPos, yPos, colour, colour, 4 * Bit_Multiplier0, 2 * Bit_Multiplier0);
            #endregion
            x_Pos_Banner += 15 * Bit_Multiplier0;//Neuen "Nullpunkt" für den Nächsten Buchstaben setzen
            #region R_Letter
            colour = Color.SaddleBrown;
            xPos = x_Pos_Banner;
            yPos = y_Pos_Banner;
            grundmethoden.malen_Bit(graphics, xPos, yPos, colour, colour, 12 * Bit_Multiplier0, 10 * Bit_Multiplier0);
            grundmethoden.malen_Bit(graphics, xPos, yPos, colour, colour, 5 * Bit_Multiplier0, 15 * Bit_Multiplier0);
            xPos += 8 * Bit_Multiplier0;
            yPos += Bit_Multiplier0;
            grundmethoden.malen_Bit(graphics, xPos, yPos, colour, colour, 5 * Bit_Multiplier0, 14 * Bit_Multiplier0);
            colour = Color.Yellow;
            xPos = x_Pos_Banner + Bit_Multiplier0;
            yPos = y_Pos_Banner + Bit_Multiplier0;
            grundmethoden.malen_Bit(graphics, xPos, yPos, colour, colour, 10 * Bit_Multiplier0, 8 * Bit_Multiplier0);
            grundmethoden.malen_Bit(graphics, xPos, yPos, colour, colour, 3 * Bit_Multiplier0, 13 * Bit_Multiplier0);
            xPos += 8 * Bit_Multiplier0;
            yPos += Bit_Multiplier0;
            grundmethoden.malen_Bit(graphics, xPos, yPos, colour, colour, 3 * Bit_Multiplier0, 12 * Bit_Multiplier0);
            colour = Color.SaddleBrown;
            xPos -= 5 * Bit_Multiplier0;
            yPos += 2 * Bit_Multiplier0;
            grundmethoden.malen_Bit(graphics, xPos, yPos, colour, colour, 5 * Bit_Multiplier0, 2 * Bit_Multiplier0);
            yPos = y_Pos_Banner + 8 * Bit_Multiplier0;
            xPos = x_Pos_Banner + 11 * Bit_Multiplier0;
            grundmethoden.malen_Bit(graphics, xPos, yPos, colour, colour, 2 * Bit_Multiplier0, Bit_Multiplier0);
            #endregion
            x_Pos_Banner += 14 * Bit_Multiplier0;//Neuen "Nullpunkt" für den Nächsten Buchstaben setzen
            #region I_Letter
            colour = Color.SaddleBrown;
            xPos = x_Pos_Banner;
            yPos = y_Pos_Banner;
            grundmethoden.malen_Bit(graphics, xPos, yPos, colour, colour, 9 * Bit_Multiplier0, 3 * Bit_Multiplier0);
            xPos += 2 * Bit_Multiplier0;
            grundmethoden.malen_Bit(graphics, xPos, yPos, colour, colour, 5 * Bit_Multiplier0, 15 * Bit_Multiplier0);
            xPos = x_Pos_Banner;
            yPos = y_Pos_Banner + 12 * Bit_Multiplier0;
            grundmethoden.malen_Bit(graphics, xPos, yPos, colour, colour, 9 * Bit_Multiplier0, 3 * Bit_Multiplier0);
            colour = Color.Yellow;
            xPos = x_Pos_Banner + Bit_Multiplier0;
            yPos = y_Pos_Banner + Bit_Multiplier0;
            grundmethoden.malen_Bit(graphics, xPos, yPos, colour, colour, 7 * Bit_Multiplier0, Bit_Multiplier0);
            yPos = y_Pos_Banner + 13 * Bit_Multiplier0;
            grundmethoden.malen_Bit(graphics, xPos, yPos, colour, colour, 7 * Bit_Multiplier0, Bit_Multiplier0);
            yPos = y_Pos_Banner + Bit_Multiplier0;
            xPos = x_Pos_Banner + 3 * Bit_Multiplier0;
            grundmethoden.malen_Bit(graphics, xPos, yPos, colour, colour, 3 * Bit_Multiplier0, 12 * Bit_Multiplier0);
            #endregion
            x_Pos_Banner += 10 * Bit_Multiplier0;//Neuen "Nullpunkt" für den Nächsten Buchstaben setzen 
            #region O_Letter
            colour = Color.SaddleBrown;
            xPos = x_Pos_Banner;
            yPos = y_Pos_Banner + Bit_Multiplier0;
            grundmethoden.malen_Bit(graphics, xPos, yPos, colour, colour, 14 * Bit_Multiplier0, 13 * Bit_Multiplier0);
            xPos = x_Pos_Banner + Bit_Multiplier0;
            yPos = y_Pos_Banner;
            grundmethoden.malen_Bit(graphics, xPos, yPos, colour, colour, 12 * Bit_Multiplier0, 15 * Bit_Multiplier0);
            colour = Color.Yellow;
            xPos = x_Pos_Banner + Bit_Multiplier0;
            yPos = y_Pos_Banner + 2 * Bit_Multiplier0;
            grundmethoden.malen_Bit(graphics, xPos, yPos, colour, colour, 12 * Bit_Multiplier0, 11 * Bit_Multiplier0);
            xPos = x_Pos_Banner + 2 * Bit_Multiplier0;
            yPos = y_Pos_Banner + Bit_Multiplier0;
            grundmethoden.malen_Bit(graphics, xPos, yPos, colour, colour, 10 * Bit_Multiplier0, 13 * Bit_Multiplier0);
            colour = Color.SaddleBrown;
            xPos = x_Pos_Banner + 4 * Bit_Multiplier0;
            yPos = y_Pos_Banner + 3 * Bit_Multiplier0;
            grundmethoden.malen_Bit(graphics, xPos, yPos, colour, colour, 6 * Bit_Multiplier0, 9 * Bit_Multiplier0);
            colour = Color.LightSkyBlue;
            xPos = x_Pos_Banner + 5 * Bit_Multiplier0;
            yPos = y_Pos_Banner + 4 * Bit_Multiplier0;
            grundmethoden.malen_Bit(graphics, xPos, yPos, colour, colour, 4 * Bit_Multiplier0, 7 * Bit_Multiplier0);

            #endregion
        }
    }
}



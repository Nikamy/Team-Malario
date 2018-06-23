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
            Color füllfarbe = Color.Yellow;
            Color stiftfarbe = Color.Yellow;
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
                füllfarbe = Color.Red;
                stiftfarbe = Color.Red;
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

                    füllfarbe = Color.Yellow;
                    stiftfarbe = Color.Yellow;
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
                füllfarbe = Color.Yellow;
                stiftfarbe = Color.Yellow;

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
                füllfarbe = Color.Red;
                stiftfarbe = Color.Red;

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
                    füllfarbe = Color.Yellow;
                    stiftfarbe = Color.Yellow;

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
                    x_Pos_Malario += (1* x_Bit_Multiplier0);
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
    }
}



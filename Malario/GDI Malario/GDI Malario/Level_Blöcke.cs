﻿using System;
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
    class Level_Blöcke : Grundmethoden
    {
        public static void malen_MauerBlock(Graphics graphics, int x_Coordinate1, int y_Coordinate1)
        {
            int y_Bit_Multiplier_GanzerBlock = 24,
                x_Bit_Multiplier0 = (y_Bit_Multiplier_GanzerBlock - 4) / 2,
                y_Bit_Multiplier0 = (y_Bit_Multiplier_GanzerBlock - 8) / 4,
                Block_Spalenbreite = y_Bit_Multiplier_GanzerBlock / 12;


            Grundmethoden grundmethoden = new Grundmethoden();
            Color grafikfarbe = Color.Black,
                  stiftfarbe = Color.Black;

            grundmethoden.malen_Bit(graphics, x_Coordinate1, y_Coordinate1, grafikfarbe, stiftfarbe, y_Bit_Multiplier_GanzerBlock, y_Bit_Multiplier_GanzerBlock);

            grafikfarbe = Color.Brown;
            stiftfarbe = Color.Brown;

            grundmethoden.malen_Bit(graphics, x_Coordinate1, y_Coordinate1, grafikfarbe, stiftfarbe, x_Bit_Multiplier0, y_Bit_Multiplier0);
            x_Coordinate1 += x_Bit_Multiplier0 + Block_Spalenbreite;
            grundmethoden.malen_Bit(graphics, x_Coordinate1, y_Coordinate1, grafikfarbe, stiftfarbe, x_Bit_Multiplier0, y_Bit_Multiplier0);

            y_Coordinate1 += y_Bit_Multiplier0 + Block_Spalenbreite;
            x_Coordinate1 -= (x_Bit_Multiplier0 + Block_Spalenbreite);

            x_Bit_Multiplier0 -= (x_Bit_Multiplier0 / 2);
            grundmethoden.malen_Bit(graphics, x_Coordinate1, y_Coordinate1, grafikfarbe, stiftfarbe, x_Bit_Multiplier0, y_Bit_Multiplier0);
            x_Bit_Multiplier0 += (x_Bit_Multiplier0);
            x_Coordinate1 += (x_Bit_Multiplier0 / 2) + Block_Spalenbreite;
            grundmethoden.malen_Bit(graphics, x_Coordinate1, y_Coordinate1, grafikfarbe, stiftfarbe, x_Bit_Multiplier0, y_Bit_Multiplier0);
            x_Coordinate1 += (x_Bit_Multiplier0 + Block_Spalenbreite);
            x_Bit_Multiplier0 -= (x_Bit_Multiplier0 / 2);
            grundmethoden.malen_Bit(graphics, x_Coordinate1, y_Coordinate1, grafikfarbe, stiftfarbe, x_Bit_Multiplier0, y_Bit_Multiplier0);
            x_Bit_Multiplier0 += (x_Bit_Multiplier0);

            y_Coordinate1 += y_Bit_Multiplier0 + Block_Spalenbreite;
            x_Coordinate1 -= (x_Bit_Multiplier0 / 2) + x_Bit_Multiplier0 + 2 * Block_Spalenbreite;

            grundmethoden.malen_Bit(graphics, x_Coordinate1, y_Coordinate1, grafikfarbe, stiftfarbe, x_Bit_Multiplier0, y_Bit_Multiplier0);
            x_Coordinate1 += x_Bit_Multiplier0 + Block_Spalenbreite;
            grundmethoden.malen_Bit(graphics, x_Coordinate1, y_Coordinate1, grafikfarbe, stiftfarbe, x_Bit_Multiplier0, y_Bit_Multiplier0);

            y_Coordinate1 += y_Bit_Multiplier0 + Block_Spalenbreite;
            x_Coordinate1 -= (x_Bit_Multiplier0 + Block_Spalenbreite);

            x_Bit_Multiplier0 -= (x_Bit_Multiplier0 / 2);
            grundmethoden.malen_Bit(graphics, x_Coordinate1, y_Coordinate1, grafikfarbe, stiftfarbe, x_Bit_Multiplier0, y_Bit_Multiplier0);
            x_Bit_Multiplier0 += (x_Bit_Multiplier0);
            x_Coordinate1 += (x_Bit_Multiplier0 / 2) + Block_Spalenbreite;
            grundmethoden.malen_Bit(graphics, x_Coordinate1, y_Coordinate1, grafikfarbe, stiftfarbe, x_Bit_Multiplier0, y_Bit_Multiplier0);
            x_Coordinate1 += (x_Bit_Multiplier0 + Block_Spalenbreite);
            x_Bit_Multiplier0 -= (x_Bit_Multiplier0 / 2);
            grundmethoden.malen_Bit(graphics, x_Coordinate1, y_Coordinate1, grafikfarbe, stiftfarbe, x_Bit_Multiplier0, y_Bit_Multiplier0);
            x_Bit_Multiplier0 += (x_Bit_Multiplier0);

            y_Coordinate1 += y_Bit_Multiplier0 + Block_Spalenbreite;
            x_Coordinate1 -= (x_Bit_Multiplier0 / 2) + x_Bit_Multiplier0 + 2 * Block_Spalenbreite;

        }
        public static void malen_BodenBlock(Graphics graphics, int x_Pos0, int y_Pos0)
        {
            int x_Pos = x_Pos0, y_Pos = y_Pos0, xlänge, ylänge;
            Color color1 = Color.LightGray;
            Color color2 = Color.DarkGray;
            Grundmethoden grundmethoden = new Grundmethoden();
            xlänge = 24;
            ylänge = 24;
            x_Pos += 0;
            y_Pos += 0;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color2, color2, xlänge, ylänge);

            xlänge = 6;
            ylänge = 6;
            x_Pos += 0;
            y_Pos += 18;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color1, color1, xlänge, ylänge);

            xlänge = 3;
            ylänge = 3;
            x_Pos += 6;
            y_Pos += 3;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color1, color1, xlänge, ylänge);

            xlänge = 3;
            ylänge = 6;
            x_Pos += 15;
            y_Pos -= 3;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color1, color1, xlänge, ylänge);

            xlänge = 15;
            ylänge = 3;
            x_Pos -= 18;
            y_Pos -= 3;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color1, color1, xlänge, ylänge);

            xlänge = 6;
            ylänge = 3;
            x_Pos += 9;
            y_Pos -= 3;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color1, color1, xlänge, ylänge);

            xlänge = 3;
            ylänge = 3;
            x_Pos -= 9;
            y_Pos -= 3;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color1, color1, xlänge, ylänge);

            xlänge = 3;
            ylänge = 3;
            x_Pos += 3;
            y_Pos -= 3;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color1, color1, xlänge, ylänge);

            xlänge = 3;
            ylänge = 3;
            x_Pos -= 6;
            y_Pos -= 3;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color1, color1, xlänge, ylänge);

            xlänge = 9;
            ylänge = 3;
            x_Pos += 15;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color1, color1, xlänge, ylänge);

            xlänge = 9;
            ylänge = 3;
            x_Pos -= 15;
            y_Pos -= 3;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color1, color1, xlänge, ylänge);

            xlänge = 3;
            ylänge = 3;
            x_Pos += 21;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, color1, color1, xlänge, ylänge);
        }
        public static void malen_RöhrenBlock_Kopf(Graphics graphics, int x_Pos0, int y_Pos0)
        {
            int x_Pos = x_Pos0, y_Pos = y_Pos0;
            int Bit_Multiplier0 = Convert.ToInt32(2.526314);
            Color füllfarbe = Color.Black;
            Color stiftfarbe = Color.Black;
            Grundmethoden grundmethoden = new Grundmethoden();

            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, füllfarbe, stiftfarbe, 19 * Bit_Multiplier0, 9 * Bit_Multiplier0);


            füllfarbe = Color.YellowGreen;
            stiftfarbe = Color.YellowGreen;
            x_Pos += (1 * Bit_Multiplier0);
            y_Pos += (1 * Bit_Multiplier0);
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, füllfarbe, stiftfarbe, 17 * Bit_Multiplier0, 8 * Bit_Multiplier0);

            füllfarbe = Color.DarkGreen;
            stiftfarbe = Color.DarkGreen;
            x_Pos += (0 * Bit_Multiplier0);
            y_Pos += (1 * Bit_Multiplier0);
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, füllfarbe, stiftfarbe, 1 * Bit_Multiplier0, 1 * Bit_Multiplier0);
            x_Pos += (1 * Bit_Multiplier0);
            y_Pos += (0 * Bit_Multiplier0);
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, füllfarbe, stiftfarbe, 1 * Bit_Multiplier0, 7 * Bit_Multiplier0);
            x_Pos += (5 * Bit_Multiplier0);
            y_Pos += (0 * Bit_Multiplier0);
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, füllfarbe, stiftfarbe, 7 * Bit_Multiplier0, 7 * Bit_Multiplier0);
            x_Pos += (8 * Bit_Multiplier0);
            y_Pos += (0 * Bit_Multiplier0);
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, füllfarbe, stiftfarbe, 1 * Bit_Multiplier0, 1 * Bit_Multiplier0);
            x_Pos -= (1 * Bit_Multiplier0);
            y_Pos += (1 * Bit_Multiplier0);
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, füllfarbe, stiftfarbe, 1 * Bit_Multiplier0, 1 * Bit_Multiplier0);
            x_Pos += (2 * Bit_Multiplier0);
            y_Pos += (0 * Bit_Multiplier0);
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, füllfarbe, stiftfarbe, 1 * Bit_Multiplier0, 1 * Bit_Multiplier0);
            x_Pos -= (1 * Bit_Multiplier0);
            y_Pos += (1 * Bit_Multiplier0);
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, füllfarbe, stiftfarbe, 1 * Bit_Multiplier0, 1 * Bit_Multiplier0);
            x_Pos -= (1 * Bit_Multiplier0);
            y_Pos += (1 * Bit_Multiplier0);
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, füllfarbe, stiftfarbe, 1 * Bit_Multiplier0, 1 * Bit_Multiplier0);
            x_Pos += (0 * Bit_Multiplier0);
            y_Pos += (0 * Bit_Multiplier0);
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, füllfarbe, stiftfarbe, 1 * Bit_Multiplier0, 1 * Bit_Multiplier0);
            x_Pos += (2 * Bit_Multiplier0);
            y_Pos += (0 * Bit_Multiplier0);
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, füllfarbe, stiftfarbe, 1 * Bit_Multiplier0, 1 * Bit_Multiplier0);
            x_Pos -= (1 * Bit_Multiplier0);
            y_Pos += (1 * Bit_Multiplier0);
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, füllfarbe, stiftfarbe, 1 * Bit_Multiplier0, 1 * Bit_Multiplier0);
            x_Pos -= (1 * Bit_Multiplier0);
            y_Pos += (1 * Bit_Multiplier0);
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, füllfarbe, stiftfarbe, 1 * Bit_Multiplier0, 1 * Bit_Multiplier0);
            x_Pos += (2 * Bit_Multiplier0);
            y_Pos += (0 * Bit_Multiplier0);
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, füllfarbe, stiftfarbe, 1 * Bit_Multiplier0, 1 * Bit_Multiplier0);
            x_Pos -= (1 * Bit_Multiplier0);
            y_Pos += (1 * Bit_Multiplier0);
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, füllfarbe, stiftfarbe, 1 * Bit_Multiplier0, 1 * Bit_Multiplier0);


            füllfarbe = Color.Black;
            stiftfarbe = Color.Black;

            x_Pos -= (14 * Bit_Multiplier0);
            y_Pos += (1 * Bit_Multiplier0);
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, füllfarbe, stiftfarbe, 17 * Bit_Multiplier0, 1 * Bit_Multiplier0);

            //Halsstück

            x_Pos += (1 * Bit_Multiplier0);
            y_Pos += (1 * Bit_Multiplier0);
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, füllfarbe, stiftfarbe, 15 * Bit_Multiplier0, 6 * Bit_Multiplier0);
            y_Pos += (1 * Bit_Multiplier0);
            x_Pos += (1 * Bit_Multiplier0);
            füllfarbe = Color.YellowGreen;
            stiftfarbe = Color.YellowGreen;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, füllfarbe, stiftfarbe, 13 * Bit_Multiplier0, 5 * Bit_Multiplier0);
            x_Pos += (1 * Bit_Multiplier0);
            füllfarbe = Color.DarkGreen;
            stiftfarbe = Color.DarkGreen;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, füllfarbe, stiftfarbe, 1 * Bit_Multiplier0, 5 * Bit_Multiplier0);
            x_Pos += (4 * Bit_Multiplier0);
            füllfarbe = Color.DarkGreen;
            stiftfarbe = Color.DarkGreen;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, füllfarbe, stiftfarbe, 1 * Bit_Multiplier0, 5 * Bit_Multiplier0);
            x_Pos += (2 * Bit_Multiplier0);
            füllfarbe = Color.DarkGreen;
            stiftfarbe = Color.DarkGreen;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, füllfarbe, stiftfarbe, 2 * Bit_Multiplier0, 5 * Bit_Multiplier0);
            //Muster
            x_Pos += (2 * Bit_Multiplier0);
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, füllfarbe, stiftfarbe, 1 * Bit_Multiplier0, 1 * Bit_Multiplier0);
            x_Pos += (2 * Bit_Multiplier0);
            y_Pos += (0 * Bit_Multiplier0);
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, füllfarbe, stiftfarbe, 1 * Bit_Multiplier0, 1 * Bit_Multiplier0);
            x_Pos -= (1 * Bit_Multiplier0);
            y_Pos += (1 * Bit_Multiplier0);
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, füllfarbe, stiftfarbe, 1 * Bit_Multiplier0, 1 * Bit_Multiplier0);
            x_Pos -= (1 * Bit_Multiplier0);
            y_Pos += (1 * Bit_Multiplier0);
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, füllfarbe, stiftfarbe, 1 * Bit_Multiplier0, 1 * Bit_Multiplier0);
            x_Pos += (0 * Bit_Multiplier0);
            y_Pos += (0 * Bit_Multiplier0);
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, füllfarbe, stiftfarbe, 1 * Bit_Multiplier0, 1 * Bit_Multiplier0);
            x_Pos += (2 * Bit_Multiplier0);
            y_Pos += (0 * Bit_Multiplier0);
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, füllfarbe, stiftfarbe, 1 * Bit_Multiplier0, 1 * Bit_Multiplier0);
            x_Pos -= (1 * Bit_Multiplier0);
            y_Pos += (1 * Bit_Multiplier0);
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, füllfarbe, stiftfarbe, 1 * Bit_Multiplier0, 1 * Bit_Multiplier0);
            x_Pos -= (1 * Bit_Multiplier0);
            y_Pos += (1 * Bit_Multiplier0);
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, füllfarbe, stiftfarbe, 1 * Bit_Multiplier0, 1 * Bit_Multiplier0);
            x_Pos += (2 * Bit_Multiplier0);
            y_Pos += (0 * Bit_Multiplier0);
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, füllfarbe, stiftfarbe, 1 * Bit_Multiplier0, 1 * Bit_Multiplier0);
        }
        public static void malen_RöhrenBlock_Hals(Graphics graphics, int x_Pos0, int y_Pos0)
        {
            int x_Pos = x_Pos0, y_Pos = y_Pos0;
            int Bit_Multiplier0 = 3;
            Color füllfarbe = Color.Black;
            Color stiftfarbe = Color.Black;
            Grundmethoden grundmethoden = new Grundmethoden();

            x_Pos += (2 * Bit_Multiplier0);
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, füllfarbe, stiftfarbe, 15 * Bit_Multiplier0, 8 * Bit_Multiplier0);
            x_Pos += (1 * Bit_Multiplier0);
            füllfarbe = Color.YellowGreen;
            stiftfarbe = Color.YellowGreen;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, füllfarbe, stiftfarbe, 13 * Bit_Multiplier0, 8 * Bit_Multiplier0);
            x_Pos += (1 * Bit_Multiplier0);
            füllfarbe = Color.DarkGreen;
            stiftfarbe = Color.DarkGreen;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, füllfarbe, stiftfarbe, 1 * Bit_Multiplier0, 8 * Bit_Multiplier0);
            x_Pos += (4 * Bit_Multiplier0);
            füllfarbe = Color.DarkGreen;
            stiftfarbe = Color.DarkGreen;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, füllfarbe, stiftfarbe, 1 * Bit_Multiplier0, 8 * Bit_Multiplier0);
            x_Pos += (2 * Bit_Multiplier0);
            füllfarbe = Color.DarkGreen;
            stiftfarbe = Color.DarkGreen;
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, füllfarbe, stiftfarbe, 2 * Bit_Multiplier0, 8 * Bit_Multiplier0);
            //Muster
            x_Pos += (3 * Bit_Multiplier0);
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, füllfarbe, stiftfarbe, 1 * Bit_Multiplier0, 1 * Bit_Multiplier0);
            x_Pos -= (1 * Bit_Multiplier0);
            y_Pos += (1 * Bit_Multiplier0);
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, füllfarbe, stiftfarbe, 1 * Bit_Multiplier0, 1 * Bit_Multiplier0);
            x_Pos += (2 * Bit_Multiplier0);
            y_Pos += (0 * Bit_Multiplier0);
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, füllfarbe, stiftfarbe, 1 * Bit_Multiplier0, 1 * Bit_Multiplier0);
            x_Pos -= (1 * Bit_Multiplier0);
            y_Pos += (1 * Bit_Multiplier0);
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, füllfarbe, stiftfarbe, 1 * Bit_Multiplier0, 1 * Bit_Multiplier0);
            x_Pos -= (1 * Bit_Multiplier0);
            y_Pos += (1 * Bit_Multiplier0);
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, füllfarbe, stiftfarbe, 1 * Bit_Multiplier0, 1 * Bit_Multiplier0);
            x_Pos += (2 * Bit_Multiplier0);
            y_Pos += (0 * Bit_Multiplier0);
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, füllfarbe, stiftfarbe, 1 * Bit_Multiplier0, 1 * Bit_Multiplier0);
            x_Pos -= (1 * Bit_Multiplier0);
            y_Pos += (1 * Bit_Multiplier0);
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, füllfarbe, stiftfarbe, 1 * Bit_Multiplier0, 1 * Bit_Multiplier0);
            x_Pos -= (1 * Bit_Multiplier0);
            y_Pos += (1 * Bit_Multiplier0);
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, füllfarbe, stiftfarbe, 1 * Bit_Multiplier0, 1 * Bit_Multiplier0);
            x_Pos += (2 * Bit_Multiplier0);
            y_Pos += (0 * Bit_Multiplier0);
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, füllfarbe, stiftfarbe, 1 * Bit_Multiplier0, 1 * Bit_Multiplier0);
            x_Pos -= (1 * Bit_Multiplier0);
            y_Pos += (1 * Bit_Multiplier0);
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, füllfarbe, stiftfarbe, 1 * Bit_Multiplier0, 1 * Bit_Multiplier0);
            x_Pos -= (1 * Bit_Multiplier0);
            y_Pos += (1 * Bit_Multiplier0);
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, füllfarbe, stiftfarbe, 1 * Bit_Multiplier0, 1 * Bit_Multiplier0);
            x_Pos += (2 * Bit_Multiplier0);
            y_Pos += (0 * Bit_Multiplier0);
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, füllfarbe, stiftfarbe, 1 * Bit_Multiplier0, 1 * Bit_Multiplier0);
        }
        public static void malen_StahlBlock(Graphics graphics, int x_Pos0, int y_Pos0)
        {
            int x_Pos = x_Pos0, y_Pos = y_Pos0;
            int Bit_Multiplier0 = 1;
            Color füllfarbe = Color.Black;
            Color stiftfarbe = Color.Black;
            Grundmethoden grundmethoden = new Grundmethoden();

            x_Pos += (2 * Bit_Multiplier0);
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, füllfarbe, stiftfarbe, 20 * Bit_Multiplier0, 24 * Bit_Multiplier0);
            x_Pos -= (2 * Bit_Multiplier0);
            y_Pos += (2 * Bit_Multiplier0);
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, füllfarbe, stiftfarbe, 24 * Bit_Multiplier0, 20 * Bit_Multiplier0);

            füllfarbe = Color.Chocolate;
            stiftfarbe = Color.Chocolate;
            x_Pos += (2 * Bit_Multiplier0);
            y_Pos += (0 * Bit_Multiplier0);
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, füllfarbe, stiftfarbe, 20 * Bit_Multiplier0, 20 * Bit_Multiplier0);
            füllfarbe = Color.Black;
            stiftfarbe = Color.Black;
            x_Pos += (1 * Bit_Multiplier0);
            y_Pos += (1 * Bit_Multiplier0);
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, füllfarbe, stiftfarbe, 1 * Bit_Multiplier0, 1 * Bit_Multiplier0);
            x_Pos += (17 * Bit_Multiplier0);
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, füllfarbe, stiftfarbe, 1 * Bit_Multiplier0, 1 * Bit_Multiplier0);
            x_Pos -= (17 * Bit_Multiplier0);
            y_Pos += (17 * Bit_Multiplier0);
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, füllfarbe, stiftfarbe, 1 * Bit_Multiplier0, 1 * Bit_Multiplier0);
            x_Pos += (17 * Bit_Multiplier0);
            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, füllfarbe, stiftfarbe, 1 * Bit_Multiplier0, 1 * Bit_Multiplier0);
        }
        public static void malen_Dungeonhintergrund(Graphics graphics, int x_Pos0, int y_Pos0)
        {
            int x_Pos = x_Pos0, y_Pos = y_Pos0;
            Color füllfarbe = Color.Black;
            Color stiftfarbe = Color.Black;
            Grundmethoden grundmethoden = new Grundmethoden();

            grundmethoden.malen_Bit(graphics, x_Pos, y_Pos, füllfarbe, stiftfarbe, 840, 480);
        }
    }
}
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
    class Gegner : Grundmethoden
    {
        public static void malen_Goethe( Graphics graphics, char direction)
        {
            int x_Pos = 0, y_Pos = 0, Bit_Multiplier0 = 2;
            Color colour = Color.SaddleBrown;

            y_Pos = y_Pos + (Bit_Multiplier0 * 15);
            //unterste Zeile
            Grundmethoden grundmethoden = new Grundmethoden();
            x_Pos += Bit_Multiplier0;
            grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
            x_Pos += (4 * Bit_Multiplier0);
            grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
            x_Pos += Bit_Multiplier0;
            grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
            x_Pos += (3 * Bit_Multiplier0);
            grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
            x_Pos += Bit_Multiplier0;
            grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
            x_Pos += (4 * Bit_Multiplier0);
            grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
            //eine Zeile höher
            y_Pos -= Bit_Multiplier0;
            grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
            x_Pos -= Bit_Multiplier0;
            grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
            x_Pos -= (2 * Bit_Multiplier0);
            grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
            x_Pos -= Bit_Multiplier0;
            grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
            x_Pos -= Bit_Multiplier0;
            grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
            x_Pos -= (2 * Bit_Multiplier0);
            grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
            x_Pos -= Bit_Multiplier0;
            grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
            x_Pos -= Bit_Multiplier0;
            grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
            x_Pos -= Bit_Multiplier0;
            grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
            x_Pos -= (2 * Bit_Multiplier0);
            grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
            x_Pos -= Bit_Multiplier0;
            grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
            //Die Nächsten 4 Zeilen
            for (int i = 0; i < 5; i++)
            {
                x_Pos = Bit_Multiplier0;
                y_Pos -= Bit_Multiplier0;
                for (int j = 0; j < 14; j++)
                {
                    grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                    x_Pos += Bit_Multiplier0;
                }
            }
            //Nächste Zeile und verschiedene Augen je nach Richtung in die er läuft
            if (direction == 'r')
            {
                x_Pos -= Bit_Multiplier0;
                y_Pos -= Bit_Multiplier0;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                x_Pos -= Bit_Multiplier0;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                colour = Color.LightGray;
                x_Pos -= Bit_Multiplier0;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                x_Pos -= Bit_Multiplier0;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                colour = Color.SaddleBrown;
                for (int i = 0; i < 4; i++)
                {
                    x_Pos -= Bit_Multiplier0;
                    grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                }
                colour = Color.LightGray;
                x_Pos -= Bit_Multiplier0;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                x_Pos -= Bit_Multiplier0;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                colour = Color.SaddleBrown;
                for (int i = 0; i < 4; i++)
                {
                    x_Pos -= Bit_Multiplier0;
                    grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                }
                //Nächste Zeile
                y_Pos -= Bit_Multiplier0;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                x_Pos += Bit_Multiplier0;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                x_Pos += Bit_Multiplier0;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                colour = Color.LightGray;
                x_Pos += Bit_Multiplier0;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                x_Pos += Bit_Multiplier0;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                colour = Color.Blue;
                x_Pos += Bit_Multiplier0;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                x_Pos += Bit_Multiplier0;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                colour = Color.SaddleBrown;
                x_Pos += Bit_Multiplier0;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                x_Pos += Bit_Multiplier0;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                colour = Color.LightGray;
                x_Pos += Bit_Multiplier0;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                x_Pos += Bit_Multiplier0;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                colour = Color.Blue;
                x_Pos += Bit_Multiplier0;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                x_Pos += Bit_Multiplier0;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                colour = Color.SaddleBrown;
                x_Pos += Bit_Multiplier0;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                //Nächste Zeile
                y_Pos -= Bit_Multiplier0;
                x_Pos = 2 * Bit_Multiplier0;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                x_Pos += Bit_Multiplier0;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                colour = Color.LightGray;
                x_Pos += Bit_Multiplier0;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                x_Pos += Bit_Multiplier0;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                colour = Color.Blue;
                x_Pos += Bit_Multiplier0;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                x_Pos += Bit_Multiplier0;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                colour = Color.SaddleBrown;
                x_Pos += Bit_Multiplier0;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                x_Pos += Bit_Multiplier0;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                colour = Color.LightGray;
                x_Pos += Bit_Multiplier0;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                x_Pos += Bit_Multiplier0;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                colour = Color.Blue;
                x_Pos += Bit_Multiplier0;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                x_Pos += Bit_Multiplier0;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                //Nächste Zeile
                y_Pos -= Bit_Multiplier0;
                colour = Color.LightGray;
                for (int i = 0; i < 4; i++)
                {
                    grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                    x_Pos -= Bit_Multiplier0;
                }
                colour = Color.SaddleBrown;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                x_Pos -= Bit_Multiplier0;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                x_Pos -= Bit_Multiplier0;
                colour = Color.LightGray;
                for (int i = 0; i < 4; i++)
                {
                    grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                    x_Pos -= Bit_Multiplier0;
                }
                colour = Color.SaddleBrown;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                x_Pos -= Bit_Multiplier0;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                //Nächste Zeile
                y_Pos -= Bit_Multiplier0;
                x_Pos = 2 * Bit_Multiplier0;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                x_Pos += Bit_Multiplier0;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                x_Pos += Bit_Multiplier0;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                colour = Color.LightGray;
                x_Pos += Bit_Multiplier0;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                x_Pos += Bit_Multiplier0;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                colour = Color.SaddleBrown;
                for (int i = 0; i < 4; i++)
                {
                    x_Pos += Bit_Multiplier0;
                    grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                }
                colour = Color.LightGray;
                x_Pos += Bit_Multiplier0;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                x_Pos += Bit_Multiplier0;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                colour = Color.SaddleBrown;
                x_Pos += Bit_Multiplier0;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);

            }
            else if (direction == 'l')
            {
                y_Pos -= Bit_Multiplier0;
                x_Pos = Bit_Multiplier0;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                x_Pos += Bit_Multiplier0;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                colour = Color.LightGray;
                x_Pos += Bit_Multiplier0;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                x_Pos += Bit_Multiplier0;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                colour = Color.SaddleBrown;
                for (int i = 0; i < 4; i++)
                {
                    x_Pos += Bit_Multiplier0;
                    grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                }
                colour = Color.LightGray;
                x_Pos += Bit_Multiplier0;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                x_Pos += Bit_Multiplier0;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                colour = Color.SaddleBrown;
                for (int i = 0; i < 4; i++)
                {
                    x_Pos += Bit_Multiplier0;
                    grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                }
                //Nächste Zeile
                y_Pos -= Bit_Multiplier0;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                x_Pos -= Bit_Multiplier0;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                x_Pos -= Bit_Multiplier0;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                colour = Color.LightGray;
                x_Pos -= Bit_Multiplier0;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                x_Pos -= Bit_Multiplier0;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                colour = Color.Blue;
                x_Pos -= Bit_Multiplier0;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                x_Pos -= Bit_Multiplier0;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                colour = Color.SaddleBrown;
                x_Pos -= Bit_Multiplier0;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                x_Pos -= Bit_Multiplier0;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                colour = Color.LightGray;
                x_Pos -= Bit_Multiplier0;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                x_Pos -= Bit_Multiplier0;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                colour = Color.Blue;
                x_Pos -= Bit_Multiplier0;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                x_Pos -= Bit_Multiplier0;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                colour = Color.SaddleBrown;
                x_Pos -= Bit_Multiplier0;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                //Nächste Zeile
                y_Pos -= Bit_Multiplier0;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                x_Pos = (14 * Bit_Multiplier0);
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                x_Pos -= Bit_Multiplier0;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                x_Pos -= Bit_Multiplier0;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                colour = Color.LightGray;
                x_Pos -= Bit_Multiplier0;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                x_Pos -= Bit_Multiplier0;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                colour = Color.Blue;
                x_Pos -= Bit_Multiplier0;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                x_Pos -= Bit_Multiplier0;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                colour = Color.SaddleBrown;
                x_Pos -= Bit_Multiplier0;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                x_Pos -= Bit_Multiplier0;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                colour = Color.LightGray;
                x_Pos -= Bit_Multiplier0;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                x_Pos -= Bit_Multiplier0;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                colour = Color.Blue;
                x_Pos -= Bit_Multiplier0;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                x_Pos -= Bit_Multiplier0;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                //Nächste Zeile
                y_Pos -= Bit_Multiplier0;
                x_Pos = 2 * Bit_Multiplier0;
                colour = Color.LightGray;
                for (int i = 0; i < 4; i++)
                {
                    grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                    x_Pos += Bit_Multiplier0;
                }
                colour = Color.SaddleBrown;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                x_Pos += Bit_Multiplier0;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                x_Pos += Bit_Multiplier0;
                colour = Color.LightGray;
                for (int i = 0; i < 4; i++)
                {
                    grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                    x_Pos += Bit_Multiplier0;
                }
                colour = Color.SaddleBrown;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                x_Pos += Bit_Multiplier0;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                //Nächste Zeile
                y_Pos -= Bit_Multiplier0;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                x_Pos -= Bit_Multiplier0;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                x_Pos -= Bit_Multiplier0;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                colour = Color.LightGray;
                x_Pos -= Bit_Multiplier0;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                x_Pos -= Bit_Multiplier0;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                colour = Color.SaddleBrown;
                for (int i = 0; i < 4; i++)
                {
                    x_Pos -= Bit_Multiplier0;
                    grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                }
                colour = Color.LightGray;
                x_Pos -= Bit_Multiplier0;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                x_Pos -= Bit_Multiplier0;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                colour = Color.SaddleBrown;
                x_Pos -= Bit_Multiplier0;
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
            }
            //Nächste Zeile
            y_Pos -= Bit_Multiplier0;
            x_Pos = 3 * Bit_Multiplier0;
            for (int i = 0; i < 10; i++)
            {
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                x_Pos += Bit_Multiplier0;
            }
            //Nächste Zeile
            y_Pos -= Bit_Multiplier0;
            x_Pos = (4 * Bit_Multiplier0);
            for (int i = 0; i < 8; i++)
            {
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                x_Pos += Bit_Multiplier0;
            }
            //Letzte Zeile
            y_Pos -= Bit_Multiplier0;
            x_Pos = (6 * Bit_Multiplier0);
            for (int i = 0; i < 4; i++)
            {
                grundmethoden.malen_Bit( graphics,  x_Pos,  y_Pos,  colour,  colour,  Bit_Multiplier0,  Bit_Multiplier0);
                x_Pos += Bit_Multiplier0;
            }
        }


    }
}

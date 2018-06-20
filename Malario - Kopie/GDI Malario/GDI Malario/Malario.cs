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
        public static void malen_Malario(Graphics graphics, int x_Pos_Malario, int y_Pos_Malario)
        {
            int x_Bit_Multiplier0 = 2, y_Bit_Multiplier0 = 2;
            Color füllfarbe = Color.Brown;
            Color stiftfarbe = Color.Brown;


            y_Pos_Malario= y_Pos_Malario+ (y_Bit_Multiplier0 * 16);
            //Schuh links
            //Erste Ebene
            Grundmethoden grundmethoden = new Grundmethoden();
            x_Pos_Malario = x_Pos_Malario + x_Bit_Multiplier0;
            grundmethoden.malen_Bit( graphics,  x_Pos_Malario,  y_Pos_Malario,  füllfarbe,  stiftfarbe,  x_Bit_Multiplier0,  y_Bit_Multiplier0);
            x_Pos_Malario = x_Pos_Malario + x_Bit_Multiplier0;
            grundmethoden.malen_Bit( graphics,  x_Pos_Malario,  y_Pos_Malario,  füllfarbe,  stiftfarbe,  x_Bit_Multiplier0,  y_Bit_Multiplier0);
            x_Pos_Malario = x_Pos_Malario + x_Bit_Multiplier0;
            grundmethoden.malen_Bit( graphics,  x_Pos_Malario,  y_Pos_Malario,  füllfarbe,  stiftfarbe,  x_Bit_Multiplier0,  y_Bit_Multiplier0);
            x_Pos_Malario = x_Pos_Malario + x_Bit_Multiplier0;
            grundmethoden.malen_Bit( graphics,  x_Pos_Malario,  y_Pos_Malario,  füllfarbe,  stiftfarbe,  x_Bit_Multiplier0,  y_Bit_Multiplier0);
            //Zweite Ebene
            x_Pos_Malario = x_Pos_Malario - (x_Bit_Multiplier0 * 2);
            y_Pos_Malario = y_Pos_Malario - y_Bit_Multiplier0;
            grundmethoden.malen_Bit( graphics,  x_Pos_Malario,  y_Pos_Malario,  füllfarbe,  stiftfarbe,  x_Bit_Multiplier0,  y_Bit_Multiplier0);
            x_Pos_Malario = x_Pos_Malario + x_Bit_Multiplier0;
            grundmethoden.malen_Bit( graphics,  x_Pos_Malario,  y_Pos_Malario,  füllfarbe,  stiftfarbe,  x_Bit_Multiplier0,  y_Bit_Multiplier0);
            x_Pos_Malario = x_Pos_Malario + x_Bit_Multiplier0;
            grundmethoden.malen_Bit( graphics,  x_Pos_Malario,  y_Pos_Malario,  füllfarbe,  stiftfarbe,  x_Bit_Multiplier0,  y_Bit_Multiplier0);


            //Schuh rechts
            //Erste Ebene
            x_Pos_Malario = x_Pos_Malario + (x_Bit_Multiplier0 * 5);
            y_Pos_Malario = y_Pos_Malario + y_Bit_Multiplier0;
            grundmethoden.malen_Bit( graphics,  x_Pos_Malario,  y_Pos_Malario,  füllfarbe,  stiftfarbe,  x_Bit_Multiplier0,  y_Bit_Multiplier0);
            x_Pos_Malario = x_Pos_Malario + x_Bit_Multiplier0;
            grundmethoden.malen_Bit( graphics,  x_Pos_Malario,  y_Pos_Malario,  füllfarbe,  stiftfarbe,  x_Bit_Multiplier0,  y_Bit_Multiplier0);
            x_Pos_Malario = x_Pos_Malario + x_Bit_Multiplier0;
            grundmethoden.malen_Bit( graphics,  x_Pos_Malario,  y_Pos_Malario,  füllfarbe,  stiftfarbe,  x_Bit_Multiplier0,  y_Bit_Multiplier0);
            x_Pos_Malario = x_Pos_Malario + x_Bit_Multiplier0;
            grundmethoden.malen_Bit( graphics,  x_Pos_Malario,  y_Pos_Malario,  füllfarbe,  stiftfarbe,  x_Bit_Multiplier0,  y_Bit_Multiplier0);
            //Zweite Ebene
            x_Pos_Malario = x_Pos_Malario - (x_Bit_Multiplier0 * 3);
            y_Pos_Malario = y_Pos_Malario - y_Bit_Multiplier0;
            grundmethoden.malen_Bit( graphics,  x_Pos_Malario,  y_Pos_Malario,  füllfarbe,  stiftfarbe,  x_Bit_Multiplier0,  y_Bit_Multiplier0);
            x_Pos_Malario = x_Pos_Malario + x_Bit_Multiplier0;
            grundmethoden.malen_Bit( graphics,  x_Pos_Malario,  y_Pos_Malario,  füllfarbe,  stiftfarbe,  x_Bit_Multiplier0,  y_Bit_Multiplier0);
            x_Pos_Malario = x_Pos_Malario + x_Bit_Multiplier0;
            grundmethoden.malen_Bit( graphics,  x_Pos_Malario,  y_Pos_Malario,  füllfarbe,  stiftfarbe,  x_Bit_Multiplier0,  y_Bit_Multiplier0);


            //Hose
            stiftfarbe = Color.Blue;
            füllfarbe = Color.Blue;
            //Dritte Ebene
            x_Pos_Malario = x_Pos_Malario - (x_Bit_Multiplier0 * 8);
            y_Pos_Malario = y_Pos_Malario - y_Bit_Multiplier0;
            grundmethoden.malen_Bit( graphics,  x_Pos_Malario,  y_Pos_Malario,  füllfarbe,  stiftfarbe,  x_Bit_Multiplier0,  y_Bit_Multiplier0);
            x_Pos_Malario = x_Pos_Malario + x_Bit_Multiplier0;
            grundmethoden.malen_Bit( graphics,  x_Pos_Malario,  y_Pos_Malario,  füllfarbe,  stiftfarbe,  x_Bit_Multiplier0,  y_Bit_Multiplier0);
            x_Pos_Malario = x_Pos_Malario + x_Bit_Multiplier0;
            grundmethoden.malen_Bit( graphics,  x_Pos_Malario,  y_Pos_Malario,  füllfarbe,  stiftfarbe,  x_Bit_Multiplier0,  y_Bit_Multiplier0);
            x_Pos_Malario = x_Pos_Malario + (x_Bit_Multiplier0 * 3);
            grundmethoden.malen_Bit( graphics,  x_Pos_Malario,  y_Pos_Malario,  füllfarbe,  stiftfarbe,  x_Bit_Multiplier0,  y_Bit_Multiplier0);
            x_Pos_Malario = x_Pos_Malario + x_Bit_Multiplier0;
            grundmethoden.malen_Bit( graphics,  x_Pos_Malario,  y_Pos_Malario,  füllfarbe,  stiftfarbe,  x_Bit_Multiplier0,  y_Bit_Multiplier0);
            x_Pos_Malario = x_Pos_Malario + x_Bit_Multiplier0;
            grundmethoden.malen_Bit( graphics,  x_Pos_Malario,  y_Pos_Malario,  füllfarbe,  stiftfarbe,  x_Bit_Multiplier0,  y_Bit_Multiplier0);
            //Vierte Ebene
            x_Pos_Malario = x_Pos_Malario - (x_Bit_Multiplier0 * 7);
            y_Pos_Malario = y_Pos_Malario - y_Bit_Multiplier0;
            grundmethoden.malen_Bit( graphics,  x_Pos_Malario,  y_Pos_Malario,  füllfarbe,  stiftfarbe,  x_Bit_Multiplier0,  y_Bit_Multiplier0);
            x_Pos_Malario = x_Pos_Malario + x_Bit_Multiplier0;
            grundmethoden.malen_Bit( graphics,  x_Pos_Malario,  y_Pos_Malario,  füllfarbe,  stiftfarbe,  x_Bit_Multiplier0,  y_Bit_Multiplier0);
            x_Pos_Malario = x_Pos_Malario + x_Bit_Multiplier0;
            grundmethoden.malen_Bit( graphics,  x_Pos_Malario,  y_Pos_Malario,  füllfarbe,  stiftfarbe,  x_Bit_Multiplier0,  y_Bit_Multiplier0);
            x_Pos_Malario = x_Pos_Malario + x_Bit_Multiplier0;
            grundmethoden.malen_Bit( graphics,  x_Pos_Malario,  y_Pos_Malario,  füllfarbe,  stiftfarbe,  x_Bit_Multiplier0,  y_Bit_Multiplier0);
            x_Pos_Malario = x_Pos_Malario + x_Bit_Multiplier0;
            grundmethoden.malen_Bit( graphics,  x_Pos_Malario,  y_Pos_Malario,  füllfarbe,  stiftfarbe,  x_Bit_Multiplier0,  y_Bit_Multiplier0);
            x_Pos_Malario = x_Pos_Malario + x_Bit_Multiplier0;
            grundmethoden.malen_Bit( graphics,  x_Pos_Malario,  y_Pos_Malario,  füllfarbe,  stiftfarbe,  x_Bit_Multiplier0,  y_Bit_Multiplier0);
            x_Pos_Malario = x_Pos_Malario + x_Bit_Multiplier0;
            grundmethoden.malen_Bit( graphics,  x_Pos_Malario,  y_Pos_Malario,  füllfarbe,  stiftfarbe,  x_Bit_Multiplier0,  y_Bit_Multiplier0);
            x_Pos_Malario = x_Pos_Malario + x_Bit_Multiplier0;
            grundmethoden.malen_Bit( graphics,  x_Pos_Malario,  y_Pos_Malario,  füllfarbe,  stiftfarbe,  x_Bit_Multiplier0,  y_Bit_Multiplier0);
            //Fünfte Ebene
            x_Pos_Malario = x_Pos_Malario - (x_Bit_Multiplier0 * 6);
            y_Pos_Malario = y_Pos_Malario - y_Bit_Multiplier0;
            grundmethoden.malen_Bit( graphics,  x_Pos_Malario,  y_Pos_Malario,  füllfarbe,  stiftfarbe,  x_Bit_Multiplier0,  y_Bit_Multiplier0);
            x_Pos_Malario = x_Pos_Malario + x_Bit_Multiplier0;
            grundmethoden.malen_Bit( graphics,  x_Pos_Malario,  y_Pos_Malario,  füllfarbe,  stiftfarbe,  x_Bit_Multiplier0,  y_Bit_Multiplier0);
            x_Pos_Malario = x_Pos_Malario + x_Bit_Multiplier0;
            grundmethoden.malen_Bit( graphics,  x_Pos_Malario,  y_Pos_Malario,  füllfarbe,  stiftfarbe,  x_Bit_Multiplier0,  y_Bit_Multiplier0);
            x_Pos_Malario = x_Pos_Malario + x_Bit_Multiplier0;
            grundmethoden.malen_Bit( graphics,  x_Pos_Malario,  y_Pos_Malario,  füllfarbe,  stiftfarbe,  x_Bit_Multiplier0,  y_Bit_Multiplier0);
            x_Pos_Malario = x_Pos_Malario + x_Bit_Multiplier0;
            grundmethoden.malen_Bit( graphics,  x_Pos_Malario,  y_Pos_Malario,  füllfarbe,  stiftfarbe,  x_Bit_Multiplier0,  y_Bit_Multiplier0);
            x_Pos_Malario = x_Pos_Malario + x_Bit_Multiplier0;
            grundmethoden.malen_Bit( graphics,  x_Pos_Malario,  y_Pos_Malario,  füllfarbe,  stiftfarbe,  x_Bit_Multiplier0,  y_Bit_Multiplier0);
            //Sechste Ebene
            x_Pos_Malario = x_Pos_Malario - (x_Bit_Multiplier0 * 5);
            y_Pos_Malario = y_Pos_Malario - y_Bit_Multiplier0;
            grundmethoden.malen_Bit( graphics,  x_Pos_Malario,  y_Pos_Malario,  füllfarbe,  stiftfarbe,  x_Bit_Multiplier0,  y_Bit_Multiplier0);
            x_Pos_Malario = x_Pos_Malario + x_Bit_Multiplier0;
            stiftfarbe = Color.Yellow;
            füllfarbe = Color.Yellow;
            grundmethoden.malen_Bit( graphics,  x_Pos_Malario,  y_Pos_Malario,  füllfarbe,  stiftfarbe,  x_Bit_Multiplier0,  y_Bit_Multiplier0);
            stiftfarbe = Color.Blue;
            füllfarbe = Color.Blue;
            x_Pos_Malario = x_Pos_Malario + x_Bit_Multiplier0;
            grundmethoden.malen_Bit( graphics,  x_Pos_Malario,  y_Pos_Malario,  füllfarbe,  stiftfarbe,  x_Bit_Multiplier0,  y_Bit_Multiplier0);
            x_Pos_Malario = x_Pos_Malario + x_Bit_Multiplier0;
            grundmethoden.malen_Bit( graphics,  x_Pos_Malario,  y_Pos_Malario,  füllfarbe,  stiftfarbe,  x_Bit_Multiplier0,  y_Bit_Multiplier0);
            x_Pos_Malario = x_Pos_Malario + x_Bit_Multiplier0;
            stiftfarbe = Color.Yellow;
            füllfarbe = Color.Yellow;
            grundmethoden.malen_Bit( graphics,  x_Pos_Malario,  y_Pos_Malario,  füllfarbe,  stiftfarbe,  x_Bit_Multiplier0,  y_Bit_Multiplier0);
            stiftfarbe = Color.Blue;
            füllfarbe = Color.Blue;
            x_Pos_Malario = x_Pos_Malario + x_Bit_Multiplier0;
            grundmethoden.malen_Bit( graphics,  x_Pos_Malario,  y_Pos_Malario,  füllfarbe,  stiftfarbe,  x_Bit_Multiplier0,  y_Bit_Multiplier0);
            //Siebte Ebene 
            x_Pos_Malario = x_Pos_Malario - (x_Bit_Multiplier0 * 4);
            y_Pos_Malario = y_Pos_Malario - y_Bit_Multiplier0;
            grundmethoden.malen_Bit( graphics,  x_Pos_Malario,  y_Pos_Malario,  füllfarbe,  stiftfarbe,  x_Bit_Multiplier0,  y_Bit_Multiplier0);
            x_Pos_Malario = x_Pos_Malario + x_Bit_Multiplier0;
            grundmethoden.malen_Bit( graphics,  x_Pos_Malario,  y_Pos_Malario,  füllfarbe,  stiftfarbe,  x_Bit_Multiplier0,  y_Bit_Multiplier0);
            x_Pos_Malario = x_Pos_Malario + x_Bit_Multiplier0;
            grundmethoden.malen_Bit( graphics,  x_Pos_Malario,  y_Pos_Malario,  füllfarbe,  stiftfarbe,  x_Bit_Multiplier0,  y_Bit_Multiplier0);
            x_Pos_Malario = x_Pos_Malario + x_Bit_Multiplier0;
            grundmethoden.malen_Bit( graphics,  x_Pos_Malario,  y_Pos_Malario,  füllfarbe,  stiftfarbe,  x_Bit_Multiplier0,  y_Bit_Multiplier0);
            //Achte Ebene
            x_Pos_Malario = x_Pos_Malario - (x_Bit_Multiplier0 * 3);
            y_Pos_Malario = y_Pos_Malario - y_Bit_Multiplier0;
            grundmethoden.malen_Bit( graphics,  x_Pos_Malario,  y_Pos_Malario,  füllfarbe,  stiftfarbe,  x_Bit_Multiplier0,  y_Bit_Multiplier0);
            x_Pos_Malario = x_Pos_Malario + (x_Bit_Multiplier0 * 3);
            grundmethoden.malen_Bit( graphics,  x_Pos_Malario,  y_Pos_Malario,  füllfarbe,  stiftfarbe,  x_Bit_Multiplier0,  y_Bit_Multiplier0);
            //Neunte Ebene
            x_Pos_Malario = x_Pos_Malario - (x_Bit_Multiplier0 * 3);
            y_Pos_Malario = y_Pos_Malario - y_Bit_Multiplier0;
            grundmethoden.malen_Bit( graphics,  x_Pos_Malario,  y_Pos_Malario,  füllfarbe,  stiftfarbe,  x_Bit_Multiplier0,  y_Bit_Multiplier0);


            //T-Shit
            //Sechste Ebene
            stiftfarbe = Color.Red;
            füllfarbe = Color.Red;
            x_Pos_Malario = x_Pos_Malario - (x_Bit_Multiplier0 * 2);
            y_Pos_Malario = y_Pos_Malario + y_Bit_Multiplier0 * 3;
            grundmethoden.malen_Bit( graphics,  x_Pos_Malario,  y_Pos_Malario,  füllfarbe,  stiftfarbe,  x_Bit_Multiplier0,  y_Bit_Multiplier0);
            x_Pos_Malario = x_Pos_Malario + (x_Bit_Multiplier0 * 7);
            grundmethoden.malen_Bit( graphics,  x_Pos_Malario,  y_Pos_Malario,  füllfarbe,  stiftfarbe,  x_Bit_Multiplier0,  y_Bit_Multiplier0);
            //Siebte Ebene
            x_Pos_Malario = x_Pos_Malario - (x_Bit_Multiplier0 * 9);
            y_Pos_Malario = y_Pos_Malario - y_Bit_Multiplier0;
            grundmethoden.malen_Bit( graphics,  x_Pos_Malario,  y_Pos_Malario,  füllfarbe,  stiftfarbe,  x_Bit_Multiplier0,  y_Bit_Multiplier0);
            x_Pos_Malario = x_Pos_Malario + x_Bit_Multiplier0;
            grundmethoden.malen_Bit( graphics,  x_Pos_Malario,  y_Pos_Malario,  füllfarbe,  stiftfarbe,  x_Bit_Multiplier0,  y_Bit_Multiplier0);
            x_Pos_Malario = x_Pos_Malario + x_Bit_Multiplier0;
            grundmethoden.malen_Bit( graphics,  x_Pos_Malario,  y_Pos_Malario,  füllfarbe,  stiftfarbe,  x_Bit_Multiplier0,  y_Bit_Multiplier0);
            x_Pos_Malario = x_Pos_Malario + x_Bit_Multiplier0;
            grundmethoden.malen_Bit( graphics,  x_Pos_Malario,  y_Pos_Malario,  füllfarbe,  stiftfarbe,  x_Bit_Multiplier0,  y_Bit_Multiplier0);
            x_Pos_Malario = x_Pos_Malario + x_Bit_Multiplier0 * 5;
            grundmethoden.malen_Bit( graphics,  x_Pos_Malario,  y_Pos_Malario,  füllfarbe,  stiftfarbe,  x_Bit_Multiplier0,  y_Bit_Multiplier0);
            x_Pos_Malario = x_Pos_Malario + x_Bit_Multiplier0;
            grundmethoden.malen_Bit( graphics,  x_Pos_Malario,  y_Pos_Malario,  füllfarbe,  stiftfarbe,  x_Bit_Multiplier0,  y_Bit_Multiplier0);
            x_Pos_Malario = x_Pos_Malario + x_Bit_Multiplier0;
            grundmethoden.malen_Bit( graphics,  x_Pos_Malario,  y_Pos_Malario,  füllfarbe,  stiftfarbe,  x_Bit_Multiplier0,  y_Bit_Multiplier0);
            x_Pos_Malario = x_Pos_Malario + x_Bit_Multiplier0;
            grundmethoden.malen_Bit( graphics,  x_Pos_Malario,  y_Pos_Malario,  füllfarbe,  stiftfarbe,  x_Bit_Multiplier0,  y_Bit_Multiplier0);
        }
    }
}


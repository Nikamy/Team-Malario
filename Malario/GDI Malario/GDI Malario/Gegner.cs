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
        public static void malen_Gambo(ref Graphics graphics)
        {
            int x_Pos = 0, y_Pos = 6, Bit_Multiplier0 = 6;
            Color füllfarbe = Color.Brown;
            Color stiftfarbe = Color.Brown;

            y_Pos = y_Pos + (Bit_Multiplier0 * 14);
            //unterste Ebene
            Grundmethoden grundmethoden = new Grundmethoden();
            x_Pos = x_Pos + Bit_Multiplier0;
            grundmethoden.malen_Bit(ref graphics, ref x_Pos, ref y_Pos, ref füllfarbe, ref stiftfarbe, ref Bit_Multiplier0, ref Bit_Multiplier0);
            x_Pos = x_Pos + (4 * Bit_Multiplier0);
            grundmethoden.malen_Bit(ref graphics, ref x_Pos, ref y_Pos, ref füllfarbe, ref stiftfarbe, ref Bit_Multiplier0, ref Bit_Multiplier0);
            x_Pos = x_Pos + Bit_Multiplier0;
            grundmethoden.malen_Bit(ref graphics, ref x_Pos, ref y_Pos, ref füllfarbe, ref stiftfarbe, ref Bit_Multiplier0, ref Bit_Multiplier0);
            x_Pos = x_Pos + (3 * Bit_Multiplier0);
            grundmethoden.malen_Bit(ref graphics, ref x_Pos, ref y_Pos, ref füllfarbe, ref stiftfarbe, ref Bit_Multiplier0, ref Bit_Multiplier0);
            x_Pos = x_Pos + Bit_Multiplier0;
            grundmethoden.malen_Bit(ref graphics, ref x_Pos, ref y_Pos, ref füllfarbe, ref stiftfarbe, ref Bit_Multiplier0, ref Bit_Multiplier0);
            x_Pos = x_Pos + (4 * Bit_Multiplier0);
            grundmethoden.malen_Bit(ref graphics, ref x_Pos, ref y_Pos, ref füllfarbe, ref stiftfarbe, ref Bit_Multiplier0, ref Bit_Multiplier0);
            //eine Ebene höher
            y_Pos -= Bit_Multiplier0;
            grundmethoden.malen_Bit(ref graphics, ref x_Pos, ref y_Pos, ref füllfarbe, ref stiftfarbe, ref Bit_Multiplier0, ref Bit_Multiplier0);
            x_Pos -= Bit_Multiplier0;
            grundmethoden.malen_Bit(ref graphics, ref x_Pos, ref y_Pos, ref füllfarbe, ref stiftfarbe, ref Bit_Multiplier0, ref Bit_Multiplier0);
            x_Pos -= (2 * Bit_Multiplier0);
            grundmethoden.malen_Bit(ref graphics, ref x_Pos, ref y_Pos, ref füllfarbe, ref stiftfarbe, ref Bit_Multiplier0, ref Bit_Multiplier0);
            x_Pos -= Bit_Multiplier0;
            grundmethoden.malen_Bit(ref graphics, ref x_Pos, ref y_Pos, ref füllfarbe, ref stiftfarbe, ref Bit_Multiplier0, ref Bit_Multiplier0);
            x_Pos -= Bit_Multiplier0;
            grundmethoden.malen_Bit(ref graphics, ref x_Pos, ref y_Pos, ref füllfarbe, ref stiftfarbe, ref Bit_Multiplier0, ref Bit_Multiplier0);
            x_Pos -= (3*Bit_Multiplier0);
            grundmethoden.malen_Bit(ref graphics, ref x_Pos, ref y_Pos, ref füllfarbe, ref stiftfarbe, ref Bit_Multiplier0, ref Bit_Multiplier0);
            x_Pos -= Bit_Multiplier0;
            grundmethoden.malen_Bit(ref graphics, ref x_Pos, ref y_Pos, ref füllfarbe, ref stiftfarbe, ref Bit_Multiplier0, ref Bit_Multiplier0);
            x_Pos -= Bit_Multiplier0;
            grundmethoden.malen_Bit(ref graphics, ref x_Pos, ref y_Pos, ref füllfarbe, ref stiftfarbe, ref Bit_Multiplier0, ref Bit_Multiplier0);
            x_Pos -= (2*Bit_Multiplier0);
            grundmethoden.malen_Bit(ref graphics, ref x_Pos, ref y_Pos, ref füllfarbe, ref stiftfarbe, ref Bit_Multiplier0, ref Bit_Multiplier0);
            x_Pos -= Bit_Multiplier0;
            grundmethoden.malen_Bit(ref graphics, ref x_Pos, ref y_Pos, ref füllfarbe, ref stiftfarbe, ref Bit_Multiplier0, ref Bit_Multiplier0);
            for (int i = 0; i < 5; i++)
            {
                x_Pos = 0;
                y_Pos -= Bit_Multiplier0;
                for (int j = 0; j < 14; j++)
                {
                    x_Pos += Bit_Multiplier0;
                    grundmethoden.malen_Bit(ref graphics, ref x_Pos, ref y_Pos, ref füllfarbe, ref stiftfarbe, ref Bit_Multiplier0, ref Bit_Multiplier0);
                }
            }

        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Panel_Malario
            // 
            this.Panel_Malario.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Malario_Paint);
            // 
            // Malario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(464, 441);
            this.Name = "Gambo";
            this.ResumeLayout(false);

        }

        private void Panel_Malario_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

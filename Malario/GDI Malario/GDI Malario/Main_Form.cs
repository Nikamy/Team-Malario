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
        int x_Coorinate_Malario;
        bool M_Right = false, M_Left = false, M_Crouch = false, M_Jump = false;
        public Main_Form()
        {
            InitializeComponent();
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
                    M_Jump = true;
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (M_Right == true)
            {
                Panel_Malario.Left += 5;
            }
            if (M_Left == true)
            {
                Panel_Malario.Left -= 5;
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
                case Keys.W:
                    M_Jump = false;
                    break;
            }
        }
        private void Main_Form_Load(object sender, EventArgs e)
        {
            
        }
        private void Panel_Malario_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            base.OnPaint(e);
            Malario.malen_Malario(ref graphics);
            //Lässt das Panel neuladen und anzeigen
            Panel_Malario.Paint += new PaintEventHandler(Panel_Malario_Paint);
            //Panel_Malario.Refresh();
        }

        
    }
}

﻿namespace GDI_Malario
{
    partial class Main_Form
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Panel_Malario = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Panel_Game = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Panel_Game.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Malario
            // 
            this.Panel_Malario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Panel_Malario.BackColor = System.Drawing.Color.White;
            this.Panel_Malario.ForeColor = System.Drawing.Color.White;
            this.Panel_Malario.Location = new System.Drawing.Point(277, 339);
            this.Panel_Malario.Name = "Panel_Malario";
            this.Panel_Malario.Size = new System.Drawing.Size(34, 34);
            this.Panel_Malario.TabIndex = 0;
            this.Panel_Malario.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Malario_Paint);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Panel_Game
            // 
            this.Panel_Game.Controls.Add(this.Panel_Malario);
            this.Panel_Game.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Game.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Panel_Game.Location = new System.Drawing.Point(0, 0);
            this.Panel_Game.Name = "Panel_Game";
            this.Panel_Game.Size = new System.Drawing.Size(569, 569);
            this.Panel_Game.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(569, 569);
            this.Controls.Add(this.Panel_Game);
            this.Name = "Main_Form";
            this.Text = "Malario";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_Form_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Main_Form_KeyUp);
            this.Panel_Game.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel Panel_Malario;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Panel Panel_Game;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}


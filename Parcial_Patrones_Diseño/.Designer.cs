namespace Parcial_Patrones_Diseño
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mODULOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pEDIDOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOMPRASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fACTURACIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOTIZACIONESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mODULOSToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1400, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mODULOSToolStripMenuItem
            // 
            this.mODULOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pEDIDOSToolStripMenuItem,
            this.cOMPRASToolStripMenuItem,
            this.fACTURACIONToolStripMenuItem,
            this.cOTIZACIONESToolStripMenuItem});
            this.mODULOSToolStripMenuItem.Name = "mODULOSToolStripMenuItem";
            this.mODULOSToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.mODULOSToolStripMenuItem.Text = "MODULOS";
            // 
            // pEDIDOSToolStripMenuItem
            // 
            this.pEDIDOSToolStripMenuItem.Name = "pEDIDOSToolStripMenuItem";
            this.pEDIDOSToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.pEDIDOSToolStripMenuItem.Text = "PEDIDOS";
            // 
            // cOMPRASToolStripMenuItem
            // 
            this.cOMPRASToolStripMenuItem.Name = "cOMPRASToolStripMenuItem";
            this.cOMPRASToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.cOMPRASToolStripMenuItem.Text = "COMPRAS";
            // 
            // fACTURACIONToolStripMenuItem
            // 
            this.fACTURACIONToolStripMenuItem.Name = "fACTURACIONToolStripMenuItem";
            this.fACTURACIONToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.fACTURACIONToolStripMenuItem.Text = "FACTURACION";
            // 
            // cOTIZACIONESToolStripMenuItem
            // 
            this.cOTIZACIONESToolStripMenuItem.Name = "cOTIZACIONESToolStripMenuItem";
            this.cOTIZACIONESToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.cOTIZACIONESToolStripMenuItem.Text = "COTIZACIONES";
            // 
            // panelMenu
            // 
            this.panelMenu.Location = new System.Drawing.Point(0, 31);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1400, 672);
            this.panelMenu.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1400, 703);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Patrones Diseño Sofware";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mODULOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pEDIDOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOMPRASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fACTURACIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOTIZACIONESToolStripMenuItem;
        private System.Windows.Forms.Panel panelMenu;
    }
}

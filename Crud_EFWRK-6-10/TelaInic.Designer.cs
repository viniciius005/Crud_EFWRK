namespace Crud_EFWRK_6_10
{
    partial class TelaInic
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msSair = new System.Windows.Forms.ToolStripMenuItem();
            this.msCadAgenda = new System.Windows.Forms.ToolStripMenuItem();
            this.msCadAula = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.msSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(283, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msCadAgenda,
            this.msCadAula});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // msSair
            // 
            this.msSair.Name = "msSair";
            this.msSair.Size = new System.Drawing.Size(38, 20);
            this.msSair.Text = "Sair";
            this.msSair.Click += new System.EventHandler(this.msSair_Click);
            // 
            // msCadAgenda
            // 
            this.msCadAgenda.Name = "msCadAgenda";
            this.msCadAgenda.Size = new System.Drawing.Size(180, 22);
            this.msCadAgenda.Text = "Cadastro Agenda";
            this.msCadAgenda.Click += new System.EventHandler(this.msCadAgenda_Click);
            // 
            // msCadAula
            // 
            this.msCadAula.Name = "msCadAula";
            this.msCadAula.Size = new System.Drawing.Size(180, 22);
            this.msCadAula.Text = "Cadastro Aula";
            this.msCadAula.Click += new System.EventHandler(this.msCadAula_Click);
            // 
            // TelaInic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 260);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TelaInic";
            this.Text = "TelaInic";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msCadAgenda;
        private System.Windows.Forms.ToolStripMenuItem msCadAula;
        private System.Windows.Forms.ToolStripMenuItem msSair;
    }
}
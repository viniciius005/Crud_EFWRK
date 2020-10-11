namespace Crud_EFWRK_6_10
{
    partial class SalaAulas
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
            this.btnInserir = new System.Windows.Forms.Button();
            this.mtxtData = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GridSalaAula = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtProf = new System.Windows.Forms.TextBox();
            this.txtSala = new System.Windows.Forms.TextBox();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.Sala = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridSalaAula)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(38, 223);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 0;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // mtxtData
            // 
            this.mtxtData.Location = new System.Drawing.Point(107, 188);
            this.mtxtData.Mask = "00/00/0000";
            this.mtxtData.Name = "mtxtData";
            this.mtxtData.Size = new System.Drawing.Size(100, 20);
            this.mtxtData.TabIndex = 1;
            this.mtxtData.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // GridSalaAula
            // 
            this.GridSalaAula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridSalaAula.Location = new System.Drawing.Point(12, 262);
            this.GridSalaAula.Name = "GridSalaAula";
            this.GridSalaAula.Size = new System.Drawing.Size(364, 176);
            this.GridSalaAula.TabIndex = 3;
            this.GridSalaAula.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridSalaAula_CellClick);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(105, 36);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(33, 20);
            this.txtId.TabIndex = 4;
            // 
            // txtProf
            // 
            this.txtProf.Location = new System.Drawing.Point(107, 79);
            this.txtProf.Name = "txtProf";
            this.txtProf.Size = new System.Drawing.Size(213, 20);
            this.txtProf.TabIndex = 4;
            // 
            // txtSala
            // 
            this.txtSala.Location = new System.Drawing.Point(107, 119);
            this.txtSala.Name = "txtSala";
            this.txtSala.Size = new System.Drawing.Size(100, 20);
            this.txtSala.TabIndex = 4;
            // 
            // txtCurso
            // 
            this.txtCurso.Location = new System.Drawing.Point(107, 149);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(100, 20);
            this.txtCurso.TabIndex = 4;
            // 
            // Sala
            // 
            this.Sala.AutoSize = true;
            this.Sala.Location = new System.Drawing.Point(38, 122);
            this.Sala.Name = "Sala";
            this.Sala.Size = new System.Drawing.Size(28, 13);
            this.Sala.TabIndex = 2;
            this.Sala.Text = "Sala";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Curso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Professor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(131, 223);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 0;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(225, 223);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 0;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // SalaAulas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 450);
            this.Controls.Add(this.txtCurso);
            this.Controls.Add(this.txtSala);
            this.Controls.Add(this.txtProf);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.GridSalaAula);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Sala);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtxtData);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnInserir);
            this.Name = "SalaAulas";
            this.Text = "SalaAulas";
            this.Load += new System.EventHandler(this.SalaAulas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridSalaAula)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.MaskedTextBox mtxtData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GridSalaAula;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtProf;
        private System.Windows.Forms.TextBox txtSala;
        private System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.Label Sala;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
    }
}
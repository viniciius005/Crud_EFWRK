namespace Crud_EFWRK_6_10
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grid = new System.Windows.Forms.DataGridView();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.btninserir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.mtxtTel = new System.Windows.Forms.MaskedTextBox();
            this.mtxtcpf = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Telefone";
            // 
            // grid
            // 
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(9, 227);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(376, 179);
            this.grid.TabIndex = 1;
            this.grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellClick);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(93, 25);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(63, 20);
            this.txtid.TabIndex = 2;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(93, 76);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(231, 20);
            this.txtnome.TabIndex = 2;
            // 
            // btninserir
            // 
            this.btninserir.Location = new System.Drawing.Point(46, 198);
            this.btninserir.Name = "btninserir";
            this.btninserir.Size = new System.Drawing.Size(75, 23);
            this.btninserir.TabIndex = 3;
            this.btninserir.Text = "Inserir";
            this.btninserir.UseVisualStyleBackColor = true;
            this.btninserir.Click += new System.EventHandler(this.btninserir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(145, 198);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(249, 198);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // mtxtTel
            // 
            this.mtxtTel.Location = new System.Drawing.Point(93, 126);
            this.mtxtTel.Mask = "(99) 00000-0000";
            this.mtxtTel.Name = "mtxtTel";
            this.mtxtTel.Size = new System.Drawing.Size(100, 20);
            this.mtxtTel.TabIndex = 6;
            // 
            // mtxtcpf
            // 
            this.mtxtcpf.Location = new System.Drawing.Point(93, 164);
            this.mtxtcpf.Mask = "000.000.000-00";
            this.mtxtcpf.Name = "mtxtcpf";
            this.mtxtcpf.Size = new System.Drawing.Size(100, 20);
            this.mtxtcpf.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "CPF";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 428);
            this.Controls.Add(this.mtxtcpf);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mtxtTel);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btninserir);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Button btninserir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.MaskedTextBox mtxtTel;
        private System.Windows.Forms.MaskedTextBox mtxtcpf;
        private System.Windows.Forms.Label label4;
    }
}


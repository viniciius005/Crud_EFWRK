using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Crud_EFWRK_6_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void btninserir_Click(object sender, EventArgs e)
        {
            try
            {
                using (var tb = new Contexto())
                {
                    tb.ObjetoAgenda.Add(new Agenda { nome = txtnome.Text, telefone = mtxtTel.Text, CPF = mtxtcpf.Text });
                    tb.SaveChanges();
                    limparcampos();
                    MessageBox.Show("Incluido com Sucesso", "Inclusão");
                    AtualizaGrid();
                }
                
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
           
        }

        public void limparcampos()
        {
            txtnome.Clear();
            txtid.Clear();
            mtxtcpf.Clear();
            mtxtTel.Clear();
            txtnome.Focus();
            
    }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var tb = new Contexto())
                {
                    var objeto = tb.ObjetoAgenda.Find(Convert.ToInt32(txtid.Text));
                    objeto.nome = txtnome.Text;
                    objeto.telefone = mtxtTel.Text;
                    objeto.CPF = mtxtcpf.Text;

                    tb.Entry(objeto).State = EntityState.Modified;
                    tb.SaveChanges();
                    MessageBox.Show("Alterado com Sucesso", "Alteração");
                    AtualizaGrid();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
           
        }

       
        private void AtualizaGrid()
        {
            using (var tb = new Contexto())
            {
                grid.DataSource = null;
                grid.DataSource = tb.ObjetoAgenda.ToList();
            }
        }
      
        private void Form1_Load(object sender, EventArgs e)
        {
            AtualizaGrid();
        }
      
        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = grid.CurrentRow.Cells[0].Value.ToString();
            txtnome.Text = grid.CurrentRow.Cells[1].Value.ToString();
            mtxtTel.Text = grid.CurrentRow.Cells[2].Value.ToString();
            mtxtcpf.Text = grid.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                using (var tb = new Contexto())
                {
                    var objeto = tb.ObjetoAgenda.Find(Convert.ToInt32(txtid.Text));
                    tb.ObjetoAgenda.Remove(objeto);
                    tb.SaveChanges();
                    MessageBox.Show("Excluido com Sucesso", "Exclusão");
                    limparcampos();
                    AtualizaGrid();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
         
        }
    }
    
}

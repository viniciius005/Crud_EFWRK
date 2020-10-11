using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace Crud_EFWRK_6_10
{
    public partial class SalaAulas : Form
    {
        public SalaAulas()
        {
            InitializeComponent();
        }

        public void limparcampos()
        {
            txtId.Clear();
            txtProf.Clear();
            txtCurso.Clear();
            txtSala.Clear();
            mtxtData.Clear();
            txtProf.Focus();
        }
       
        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                using (var tb = new Contexto())
                {
                    tb.ObjetoSalaAula.Add(new SalaAula { Professor = txtProf.Text, Curso= txtCurso.Text, Sala= txtSala.Text , Data = mtxtData.Text });
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
        private void AtualizaGrid()
        {
            using (var tb = new Contexto())
            {
                GridSalaAula.DataSource = null;
                GridSalaAula.DataSource = tb.ObjetoSalaAula.ToList();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var tb = new Contexto())
                {
                    var objeto = tb.ObjetoSalaAula.Find(Convert.ToInt32(txtId.Text));
                    objeto.Professor = txtProf.Text;
                    objeto.Curso = txtCurso.Text;
                    objeto.Sala = txtSala.Text;
                    objeto.Data = mtxtData.Text;

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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                using (var tb = new Contexto())
                {
                    var objeto = tb.ObjetoSalaAula.Find(Convert.ToInt32(txtId.Text));
                    tb.ObjetoSalaAula.Remove(objeto);
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

        private void GridSalaAula_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = GridSalaAula.CurrentRow.Cells[0].Value.ToString();
            txtProf.Text = GridSalaAula.CurrentRow.Cells[1].Value.ToString();
            txtCurso.Text = GridSalaAula.CurrentRow.Cells[2].Value.ToString();
            txtSala.Text = GridSalaAula.CurrentRow.Cells[3].Value.ToString();
            mtxtData.Text = GridSalaAula.CurrentRow.Cells[4].Value.ToString();
        }

        private void SalaAulas_Load(object sender, EventArgs e)
        {
            AtualizaGrid();
        }
    }
    
}

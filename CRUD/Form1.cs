using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ConexaoAluno bd = new ConexaoAluno();
        string tabela = "tblalunos";
        
        private void ExibirDados()
        {
            string dados = $"SELECT * FROM {tabela} ORDER BY nome";
            DataTable dt = bd.executarConsulta(dados);
            dtgAluno.DataSource = dt.AsDataView();
        }

        private void LimpaDados()
        {
            txtNome.Clear();
            txtIdade.Clear();
            rdbBarroca.Checked = false;
            rdbFloresta.Checked = false;
            rdbSerie1.Checked = false;
            rdbSerie2.Checked = false;
            rdbSerie3.Checked = false;
            cmbTurma.Text = "";
            txtNome.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            ExibirDados();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string inserir;
            string unidade = rdbBarroca.Checked ? "Barroca" : "Floresta";
            int serie = rdbSerie1.Checked ? 1 : rdbSerie2.Checked ? 2 : 3;
            string turma = cmbTurma.Text;
            int idade;
            if (txtNome.Text != "" && int.TryParse(txtIdade.Text, out idade))
            {
                inserir = String.Format($" INSERT INTO {tabela} values (NULL, '{txtNome.Text}', '{txtIdade.Text}', '{unidade}' , '{serie}','{turma}')");
                bd.executarComandos(inserir);
                
            }
            else
            {
                MessageBox.Show("Iformação Inválida1", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string excluir;
            if(txtNome.Text != "")
            {
                excluir = String.Format($"DELETE FROM {tabela} WHERE id = '{lblID.Text}'");
                int resultado = bd.executarComandos(excluir);
                ExibirDados();
                if (resultado == 1)
                {
                    MessageBox.Show("Registro deletado com sucesso.", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Informação Inválida!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LimpaDados();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string alterar;
            int idade;
            if (int.TryParse(txtIdade.Text, out idade))
            {
                string unidade = rdbBarroca.Checked ? "Barroca" : "Floresta";
                int serie = rdbSerie1.Checked ? 1 : rdbSerie2.Checked ? 2 : 3;
                string turma = cmbTurma.Text;
                alterar = string.Format($"UPDATE {tabela} SET nome = '{txtNome.Text}', idade = '{txtIdade.Text}', unidade = '{unidade}', serie = '{serie}', turma '{turma}' WHERE id = '{lblID.Text}'");
                int resultado = bd.executarComandos(alterar);
                ExibirDados();
                if (resultado == 1)
                {
                    MessageBox.Show("Registro deletado com sucesso.", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Informação Inválida!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LimpaDados();
        }

        private void dtgAluno_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e)
        {
            e.ToolTipText = "Clique em uma célila para preencher os campos do formulário. ";
        }

        private void dtgAluno_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblID.Text = dtgAluno.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNome.Text = dtgAluno.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtIdade.Text = dtgAluno.Rows[e.RowIndex].Cells[2].Value.ToString();
            string unidade = dtgAluno.Rows[e.RowIndex].Cells[3].Value.ToString();
            string serie = dtgAluno.Rows[e.RowIndex].Cells[4].Value.ToString();
            cmbTurma.Text = dtgAluno.Rows[e.RowIndex].Cells[5].Value.ToString();

            if(unidade == "Barroca")
            {
                rdbBarroca.Checked = true;
            }
            else
            {
                rdbFloresta.Checked = true;
            }

            if (serie == "1")
            {
                rdbSerie1.Checked = true;
            }
            else if (serie == "2")
            {
                rdbSerie2.Checked = true;
            }
            else
            {
                rdbSerie3.Checked = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ExibirDados();
        }

      
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using koc.Controller;
using koc.Model;

namespace koc.View.Visualizar
{
    public partial class VisualizarCliente : Form
    {
        public VisualizarCliente()
        {
            InitializeComponent();
            Conexao.iniciarBanco();
        }

        private Cliente clienteSelecionado;

        private void visualizarClientes()
        {
            List<Cliente> lista = Cliente.listarCliente();

            lvClientes.Items.Clear();

            foreach (Cliente cliente in lista)
            {
                ListViewItem dados = new ListViewItem(
                    new string[] {cliente.IdCli.ToString(), cliente.NomeCli.ToString(), cliente.CpfCli.ToString(), cliente.FoneCli.ToString(), cliente.EmailCli.ToString(), cliente.SenhaCli.ToString()
                });

                dados.Tag = cliente;

                lvClientes.Items.Add(dados);
            }
        }

        private void btnBuscarCli_Click(object sender, EventArgs e)
        {
            if (Conexao.dbConexao.State != ConnectionState.Open)
            {
                visualizarClientes();
            }
        }

        private void lvClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvClientes.SelectedItems.Count > 0)
            {
                ListViewItem dados = lvClientes.SelectedItems[0];
                clienteSelecionado = (Cliente)dados.Tag;

                int idCli = clienteSelecionado.IdCli;
                string nomeCli = clienteSelecionado.NomeCli;
                long cpfCli = clienteSelecionado.CpfCli;
                long foneCli = clienteSelecionado.FoneCli;
                string emailCli = clienteSelecionado.EmailCli;
                string senhaCli = clienteSelecionado.SenhaCli;

                tbxIdCli.Text = idCli.ToString();
                tbxNomeCli.Text = nomeCli;
                tbxCpfCli.Text = cpfCli.ToString();
                tbxFoneCli.Text = foneCli.ToString();
                tbxEmailCli.Text = emailCli;
                tbxSenhaCli.Text = senhaCli;

            }
        }

        private void btnAlterarCli_Click(object sender, EventArgs e)
        {
            if (tbxNomeCli.Text == "" | tbxCpfCli.Text == "" | tbxFoneCli.Text == "" | tbxEmailCli.Text == "" | tbxSenhaCli.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (tbxCpfCli.TextLength != 11 || tbxFoneCli.TextLength != 11)
            {
                MessageBox.Show("O CPF e o telefone devem conter 11 caracteres.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                string nomeCli = tbxNomeCli.Text;
                long cpfCli = Convert.ToInt64(tbxCpfCli.Text);
                long foneCli = Convert.ToInt64(tbxFoneCli.Text);
                string emailCli = tbxEmailCli.Text;
                string senhaCli = tbxSenhaCli.Text;

                clienteSelecionado.alterarCliente(nomeCli, cpfCli, foneCli, emailCli, senhaCli);
                visualizarClientes();
                limpaTela();
            }
        }

        private void btnDeletarCli_Click(object sender, EventArgs e)
        {
            if (clienteSelecionado == null)
            {
                MessageBox.Show("Selecione um cliente");
            }
            else
            {
                var confirmacao = MessageBox.Show("Tem certeza que deseja deletar o cliente?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacao == DialogResult.Yes)
                {
                clienteSelecionado.deletarCliente();
                visualizarClientes();
                limpaTela();

                }
            }
        }

        private void limpaTela()
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl is TextBox)
                {
                    ctl.Text = string.Empty;
                }
            }
        }
    }
}

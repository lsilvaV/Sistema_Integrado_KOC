using System;
using System.Windows.Forms;
using koc.Controller;
using koc.Model;

namespace koc.View.Cadastrar
{
    public partial class CadastrarCliente : Form
    {
        public CadastrarCliente()
        {
            InitializeComponent();
            Conexao.iniciarBanco();
        }

        private Cliente inserirCliente;

        private void btnCadastrarCli_Click(object sender, EventArgs e)
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

                inserirCliente = Cliente.inserirCliente(nomeCli, cpfCli, foneCli, emailCli, senhaCli);

                limpaTela();
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

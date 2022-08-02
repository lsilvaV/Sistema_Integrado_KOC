using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using koc.Controller;
using koc.Model;

namespace koc.View.Visualizar
{
    public partial class VisualizarPedido : Form
    {
        public VisualizarPedido()
        {
            InitializeComponent();
            Conexao.iniciarBanco();
        }

        private Pedido pedidoSelecionado;

        private void visualizarPedidos()
        {
            List<Pedido> lista = Pedido.listarPedido();

            lvPedidos.Items.Clear();

            foreach (Pedido pedido in lista)
            {
                ListViewItem dados = new ListViewItem(
                    new string[] {pedido.IdPed.ToString(), pedido.ConfigPed.ToString(), pedido.DataEnPed.ToString(), pedido.DataSaPed.ToString(), pedido.StatusPed.ToString(), pedido.ValorPed.ToString(), pedido.IdCliFK.ToString()
                });

                dados.Tag = pedido;

                lvPedidos.Items.Add(dados);
            }
        }

        private void btnBuscarPed_Click(object sender, EventArgs e)
        {
            if (Conexao.dbConexao.State != ConnectionState.Open)
            {
                visualizarPedidos();
            }
        }

        private void lvPedidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvPedidos.SelectedItems.Count > 0)
            {
                ListViewItem dados = lvPedidos.SelectedItems[0];
                pedidoSelecionado = (Pedido)dados.Tag;

                int idPed = pedidoSelecionado.IdPed;
                string configPed = pedidoSelecionado.ConfigPed;
                string dataEnPed = pedidoSelecionado.DataEnPed;
                string dataSaPed = pedidoSelecionado.DataSaPed;
                string statusPed = pedidoSelecionado.StatusPed;
                decimal valorPed = pedidoSelecionado.ValorPed;
                int idCliFK = pedidoSelecionado.IdCliFK;

                tbxIdPed.Text = idPed.ToString();
                rtbConfigPed.Text = configPed;
                tbxDataEnPed.Text = dataEnPed;
                tbxDataSaPed.Text = dataSaPed;
                cbxStatusPed.Text = statusPed;
                tbxValorPed.Text = valorPed.ToString();
                tbxIdCliFK.Text = idCliFK.ToString();

            }
        }

        private void btnAlterarPed_Click(object sender, EventArgs e)
        {
            if (rtbConfigPed.Text == "" | tbxValorPed.Text == "" | tbxDataEnPed.Text == "" | tbxDataSaPed.Text == "" | cbxStatusPed.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                string configPed = rtbConfigPed.Text;
                decimal valorPed = Convert.ToDecimal(tbxValorPed.Text);
                string dataEnPed = tbxDataEnPed.Text;
                string dataSaPed = tbxDataSaPed.Text;
                string statusPed = cbxStatusPed.Text;

                pedidoSelecionado.alterarPedido(configPed, dataEnPed, dataSaPed, statusPed, valorPed);
                visualizarPedidos();
                limpaTela();

            }
        }

        private void btnDeletarPed_Click(object sender, EventArgs e)
        {
            if (pedidoSelecionado == null)
            {
                MessageBox.Show("Selecione um pedido");
            }
            else
            {
                var confirmacao = MessageBox.Show("Tem certeza que deseja deletar o pedido?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacao == DialogResult.Yes)
                {
                    pedidoSelecionado.deletarPedido();
                    visualizarPedidos();
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

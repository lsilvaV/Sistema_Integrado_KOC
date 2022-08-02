using System;
using System.Windows.Forms;
using koc.Controller;
using koc.Model;

namespace koc.View.Cadastrar
{
    public partial class CadastrarPedido : Form
    {
        public CadastrarPedido()
        {
            InitializeComponent();
            Conexao.iniciarBanco();
        }

        private Pedido inserirPedido;

        private void btnCadastrarPed_Click(object sender, EventArgs e)
        {
            if (rtbConfigPed.Text == "" || tbxDataEnPed.Text == "" || tbxDataSaPed.Text == "" || cbxStatusPed.Text == "" || tbxValorPed.Text == "" || tbxIdCliFK.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                string configPed = rtbConfigPed.Text;
                string dataEnPed = tbxDataEnPed.Text;
                string dataSaPed = tbxDataSaPed.Text;
                string statusPed = cbxStatusPed.Text;
                decimal valorPed = Convert.ToDecimal(tbxValorPed.Text);
                int idCliFK = Convert.ToInt32(tbxIdCliFK.Text);

                inserirPedido = Pedido.inserirPedido(configPed, dataEnPed, dataSaPed, statusPed, valorPed, idCliFK);
            }
        }
    }
}

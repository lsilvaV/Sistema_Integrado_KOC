using System;
using System.Windows.Forms;
using koc.View.Cadastrar;
using koc.View.Visualizar;


namespace koc.View
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        //CLIENTE
        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            CadastrarCliente cadastrarCliente = new CadastrarCliente();
            cadastrarCliente.ShowDialog();
        }


        private void btnVisualizarCliente_Click(object sender, EventArgs e)
        {
            VisualizarCliente visualizarCliente = new VisualizarCliente();
            visualizarCliente.ShowDialog();
        }

        //PEDIDO
        private void btnCadastrarManutencao_Click(object sender, EventArgs e)
        {
            CadastrarPedido cadastrarPedido = new CadastrarPedido();
            cadastrarPedido.ShowDialog();
        }

        private void btnVisualizarManutencao_Click(object sender, EventArgs e)
        {
            VisualizarPedido visualizarPedido = new VisualizarPedido();
            visualizarPedido.ShowDialog();
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Feito para uso educacional :)");
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}

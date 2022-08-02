using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using koc.Controller;


namespace koc.Model
{
    class Pedido
    {
        //DEFININDO ELEMENTOS
        public int IdPed { get; private set; }
        public string ConfigPed { get; private set; }
        public string DataEnPed { get; private set; }
        public string DataSaPed { get; private set; }
        public string StatusPed { get; private set; }
        public decimal ValorPed { get; private set; }
        public int IdCliFK { get; private set; }

        public Pedido(int idPed, string configPed, string dataEnPed, string dataSaPed, string statusPed, decimal valorPed, int idCliFK)
        {
            IdPed = idPed;
            ConfigPed = configPed;
            DataEnPed = dataEnPed;
            DataSaPed = dataSaPed;
            StatusPed = statusPed;
            ValorPed = valorPed;
            IdCliFK = idCliFK;
        }

        //INSERIR
        public static Pedido inserirPedido(string configPed, string dataEnPed, string dataSaPed, string statusPed, decimal valorPed, int idCliFK)
        {
            string query = string.Format("INSERT INTO tbpedido(configPed, dataEnPed, dataSaPed, statusPed, valorPed, idCliFK) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", configPed, dataEnPed, dataSaPed,  statusPed, valorPed, idCliFK);

            MySqlCommand cmd = new MySqlCommand(query, Conexao.dbConexao);
            Conexao.dbConexao.Open();
            cmd.ExecuteNonQuery();

            int idPed = (int)cmd.LastInsertedId;
            Pedido pedido = new Pedido(idPed, configPed, dataEnPed, dataSaPed, statusPed, valorPed, idCliFK);

            var resposta = MessageBox.Show("Pedido cadastrado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Conexao.dbConexao.Close();

            return pedido;
        }

        //LISTAR
        public static List<Pedido> listarPedido()
        {
            List<Pedido> listaPedido = new List<Pedido>();

            string query = "SELECT * FROM tbpedido";
            MySqlCommand cmd = new MySqlCommand(query, Conexao.dbConexao);
            Conexao.dbConexao.Open();

            MySqlDataReader leitor = cmd.ExecuteReader();
            while (leitor.Read())
            {
                int idPed = (int)leitor["idPed"];
                string configPed = leitor["configPed"].ToString();
                string dataEnPed = leitor["dataEnPed"].ToString();
                string dataSaPed = leitor["dataSaPed"].ToString();
                string statusPed = leitor["statusPed"].ToString();
                decimal valorPed = Convert.ToDecimal(leitor["valorPed"]);
                int idCliFK = (int)leitor["idCliFK"];

                Pedido pedido = new Pedido(idPed, configPed, dataEnPed, dataSaPed, statusPed, valorPed, idCliFK);

                listaPedido.Add(pedido);
            }

            Conexao.dbConexao.Close();

            return listaPedido;
        }

        //ALTERAR
        public void alterarPedido(string configPed, string dataEnPed, string dataSaPed, string statusPed, decimal valorPed)
        {
            string query = string.Format("UPDATE tbpedido SET configPed = '{0}', dataEnPed = '{1}', dataSaPed = '{2}', statusPed = '{3}', valorPed = '{4}' WHERE idPed = '{5}'", configPed, dataEnPed, dataSaPed, statusPed, valorPed, IdPed);

            MySqlCommand cmd = new MySqlCommand(query, Conexao.dbConexao);
            Conexao.dbConexao.Open();
            cmd.ExecuteNonQuery();

            var resposta = MessageBox.Show("Pedido alterado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Conexao.dbConexao.Close();
        }

        //DELETAR
        public void deletarPedido()
        {
            string query = string.Format("DELETE FROM tbpedido WHERE idPed = {0}", IdPed);

            MySqlCommand cmd = new MySqlCommand(query, Conexao.dbConexao);
            Conexao.dbConexao.Open();
            cmd.ExecuteNonQuery();

            var resposta = MessageBox.Show("Pedido deletado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Conexao.dbConexao.Close();
        }
    }
}

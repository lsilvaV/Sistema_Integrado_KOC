using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using koc.Controller;

namespace koc.Model
{
    class Cliente
    {
        //DEFININDO ELEMENTOS
        public int IdCli { get; private set; }
        public string NomeCli { get; private set; }
        public long CpfCli { get; private set; }
        public long FoneCli { get; private set; }
        public string EmailCli { get; private set; }
        public string SenhaCli { get; private set; }

        public Cliente(int idCli, string nomeCli, long cpfCli, long foneCli, string emailCli, string senhaCli)
        {
            IdCli = idCli;
            NomeCli = nomeCli;
            CpfCli = cpfCli;
            FoneCli = foneCli;
            EmailCli = emailCli;
            SenhaCli = senhaCli;
        }

        //INSERIR
        public static Cliente inserirCliente(string nomeCli, long cpfCli, long foneCli, string emailCli, string senhaCli)
        {
            string query = string.Format("INSERT INTO tbcliente(nomeCli, cpfCli, foneCli, emailCli, senhaCli) VALUES('{0}', '{1}', '{2}', '{3}', '{4}')", nomeCli, cpfCli, foneCli, emailCli, senhaCli);

            MySqlCommand cmd = new MySqlCommand(query, Conexao.dbConexao);
            Conexao.dbConexao.Open();
            cmd.ExecuteNonQuery();

            int idCli = (int)cmd.LastInsertedId;
            Cliente cliente = new Cliente(idCli, nomeCli, cpfCli, foneCli, emailCli, senhaCli);

            var resposta = MessageBox.Show("Cliente cadastrado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Conexao.dbConexao.Close();

            return cliente;
        }

        //LISTAR
        public static List<Cliente> listarCliente()
        {
            List<Cliente> listaCliente = new List<Cliente>();

            string query = "SELECT * FROM tbcliente";
            MySqlCommand cmd = new MySqlCommand(query, Conexao.dbConexao);
            Conexao.dbConexao.Open();

            MySqlDataReader leitor = cmd.ExecuteReader();
            while (leitor.Read())
            {
                int idCli = (int)leitor["idCli"];
                string nomeCli = leitor["nomeCli"].ToString();
                long cpfCli = Convert.ToInt64(leitor["cpfCli"]);
                long foneCli = Convert.ToInt64(leitor["foneCli"]);
                string emailCli = leitor["emailCli"].ToString();
                string senhaCli = leitor["senhaCli"].ToString();

                Cliente cliente = new Cliente(idCli, nomeCli, cpfCli, foneCli, emailCli, senhaCli);

                listaCliente.Add(cliente);
            }

            Conexao.dbConexao.Close();

            return listaCliente;
        }

        //ALTERAR
        public void alterarCliente(string nomeCli, long cpfCli, long foneCli, string emailCli, string senhaCli)
        {
            string query = string.Format("UPDATE tbcliente SET nomeCli = '{0}', cpfCli = '{1}', foneCli = '{2}', emailCli = '{3}', senhaCli = '{4}' WHERE idCli = '{5}'", nomeCli, cpfCli, foneCli, emailCli, senhaCli, IdCli);

            MySqlCommand cmd = new MySqlCommand(query, Conexao.dbConexao);
            Conexao.dbConexao.Open();
            cmd.ExecuteNonQuery();

            var resposta = MessageBox.Show("Cliente alterado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Conexao.dbConexao.Close();
        }

        //DELETAR
        public void deletarCliente()
        {
            string query = string.Format("DELETE FROM tbcliente WHERE idCli = {0}", IdCli);

            MySqlCommand cmd = new MySqlCommand(query, Conexao.dbConexao);
            Conexao.dbConexao.Open();
            cmd.ExecuteNonQuery();

            var resposta = MessageBox.Show("Cliente deletado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Conexao.dbConexao.Close();
        }
    }
}

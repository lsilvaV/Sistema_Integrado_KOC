using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace koc.Controller
{
    class Conexao
    {
        //conectando com o banco de dados
        public const string SERVER = "localhost";
        public const string DATABASE = "dbkoc";
        public const string USER = "root";
        public const string PASSWORD = "";
        public static MySqlConnection dbConexao;

        //iniciando banco
        public static void iniciarBanco()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();

            builder.Server = SERVER;
            builder.UserID = USER;
            builder.Password = PASSWORD;
            builder.Database = DATABASE;

            string connString = builder.ToString();
            builder = null;
            dbConexao = new MySqlConnection(connString);

            Application.ApplicationExit += (sender, args) =>
            {
                if (dbConexao != null)
                {
                    dbConexao.Dispose();
                    dbConexao = null;
                }
            };
        }
    }
}

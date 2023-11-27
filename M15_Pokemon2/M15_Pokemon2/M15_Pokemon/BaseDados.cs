using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; // Livraria pra acesso á DB
using System.Data; // livraria para trabalhar objetos de dados

namespace M15_Pokemon
{
    class BaseDados
    {
        SqlConnection BD = new SqlConnection();
        string LigacaoBD = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|datadirectory|\Pokemon.mdf;Integrated Security=True";
        public BaseDados()
        {
            BD.ConnectionString = LigacaoBD;
            BD.Open();
        }
        ~BaseDados()
        {

        }
        public void fechar_bd()
        {
            BD.Close();
        }

        public void executa_SQL(string querySQL)
        {
            //Objeto para executar um comando de SQL
            SqlCommand comando = new SqlCommand();

            //Associar a Query ao objeto 
            comando.CommandText = querySQL;

            //Associar o comando à BaseDados
            comando.Connection = BD;

            //Executar o comando de SQL
            comando.ExecuteNonQuery();
        }
        public DataTable devolve_consulta(string querySQL)
        {
            SqlCommand comando = new SqlCommand(querySQL, BD);
            DataTable dados = new DataTable();
            SqlDataReader ler_dados = comando.ExecuteReader();
            dados.Load(ler_dados);
            return dados;
        }
        public void executa_SQL(string querySQL, List<SqlParameter> parametros)
        {
            SqlCommand comando = new SqlCommand(querySQL, BD);
            comando.Parameters.AddRange(parametros.ToArray());
            comando.ExecuteNonQuery();
        }
    }
}

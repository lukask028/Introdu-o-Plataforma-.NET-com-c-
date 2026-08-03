using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01_ADONET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ADONET - Comunicacao com o banco de dados; 
            // SQL CONNECTION , SQL COMMAND, SQLDATAREADER; 
            // SQL CONNECTION - Responsavel por abrir e gerenciar a conexao com o banco de dados; 
            // SQL COMAND - Executa os comandos sql 
            // SQL DATAREADER - Le os dados retornados da consulta; 

            // é necessario passar: 
            // servidor 
            // banco de dados
            // acesso

            String StringConexao = "Data Source=DESKTOP-K8KPMD8; Initial Catalog=Empresa; Integrated Security=true";

            //using garante que a conexao seja fechada. 

            string Query = "SELECT * FROM Cliente";

            // preparacao de conexao
            using (SqlConnection conexao = new SqlConnection(StringConexao))
            {
                // abre a conexao
                conexao.Open();

                Console.WriteLine($"Conexao estabelecida: {conexao.State}");

                using (SqlCommand command = new SqlCommand(Query, conexao))
                {
                    // le o comando da resultado da query do bd; 
                    SqlDataReader reader = command.ExecuteReader();

                    // enquanto tiver comando para ler, exibe no retorno
                    while (reader.Read())
                    {
                        Console.WriteLine($"Nome: {reader["nome"]},    Cidade: {reader["cidade"]}");
                    }
                }
            }
        }
    }
}

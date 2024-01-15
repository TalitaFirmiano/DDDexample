using Dapper;
using Domain.Command;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public class ClienteRepository
    {
        string conexao = @"Server=(localdb)\mssqllocaldb;Database=Application;Trusted_Connection=True;MultipleActiveResultSets=True";
        public async Task<string> PostAsync(ClienteCommand command)
        {

            string queryInsert = @"
                queryInsert into Cliente(ClienteId, Nome, DataNascimento, Estado,Habilitacao )
                Values (@ClienteId, @Nome, @DataNascimento, @Estado, @Habilitacao)";

            using (SqlConnection conn = new SqlConnection(conexao))

                conn.Execute(queryInsert, new
                {
                    ClienteId = command.ClienteId,
                    Nome = command.Nome,
                    DataNascimento = command.DataNascimento,
                    Estado = command.Estado,
                    Habilitacao = command.Habilitacao,            

                });
            return "Veiculo cadastrado com Sucesso";

        }
    }
}
using Dapper;
using Domain.Command;
using Domain.Interfaces;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Infrastructure.Repository
{
    public class VeiculoRepository : IVeiculoRepository
    {
        string conexao = @"Server=(localdb)\mssqllocaldb;Database=Application;Trusted_Connection=True;MultipleActiveResultSets=True";
        public async Task<string> PostAsync(VeiculoCommand command)
        {

            string queryInsert = @"
                queryInsert into Veiculo(Placa, AnoFabricacao, ETipo, Estado, EMarca)
                Values (@Placa, @AnoFabricacao, @TipoVeiculo, @Estado, @EMontadora )";
            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Execute(queryInsert, new
                {

                    Placa = command.Placa,
                    AnoFabricacao = command.AnoFabricacao,
                    ETipo = command.TipoVeiculo,
                    Estado = command.Estado,
                    EMontadora = command.EMarca,
                    Alugado = command.Alugado,
                    AluguelDisponivel = command.AluguelDisponivel,

                });
                return "Veiculo cadastrado com Sucesso";
            }


        }

        public void PostAsync()
        {

        }
        public void GetAsync()
        {
        }
        public async Task<IEnumerable<VeiculoCommand>> GetAluguelDisponivelAsync()
        {
            string queryBuscarVeiculosDisponiveis = @"SELECT * FROM Alugado WHERE AluguelDisponivel= 0";
            using (SqlConnection conn = new SqlConnection(conexao))
            {
                return conn.QueryAsync<VeiculoCommand>(queryBuscarVeiculosDisponiveis).Result.ToList();
            }

        }

    }
}


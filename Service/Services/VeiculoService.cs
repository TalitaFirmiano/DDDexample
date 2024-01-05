using Domain.Command;
using Domain.Enums;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class VeiculoService : IVeiculoService
    {
        public void GetAsync()
        {
            throw new NotImplementedException();
        }

        public Task PostAsync(VeiculoCommand command)
        {
            if (command == null) throw new ArgumentNullException();

            // To do 
            //Incluir validação, só podem cadastrar veiculos com até 5 anos de uso

            // To do 
            // Incluir somente carro do tipo SUV, Sedan e Hatch

            int AnoAtual= DateTime.Now.Year;

            if ((AnoAtual - command.AnoFabricacao )<5);
            {
                Console.WriteLine("O veiculo esta dentro dos requisitos");
            }

            if (command.TipoVeiculo == ETipo.Suv
             && command.TipoVeiculo != ETipo.Hatch
             && command.TipoVeiculo != ETipo.Sedan
            )
            {
                Console.WriteLine("Não Cadastrou o veiculo");
            throw new ArgumentNullException();
            }
            else
            {
                Console.WriteLine("Cadastrou o veiculo");
            }

            throw new NotImplementedException();
        }

        public void PostAsync()
        {
            throw new NotImplementedException();
        }
    }
}

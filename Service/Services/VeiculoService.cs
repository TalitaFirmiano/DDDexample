using Domain.Command;
using Domain.Enums;
using Domain.Interfaces;


namespace Service.Services
{
    public class VeiculoService : IVeiculoService
    {
        private readonly IVeiculoRepository _repository;
        public VeiculoService(IVeiculoRepository repository)
        {
            _repository = repository;
        }
        public void GetAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<string> PostAsync(VeiculoCommand command)
        {
            if (command == null)
            {
                return "Todos os campos são obrigatorios";
            }

            // To do 
            //Incluir validação, só podem cadastrar veiculos com até 5 anos de uso

            // To do 
            // Incluir somente carro do tipo SUV, Sedan e Hatch

            int anoAtual = DateTime.Now.Year;

            if ((anoAtual - command.AnoFabricacao) < 5)
            {
                return "O ano do veiculo é menor que o permitido";
            }

            if (command.TipoVeiculo == ETipo.Suv
             && command.TipoVeiculo != ETipo.Hatch
             && command.TipoVeiculo != ETipo.Sedan
            )
            {
                return "O tipo do veiculo não é permitido";
            }

            return await _repository.PostAsync(command);
            {
             
            }

        }
        public void PostAsync()
        {
            throw new NotImplementedException();
        }
        public async Task<IEnumerable<VeiculoCommand>> GetAluguelDisponivelAsync()
        {
            return await _repository.GetAluguelDisponivelAsync();
        }

    }
}

using Domain.Command;

namespace Domain
{
    public interface IVeiculoService
    {
        Task <string> PostAsync(VeiculoCommand command);
        void PostAsync();
        void GetAsync();
    }
}
//Interface é um contrato, apenas usamos para adicionar metodos
// não é implementação de nada


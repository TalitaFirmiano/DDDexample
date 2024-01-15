using Domain.Command;
using System.Collections.Generic;

namespace Domain.Interfaces
{
    public interface IVeiculoRepository
    {
        Task<string> PostAsync (VeiculoCommand command);
        void PostAsync();
        void GetAsync();
        Task<IEnumerable<VeiculoCommand>> GetAluguelDisponivelAsync();
        
    }
}

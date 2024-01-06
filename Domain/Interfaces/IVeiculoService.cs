using Domain.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IVeiculoService
    {
        //Interface é um contrato, apenas usamos para adicionar metodos
        // não é implementação de nada


        void GetAsync();
        Task<string> PostAsync(VeiculoCommand command);
        void PostAsync();


    }
}

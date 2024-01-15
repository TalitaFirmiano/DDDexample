using Domain.Command;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class ClienteService : IClienteService
    {
        public void GetAsync()
        {
            throw new NotImplementedException();
        }

        public Task<string> PostAsync(ClienteCommand command)
        {
            throw new NotImplementedException();
        }

        public void PostAsync()
        {
            throw new NotImplementedException();
        }
    }
}

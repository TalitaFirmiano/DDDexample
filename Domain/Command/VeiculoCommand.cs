using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Command
{
    public class VeiculoCommand
    {
       
        public int VeiculoId { get; set; }
        public string Placa { get; set; }
        public int AnoFabricacao { get; set; }
        public ETipo TipoVeiculo { get; set; } 
        public string Estado { get; set; } 
        public EMontadora EMarca { get; set; } 
        public bool Alugado { get; set; } 
        public bool AluguelDisponivel { get; set; } 
    }
}

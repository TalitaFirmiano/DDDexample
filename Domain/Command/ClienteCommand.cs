using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Command
{
    public class ClienteCommand
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public int DataNascimento { get; set; }
        public string Habilitacao { get; set; }
        public string Estado { get; set; }
    }
}

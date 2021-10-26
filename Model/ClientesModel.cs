using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysVeterinario_V3.Model
{
    public class ClientesModel
    {
        public Int32 IdAnimal { get; set; }

        public Int32 IdCliente { get; set; }

        public string NomeCliente { get; set; }

        public string CPFCliente { get; set; }

        public string EmailCliente { get; set; }

        public DateTime DataCadastroCliente { get; set; }

        public string? TelefoneCliente { get; set; }
    }
}

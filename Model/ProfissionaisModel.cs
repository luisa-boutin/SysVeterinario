using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysVeterinario_V3.Model
{
    public class ProfissionaisModel
    {
        public string NomeProfissional { get; set; }

        public Int32 IdProfissional { get; set; }

        public string CRMVProfissional { get; set; }

        public string CPFProfissional { get; set; }

        public string? TelefoneProfissional { get; set; }

        public string EmailProfissional { get; set; }

        public DateTime DataCadastroProfissional { get; set; }

        public bool? FeriasProfissional { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysVeterinario_V3.Model
{
    public class AnimaisModel
    {
        public Int32 IdAnimal { get; set; }
        
        public string NomeAnimal { get; set; }
        
        public string? ApelidoAnimal { get; set; }

        public DateTime DataDeNascimentoAnimal { get; set; }

        public string? ObservacoesAnimal { get; set; }

        public Int32 IdEspecieAnimal { get; set; }

    }
}

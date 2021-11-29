using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysVeterinario_V3.Model
{
    public class AnimaisModel
    {
        public int IdAnimal { get; set; }
        
        public string NomeAnimal { get; set; }
        
        public string? ApelidoAnimal { get; set; }

        public DateTime DataDeNascimentoAnimal { get; set; }

        public string? ObservacoesAnimal { get; set; }

        public int IdEspecieAnimal { get; set; }

    }
}

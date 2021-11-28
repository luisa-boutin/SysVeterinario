using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysVeterinario_V3.Model
{
    public class AnimaisModel
    {
        public int idAnimal;

        public int IdAnimal { get => idAnimal; set => idAnimal = value; }
        
        public string NomeAnimal { get; set; }
        
        public string? ApelidoAnimal { get; set; }

        public DateTime DataDeNascimentoAnimal { get; set; }

        public string? ObservacoesAnimal { get; set; }

        public int IdEspecieAnimal { get; set; }

    }
}

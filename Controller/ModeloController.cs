using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysVeterinario_V3.Model;

namespace SysVeterinario_V3.Controller
{
    public abstract class ModeloController
    {
        public abstract void SalvarBancoDados();
        public abstract void LerBancoDados();
        public abstract void Inserir<T>(T Modelo);
        public abstract void Alterar<T>(T Modelo);
        public abstract void Excluir<T>(T Modelo);
        public abstract void Pesquisar(int valor);
        public abstract void Imprimir<T>(T Modelo);
    }
}

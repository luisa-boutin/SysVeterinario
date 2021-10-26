using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using SysVeterinario_V3.Model;

namespace SysVeterinario_V3.Controller
{
    public class AnimaisController : ModeloController
    {
        private List<AnimaisModel> _listaAnimais = new();

        public AnimaisModel Animal = new();

        public override void SalvarBancoDados()
        {
            XmlSerializer xml = new(typeof(List<AnimaisModel>));
            TextWriter arquivo = new StreamWriter(@"C:\Users\lbout\source\repos\Arquitetura\Projeto\SysVeterinario_V3\Animais.xml");
            xml.Serialize(arquivo, _listaAnimais);
            arquivo.Close();
        }

        public override void LerBancoDados()
        {
            XmlSerializer xml = new(typeof(List<AnimaisModel>));
            FileStream arquivo = new(@"C:\Users\lbout\source\repos\Arquitetura\Projeto\SysVeterinario_V3\Animais.xml", FileMode.Open);
            _listaAnimais = (List<AnimaisModel>)xml.Deserialize(arquivo);
            arquivo.Close();
        }
        public void Inserir(AnimaisModel Animal)
        {
            _listaAnimais.Add(Animal);
        }

        public void Alterar()
        {
            throw new NotImplementedException();
        }

        public void Excluir()
        {
            throw new NotImplementedException();
        }

        public void Pesquisar()
        {
            AnimaisModel valor = null;
            /*
            foreach (var item in _listaAnimais)
            {
                if(item.getCodigo() == codigoEstado)
                {
                    valor = item;
                }
            }
            
            return valor; */
        }

    }
}

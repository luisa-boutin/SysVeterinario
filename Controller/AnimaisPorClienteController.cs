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
    public class AnimaisPorClienteController : ModeloController
    {
        private List<AnimaisPorClienteModel> _listaAnimaisPorCliente = new();

        public AnimaisPorClienteModel Animal = new();

        public override void SalvarBancoDados()
        {
            XmlSerializer xml = new(typeof(List<AnimaisPorClienteModel>));
            TextWriter arquivo = new StreamWriter(@"C:\Users\lbout\source\repos\Arquitetura\Projeto\SysVeterinario_V3\AnimaisPorCliente.xml");
            xml.Serialize(arquivo, _listaAnimaisPorCliente);
            arquivo.Close();
        }

        public override void LerBancoDados()
        {
            XmlSerializer xml = new(typeof(List<AnimaisPorClienteModel>));
            FileStream arquivo = new(@"C:\Users\lbout\source\repos\Arquitetura\Projeto\SysVeterinario_V3\AnimaisPorCliente.xml", FileMode.Open);
            _listaAnimaisPorCliente = (List<AnimaisPorClienteModel>)xml.Deserialize(arquivo);
            arquivo.Close();
        }
 
        public void Inserir(AnimaisPorClienteModel animalPorCliente)
        {
            _listaAnimaisPorCliente.Add(animalPorCliente);
        }
        public void Alterar()
        {

        }
        public void Excluir()
        {

        }
        public void Pesquisar()
        {

        }
        
    }
}

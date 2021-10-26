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
    class EspeciesController : ModeloController 
    {
        private List<EspeciesModel> _listaEspecies = new();

        public EspeciesModel Especie = new();
        public override void SalvarBancoDados()
        {
            XmlSerializer xml = new(typeof(List<EspeciesModel>));
            TextWriter arquivo = new StreamWriter(@"C:\Users\lbout\source\repos\Arquitetura\Projeto\SysVeterinario_V3\Especies.xml");
            xml.Serialize(arquivo, _listaEspecies);
            arquivo.Close();
        }

        public override void LerBancoDados()
        {
            XmlSerializer xml = new(typeof(List<EspeciesModel>));
            FileStream arquivo = new(@"C:\Users\lbout\source\repos\Arquitetura\Projeto\SysVeterinario_V3\Especies.xml", FileMode.Open);
            _listaEspecies = (List<EspeciesModel>)xml.Deserialize(arquivo);
            arquivo.Close();
        }
        public void Inserir(EspeciesModel novaEspecie)
        {
            _listaEspecies.Add(Especie);
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

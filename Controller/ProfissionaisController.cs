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
    public class ProfissionaisController : ModeloController 
    {
        private List<ProfissionaisModel> _listaProfissionais = new();

        public ProfissionaisModel Profissional = new();
        // TODO: Verificar porque não está criando o xml
        public override void SalvarBancoDados()
        {
            XmlSerializer xml = new(typeof(List<ProfissionaisModel>));
            TextWriter arquivo = new StreamWriter(@"C:\Users\lbout\source\repos\Arquitetura\Projeto\SysVeterinario_V3\Profissionais.xml");
            xml.Serialize(arquivo, _listaProfissionais);
            arquivo.Close();
        }

        public override void LerBancoDados()
        {
            XmlSerializer xml = new(typeof(List<ProfissionaisModel>));
            FileStream arquivo = new(@"C:\Users\lbout\source\repos\Arquitetura\Projeto\SysVeterinario_V3\Profissionais.xml", FileMode.Open);
            _listaProfissionais = (List<ProfissionaisModel>)xml.Deserialize(arquivo);
            arquivo.Close();
        }

        public void Inserir(ProfissionaisModel Profissional)
        {
            _listaProfissionais.Add(Profissional);
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

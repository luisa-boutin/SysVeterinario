using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysVeterinario_V3.Model;
using System.Xml.Serialization;
using System.IO;

namespace SysVeterinario_V3.Controller
{
    public class ClientesController : ModeloController
    {
        private List<ClientesModel> _listaClientes = new();

        public ClientesModel Cliente = new();
        public override void SalvarBancoDados()
        {
            XmlSerializer xml = new(typeof(List<ClientesModel>));
            TextWriter arquivo = new StreamWriter(@"C:\Users\lbout\source\repos\Arquitetura\Projeto\SysVeterinario_V3\Clientes.xml");
            xml.Serialize(arquivo, _listaClientes);
            arquivo.Close();
        }

        public override void LerBancoDados()
        {
            XmlSerializer xml = new(typeof(List<ClientesModel>));
            FileStream arquivo = new(@"C:\Users\lbout\source\repos\Arquitetura\Projeto\SysVeterinario_V3\Clientes.xml", FileMode.Open);
            _listaClientes = (List<ClientesModel>)xml.Deserialize(arquivo);
            arquivo.Close();
        }
        public void Inserir(ClientesModel Cliente)
        {
            _listaClientes.Add(Cliente);
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

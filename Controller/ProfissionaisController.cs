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
        public override void Inserir<T>(T Profissional)
        {
            _listaProfissionais.Add(Profissional as ProfissionaisModel);
            SalvarBancoDados();
        }
        public override void Alterar<T>(T Profissional)
        {
            Boolean achou = false;

            foreach (var item in _listaProfissionais)
            {
                if ((Profissional as ProfissionaisModel).IdProfissional == item.IdProfissional)
                {
                    achou = true;

                    Console.WriteLine("Insira aqui o nome do profissional:");
                    (Profissional as ProfissionaisModel).NomeProfissional = Console.ReadLine();
                    Console.WriteLine("Insira aqui o CRMV do profissional:");
                    (Profissional as ProfissionaisModel).CRMVProfissional = Console.ReadLine();
                    Console.WriteLine("Insira aqui o CPF do profissional:");
                    (Profissional as ProfissionaisModel).CPFProfissional = Console.ReadLine();
                    Console.WriteLine("Insira aqui o telefone do profissional:");
                    (Profissional as ProfissionaisModel).TelefoneProfissional = Console.ReadLine();
                    Console.WriteLine("Insira aqui o e-mail do profissional:");
                    (Profissional as ProfissionaisModel).EmailProfissional = Console.ReadLine();
                    Console.WriteLine("Insira aqui a data de cadastro do profissional (dd/mm/aaaa):");
                    (Profissional as ProfissionaisModel).DataCadastroProfissional = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("O profissional esta de ferias? (S/N)");
                    (Profissional as ProfissionaisModel).FeriasProfissional = Console.ReadLine();

                    Console.WriteLine("Dados alterados com sucesso.\n");
                }
            }

            if (achou == false)
            {
                Console.WriteLine("O profissional nao foi encontrado.\n");
            }

            SalvarBancoDados();
        }
        public override void Excluir<T>(T Profissional)
        {
            Boolean achou = false;
            int posicao = -1;

            foreach (var item in _listaProfissionais)
            {
                if ((Profissional as ProfissionaisModel).IdProfissional == item.IdProfissional)
                {
                    achou = true;
                    posicao = _listaProfissionais.IndexOf(item);
                    _listaProfissionais.RemoveAt(posicao);
                    Console.WriteLine("Animal removido da lista!\n");
                }
            }

            if (achou == false)
            {
                Console.WriteLine("O profissional nao foi encontrado.\n");
            }

            SalvarBancoDados();
        }
        public override void Pesquisar(int IdProfissional)
        {
            ProfissionaisModel profissional = null;

            foreach (var item in _listaProfissionais)
            {
                if (item.IdProfissional == IdProfissional)
                {
                    profissional = item;
                    Imprimir(profissional);
                }
                else
                {
                    Console.WriteLine("Profissional nao encontrado.");
                }
            }
        }
        public override void Imprimir<T>(T Profissional)
        {
            foreach (var item in _listaProfissionais)
            {
                Console.WriteLine($"Nome do profissional: {item.NomeProfissional.ToString()}");
                Console.WriteLine($"ID do profissional: {item.IdProfissional.ToString()}");
                Console.WriteLine($"CRMV do profissional: {item.CRMVProfissional.ToString()}");
                Console.WriteLine($"CPF do profissional: {item.CPFProfissional.ToString()}");
                Console.WriteLine($"Telefone do profissional: {item.TelefoneProfissional.ToString()}");
                Console.WriteLine($"Email do profissional : {item.EmailProfissional.ToString()}");
                Console.WriteLine($"Data de cadastro do profissional: {item.DataCadastroProfissional.ToString()}");
                Console.WriteLine($"Ferias do profissional: {item.FeriasProfissional.ToString()}");
            }
        }
    }
}

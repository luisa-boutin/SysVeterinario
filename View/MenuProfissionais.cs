using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysVeterinario_V3.Controller;
using SysVeterinario_V3.Model;

namespace SysVeterinario_V3.View
{
    public class MenuProfissionais : MenuAbstrato
    {
        public override void AbrirMenu()
        {
            int opc;
            int idPesquisaProfissional;

            ProfissionaisController ControleProfissionais = new();
            ProfissionaisModel NovoProfissional = new();

            do
            {
                Console.WriteLine("\n");
                Console.WriteLine("<< PROFISSIONAIS >> \n");
                Console.WriteLine("51. Inserir \n");
                Console.WriteLine("52. Alterar \n");
                Console.WriteLine("53. Excluir \n");
                Console.WriteLine("54. Pesquisar \n");
                Console.WriteLine("59. Sair \n");
                Console.WriteLine("Digite uma opcao:\n");

                opc = Convert.ToInt32(Console.ReadLine());

                switch (opc)
                {
                    case 51:
                        Console.WriteLine("Insira aqui o nome do profissional:");
                        NovoProfissional.NomeProfissional = Console.ReadLine();
                        Console.WriteLine("Insira aqui o codigo de identificacao do profissional:");
                        NovoProfissional.IdProfissional = int.Parse(Console.ReadLine());
                        Console.WriteLine("Insira aqui o CRMV do profissional:");
                        NovoProfissional.CRMVProfissional = Console.ReadLine();
                        Console.WriteLine("Insira aqui o CPF do profissional:");
                        NovoProfissional.CPFProfissional = Console.ReadLine();
                        Console.WriteLine("Insira aqui o telefone do profissional:");
                        NovoProfissional.TelefoneProfissional = Console.ReadLine();
                        Console.WriteLine("Insira aqui o email do profissional:");
                        NovoProfissional.EmailProfissional = Console.ReadLine();
                        Console.WriteLine("Insira aqui a data de cadastro do profissional:");
                        NovoProfissional.DataCadastroProfissional = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("Insira aqui o status de ferias do profissional (Sim/Nao):");
                        NovoProfissional.FeriasProfissional = Console.ReadLine();

                        ControleProfissionais.Inserir(NovoProfissional);

                        Console.WriteLine("Cadastro de profissional efetuado com sucesso!\n");

                        break;
                    case 52:
                        Console.WriteLine("Insira aqui o codigo de identificacao do profissional a ser atualizado:");
                        NovoProfissional.IdProfissional = int.Parse(Console.ReadLine());
                        ControleProfissionais.Alterar(NovoProfissional);
                        break;
                    case 53:
                        Console.WriteLine("Insira aqui o codigo de identificacao do profissional a ser removido:");
                        NovoProfissional.IdProfissional = int.Parse(Console.ReadLine());
                        ControleProfissionais.Excluir(NovoProfissional);
                        break;
                    case 54:
                        Console.WriteLine("Insira aqui o codigo de identificacao do animal a ser pesquisado:");
                        idPesquisaProfissional = int.Parse(Console.ReadLine());
                        ControleProfissionais.Pesquisar(idPesquisaProfissional);
                        break;
                    case 59:
                        Console.WriteLine("Voce optou por sair");
                        break;
                    default:
                        Console.WriteLine("Insira uma opcao valida por favor! \n");
                        break;
                }
            } while (opc != 59);
        }
    }
}

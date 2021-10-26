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

                        NovoProfissional.NomeProfissional = Console.ReadLine();
                        NovoProfissional.IdProfissional = int.Parse(Console.ReadLine());
                        NovoProfissional.CRMVProfissional = Console.ReadLine();
                        NovoProfissional.CPFProfissional = Console.ReadLine();
                        NovoProfissional.TelefoneProfissional = Console.ReadLine();
                        NovoProfissional.EmailProfissional = Console.ReadLine();
                        NovoProfissional.DataCadastroProfissional = DateTime.Parse(Console.ReadLine());
                        NovoProfissional.FeriasProfissional = bool.Parse(Console.ReadLine());
                        
                        ControleProfissionais.Inserir(NovoProfissional);

                        Console.WriteLine("Cadastro de profissional efetuado com sucesso!\n");

                        break;
                    case 52:

                        break;
                    case 53:

                        break;
                    case 54:

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

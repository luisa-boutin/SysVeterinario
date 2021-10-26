using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysVeterinario_V3.Controller;
using SysVeterinario_V3.Model;

namespace SysVeterinario_V3.View
{
    public class MenuClientes : MenuAbstrato
    {
        public override void AbrirMenu()
        {
            int opc;

            ClientesController ControleCliente = new();
            ClientesModel NovoCliente = new();

            do
            {
                Console.WriteLine("\n");
                Console.WriteLine("<< CLIENTES >> \n");
                Console.WriteLine("31. Inserir \n");
                Console.WriteLine("32. Alterar \n");
                Console.WriteLine("33. Excluir \n");
                Console.WriteLine("34. Pesquisar \n");
                Console.WriteLine("39. Sair \n");
                Console.WriteLine("Digite uma opcao:\n");

                opc = Convert.ToInt32(Console.ReadLine());

                switch (opc)
                {
                    case 31:

                        NovoCliente.IdAnimal = int.Parse(Console.ReadLine());
                        NovoCliente.IdCliente = int.Parse(Console.ReadLine());
                        NovoCliente.NomeCliente = Console.ReadLine();
                        NovoCliente.CPFCliente = Console.ReadLine();
                        NovoCliente.EmailCliente = Console.ReadLine();
                        NovoCliente.DataCadastroCliente = DateTime.Parse(Console.ReadLine());
                        NovoCliente.TelefoneCliente = Console.ReadLine();

                        ControleCliente.Inserir(NovoCliente);

                        Console.WriteLine("Cadastro de cliente efetuado com sucesso!\n");

                        break;
                    case 32:

                        break;
                    case 33:

                        break;
                    case 34:

                        break;
                    case 39:
                        Console.WriteLine("Voce optou por sair");
                        break;
                    default:
                        Console.WriteLine("Insira uma opcao valida por favor! \n");
                        break;
                }
            } while (opc != 39);
        }
    }
}

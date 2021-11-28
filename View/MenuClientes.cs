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
            int idPesquisaCliente;

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
                        Console.WriteLine("Insira aqui o codigo de identificacao do cliente:");
                        NovoCliente.IdCliente = int.Parse(Console.ReadLine());
                        Console.WriteLine("Insira aqui o codigo de identificacao do animal:");
                        NovoCliente.IdAnimal = int.Parse(Console.ReadLine());
                        Console.WriteLine("Insira aqui o nome do cliente:");
                        NovoCliente.NomeCliente = Console.ReadLine();
                        Console.WriteLine("Insira aqui o CPF do cliente (000.000.000-00):");
                        NovoCliente.CPFCliente = Console.ReadLine();
                        Console.WriteLine("Insira aqui o e-mail do cliente:");
                        NovoCliente.EmailCliente = Console.ReadLine();
                        Console.WriteLine("Insira aqui a data de cadastro do cliente (dd/mm/aaaa):");
                        NovoCliente.DataCadastroCliente = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("Insira aqui o telefone do cliente:");
                        NovoCliente.TelefoneCliente = Console.ReadLine();

                        ControleCliente.Inserir(NovoCliente);

                        Console.WriteLine("Cadastro de cliente efetuado com sucesso!\n");

                        break;
                    case 32:
                        Console.WriteLine("Insira aqui o codigo de identificacao do cliente a ser atualizado:");
                        NovoCliente.IdCliente = int.Parse(Console.ReadLine());
                        ControleCliente.Alterar(NovoCliente);

                        break;
                    case 33:
                        Console.WriteLine("Insira aqui o codigo de identificacao do cliente a ser removido:");
                        NovoCliente.IdCliente = int.Parse(Console.ReadLine());
                        ControleCliente.Excluir(NovoCliente);

                        break;
                    case 34:
                        Console.WriteLine("Insira aqui o codigo de identificacao do cliente a ser pesquisado:");
                        idPesquisaCliente = int.Parse(Console.ReadLine());
                        ControleCliente.Pesquisar(idPesquisaCliente);

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

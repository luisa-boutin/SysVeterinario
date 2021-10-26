using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysVeterinario_V3.Controller;
using SysVeterinario_V3.Model;

namespace SysVeterinario_V3.View
{
    public class MenuAnimaisClientes : MenuAbstrato
    {
        public override void AbrirMenu()
        {
            int opc;

            AnimaisPorClienteController ControleAnimaisPorCliente = new();
            AnimaisPorClienteModel NovoAnimalPorCliente = new();

            do
            {
                Console.WriteLine("\n");
                Console.WriteLine("<< ANIMAIS POR CLIENTE>> \n");
                Console.WriteLine("41. Inserir \n");
                Console.WriteLine("42. Alterar \n");
                Console.WriteLine("43. Excluir \n");
                Console.WriteLine("44. Pesquisar \n");
                Console.WriteLine("49. Sair \n");
                Console.WriteLine("Digite uma opcao:\n");

                opc = Convert.ToInt32(Console.ReadLine());

                switch (opc)
                {
                    case 41:

                        NovoAnimalPorCliente.IdAnimal = int.Parse(Console.ReadLine());
                        NovoAnimalPorCliente.IdCliente = int.Parse(Console.ReadLine());
                        ControleAnimaisPorCliente.Inserir(NovoAnimalPorCliente);

                        Console.WriteLine("Cadastro de animal efetuado com sucesso!\n");

                        break;
                    case 42:

                        break;
                    case 43:

                        break;
                    case 44:

                        break;
                    case 49:
                        Console.WriteLine("Voce optou por sair");
                        break;
                    default:
                        Console.WriteLine("Insira uma opcao valida por favor! \n");
                        break;
                }
            } while (opc != 49);
        }
    }
}

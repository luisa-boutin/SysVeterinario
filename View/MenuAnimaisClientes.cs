using System;
using SysVeterinario_V3.Controller;
using SysVeterinario_V3.Model;

namespace SysVeterinario_V3.View
{
    public class MenuAnimaisClientes : MenuAbstrato
    {
        public override void AbrirMenu()
        {
            int opc;
            int idPesquisaAnimal;

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
                        Console.WriteLine("Insira aqui o codigo de identificacao do animal:");
                        NovoAnimalPorCliente.IdAnimal = int.Parse(Console.ReadLine());
                        Console.WriteLine("Insira aqui o codigo de identificacao do cliente:");
                        NovoAnimalPorCliente.IdCliente = int.Parse(Console.ReadLine());
                        ControleAnimaisPorCliente.Inserir(NovoAnimalPorCliente);

                        Console.WriteLine("Cadastro de animal efetuado com sucesso!\n");

                        break;
                    case 42:
                        Console.WriteLine("Insira aqui o codigo de identificacao do animal a ser atualizado:");
                        NovoAnimalPorCliente.IdAnimal = int.Parse(Console.ReadLine());
                        ControleAnimaisPorCliente.Alterar(NovoAnimalPorCliente);
                        break;
                    case 43:
                        Console.WriteLine("Insira aqui o codigo de identificacao do animal a ser removido:");
                        NovoAnimalPorCliente.IdAnimal = int.Parse(Console.ReadLine());
                        ControleAnimaisPorCliente.Excluir(NovoAnimalPorCliente);
                        break;
                    case 44:
                        Console.WriteLine("Insira aqui o codigo de identificacao do animal a ser pesquisado:");
                        idPesquisaAnimal = int.Parse(Console.ReadLine());
                        ControleAnimaisPorCliente.Pesquisar(idPesquisaAnimal);
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

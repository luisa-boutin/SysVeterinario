using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysVeterinario_V3.Controller;
using SysVeterinario_V3.Model;

namespace SysVeterinario_V3.View
{
    public class MenuEspecies : MenuAbstrato
    {
        public override void AbrirMenu()
        {
            int opc;
            int idPesquisaEspecie;

            EspeciesController ControleEspecies = new();
            EspeciesModel NovaEspecie = new();

            do
            {
                Console.WriteLine("\n");
                Console.WriteLine("<< ESPÉCIES >> \n");
                Console.WriteLine("11. Inserir \n");
                Console.WriteLine("12. Alterar \n");
                Console.WriteLine("13. Excluir \n");
                Console.WriteLine("14. Pesquisar \n");
                Console.WriteLine("19. Sair \n");
                Console.WriteLine("Digite uma opcao:\n");

                opc = Convert.ToInt32(Console.ReadLine());

                switch (opc)
                {
                    case 11:
                        Console.WriteLine("Insira aqui o codigo de identificacao da especie de animal:");
                        NovaEspecie.IdEspecieAnimal = int.Parse(Console.ReadLine());
                        Console.WriteLine("Insira aqui o nome da especie de animal:");
                        NovaEspecie.NomeEspecieAnimal = Console.ReadLine();
                        ControleEspecies.Inserir(NovaEspecie);

                        Console.WriteLine("Especie cadastrada com sucesso!\n");

                        break;
                    case 12:
                        Console.WriteLine("Insira aqui o codigo de identificacao da especie de animal a ser atualizada:");
                        NovaEspecie.IdEspecieAnimal = int.Parse(Console.ReadLine());
                        ControleEspecies.Alterar(NovaEspecie);

                        break;
                    case 13:
                        Console.WriteLine("Insira aqui o codigo de identificacao da especie de animal a ser removida:");
                        NovaEspecie.IdEspecieAnimal = int.Parse(Console.ReadLine());
                        ControleEspecies.Excluir(NovaEspecie);

                        break;
                    case 14:
                        Console.WriteLine("Insira aqui o codigo de identificacao da especie de animal a ser pesquisada:");
                        idPesquisaEspecie = int.Parse(Console.ReadLine());
                        ControleEspecies.Pesquisar(idPesquisaEspecie);

                        break;
                    case 19:
                        Console.WriteLine("Voce optou por sair");
                        break;
                    default:
                        Console.WriteLine("Insira uma opcao valida por favor! \n");
                        break;
                }
            } while (opc != 19);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysVeterinario_V3.Controller;
using SysVeterinario_V3.Model;

namespace SysVeterinario_V3.View
{
    public class MenuAnimais : MenuAbstrato
    {
        public override void AbrirMenu()
        {
            int opc;

            AnimaisController ControleAnimais = new();
            AnimaisModel NovoAnimal = new();

            do
            {
                Console.WriteLine("\n");
                Console.WriteLine("<< ANIMAIS >> \n");
                Console.WriteLine("21. Inserir \n");
                Console.WriteLine("22. Alterar \n");
                Console.WriteLine("23. Excluir \n");
                Console.WriteLine("24. Pesquisar \n");
                Console.WriteLine("29. Sair \n");
                Console.WriteLine("Digite uma opcao:\n");

                opc = Convert.ToInt32(Console.ReadLine());

                switch (opc)
                {
                    case 21:

                        NovoAnimal.IdAnimal = int.Parse(Console.ReadLine());
                        NovoAnimal.NomeAnimal = Console.ReadLine();
                        NovoAnimal.ApelidoAnimal = Console.ReadLine();
                        NovoAnimal.DataDeNascimentoAnimal = DateTime.Parse(Console.ReadLine());
                        NovoAnimal.ObservacoesAnimal = Console.ReadLine();
                        NovoAnimal.IdEspecieAnimal = int.Parse(Console.ReadLine());
                        ControleAnimais.Inserir(NovoAnimal);

                        Console.WriteLine("Cadastro de animal efetuado com sucesso!\n");

                        break;
                    case 22:

                        break;
                    case 23:

                        break;
                    case 24:

                        break;
                    case 29:
                        Console.WriteLine("Voce optou por sair");
                        break;
                    default:
                        Console.WriteLine("Insira uma opcao valida por favor! \n");
                        break;
                }
            } while (opc != 29);
        }
    }
}

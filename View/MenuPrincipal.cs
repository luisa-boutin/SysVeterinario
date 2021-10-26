using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysVeterinario_V3.View
{
    public class MenuPrincipal : MenuAbstrato
    {

        public override void AbrirMenu()
        {
            int opc;

            MenuEspecies vMenuEspecies = new();
            MenuAnimais vMenuAnimais = new();
            MenuAnimaisClientes vMenuAnimaisPorCliente = new();
            MenuClientes vMenuClientes = new();
            MenuProfissionais vMenuProfissionais = new();

            do
            {
                Console.WriteLine("\n");
                Console.WriteLine("<< VETERINÁRIO ORELINHAS E PATINHAS >> \n");
                Console.WriteLine("1. Especies \n");
                Console.WriteLine("2. Animais \n");
                Console.WriteLine("3. Clientes \n");
                Console.WriteLine("4. Animas de Clientes \n");
                Console.WriteLine("5. Profissionais \n");
                Console.WriteLine("9. Sair \n");
                Console.WriteLine("Digite uma opcao:\n");

                opc = Convert.ToInt32(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        vMenuEspecies.AbrirMenu();
                        break;
                    case 2:
                        vMenuAnimais.AbrirMenu();
                        break;
                    case 3:
                        vMenuClientes.AbrirMenu();
                        break;
                    case 4:
                        vMenuAnimaisPorCliente.AbrirMenu();
                        break;
                    case 5:
                        vMenuProfissionais.AbrirMenu();
                        break;
                    case 9:
                        Console.WriteLine("Voce optou por sair");
                        break;
                    default:
                        Console.WriteLine("Insira uma opcao valida por favor! \n");
                        break;
                }
            } while (opc != 9);
        }
    }
}

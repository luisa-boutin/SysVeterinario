using System;
using SysVeterinario_V3.Controller;
using SysVeterinario_V3.Model;

namespace SysVeterinario_V3.View
{
    public class MenuAnimais : MenuAbstrato
    {
        public override void AbrirMenu()
        {
            int opc;
            int idPesquisaAnimal;

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
                        Console.WriteLine("Insira aqui o codigo de identificacao do animal:");
                        NovoAnimal.IdAnimal = int.Parse(Console.ReadLine());
                        Console.WriteLine("Insira aqui o nome do animal:");
                        NovoAnimal.NomeAnimal = Console.ReadLine();
                        Console.WriteLine("Insira aqui o apelido do animal:");
                        NovoAnimal.ApelidoAnimal = Console.ReadLine();
                        Console.WriteLine("Insira aqui a data de nascimento do animal (dd/mm/aaaa):");
                        NovoAnimal.DataDeNascimentoAnimal = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("Insira aqui observacoes sobre o animal:");
                        NovoAnimal.ObservacoesAnimal = Console.ReadLine();
                        Console.WriteLine("Insira aqui o codigo de identificacao da especie do animal:");
                        NovoAnimal.IdEspecieAnimal = int.Parse(Console.ReadLine());
                        ControleAnimais.Inserir(NovoAnimal);

                        Console.WriteLine("Cadastro de animal efetuado com sucesso!");

                        break;
                    case 22:
                        Console.WriteLine("Insira aqui o codigo de identificacao do animal a ser atualizado:");
                        NovoAnimal.IdAnimal = int.Parse(Console.ReadLine());
                        ControleAnimais.Alterar(NovoAnimal);

                        break;
                    case 23:
                        Console.WriteLine("Insira aqui o codigo de identificacao do animal a ser removido:");
                        NovoAnimal.IdAnimal = int.Parse(Console.ReadLine());
                        ControleAnimais.Excluir(NovoAnimal);

                        break;
                    case 24:
                        Console.WriteLine("Insira aqui o codigo de identificacao do animal a ser pesquisado:");
                        idPesquisaAnimal = int.Parse(Console.ReadLine());
                        ControleAnimais.Pesquisar(idPesquisaAnimal);
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

using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using SysVeterinario_V3.Model;

namespace SysVeterinario_V3.Controller
{
    public class AnimaisPorClienteController : ModeloController
    {
        private List<AnimaisPorClienteModel> _listaAnimaisPorCliente = new();

        public AnimaisPorClienteModel AnimalPorCliente = new();

        public override void SalvarBancoDados()
        {
            XmlSerializer xml = new(typeof(List<AnimaisPorClienteModel>));
            TextWriter arquivo = new StreamWriter(@"C:\Users\lbout\source\repos\Arquitetura\Projeto\SysVeterinario_V3\AnimaisPorCliente.xml");
            xml.Serialize(arquivo, _listaAnimaisPorCliente);
            arquivo.Close();
        }
        public override void LerBancoDados()
        {
            XmlSerializer xml = new(typeof(List<AnimaisPorClienteModel>));
            FileStream arquivo = new(@"C:\Users\lbout\source\repos\Arquitetura\Projeto\SysVeterinario_V3\AnimaisPorCliente.xml", FileMode.Open);
            _listaAnimaisPorCliente = (List<AnimaisPorClienteModel>)xml.Deserialize(arquivo);
            arquivo.Close();
        }
        public override void Inserir<T>(T animalPorCliente)
        {
            _listaAnimaisPorCliente.Add(animalPorCliente as AnimaisPorClienteModel);
            SalvarBancoDados();
        }
        public override void Alterar<T>(T animalPorCliente)
        {
            Boolean achou = false;

            foreach (var item in _listaAnimaisPorCliente)
            {
                if ((animalPorCliente as AnimaisPorClienteModel).IdAnimal == item.IdAnimal)
                {
                    achou = true;

                    Console.WriteLine("Insira aqui o novo ID do cliente:");
                    (animalPorCliente as AnimaisPorClienteModel).IdCliente = int.Parse(Console.ReadLine());

                    Console.WriteLine("Dados alterados com sucesso.\n");
                }
            }

            if (achou == false)
            {
                Console.WriteLine("O animal nao foi encontrado.\n");
            }

            SalvarBancoDados();
        }
        public override void Excluir<T>(T animalPorCliente)
        {
            Boolean achou = false;
            int posicao = -1;

            foreach (var item in _listaAnimaisPorCliente)
            {
                if ((animalPorCliente as AnimaisPorClienteModel).IdAnimal == item.IdAnimal)
                {
                    achou = true;
                    posicao = _listaAnimaisPorCliente.IndexOf(item);
                    _listaAnimaisPorCliente.RemoveAt(posicao);
                    Console.WriteLine("Animal removido da lista!\n");
                }
            }

            if (achou == false)
            {
                Console.WriteLine("O animal nao foi encontrado.\n");
            }

            SalvarBancoDados();
        }
        public override void Pesquisar(int IdAnimal)
        {
            AnimaisPorClienteModel animalPorCliente = null;

            foreach (var item in _listaAnimaisPorCliente)
            {
                if (item.IdAnimal == IdAnimal)
                {
                    animalPorCliente = item;
                    Imprimir(animalPorCliente);
                }
                else
                {
                    Console.WriteLine("Animal nao encontrado.");
                }
            }
        }
        public override void Imprimir<T>(T animalPorCliente)
        {
            foreach (var item in _listaAnimaisPorCliente)
            {
                Console.WriteLine($"ID do animal: {item.IdAnimal.ToString()}");
                Console.WriteLine($"ID do cliente: {item.IdCliente.ToString()}");
            }
        }
    }
}

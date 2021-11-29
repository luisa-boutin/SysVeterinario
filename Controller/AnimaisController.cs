using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using SysVeterinario_V3.Model;

namespace SysVeterinario_V3.Controller
{
    public class AnimaisController : ModeloController
    {
        private List<AnimaisModel> _listaAnimais = new();

        public AnimaisModel Animal = new();

        public override void SalvarBancoDados()
        { 
            XmlSerializer xml = new(typeof(List<AnimaisModel>));
            TextWriter arquivo = new StreamWriter(@"C:\Users\lbout\source\repos\Arquitetura\Projeto\SysVeterinario_V3\Animais.xml");
            xml.Serialize(arquivo, _listaAnimais);
            arquivo.Close();
        }
        public override void LerBancoDados()
        {
            XmlSerializer xml = new(typeof(List<AnimaisModel>));
            FileStream arquivo = new(@"C:\Users\lbout\source\repos\Arquitetura\Projeto\SysVeterinario_V3\Animais.xml", FileMode.Open);
            _listaAnimais = (List<AnimaisModel>)xml.Deserialize(arquivo);
            arquivo.Close();
        }
        public override void Inserir<T>(T Modelo)
        {
            _listaAnimais.Add(Modelo as AnimaisModel);
            SalvarBancoDados();
        }
        public override void Alterar<T>(T Modelo)
        {
            Boolean achou = false;

            foreach (var item in _listaAnimais)
            {
                if ((Modelo as AnimaisModel).IdAnimal == item.IdAnimal)
                {
                    achou = true;

                    Console.WriteLine("Insira aqui o nome do animal:");
                    (Modelo as AnimaisModel).NomeAnimal = Console.ReadLine();
                    Console.WriteLine("Insira aqui o apelido do animal:");
                    (Modelo as AnimaisModel).ApelidoAnimal = Console.ReadLine();
                    Console.WriteLine("Insira aqui a data de nascimento do animal (dd/mm/aaaa):");
                    (Modelo as AnimaisModel).DataDeNascimentoAnimal = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("Insira aqui observacoes sobre o animal:");
                    (Modelo as AnimaisModel).ObservacoesAnimal = Console.ReadLine();
                    Console.WriteLine("Insira aqui o codigo de identificacao da especie do animal:");
                    (Modelo as AnimaisModel).IdEspecieAnimal = int.Parse(Console.ReadLine());

                    Console.WriteLine("Dados alterados com sucesso.\n");
                }
            }

            if(achou == false)
            {
                Console.WriteLine("O animal nao foi encontrado.\n");
            }

            SalvarBancoDados();
        }
        public override void Excluir<T>(T Modelo)
        {
            Boolean achou = false;
            int posicao = -1;

            foreach (var item in _listaAnimais)
            {
                if((Animal as AnimaisModel).IdAnimal == item.IdAnimal)
                {
                    achou = true;
                    posicao = _listaAnimais.IndexOf(item);
                    _listaAnimais.RemoveAt(posicao);
                    Console.WriteLine("Animal removido da lista!\n");
                }
            }

            if (achou == false)
            {
                Console.WriteLine("O animal nao foi encontrado.\n");
            }

            SalvarBancoDados();
        }
        public override void Pesquisar(int valor)
        {
            AnimaisModel animal = null;
            
            foreach (var item in _listaAnimais)
            {
                if(item.IdAnimal == valor)
                {
                    animal = item;
                    Imprimir(animal);
                } else
                {
                    Console.WriteLine("Animal nao encontrado.");
                }
            }
        }
        public override void Imprimir<T>(T Modelo)
        {
            foreach(var item in _listaAnimais)
            {
                Console.WriteLine($"ID: {item.IdAnimal.ToString()}");
                Console.WriteLine($"Nome: {item.NomeAnimal.ToString()}");
                Console.WriteLine($"Apelido: {item.ApelidoAnimal.ToString()}");
                Console.WriteLine($"Data de nascimento: {item.DataDeNascimentoAnimal.ToString()}");
                Console.WriteLine($"Observacoes: {item.ObservacoesAnimal.ToString()}");
                Console.WriteLine($"ID da Especie: {item.IdEspecieAnimal.ToString()}");
            }
        }  
    }
}

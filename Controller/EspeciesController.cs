using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using SysVeterinario_V3.Model;

namespace SysVeterinario_V3.Controller
{
    public class EspeciesController : ModeloController 
    {
        private List<EspeciesModel> _listaEspecies = new();

        public EspeciesModel Especie = new();
        public override void SalvarBancoDados()
        {
            XmlSerializer xml = new(typeof(List<EspeciesModel>));
            TextWriter arquivo = new StreamWriter(@"C:\Users\lbout\source\repos\Arquitetura\Projeto\SysVeterinario_V3\Especies.xml");
            xml.Serialize(arquivo, _listaEspecies);
            arquivo.Close();
        }

        public override void LerBancoDados()
        {
            XmlSerializer xml = new(typeof(List<EspeciesModel>));
            FileStream arquivo = new(@"C:\Users\lbout\source\repos\Arquitetura\Projeto\SysVeterinario_V3\Especies.xml", FileMode.Open);
            _listaEspecies = (List<EspeciesModel>)xml.Deserialize(arquivo);
            arquivo.Close();
        }
        public override void Inserir<T>(T novaEspecie)
        {
            _listaEspecies.Add(Especie as EspeciesModel);
            SalvarBancoDados();
        }
        public override void Alterar<T>(T Especie)
        {
            Boolean achou = false;

            foreach (var item in _listaEspecies)
            {
                if ((Especie as EspeciesModel).IdEspecieAnimal == item.IdEspecieAnimal)
                {
                    achou = true;

                    Console.WriteLine("Insira aqui o nome da especie:");
                    (Especie as EspeciesModel).NomeEspecieAnimal = Console.ReadLine();

                    Console.WriteLine("Dados alterados com sucesso.\n");
                }
            }

            if (achou == false)
            {
                Console.WriteLine("A especie nao foi encontrada.\n");
            }

            SalvarBancoDados();
        }
        public override void Excluir<T>(T Especie)
        {
            Boolean achou = false;
            int posicao = -1;

            foreach (var item in _listaEspecies)
            {
                if ((Especie as EspeciesModel).IdEspecieAnimal == item.IdEspecieAnimal)
                {
                    achou = true;

                    posicao = _listaEspecies.IndexOf(item);
                    _listaEspecies.RemoveAt(posicao);
                    Console.WriteLine("Especie removida da lista!\n");
                }
            }

            if (achou == false)
            {
                Console.WriteLine("A especie nao foi encontrada.\n");
            }

            SalvarBancoDados();
        }
        public override void Pesquisar(int IdEspecieAnimal)
        {
            EspeciesModel especie = null;

            foreach (var item in _listaEspecies)
            {
                if (item.IdEspecieAnimal == IdEspecieAnimal)
                {
                    especie = item;
                    Imprimir(especie);
                }
                else
                {
                    Console.WriteLine("Especie nao encontrada.");
                }
            }
        }
        public override void Imprimir<T>(T Especie)
        {
            foreach (var item in _listaEspecies)
            {
                Console.WriteLine($"ID da especie: {item.IdEspecieAnimal.ToString()}");
                Console.WriteLine($"Nome da especie:: {item.NomeEspecieAnimal.ToString()}");
            }
        }
    }
}

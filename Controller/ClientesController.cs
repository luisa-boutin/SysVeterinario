﻿using System;
using System.Collections.Generic;
using SysVeterinario_V3.Model;
using System.Xml.Serialization;
using System.IO;

namespace SysVeterinario_V3.Controller
{
    public class ClientesController : ModeloController
    {
        private List<ClientesModel> _listaClientes = new();

        public ClientesModel Cliente = new();
        public override void SalvarBancoDados()
        {
            XmlSerializer xml = new(typeof(List<ClientesModel>));
            TextWriter arquivo = new StreamWriter(@"C:\Users\lbout\source\repos\Arquitetura\Projeto\SysVeterinario_V3\Clientes.xml");
            xml.Serialize(arquivo, _listaClientes);
            arquivo.Close();
        }

        public override void LerBancoDados()
        {
            XmlSerializer xml = new(typeof(List<ClientesModel>));
            FileStream arquivo = new(@"C:\Users\lbout\source\repos\Arquitetura\Projeto\SysVeterinario_V3\Clientes.xml", FileMode.Open);
            _listaClientes = (List<ClientesModel>)xml.Deserialize(arquivo);
            arquivo.Close();
        }
        public override void Inserir<T>(T Cliente)
        {
            _listaClientes.Add(Cliente as ClientesModel);
            SalvarBancoDados();
        }
        public override void Alterar<T>(T Cliente)
        {
            Boolean achou = false;

            foreach (var item in _listaClientes)
            {
                if ((Cliente as ClientesModel).IdAnimal == item.IdAnimal)
                {
                    achou = true;

                    Console.WriteLine("Insira aqui o codigo de identificacao do animal:");
                    (Cliente as ClientesModel).IdAnimal = int.Parse(Console.ReadLine());
                    Console.WriteLine("Insira aqui o nome do cliente:");
                    (Cliente as ClientesModel).NomeCliente = Console.ReadLine();
                    Console.WriteLine("Insira aqui o CPF do cliente (000.000.000-45):");
                    (Cliente as ClientesModel).CPFCliente = Console.ReadLine();
                    Console.WriteLine("Insira aqui o e-mail do cliente:");
                    (Cliente as ClientesModel).EmailCliente = Console.ReadLine();
                    Console.WriteLine("Insira aqui a data de cadastro do cliente (dd/mm/aaaa):");
                    (Cliente as ClientesModel).DataCadastroCliente = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("Insira aqui o telefone do cliente:");
                    (Cliente as ClientesModel).TelefoneCliente = Console.ReadLine();

                    Console.WriteLine("Dados alterados com sucesso.\n");
                }
            }

            if (achou == false)
            {
                Console.WriteLine("O cliente nao foi encontrado.\n");
            }

            SalvarBancoDados();
        }
        public override void Excluir<T>(T Cliente)
        {
            Boolean achou = false;
            int posicao = -1;

            foreach (var item in _listaClientes)
            {
                if ((Cliente as ClientesModel).IdCliente == item.IdCliente)
                {
                    achou = true;
                    posicao = _listaClientes.IndexOf(item);
                    _listaClientes.RemoveAt(posicao);
                    Console.WriteLine("Cliente removido da lista!\n");
                }
            }

            if (achou == false)
            {
                Console.WriteLine("O cliente nao foi encontrado.\n");
            }

            SalvarBancoDados();
        }
        public override void Pesquisar(int IdCliente)
        {
            ClientesModel cliente = null;

            foreach (var item in _listaClientes)
            {
                if (item.IdCliente == IdCliente)
                {
                    cliente = item;
                    Imprimir(cliente);
                }
                else
                {
                    Console.WriteLine("Cliente nao encontrado.");
                }
            }
        }
        public override void Imprimir<T>(T Cliente)
        {
            foreach (var item in _listaClientes)
            {
                Console.WriteLine($"ID do cliente: {item.IdCliente.ToString()}");
                Console.WriteLine($"ID do animal: {item.IdAnimal.ToString()}");
                Console.WriteLine($"Nome: {item.NomeCliente.ToString()}");
                Console.WriteLine($"CPF do cliente: {item.CPFCliente.ToString()}");
                Console.WriteLine($"Email do cliente: {item.EmailCliente.ToString()}");
                Console.WriteLine($"Data de cadastro: {item.DataCadastroCliente.ToString()}");
                Console.WriteLine($"Telefone do cliente: {item.TelefoneCliente.ToString()}");
            }
        }
    }
}

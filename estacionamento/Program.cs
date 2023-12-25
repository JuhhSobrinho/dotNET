// See https://aka.ms/new-console-template for more information
using estacionamento.models;
using System;

class Program
{
    static void Main()
    {
        Estacionamento es = new Estacionamento(); // Corrigindo o nome do tipo

        System.Console.WriteLine("Seja bem vindo ao sistema de estacionamento!");
        System.Console.Write("Digite o Preço inicial: ");

        string? precoInicialInput = Console.ReadLine();

        bool valor = decimal.TryParse(precoInicialInput, out decimal precoInicial); // Corrigindo o tipo bool
        if (!valor)
        {
            throw new ArgumentException("Valor Inválido");
        }
        System.Console.Write("Digite o Preço Por hora: ");
        string? precoHoraInput = Console.ReadLine();
        int.TryParse(precoHoraInput, out int precoHora);






        bool estado = true;
        while (estado)
        {
            Console.Clear();

            System.Console.WriteLine("Digite Sua Opção: \n 1 - Cadastrar Veículo \n 2 - Remover Veículo \n 3 - Listar Veículo \n 4 - Encerrar");
            string? caso = Console.ReadLine();
            switch (caso)
            {
                case "1":
                    System.Console.Write("Digite a Placa do Veículo: ");
                    string? placaInput = Console.ReadLine();
                    es.Adicionar(placaInput);
                    System.Console.WriteLine("Precione Uma Tecla Para Continuar");
                    Console.ReadLine();
                    break;
                case "2":
                    System.Console.Write("Digite a Placa do Veículo:");
                    string? placaInputRemo = Console.ReadLine();
                    System.Console.Write("Digite o tempo que permaneceu:");
                    string? precoHoraPermaneceuInput = Console.ReadLine();
                    int.TryParse(precoHoraPermaneceuInput, out int precoHoraPermaneceu);
                    es.Remover(placaInputRemo, precoHoraPermaneceu, precoHora, precoInicial);
                    System.Console.Write("Precione Uma Tecla Para Continuar");
                    Console.ReadLine();
                    break;
                case "3":
                    System.Console.WriteLine("Veículos estacionados são:");
                    es.Listar();
                    System.Console.Write("Precione Uma Tecla Para Continuar");
                    Console.ReadLine();
                    break;
                case "4":
                    estado = false;
                    System.Console.WriteLine("Tchau e até aa proxima :)");
                    System.Console.Write("Precione Uma Tecla Para Sair");
                    Console.ReadLine();
                    break;
                default:
                    System.Console.WriteLine("Selecione uma das Opções");
                    break;

            }
        }



    }
}

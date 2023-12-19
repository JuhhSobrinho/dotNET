using System;
using System.Collections.Generic;
using projetoPessoa.models;

class Program
{
    static void Main()
    {
        Pessoa p = new Pessoa();

        Console.WriteLine("Digite os nomes (digite 'fim' para parar):");

        string? MyNameInput;
        while ((MyNameInput = Console.ReadLine()) != "fim")
        {
            Console.WriteLine("Digite Sua idade: ");
            string? userInput = Console.ReadLine();

            if (!int.TryParse(userInput, out int number))
            {
                throw new ArgumentException("Entrada inválida. Deve ser um número inteiro.");
            }

            p.MyName.Add(MyNameInput);
            p.Idade.Add(number);
            Console.WriteLine("Digite os nomes (digite 'fim' para parar):");
        }

        DateTime dataAtual = DateTime.Now;
        p.DataQuandoFoiFeitoCadastro = dataAtual;

        p.Apresentar();
    }
}

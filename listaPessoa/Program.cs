using System;
using System.Collections.Generic;
using projetoPessoa.models;

class Program
{
    static void Main()
    {
        Pessoa p = new Pessoa();

        Console.WriteLine("Digite os nomes (digite 'fim' para parar):");

        string? myNameInput;
        while ((myNameInput = Console.ReadLine()) != "fim")
        {


            Console.WriteLine("Digite Sua idade: ");
            string? idadeInput = Console.ReadLine();
            Console.WriteLine("Digite Sua a sua doação: (ex: 22,50)");
            string? doacaoInput = Console.ReadLine();


            int.TryParse(idadeInput, out int idade);
            decimal.TryParse(doacaoInput, out decimal doacao); //ou só coverter Convert.ToInt32(userInput)            p.Idade.Add(error);
            if(idade == 0){
                throw new ArgumentException("Idade invalida");
            } else {

                p.AddPessoa(myNameInput, idade, doacao);
            }

            Console.WriteLine("Digite os nomes (digite 'fim' para parar):");
        }

        DateTime dataAtual = DateTime.Now;
        p.DataQuandoFoiFeitoCadastro = dataAtual;

        p.Apresentar();
    }
}

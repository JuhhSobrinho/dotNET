using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace projetoPessoa.models
{
    public class Pessoa
    {
        public List<string?> MyName { get; set; }
        public List<int> Idade { get; set; }
        public DateTime DataQuandoFoiFeitoCadastro { get; set; }

        public Pessoa()
        {
            // Inicializar as propriedades não anuláveis no construtor
            MyName = new List<string?>();
            Idade = new List<int>();
            DataQuandoFoiFeitoCadastro = DateTime.Now;
        }

        public void Apresentar()
        {
            Console.WriteLine("Dados da Pessoa:");

            // Apresentar cada nome na lista
            Console.WriteLine("Nomes  |  Idade");
            for (int i = 0; i < MyName.Count; i++)
            {
                Console.WriteLine($"{MyName[i]} | {Idade[i]}");
            }

            Console.WriteLine(); // Adicionar uma quebra de linha
            Console.WriteLine($"Data de Cadastro: {DataQuandoFoiFeitoCadastro}");
        }
    }
}
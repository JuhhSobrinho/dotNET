using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace projetoPessoa.models
{
    public class Pessoa
    {
        private List<string?> _myName;
        private List<int> _idade;
        private List<decimal> _doacao;


        public List<string?> MyName
        {
            get => _myName; // ou {Return _myName}

            set
            {
                if (value == null || value.Count == 0)
                {
                    throw new ArgumentException("A lista de nomes não pode ser vazia");
                }
                _myName = value;
            }
        }

        public List<int> Idade
        {
            get => _idade; // ou {Return _idade}


            set
            {
                if (value == null || value.Count == 0)
                {
                    throw new ArgumentException("A lista de idades não pode ser vazia");
                }
                _idade = value;
            }
        }

        public List<decimal> Doacao
        {
            get => _doacao; // ou {Return _idade}


            set
            {
                if (value == null || value.Count < 0)
                {
                    throw new ArgumentException("A lista de doação não pode ser vazia");
                }
                _doacao = value;
            }
        }

        public DateTime DataQuandoFoiFeitoCadastro { get; set; }

        public Pessoa()
        {
            _myName = new List<string?>();
            _idade = new List<int>();
            _doacao = new List<decimal>();

            DataQuandoFoiFeitoCadastro = DateTime.Now;
        }

        public void AddPessoa(string? MyNameInput, int idadeInput, decimal doacaoInput)
        {
            MyName.Add(MyNameInput);
            Idade.Add(idadeInput);
            Doacao.Add(doacaoInput);
        }

        public void Apresentar()
        {
            Console.WriteLine(" \n \n Dados da Pessoa:");

            Console.WriteLine(" \n Nomes  |  idade  |  Doação");
            for (int i = 0; i < MyName.Count; i++)
            {
                Console.WriteLine($"  {MyName[i]} | {Idade[i]} | {Doacao[i]:C}");
            }

            Console.WriteLine();
            Console.WriteLine($"Data de Cadastro: {DataQuandoFoiFeitoCadastro.ToString("dd/MM/yyyy HH:mm")}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace estacionamento.models
{
    public class Estacionamento
    {
        private List<string?> _placa;
        public List<string?> Placa
        {
            get => _placa;
            set
            {
                if (value == null || value.Count == 0)
                {
                    throw new ArgumentException("A lista de placa não pode ser vazia");
                }
                _placa = value;
            }
        }

        public Estacionamento(){
            _placa = new List<string?>();
        }


        public void Adicionar(string? placaInput)
        {
            Placa.Add(placaInput);
        }
        public void Remover(string? placaInput, int precoHoraPermaneceu, int precoHora, decimal precoInicial)
        {
            decimal result = (precoHoraPermaneceu*precoHora) + precoInicial;
            System.Console.WriteLine($"O veículo {placaInput} foi removido e o preço total foi de: {result:C}");
            Placa.Remove(placaInput);
        }

        public void Listar(){
            foreach (var item in Placa)
            {
                System.Console.WriteLine($"Placa: {item}");
            }
        }

    }
}
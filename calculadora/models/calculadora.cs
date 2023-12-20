using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace calculadora.models
{
    public class Calculadora
    {
        public int Number1 { get; set; }
        public int Number2 { get; set; }

        public void Somar()
        {
            int result = Number1 + Number2;
            System.Console.WriteLine($"O resultado de {Number1} + {Number2} é: \n Result: {result}");
        }

        public void Subtrair()
        {
            int result = Number1 - Number2;
            System.Console.WriteLine($"O resultado de {Number1} - {Number2} é: \n Result: {result}");
        }

        public void Dividir()
        {
            float result = (float)Number1 / Number2;
            System.Console.WriteLine($"O resultado de {Number1} / {Number2} é: \n Result: {result}");
        }

        public void Multiplicar()
        {
            int result = Number1 * Number2;
            System.Console.WriteLine($"O resultado de {Number1} X {Number2} é: \n Result: {result}");
        }

        public void Potencia()
        {
            double result = Math.Pow(Number1, Number2);
            System.Console.WriteLine($"O resultado de {Number1} ** {Number2} é: \n Result: {result}");
        }

        public void Seno()
        {
            double angulo = Number1;
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            System.Console.WriteLine($"O seno de {angulo} é: \n Result: {Math.Round(seno, 4)}");
        }

        public void Cos()
        {
            double angulo = Number1;
            double radiano = angulo * Math.PI / 180;
            double cos = Math.Cos(radiano);
            System.Console.WriteLine($"O cosseno de {angulo} é: \n Result: {Math.Round(cos, 4)}");
        }

        public void Tan()
        {
            double angulo = Number1;
            double radiano = angulo * Math.PI / 180;
            double tan = Math.Tan(radiano);
            System.Console.WriteLine($"A tangente de {angulo} é: \n Result: {Math.Round(tan, 4)}");
        }

        public void Raiz(){

            int result = Number1;

            for (int i = 0; i < (Number2-1); i++)
            {
                result *= Number1;
            }

            System.Console.WriteLine($"O resultado de {Number1} com raiz {Number2} é: \n Result: {result}");

        }
    }
}
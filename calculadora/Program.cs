// See https://aka.ms/new-console-template for more information
using calculadora.models;

Calculadora cal = new Calculadora();

System.Console.WriteLine("Digite O Valor 1");
string? auxNumber1 = Console.ReadLine();
int.TryParse(auxNumber1, out int NumberInput1);



System.Console.WriteLine("Digite O Valor 2");
string? auxNumber2 = Console.ReadLine();
int.TryParse(auxNumber2, out int NumberInput2);


cal.Number1 = NumberInput1;
cal.Number2 = NumberInput2;



System.Console.WriteLine("Digite Sua Operação \n Dividir \n Somar \n Multiplicar \n Subtrair \n Potencia \n Seno \n Coseno \n Tangente \n Raiz");
string? typeOperacao = Console.ReadLine();

switch (typeOperacao)
{
    case "Dividir":
        cal.Dividir();
        break;
    case "Somar":
        cal.Somar();
        break;
    case "Multiplicar":
        cal.Multiplicar();
        break;
    case "Subtrair":
        cal.Subtrair();
        break;
    case "Potencia":
        cal.Subtrair();
        break;
    case "Seno":
        System.Console.WriteLine("Será utilizado aprenas o valor1");
        cal.Seno();
        break;
    case "Coseno":
        System.Console.WriteLine("Será utilizado aprenas o valor1");
        cal.Cos();
        break;
    case "Tangente":
        System.Console.WriteLine("Será utilizado aprenas o valor1");
        cal.Tan();
        brea k;

    case "Raiz":
        cal.Raiz();
        break;
    

    default:
        System.Console.WriteLine("Tipo de operação invalida \n \n Digite uma dessas operações \n Dividir - Somar - Multiplicar - Subtrair - Potencia - Raiz");
        break;
}
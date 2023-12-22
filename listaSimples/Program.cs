// See https://aka.ms/new-console-template for more information

string?[] valores; // ou List<string> valores = new List<string>(); deifindo como lsita vazia lista<T>

System.Console.WriteLine("Digite quantos valores deseja armazenar (ex: 8) ?");

string? auxQuantValores = Console.ReadLine();

if (int.TryParse(auxQuantValores, out int quantValores))
{

    valores = new string[quantValores];

    for (int i = 0; i < quantValores; i++)
    {
        System.Console.WriteLine($"Digite o valor {i+1}:");
        valores[i] = Console.ReadLine();
    }

    foreach (var item in valores)
    {
        System.Console.WriteLine($"\n {item}");
    }
}   else    {
    System.Console.WriteLine("Valor de quantidade invalido!!!");
}
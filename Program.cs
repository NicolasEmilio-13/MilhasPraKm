Console.Clear();
Console.WriteLine("--- MILHAS PARA KM ---");
Console.Write("Informe o Valor em Milhas: ");

string entrada = Console.ReadLine()!;
double milhas = Convert.ToDouble(entrada);

double resultado = milhas * 1.609;

Console.WriteLine($"{milhas} milhas em km ----> {resultado}");
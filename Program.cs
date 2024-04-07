using System.Security.Cryptography;

int quantidaDeFaces;
int resultado;

Console.WriteLine("--- Simulador de Rolagem de Dado ---\n");

Console.Write("Digite a quantidades de faces do dado: ");
quantidaDeFaces = Convert.ToInt32(Console.ReadLine());

resultado = RandomNumberGenerator.GetInt32(1, quantidaDeFaces + 1);

Console.WriteLine($"\no resultado da rolagem do dado de {quantidaDeFaces} faces é: {resultado}");
using System.Reflection;

Console.Clear();

/*
8% de salario

salario = 100
fgts    =  8
*/

float salario;
float fgts;

Console.WriteLine("Digite o salário:");
salario = Convert.ToSingle(Console.ReadLine());

fgts = (salario * 8) / 100;

Console.WriteLine($"FGTS: R${Math.Round(fgts, 2)}");
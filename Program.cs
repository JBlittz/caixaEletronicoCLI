Console.WriteLine("========== CAIXA ELETRÔNICO ==========");
Console.WriteLine("Coloque o valor inteiro a ser sacado: ");
int[] notas = { 100, 50, 20, 10, 5, 2 };
int[] saque = { 0, 0, 0, 0, 0, 0 };
int valor;
while (true)
{
    if (int.TryParse(Console.ReadLine(), out int v))
    {
        valor = v;
        break;
    }
    else
    {
        Console.WriteLine("Entrada inválida");
    }
}
for (int i = 0; i < notas.Length; i++)
{
    if (valor % 2 != 0 && valor > 4)
    {
        saque[4]++;
        valor -= 5;
    }
    if (notas[i] == 5)
    {
        continue;
    }
    saque[i] += (int)(valor / notas[i]);
    valor %= notas[i];
}

Console.WriteLine($"Valor não sacado: {valor}");
for (int i = 0; i < saque.Length; i++)
{
    Console.WriteLine($"Nota de {notas[i]} reais: {saque[i]}");
}

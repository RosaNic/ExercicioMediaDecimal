decimal escolhido1;
int contador = 0;

decimal soma = 0;
decimal maiorNumero = 999999.99M;
decimal menorNumero = 999999.99M;

Console.Write
    ("Digite a quantidade de números: ");
    int quantidade = Convert.ToInt32(Console.ReadLine());


while (contador < quantidade)
{
    contador += 1;
    Console.Write($"Número 0{contador}: ");
    escolhido1 = Convert.ToDecimal(Console.ReadLine());
    soma = soma + escolhido1;

    if (contador == 1)
    {
        maiorNumero = escolhido1;
        menorNumero = escolhido1;
    }

    if (escolhido1 > maiorNumero)
    {
        maiorNumero = escolhido1;
    }

    if (escolhido1 < menorNumero)
    {
        menorNumero = escolhido1;
    }
}

if (contador > 0)
{
    decimal media = soma / quantidade;

    Console.WriteLine($"\nSoma...: {soma:N2}");
    Console.WriteLine($"Média..: {media:N2}");
    Console.WriteLine($"Menor..: {menorNumero:N2}");
    Console.WriteLine($"Maior..: {maiorNumero:N2}");
}
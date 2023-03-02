double cod, quant, total;
char S, N, resposta;

Console.WriteLine("Bem vindo(a)! Deseja comprar em nossa lanchonete? (digite S ou N)");
resposta = char.Parse(Console.ReadLine());

if (resposta == 'N' || resposta == 'n')
{
    Console.WriteLine("Que pena :( ate a proxima");
}

while (resposta == 'S' || resposta == 's')
{
    Console.WriteLine("--------------------------");
    Console.WriteLine("  CODIGOS  CARDAPIO!");
    Console.WriteLine("--------------------------");
    Console.WriteLine("  cod:100) Cachorro quente");
    Console.WriteLine("  cod:101) Bauru simples");
    Console.WriteLine("  cod:102) Bauru com ovo");
    Console.WriteLine("  cod:103) Hamburguer");
    Console.WriteLine("  cod:104) Cheeseburguer");
    Console.WriteLine("  cod:105) Refrigerante");
    Console.WriteLine("--------------------------");
    Console.WriteLine("          VALORES ");
    Console.WriteLine("--------------------------");
    Console.WriteLine("  Cachorro quente R$1,70");
    Console.WriteLine("  Bauru simples   R$2,30");
    Console.WriteLine("  Bauru com ovo   R$2,60");
    Console.WriteLine("  Hamburguer      R$2,40");
    Console.WriteLine("  Cheeseburguer   R$2,50");
    Console.WriteLine("  Refrigerante    R$1,00");
    Console.WriteLine(" ");

    Console.WriteLine("Digite o codigo do produto que vai comprar");
    cod = int.Parse(Console.ReadLine());

    Console.WriteLine("Agora digite a quantidade desse produto");
    quant = int.Parse(Console.ReadLine());

    if (cod == 100)
    {
        total = (quant * 1.70);
        Console.WriteLine("O valor total de sua compra foi R$" + total);
    }
    else if (cod == 101)
    {
        total = (quant * 2.30);
        Console.WriteLine("O valor total de sua compra foi R$" + total);
    }
    else if (cod == 102)
    {
        total = (quant * 2.60);
        Console.WriteLine("O valor total de sua compra foi R$" + total);
    }
    else if (cod == 103)
    {
        total = (quant * 2.40);
        Console.WriteLine("O valor total de sua compra foi R$" + total);
    }
    else if (cod == 104)
    {
        total = (quant * 2.50);
        Console.WriteLine("O valor total de sua compra foi R$" + total);
    }
    else if (cod == 105)
    {
        total = (quant * 1.00);
        Console.WriteLine("O valor total de sua compra foi R$" + total);
    }
    else
    {
        Console.WriteLine("Codigo do produto invalido."); ;
    }
    Console.WriteLine("Deseja efetuar outra compra? (S ou N)");
    resposta = char.Parse(Console.ReadLine());
}
Console.WriteLine("Muito obrigada pela preferencia");
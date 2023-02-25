int n1, n2, operacao;
Console.WriteLine("Digite dois numeros");
n1 = int.Parse(Console.ReadLine());
n2 = int.Parse(Console.ReadLine());

Console.WriteLine(" ---------------------------------------");
Console.WriteLine(" Qual operação deseja fazer?");
Console.WriteLine(" 1: Media entre os numeros digitados");
Console.WriteLine(" 2: Diferenca entre os numeros");
Console.WriteLine(" 3: Produtos entre os numeros digitados");
Console.WriteLine(" 4: Divisão do primeiro pelo segundo");
Console.WriteLine(" ---------------------------------------");
operacao = int.Parse(Console.ReadLine());
    
switch (operacao)
{
    case 1:
    operacao = (n1 + n2) / 2;
    Console.WriteLine("O resultado eh " + operacao);
    break;

    case 2:
    operacao = n1 - n2;
    Console.WriteLine("O resultado eh " + operacao);
    break;

    case 3:
    operacao = n1 * n2;
    Console.WriteLine("O resultado eh " + operacao);
    break;

    case 4:
    operacao = n1 / n2;
    Console.WriteLine("O resultado eh " + operacao);
    break;
    
    default: 
    Console.WriteLine("Erro na opcao.Programa encerrado.");
    break;
}
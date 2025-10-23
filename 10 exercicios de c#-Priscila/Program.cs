using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("10 EXERCÍCIOS DE C#");
        Exercício1();
        Exercício2();
        Exercício3();
        Exercício4();
        Exercício5();
        Exercício6();
        Exercício7();
        Exercício8();
        Exercício9();
        Exercício10();


    }

    public static void Exercício1()
    {
        Console.WriteLine("1)\tFaça um programa que: \r\n- Leia a cotação do dólar \r\n- Leia um valor em dólares \r\n- Converta esse valor para Real \r\n- Mostre o resultado\r\n");
        Console.WriteLine("Digite o valor que deseja converter de Dolares para reais: \n");
        {
          
            try
            {
                decimal cotacaoDolar = 0;
                while (cotacaoDolar == 0)
                {
                    Console.Write("Digite a cotação do dólar (Sugerido 5,45): ");
                    string inputCotacao = Console.ReadLine();
                    if (decimal.TryParse(inputCotacao, out cotacaoDolar) && cotacaoDolar != 0)
                        break;
                    Console.WriteLine("Valor inválido! Tente novamente.");
                }

                decimal valorDolar = 0;
                while (valorDolar == 0)
                {
                    Console.Write("Digite o valor em dólares para ser convertido em reais (não pode ser zero ou vazio): ");
                    string inputValor = Console.ReadLine();
                    if (decimal.TryParse(inputValor, out valorDolar) && valorDolar != 0)
                        break;
                    Console.WriteLine("Valor inválido! Tente novamente.");
                }

                decimal valorReais = valorDolar * cotacaoDolar;
                Console.WriteLine($"Valor em reais: R$ {valorReais:F2}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
    public static void Exercício2()
{
        Console.WriteLine("2)\tFaça um programa para pagamento de comissão de vendedores de peças, levando-se em consideração que sua comissão será de 5% do total da venda e que você tem os seguintes dados: \r\n- Identificação do vendedor \r\n- Código da peça \r\n- Preço unitário da peça \r\n- Quantidade vendida\r\n");
        {
            try
            {
                Console.Write("Digite a identificação do vendedor: ");
                string identificacaoVendedor = Console.ReadLine();
                while (string.IsNullOrWhiteSpace(identificacaoVendedor))
                {
                    Console.WriteLine("Identificação não pode ser vazia. Tente novamente:");
                    identificacaoVendedor = Console.ReadLine();
                }

                Console.Write("Digite o código da peça: ");
                string codigoPeca = Console.ReadLine();
                while (string.IsNullOrWhiteSpace(codigoPeca))
                {
                    Console.WriteLine("Código da peça não pode ser vazio. Tente novamente:");
                    codigoPeca = Console.ReadLine();
                }

                decimal precoUnitario = 0;
                while (precoUnitario <= 0)
                {
                    Console.Write("Digite o preço unitário da peça: ");
                    string inputPreco = Console.ReadLine();
                    if (decimal.TryParse(inputPreco, out precoUnitario) && precoUnitario > 0)
                        break;
                    Console.WriteLine("Preço inválido! Tente novamente.");
                }

                int quantidadeVendida = 0;
                while (quantidadeVendida <= 0)
                {
                    Console.Write("Digite a quantidade vendida: ");
                    string inputQtd = Console.ReadLine();
                    if (int.TryParse(inputQtd, out quantidadeVendida) && quantidadeVendida > 0)
                        break;
                    Console.WriteLine("Quantidade inválida! Tente novamente.");
                }

                decimal totalVenda = precoUnitario * quantidadeVendida;
                decimal comissao = totalVenda * 0.05m;

                Console.WriteLine($"\nResumo da venda:");
                Console.WriteLine($"Vendedor: {identificacaoVendedor}");
                Console.WriteLine($"Código da peça: {codigoPeca}");
                Console.WriteLine($"Total da venda: R$ {totalVenda:F2}");
                Console.WriteLine($"Comissão (5%): R$ {comissao:F2}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
    public static void Exercício3()
    {
        Console.WriteLine("3)\tFaça um programa para calcular o estoque médio de uma peça, sendo que: ESTOQUE MÉDIO = (QUANTIDADE_MÍNIMA + QUANTIDADE_MÁXIMA) / 2.");
    
    try
            {
                Console.Write("Digite a identificação do vendedor: ");
                string identificacaoVendedor = Console.ReadLine();
                while (string.IsNullOrWhiteSpace(identificacaoVendedor))
                {
                    Console.WriteLine("Identificação não pode ser vazia. Tente novamente:");
                    identificacaoVendedor = Console.ReadLine();
                }

Console.Write("Digite o código da peça: ");
string codigoPeca = Console.ReadLine();
while (string.IsNullOrWhiteSpace(codigoPeca))
{
    Console.WriteLine("Código da peça não pode ser vazio. Tente novamente:");
    codigoPeca = Console.ReadLine();
}

decimal precoUnitario = 0;
while (precoUnitario <= 0)
{
    Console.Write("Digite o preço unitário da peça: ");
    string inputPreco = Console.ReadLine();
    if (decimal.TryParse(inputPreco, out precoUnitario) && precoUnitario > 0)
        break;
    Console.WriteLine("Preço inválido! Tente novamente.");
}

int quantidadeVendida = 0;
while (quantidadeVendida <= 0)
{
    Console.Write("Digite a quantidade vendida: ");
    string inputQtd = Console.ReadLine();
    if (int.TryParse(inputQtd, out quantidadeVendida) && quantidadeVendida > 0)
        break;
    Console.WriteLine("Quantidade inválida! Tente novamente.");
}

decimal totalVenda = precoUnitario * quantidadeVendida;
decimal comissao = totalVenda * 0.05m;

Console.WriteLine($"\nResumo da venda:");
Console.WriteLine($"Vendedor: {identificacaoVendedor}");
Console.WriteLine($"Código da peça: {codigoPeca}");
Console.WriteLine($"Total da venda: R$ {totalVenda:F2}");
Console.WriteLine($"Comissão (5%): R$ {comissao:F2}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    public static void Exercício4()
    {
        Console.WriteLine("4)\tEscreva um programa que leia um número inteiro e exiba o seu módulo. \r\nO módulo de um número x é: \r\nx se x é maior ou igual a zero \r\nx * (-1) se x é menor que zero\r\n");
    
     try
        {
            int numero;
            while (true)
            {
                Console.Write("Digite um número inteiro: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out numero))
                    break;
                Console.WriteLine("Valor inválido! Tente novamente.");
            }

int modulo = numero >= 0 ? numero : numero * -1;
Console.WriteLine($"O módulo de {numero} é: {modulo}");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }
    public static void Exercício5()
    {
        Console.WriteLine("5)\tEscreva um programa que leia 3 números inteiros e imprima na tela os valores em ordem decrescente.");
       
        Console.WriteLine("Me de o 1º número inteiro:");
        int n1=int.Parse(Console.ReadLine());

        Console.WriteLine("Me de o 2º número inteiro:");
        int n2=int.Parse(Console.ReadLine());

        Console.WriteLine("Me de o 3° número inteiro:");
        int n3=int.Parse(Console.ReadLine());

        
        var numeros = new List<int> { n1, n2, n3 };

        var ordenados = numeros.OrderByDescending(n => n);

        Console.WriteLine("\nNúmeros em ordem decrescente:");
        foreach (var n in ordenados)
        {
            Console.Write(n + " ");
        }

        Console.WriteLine();
    }
    public static void Exercício6()
    {
        Console.WriteLine("6)\tEscreva um programa que leia dois números e apresente a diferença do maior para o menor.\r\n\r\n");
        try
        {
            int numero1, numero2;

            while (true)
            {
                Console.Write("Digite o primeiro número inteiro: ");
                string input1 = Console.ReadLine();
                if (int.TryParse(input1, out numero1))
                    break;
                Console.WriteLine("Valor inválido! Tente novamente.");
            }

            while (true)
            {
                Console.Write("Digite o segundo número inteiro: ");
                string input2 = Console.ReadLine();
                if (int.TryParse(input2, out numero2))
                    break;
                Console.WriteLine("Valor inválido! Tente novamente.");
            }

            int maior = Math.Max(numero1, numero2);
            int menor = Math.Min(numero1, numero2);
            int diferenca = maior - menor;

            Console.WriteLine($"A diferença do maior para o menor é: {diferenca}");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
}
    public static void Exercício7()
    {
        Console.WriteLine("7)\tEscreva um programa que leia dois números e exiba mensagem informando o valor do maior número e o valor do menor número. Se os dois números forem iguais, o programa deve exibir mensagem informando este fato.");
        try
        {
            int num1, num2;

            while (true)
            {
                Console.Write("Digite o primeiro número inteiro: ");
                if (int.TryParse(Console.ReadLine(), out num1)) break;
                Console.WriteLine("Valor inválido! Tente novamente.");
            }

            while (true)
            {
                Console.Write("Digite o segundo número inteiro: ");
                if (int.TryParse(Console.ReadLine(), out num2)) break;
                Console.WriteLine("Valor inválido! Tente novamente.");
            }

            if (num1 == num2)
            {
                Console.WriteLine("Os dois números são iguais!");
            }
            else
            {
                int maior = Math.Max(num1, num2);
                int menor = Math.Min(num1, num2);
                Console.WriteLine($"O maior número é: {maior}");
                Console.WriteLine($"O menor número é: {menor}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
}
    public static void Exercício8()
    {
        Console.WriteLine("8)\tEscreva um programa que exiba as seguintes opções e realize os que se pede em cada uma delas: \r\n1 – Adição \r\n2 – Subtração \r\n3 – Multiplicação \r\n4 – Divisão\r\n");
        Console.WriteLine("8)\tEscolha uma operação:\n");
        Console.WriteLine("1 – Adição");
        Console.WriteLine("2 – Subtração");
        Console.WriteLine("3 – Multiplicação");
        Console.WriteLine("4 – Divisão\n");

        Console.Write("Digite o número da operação desejada: ");
        string opcao = Console.ReadLine();

        if (!new[] { "1", "2", "3", "4" }.Contains(opcao))
        {
            Console.WriteLine("Opção inválida.");
            return;
        }

        Console.Write("\nDigite o primeiro número: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        double num2 = double.Parse(Console.ReadLine());

        double resultado = 0;
        string operacao = "";

        switch (opcao)
        {
            case "1":
                resultado = num1 + num2;
                operacao = "Adição";
                break;
            case "2":
                resultado = num1 - num2;
                operacao = "Subtração";
                break;
            case "3":
                resultado = num1 * num2;
                operacao = "Multiplicação";
                break;
            case "4":
                if (num2 == 0)
                {
                    Console.WriteLine("\nErro: divisão por zero não é permitida.");
                    return;
                }
                resultado = num1 / num2;
                operacao = "Divisão";
                break;
        }

        Console.WriteLine($"\nResultado da {operacao}: {resultado}");
    }
    public static void Exercício9()
    {
        Console.WriteLine("9)\tEscreva um programa que exiba os números de 1 a 100 na tela em ordem decrescente.");

        for(int i = 100; i >= 1; i--)
    {
            Console.Write(i + " ");
        }

        Console.WriteLine();
    }
    public static void Exercício10()
    {
        Console.WriteLine("10)\tFaça um programa que conte de 1 até 100 e a cada múltiplo de 10 exiba uma mensagem: \"Múltiplo de 10\".\n");

        var numeros = Enumerable.Range(1, 100);

        foreach (var numero in numeros)
        {
            Console.Write(numero);

            if (numero % 10 == 0)
            {
                Console.Write(" → Múltiplo de 10");
            }

            Console.WriteLine();
        }
    }
}

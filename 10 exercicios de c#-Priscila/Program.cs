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

    }
    public static void Exercício2()
{
        Console.WriteLine("2)\tFaça um programa para pagamento de comissão de vendedores de peças, levando-se em consideração que sua comissão será de 5% do total da venda e que você tem os seguintes dados: \r\n- Identificação do vendedor \r\n- Código da peça \r\n- Preço unitário da peça \r\n- Quantidade vendida\r\n");

}
    public static void Exercício3()
    {
        Console.WriteLine("3)\tFaça um programa para calcular o estoque médio de uma peça, sendo que: ESTOQUE MÉDIO = (QUANTIDADE_MÍNIMA + QUANTIDADE_MÁXIMA) / 2.");
    }
    public static void Exercício4()
    {
        Console.WriteLine("4)\tEscreva um programa que leia um número inteiro e exiba o seu módulo. \r\nO módulo de um número x é: \r\nx se x é maior ou igual a zero \r\nx * (-1) se x é menor que zero\r\n");
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

    }
    public static void Exercício7()
    {
        Console.WriteLine("7)\tEscreva um programa que leia dois números e exiba mensagem informando o valor do maior número e o valor do menor número. Se os dois números forem iguais, o programa deve exibir mensagem informando este fato.");
      
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

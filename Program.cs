// Laços de Repetição e Condicionais
using System;


#region 
// Parte 1 - Básico

// 1. Contagem com condição par/impar
// use um for para imprimir os números 1 a 20. Mostre se é par ou impar ao lado de cada número.

/* for (int i = 1; i <= 20; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine($"o número na posição {i} é par");
    }
    else
    {
        Console.WriteLine($"o número na posição {i} é impar");
    }

} */

// 2. Somatorio até número positivo
// use um while para somar números digitados pelo usuario até que ele digite um número negativo.

/*int numero = 0;
int soma = 0;

do
{
    Console.WriteLine("Digite um número(Negativo para sair do loop): ");
    numero = int.Parse(Console.ReadLine());

    if (numero >= 0)
    {

        soma += numero;

    }


} while (numero >= 0);
        Console.WriteLine($"A soma dos números digitados é: {soma}");
        */

// 3. Tabuada Condicional
// Gerar a tabuada do 1 até o 10 com for, mas exiba somente os resultados pares.

/* int num = 1;

for (int i = 1; i <= 10; i++)
{
    int resultado = num * i;

    if (resultado % 2 ==0)
    {
        Console.WriteLine($"O Resultado {resultado} é par");
    } 
    
} */

// 4. Contador de Vogais 
// Peça uma palavra e use foreach para contar quantas vogais e consoantes há. use o if para classificar cada letra.

/*Console.WriteLine("Digite uma palavra:");


string palavra = Console.ReadLine();
int vogais = 0;
int consoantes = 0;

      foreach (char letra in palavra.ToLower())
{
    if (char.IsLetter(letra))
    {
        if ("aeiou".Contains(letra))
        {
            vogais++;
        }
        else
        {
            consoantes++;
        }

    }   
}

Console.WriteLine($"Vogais: {vogais}");
Console.WriteLine($"Consoantes: {consoantes}");
*/


// 5. Números divisiveis por 3 e 5
// Imprima os números de 1 a 50 e: 
// Se for divisel por 3 -> escreva "Fizz"
// Se for divisel por 5 -> escreva "Buzz"
// Se for por ambos -> escreva "FizzBuzz"


// for (int i = 1; i <= 50; i++)
// {
//     if (i % 3 == 0 && i % 5 == 0)
//     {
//         Console.WriteLine($"{i} - FizzBuzz");
//     }
//     else if (i % 3 == 0)
//     {
//         Console.WriteLine($"{i} - Fizz");
//     }
//     else if (i % 5 == 0)
//     {
//         Console.WriteLine($"{i} - Buzz");
//     }
//     else
//     {
//         Console.WriteLine(i);
//     }
// }
#endregion

#region
// Parte 1 - Intermediário

// 6. Média com aprovação
// Peça 5 notas, use um for para calcular a média e um if para mostrar se o aluno está:
// Aprovado (>=7),
// Recuperação (>=5),
// Reprovado (<5).

// double soma = 0;
// int notas = 5;

// for (int i = 1; i <= notas; i++)
// {
//     Console.WriteLine($"Digite a nota {i}: ");
//     double nota = Convert.ToDouble(Console.ReadLine());
//     soma += nota;
// }

// double media = soma / notas;
// Console.WriteLine($"\nMédia: {media:F0}");

// if (media >= 7)
// {
//     Console.WriteLine("Aluno Aprovado");
// } else if (media >= 5)
// {
//     Console.WriteLine("Aluno em Recuperação");
// } else
// {
//     Console.WriteLine("Aluno Reprovado");
// }
#endregion

#region 
// 7. Maior e menor número
// Leia 10 números em um while, e ao final mostre qual foi o maior e o menor.

// int contador = 0;
// int numero;
// int maior = int.MinValue;
// int menor = int.MaxValue;

// while (contador < 10)
// {
//     Console.WriteLine($"Digite o número {contador + 1}: ");
//     numero = Convert.ToInt32(Console.ReadLine());

//     if (numero > maior)
//         maior = numero;

//     if (numero < menor)
//         menor = numero;

//     contador++;
// }

// Console.WriteLine($"\nMaior número digitado: {maior}");
// Console.WriteLine($"Menor número digitado: {menor}");
#endregion

#region 
// 8. Senha com tentativas limitadas
// Permita até 3 tentativas de senha usando do while e if
// Exiba "Acesso permitido" ou "Conta Bloqueada".

// string senhaCorreta = "Edna2025";
// string tentativa;
// int tentativas = 0;

// do
// {
//     Console.WriteLine("Digite a senha: ");
//     tentativa = Console.ReadLine();
//     tentativas++;

//     if (tentativa == senhaCorreta)
//     {
//         Console.WriteLine("Acesso liberado");
//         break;
//     }
// } while (tentativas < 3);

// if (tentativa != senhaCorreta)
// {
//     Console.WriteLine("Conta Bloqueada");
// }
#endregion

#region 
// 9. Fatorial com validação
// Só aceite números positivos(use if).

// Console.WriteLine("Digite um número positivo: ");
// int numero = Convert.ToInt32(Console.ReadLine());

// if (numero < 0)
// {
//     Console.WriteLine("Número inválido. Só é aceito números positivos");
// }
// else
// {
//     int fatorial = 1;
//     int contador = 1;

//     while (contador <= numero)
//     {
//         fatorial *= contador;
//         contador++;
//     }
//     Console.WriteLine($"Fatorial de {numero} é: {fatorial}");
// }
#endregion

#region 
// 10. Contador de pares e ímpares digitados
// Peça números até o usuário digitar 0
// Mostre quantos números pares e ímpares foram digitados.

// int numero;
// int pares = 0;
// int impares = 0;

// do
// {
//     Console.WriteLine("Digite um número (0 para sair): ");
//     numero = Convert.ToInt32(Console.ReadLine());

//     if (numero != 0)
//     {
//         if (numero % 2 == 0)
//             pares++;
//         else
//             impares++;
//     }
// } while (numero != 0);

// Console.WriteLine($"\nTotal de números pares: {pares}");
// Console.WriteLine($"Total de números impares: {impares}");
#endregion

// Parte 1 - Avançado

#region 
// 11. Números primos até N
// Peça para o usuário digitar um número. 
// Depois mostre todos os números primos que existem de 2 até o número digitado.

// Console.WriteLine("Digite um número para N: ");
// int N = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"\nNúmeros primos até {N}");

// for (int i = 2; i <= N; i++)
// {
//     bool nPrimo = true;

//     for (int divisor = 2; divisor < i; divisor++)
//     {
//         if (i % divisor == 0)
//         {
//             nPrimo = false;
//             break;
//         }
//     }

//     if (nPrimo)
//     {
//         Console.WriteLine(i);
//     }
// }
#endregion

#region 
// 12. Triângulo de asteriscos com tamanho válido
// Peça um número entre 1 e 10 e desenhe um triângulo de *
// Use while para validar a entrada.

// int tamanhoDoAsteriscos;

// Console.WriteLine("Digite um número entre 1 e 10: ");
// tamanhoDoAsteriscos = Convert.ToInt32(Console.ReadLine());

// while (tamanhoDoAsteriscos < 1 || tamanhoDoAsteriscos > 10)
// {
//     Console.WriteLine("Valor inválido. Digite um número entre 1 e 10: ");
//     tamanhoDoAsteriscos = Convert.ToInt32(Console.ReadLine());
// }


// for (int linhasDoTriangulo = 1; linhasDoTriangulo <= tamanhoDoAsteriscos; linhasDoTriangulo++)
// {
//     for (int colunasDoTriangulo = 1; colunasDoTriangulo <= linhasDoTriangulo; colunasDoTriangulo++)
//     {
//         Console.Write("*");
//     }
//     Console.WriteLine();
// }
#endregion

#region 
// 13. Menu interativo de operações matemáticas
// Crie um menu (1-Somar, 2-Subtrair, 0-Sair) e use do while com switch para executar operações até o usuário sair.

// int opcao;

// do
// {
//     Console.WriteLine("\nMenu de Operações Matemáticas:");
//     Console.WriteLine("1 - Somar");
//     Console.WriteLine("2 - Subtrair");
//     Console.WriteLine("0 - Sair");
//     Console.WriteLine("Escolha uma opção: ");
//     opcao = Convert.ToInt32(Console.ReadLine());

//     switch (opcao)
//     {
//         case 1:
//             Console.WriteLine("Digite o primeiro número: ");
//             int num1 = Convert.ToInt32(Console.ReadLine());

//             Console.WriteLine("Digite o segundo número: ");
//             int num2 = Convert.ToInt32(Console.ReadLine());

//             Console.WriteLine($"Resultado da soma: {num1 + num2}");
//             break;

//         case 2:
//             Console.WriteLine("Digite o primeiro número: ");
//             int sub1 = Convert.ToInt32(Console.ReadLine());

//             Console.WriteLine("Digite o segundo número: ");
//             int sub2 = Convert.ToInt32(Console.ReadLine());

//             Console.WriteLine($"Resultado da soma: {sub1 + sub2}");
//             break;

//         case 0:
//             Console.WriteLine("Encerrando o programa");
//             break;

//         default:
//             Console.WriteLine("Opção inválida. Tente novamente");
//             break;
//     }
// } while (opcao != 0);
#endregion

#region 
// 14. Inversão de texto e verificação palíndroma
// Peça uma palavra, inverta com for e verifique (com if) se é um palíndromo

// Console.WriteLine("Digite uma palavra: ");
// string? palavra = Console.ReadLine();

// if (string.IsNullOrEmpty(palavra))
// {
//     Console.WriteLine("Você não digitou nenhuma palavra.");
// }
// else
// {

//     string palavraInvertida = "";

//     for (int i = palavra.Length - 1; i >= 0; i--)
//     {
//         palavraInvertida += palavra[i];
//     }

//     Console.WriteLine($"Palavra Invertida: {palavraInvertida}");

//     if (palavra.ToLower() == palavraInvertida.ToLower())
//     {
//         Console.WriteLine("É um palíndromo.");
//     }
//     else
//     {
//         Console.WriteLine("Não é um palíndromo.");
//     }
// }
#endregion

#region 
// 15. Sequência de Fibonacci com limite condicional
// Peça um número limite e gere os valores da sequência até esse número (use while e if).

// Console.WriteLine("Digite um número limite: ");
// int numeroLimite = Convert.ToInt32(Console.ReadLine());

// int a = 0;
// int b = 1;

// Console.WriteLine("\nSequência de Fibonacci até " + numeroLimite + ":");

// while (a <= numeroLimite)
// {
//     Console.Write(a + " ");

//     int proximoNumero = a + b;
//     a = b;
//     b = proximoNumero;
// }
#endregion


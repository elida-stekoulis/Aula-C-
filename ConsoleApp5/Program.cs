/* -**** Aula 02 ******
using System;

namespace Nota
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double nota1 = (8.5);
            double nota2 = (7.2);
            double nota3 = (9.0);
            double media = (nota1 + nota2+ nota3)/3;

            Console.WriteLine("*** NOTAS ***\n");
            Console.WriteLine($"nota1: {nota1}");
            Console.WriteLine($"nota2: {nota2}");
            Console.WriteLine($"nota3: {nota3}");
            Console.WriteLine($"A média de notas é: {media:F2}");                      
        }
    }
}


using System;

namespace Liquidação
{
    class Program
    {
        static void Main(string[] args)
        {
            string Nome = ("Smart TV 50");
            string Preço = ("R$ 2.499,00");
            Double Estoque = (15);
            bool Promoção = (true);

            Console.WriteLine("*** Produto em Promoção ***\n");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Preço: {Preço}");
            Console.WriteLine($"Estoque: {Estoque}");
            Console.WriteLine($"Promoção:{(Promoção ? "Sim": "Não")}"); // Converte True e False em Sim ou Não
        }
    }
}
*/
/*

// Aula 3  - RedLine = Só aceita string, para aceitar double ou Doublee, deve fazer uma conversão.

using System;

namespace Perfil_Doubleerativo
{
    class Program
    {
    static void Main(string[] args) 
    {
        Console.Write("Digite o seu nome: ");
        string nome = Console.ReadLine();

        Console.Write("Digite a sua idade: ");
        string idade = Console.ReadLine();

        Console.WriteLine($"Olá {nome}, vc tem {idade} anos");
    }

    }
}
*/
/*
// Primeira Calculadora 


using System;
namespace Calculadora
{
    class Progrm
    { static void Main(string[] args)
        {
            Console.Write("Digte o primeiro número: ");
            string n1 = Console.ReadLine();
            Console.Write("Digite o segundo número: ");
            string n2 = Console.ReadLine();
            Console.WriteLine($"A soma é: {n1 + n2}");
               // Se digitar 2+2, o resultado será 22
        }
    }
}
*/
/*
using System;
using System.Globalization; //Usa a linguagem universal para soma usando o ponto

namespace CalculadoraOficial
{
    class Program
    {

        static void Main(string[] args) 
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Digite o primeiro número: ");
            string n1 = Console.ReadLine();
            Double num1 = Double.Parse(n1, CI); // Converte o texto em número (pode usar o mesmo script como int)

            Console.Write("Digite o segundo número: ");
            string n2 = Console.ReadLine();
            Double num2 = Double.Parse(n2, CI);

            Double resultado = num1 + num2; // Realiza a soma 
            Console.WriteLine($"A soma é: {resultado}"); // Exibe o resultado da soma
         }
    }


}
 */

/*
// Numero secreto - Aula 4

using System;
    namespace NumeroSecreto
{
    class Program
    {
        static void Main(string[] args)
        {

            int numeroSecreto = 99;
            Console.WriteLine("Adivinhe o número secreto! (Entre 1 e 100)");
            int palpite = int.Parse(Console.ReadLine());

            if (palpite == numeroSecreto)
            {
                Console.WriteLine("Acertou mizeravel.");
            }
            else
            {
                Console.WriteLine("Tente novamente.");
            }

        }
    }    
}

*/

// Testando && 
/*
using System;
    namespace Requisitos
{
    class Program
      {
        static void Main(string[] args)
        {
            string classe = "Guerreiro";
            int nivel = 15;
            Console.WriteLine("Bem vindo ao jogo!");
            Console.WriteLine("Para participar, é necessário que você tenha algumas caracteristicas especiais");
               

                Console.Write("Informe a sua classe");
                string classe = Console.ReadLine();
                Console.Write("Informe o seu Nível");
                int nivel = int.Parse(Console.ReadLine());

            if( class == "Guerreiro") 
                 
                   
            


        }
       }
 }
*/

/*
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bem vindo ao jogo!");
        Console.WriteLine("Para participar, você precisa de algumas caracteristicas especiais");

        string classe = "Guerreiro";
        int nivel = 10;

        // Solicita a classe do jogador
        Console.Write("Digite sua classe: ");
        classe = Console.ReadLine();

        // Solicita o nível do jogador
        Console.Write("Digite seu nível: ");
        bool nivelValido = int.TryParse(Console.ReadLine(), out nivel);

        // Verifica se a entrada do nível é válida
        if (!nivelValido)
        {
            Console.WriteLine("Nível inválido. Tente novamente.");
            return;
        }

        // Verifica os requisitos para entrar no jogo
        if (classe == "Guerreiro" && nivel >= 10)
        {
            Console.WriteLine("Bem-vindo ao Jogo Guerreiro!");
        }
        else if (classe == "Guerreiro" && nivel < 10)
        {
            Console.WriteLine("Lamento, o seu nível não é compativel!");
        }
        else if (classe != "Guerreiro" && nivel > 10)
        {
            Console.WriteLine("Lamento, mas a sua classe não é compativel!");
        }
        else
        {
            Console.WriteLine("Você não cumpre os requisitos, sorry.");
        }
    }
}
*/

/*
// Importa a biblioteca System, que contém funções essenciais como o Console.
using System;
// Organiza nosso código em um "pacote" ou "projeto".
namespace Menu_de_Premio;
// A classe principal do nosso programa.
class Program
{   // O Main é o ponto de entrada. É aqui que a execução do programa começa.
    static void Main()
    {  // 1. Exibe um menu de opções para o usuário.
        Console.WriteLine("Escolha o seu prêmio:");
        Console.WriteLine("1");
        Console.WriteLine("2");
        Console.WriteLine("3");
        Console.WriteLine("4");
        Console.WriteLine("Digite uma opção:");
        // 2. Lê a opção que o usuário digitou e guarda na variável 'opcao'.
        // Console.ReadLine() sempre lê o texto (string).
        string escolha = Console.ReadLine();

        Console.WriteLine("--------------------------"); // Linha para organizar a saída.
          // 3. A estrutura switch começa aqui. Ela vai avaliar o conteúdo da variável 'opcao'.
        switch (escolha)
        {   // Caso o valor de 'opcao' seja "1"
            case "1":
                Console.WriteLine("Você escolheu o Prêmio de R$ 500,00 reais!");
                break; // O 'break' é essen'cial. Ele encerra o switch.
            case "2":
                Console.WriteLine("Você escolheu o Prêmio de R$ 1000,00 reais!");
                break;
            case "3":
                Console.WriteLine("Você escolheu um carro!");
                break;
            case "4":
                Console.WriteLine("Você escolheu o Prêmio de consolação - Um pirulito!");
                break;
            default:    // Se nenhum dos 'case' acima corresponder ao valor de 'opcao'.
                Console.WriteLine("Opção inválida. Tente novamente.");
                break; // Encerra o switch.
        } 
        // Mensagem final do programa.
        Console.WriteLine("Obrigado por participar!");
        Console.ReadKey(); // Espera o usuário pressionar uma tecla antes de fechar.
    }
}
*/

/*
 Atividade Switch
Enunciado:Você deve criar um programa que simule o menu de um caixa eletrônico. O programa precisa seguir os seguintes passos:
Exibir um Menu: Mostre na tela as seguintes opções para o usuário:
--- Caixa Eletrônico ---
1 - Ver Saldo
2 - Fazer Saque
3 - Fazer Depósito
Pedir uma Escolha: Solicite que o usuário digite o número da operação desejada.
Processar a Escolha: Use uma estrutura switch para verificar o número que o usuário digitou.
Se o usuário digitar "1", exiba a mensagem: Você escolheu a opção: VER SALDO.
Se o usuário digitar "2", exiba a mensagem: Você escolheu a opção: FAZER SAQUE.
Se o usuário digitar "3", exiba a mensagem: Você escolheu a opção: FAZER DEPÓSITO.
Lidar com Erros: Se o usuário digitar qualquer outra coisa, o programa deve exibir a mensagem: Opção inválida.
 
*/
/*
using System;

namespace CaixaEletronico
{
    class Program
    {
        static void Main()
        {
            decimal saldo = 1500.00m; // Saldo inicial
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("---- Caixa Eletrônico ----");
                Console.WriteLine("1 - Ver Saldo");
                Console.WriteLine("2 - Fazer Saque");
                Console.WriteLine("3 - Fazer Depósito");
                Console.WriteLine("0 - Sair");
                Console.Write("\nDigite o número da operação desejada: ");

                string escolha = Console.ReadLine();

                switch (escolha)
                {
                    case "1":
                        Console.WriteLine($"\nSeu saldo é R${saldo:F2}");
                        break;

                    case "2":
                        Console.Write("Digite o valor que deseja sacar: ");

                        if (decimal.TryParse(Console.ReadLine(), out decimal valorSaque))

                        {
                            if (valorSaque <= saldo)
                            {
                                saldo -= valorSaque;
                                Console.WriteLine($"Saque de R${valorSaque:F2} realizado com sucesso!");
                            }
                            else
                            {
                                Console.WriteLine("Saldo insuficiente.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Entrada inválida.");
                        }
                        break;

                    case "3":
                        Console.Write("\nDigite o valor do depósito: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal valorDeposito) && valorDeposito > 0)
                        {
                            saldo += valorDeposito;
                            Console.WriteLine($"Depósito de R${valorDeposito:F2} realizado com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Valor inválido para depósito.");
                        }
                        break;

                    case "0":
                        continuar = false;
                        Console.WriteLine("\nObrigado por usar o caixa eletrônico!");
                        break;

                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }

                if (continuar)
                {
                    Console.WriteLine("\nPressione qualquer tecla para continuar...");
                    Console.ReadKey();
                }
            }
        }
    }
}
*/

/*
// Importa a biblioteca System, essencial para usar o Console.
using System;

// Namespace para organizar o nosso projeto.
namespace JogoAdivinhacaoNumeros
{
    // Classe principal do programa.
    class Program
    {
        // Ponto de entrada, onde o código começa a ser executado.
        static void Main(string[] args)
        {
            // 1. Definimos o número que o usuário precisa adivinhar.
            const int numeroSecreto = 7;

            // 2. Criamos uma variável para guardar o palpite do usuário.
            //    Inicializamos com 0 (ou qualquer número diferente do secreto).
            int palpite = 0;

            // 3. Exibimos as instruções do jogo.
            Console.WriteLine("--- Jogo de Adivinhar o Número ---");
            Console.WriteLine("Tente adivinhar o número secreto entre 1 e 10.");
            Console.WriteLine("------------------------------------");

            // 4. Início do loop while.
            //    A condição é: "Enquanto o 'palpite' for diferente do 'numeroSecreto'".
            while (palpite != numeroSecreto)
            {
                Console.Write("Digite seu palpite: ");
                // Lê o que o usuário digitou como texto.
                string inputDoUsuario = Console.ReadLine();

                // Tenta converter o texto para um número inteiro.
                // Se conseguir, 'sucesso' será true e o número irá para a variável 'palpite'.
                // Se não conseguir (ex: usuário digitou "abc"), 'sucesso' será false.
                bool sucesso = int.TryParse(inputDoUsuario, out palpite);

                // 5. Verifica se a conversão deu certo.
                if (sucesso)
                {
                    // Se a conversão foi bem-sucedida, verifica se o palpite está correto.
                    if (palpite != numeroSecreto)
                    {
                        Console.WriteLine("Número incorreto. Tente novamente!");
                    }
                }
                else
                {
                    // Se a conversão falhou, avisa o usuário.
                    Console.WriteLine("Entrada inválida. Por favor, digite apenas números.");
                }
            }

            // 6. Esta parte do código só é alcançada quando o loop termina,
            //    ou seja, quando o usuário acerta o número.
            Console.WriteLine("\n------------------------------------");
            Console.WriteLine($"Parabéns! Você acertou! O número secreto era {numeroSecreto}!");
            Console.WriteLine("------------------------------------");

            Console.ReadKey(); // Pausa o programa antes de fechar.
        }
    }
}
*/

/*
//Tabuada com For
// Importa a biblioteca System para usar o Console.

using System;
 
// Namespace para organizar nosso projeto.

namespace TabuadaComFor

{

    // Classe principal do programa.

    class Program

    {

        // Ponto de entrada do programa.

        static void Main(string[] args)

        {

            Console.WriteLine("--- Programa de Tabuada ---");

            Console.Write("Digite um número para ver a sua tabuada: ");

            string input = Console.ReadLine();

            int numeroEscolhido;

            // Usamos TryParse para garantir que o usuário digitou um número válido.

            if (int.TryParse(input, out numeroEscolhido))

            {

                Console.WriteLine($"\n--- Tabuada do {numeroEscolhido} ---");

                // 1. Início do loop for.

                //    - Inicialização: `int i = 1;` -> cria um contador 'i' começando em 1.

                //    - Condição: `i <= 10;` -> o loop continuará ENQUANTO 'i' for menor ou igual a 10.

                //    - Incremento: `i++` -> ao final de cada volta, aumenta o 'i' em 1.

                for (int i = 1; i <= 10; i++)

                {

                    // 2. Dentro do loop, calculamos o resultado.

                    int resultado = numeroEscolhido * i;

                    // 3. Exibimos a linha da tabuada de forma formatada.

                    //    A variável 'i' muda de valor a cada volta (1, 2, 3, ..., 10).

                    Console.WriteLine($"{numeroEscolhido} x {i} = {resultado}");

                }

                Console.WriteLine("--------------------------");

            }

            else

            {

                // Mensagem de erro se a entrada não for um número.

                Console.WriteLine("Entrada inválida. Por favor, execute o programa novamente e digite um número.");

            }

            Console.ReadKey(); // Pausa o programa.

        }

    }

}
*/



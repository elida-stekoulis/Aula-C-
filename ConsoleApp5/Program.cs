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

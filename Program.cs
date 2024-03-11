using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.WriteLine("Bem vindo a sua calculadora. \n Escolha uma opção de operação:                \n 1 - Soma: \n 2 - Subtração: \n 3 - Divisão: \n 4 - Multiplicação: \n 5 - Potência \n 6 - Raiz Quadrada \n 7 - Sair \n ----------");

            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1: Soma(); break;
                case 2: Sub(); break;
                case 3: Divide(); break;
                case 4: Multiply(); break;
                case 5: Pow(); break;
                case 6: Square(); break;
                case 7: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }
        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor:");
            double v1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            double v2 = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            double resultado = v1 + v2;
            Console.WriteLine($"O resultado da soma é {resultado}");

            Console.ReadKey();
            Menu();

        }
        static void Sub()
        {

            Console.Clear();

            Console.WriteLine("Primeiro número:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo número: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 - v2;

            Console.WriteLine($"O resultado da subtração é {resultado}");
            Console.ReadKey();
            Menu();
        }
        static void Divide()
        {
            Console.Clear();

            Console.WriteLine("Primeiro número:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo número: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 / v2;

            Console.WriteLine($"O resultado da divisão é {resultado}");
            Console.ReadKey();
            Menu();
        }
        static void Multiply()
        {
            Console.Clear();

            Console.WriteLine("Primeiro número:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo número: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 * v2;

            Console.WriteLine($"O resultado da multiplicação é {resultado}");
            Console.ReadKey();
            Menu();
        }
        static void Pow()
        {
            Console.Clear();

            Console.WriteLine("Escolha um número");
            double v1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Escolha a potência para o número");
            double v2 = double.Parse(Console.ReadLine());

            double resultado = Math.Pow(v1, v2);

            Console.WriteLine($"O resultado da potenciação é {resultado}");
            Console.ReadKey();
            Menu();
        }
        static void Square()
        {
            Console.Clear();

            Console.WriteLine("Escolha um número");
            double v1 = double.Parse(Console.ReadLine());

            double resultado = Math.Sqrt(v1);

            Console.WriteLine($"O resultado da raiz quadrada de {v1} é {resultado}");
            Console.ReadKey();
            Menu();
        }
    }
}
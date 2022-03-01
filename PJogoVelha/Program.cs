using System;

namespace PJogoVelha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Jogo j = new Jogo();

            int opc = 0;
            while (opc != 2)
            {
                Console.WriteLine("Digite uma opção: ");
                Console.WriteLine("1 - Começar Jogo ");
                Console.WriteLine("2 - Sair do Jogo ");
                opc = Convert.ToInt32(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        j.Inicio();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Saindo");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("DIGITE UMA OPÇÃO VÁLIDA");
                        break;
                }
            }
        }
    }
}

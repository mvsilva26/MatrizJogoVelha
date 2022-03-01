using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJogoVelha
{
    internal class Jogo
    {

        public Player Player1 { get; set; }
        public Player Player2 { get; set; }
        public char[,] Matriz { get; set; }
        public int Jogadas { get; set; }
        public Player VezPlayer { get; set; }



        public void Inicio()
        {
            Matriz = new char[3, 3];
            Jogadas = 1;
            int i = 0;
            int j = 0;
            CriarJogador();
            VezPlayer = Player1;
            do
            {
                ImprimirJogo();
                Console.WriteLine("Jogada {0} / Vez do Player {1} -> {2}", Jogadas, VezPlayer.Nome, VezPlayer.Peca);

                do
                {
                    Console.Write("Digite a linha:");
                    i = Convert.ToInt32(Console.ReadLine());
                } while (i < 0 || i > 3);

                do
                {
                    Console.WriteLine("Digite a coluna: ");
                    j = Convert.ToInt32(Console.ReadLine());
                } while (j < 0 || j > 2);
                if (VerificarPosicaoPreenchida(i, j))
                {
                    do
                    {
                        Console.Clear();
                        ImprimirJogo();
                        Console.WriteLine("Já existe uma peça nessa casa. Selecione outra");
                        Console.WriteLine("Jogadas {0}", Jogadas);
                        Console.WriteLine("Digite a linha: ");
                        i = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite a coluna: ");
                        j = Convert.ToInt32(Console.ReadLine());

                    } while (VerificarPosicaoPreenchida(i, j));

                }
                Jogadas++;
                Matriz[i, j] = VezPlayer.Peca;
                ImprimirJogo();
                VerificaSituação();
                TrocaDeVez();
            } while (Jogadas != 10);

        }

        public bool VerificarPosicaoPreenchida(int i, int j)
        {
            if (Matriz[i, j] == 'X' || Matriz[i, j] == 'O')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ImprimirJogo()
        {
            Console.Clear();
            Console.WriteLine(" -- SITUAÇÃO DO JOGO -- ");

            Console.WriteLine($"\t__{Matriz[0, 0]}__|__{Matriz[0, 1]}__|__{Matriz[0, 2]}__" +
                               $"\n\t__{Matriz[1, 0]}__|__{Matriz[1, 1]}__|__{Matriz[1, 2]}__" +
                               $"\n\t  {Matriz[2, 0]}  |  {Matriz[2, 1]}  |  {Matriz[2, 2]}  \n");
        }

        public void TrocaDeVez()
        {
            VezPlayer = VezPlayer == Player1 ? Player2 : Player1;
        }

        public void CriarJogador()
        {
            Console.Clear();
            Console.WriteLine(" -- CRIAR JOGADORES -- ");
            Console.WriteLine("Digite o nome do Player 1: ");
            string player1 = Console.ReadLine();
            char pecaPlayer1 = 'X';
            Player1 = new Player(player1, pecaPlayer1);

            Console.WriteLine("Digite o nome do Player 2: ");
            string player2 = Console.ReadLine();
            char pecaPlayer2 = 'O';
            Player2 = new Player(player2, pecaPlayer2);
        }

        public void VerificaSituação()
        {
            if (Matriz[0, 0] == 'X' && Matriz[0, 1] == 'X' && Matriz[0, 2] == 'X' ||  Matriz[0, 0] == 'O' && Matriz[0, 1] == 'O' && Matriz[0, 2] == 'O')
            {
                Console.Clear();
                Console.WriteLine("O jogador vencedor é: {0}", VezPlayer.Peca);
                Jogadas = 10;
            }
            else if (Matriz[1, 0] == 'X' && Matriz[1, 1] == 'X' && Matriz[1, 2] == 'X' ||  Matriz[1, 0] == 'O' && Matriz[1, 1] == 'O' && Matriz[1, 2] == 'O')
            {
                Console.Clear();
                Console.WriteLine("O jogador vencedor é: {0}", VezPlayer.Peca);
                Jogadas = 10;
            }
            else if (Matriz[2, 0] == 'X' && Matriz[2, 1] == 'X' && Matriz[2, 2] == 'X' ||  Matriz[2, 0] == 'O' && Matriz[2, 1] == 'O' && Matriz[2, 2] == 'O')
            {
                Console.Clear();
                Console.WriteLine("O jogador vencedor é: {0}", VezPlayer.Peca);
                Jogadas = 10;
            }
            else if (Matriz[0, 0] == 'X' && Matriz[1, 0] == 'X' && Matriz[2, 0] == 'X' ||  Matriz[0, 0] == 'O' && Matriz[1, 0] == 'O' && Matriz[2, 0] == 'O')
            {
                Console.Clear();
                Console.WriteLine("O jogador vencedor é: {0}", VezPlayer.Peca);
                Jogadas = 10;
            }
            else if (Matriz[0, 1] == 'X' && Matriz[1, 1] == 'X' && Matriz[2, 1] == 'X' ||  Matriz[0, 1] == 'O' && Matriz[1, 1] == 'O' && Matriz[2, 1] == 'O')
            {
                Console.Clear();
                Console.WriteLine("O jogador vencedor é: {0}", VezPlayer.Peca);
                Jogadas = 10;
            }
            else if (Matriz[0, 2] == 'X' && Matriz[1, 2] == 'X' && Matriz[2, 2] == 'X' ||  Matriz[0, 2] == 'O' && Matriz[1, 2] == 'O' && Matriz[2, 2] == 'O')
            {
                Console.Clear();
                Console.WriteLine("O jogador vencedor é: {0}", VezPlayer.Peca);
                Jogadas = 10;

            }
            else if (Matriz[0, 0] == 'X' && Matriz[1, 1] == 'X' && Matriz[2, 2] == 'X' ||  Matriz[0, 0] == 'O' && Matriz[1, 1] == 'O' && Matriz[2, 2] == 'O')
            {
                Console.Clear();
                Console.WriteLine("O jogador vencedor é: {0}", VezPlayer.Peca);
                Jogadas = 10;
            }
            else if (Matriz[0, 2] == 'X' && Matriz[1, 1] == 'X' && Matriz[2, 0] == 'X' ||  Matriz[0, 2] == 'O' && Matriz[1, 1] == 'O' && Matriz[2, 0] == 'O')
            {
                Console.Clear();
                Console.WriteLine("O jogador vencedor é: {0}", VezPlayer.Peca);
                Jogadas = 10;
            }
            else if (Jogadas == 10)
            {
                Console.Clear();
                Console.WriteLine(" -- EMPATE -- ");
            }

        }
    }
}

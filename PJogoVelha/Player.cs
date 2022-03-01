using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJogoVelha
{
    internal class Player
    {
        public string Nome { get; set; }
        public char Peca { get; set; }

        public Player(string nome, char peca)
        {
            Nome = nome;
            Peca = peca;
        }

    }
}

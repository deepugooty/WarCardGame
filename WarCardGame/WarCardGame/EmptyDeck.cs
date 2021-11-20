using System;
using System.Collections.Generic;
using System.Text;

namespace WarCardGame
{
    class EmptyDeck
    {
        public void checkDeckEmpty(WarCardGame.Functionalities player1deck, WarCardGame.Functionalities player2deck, int turns_count)
        {
            if (player1deck == null)
            {
                Console.WriteLine("Player2 has won the game with maximum number of cards" +
                    " Total number of rounds played are - {0}\n", turns_count);
            }
            else if(player2deck == null)
            {
                Console.WriteLine("Player1 has won the game with maximum number of cards" +
                    " Total number of rounds played are - {0}\n", turns_count);
            }
        }
    }
}

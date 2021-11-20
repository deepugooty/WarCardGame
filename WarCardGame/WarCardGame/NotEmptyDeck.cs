using System;
using System.Collections.Generic;
using System.Text;

namespace WarCardGame
{
    class NotEmptyDeck
    {
        public void checkDeckNotEmpty(WarCardGame.Functionalities player1deck, WarCardGame.Functionalities player2deck, int turns_count)
        {
            Functionalities fn = new Functionalities();
            while (player1deck != null && player2deck != null)
            {
                Console.ReadLine();

                CardProperties player1 = (CardProperties)player1deck.pull_a_card();
                CardProperties player2 = (CardProperties)player2deck.pull_a_card();
                List<CardProperties> player1threecards = new List<CardProperties>(player1deck.pull_three_cards());
                List<CardProperties> player2threecards = new List<CardProperties>(player2deck.pull_three_cards());
                //CardProperties player1three = (list<CardProperties>)player1deck.pull_three_cards();

                turns_count++;

                Console.WriteLine("Player 1 turn -  {0} {1}.\n", player1.number, player2.shape);
                Console.WriteLine("Player 2 turn - {0} {1}.\n\n", player2.number, player2.shape);

                if ((int)player1.number > (int)player2.number)
                {
                    Console.WriteLine("Since {0} is greater than {1}, Player 1 wins this round and gets the card \n" +
                        "*******************************************************************************", player1.number, player2.number);
                    player1deck.back_into_deck(player1, player2);
                }
                else if ((int)player1.number < (int)player2.number)
                {
                    Console.WriteLine("Since {0} is greater than {1}, Player 2 wins this round and gets the card \n" +
                        "*******************************************************************************", player2.number, player1.number);
                    player2deck.back_into_deck(player1, player2);
                }
                else if ((int)player1.number == (int)player2.number)
                {
                    Console.WriteLine("Since {0} is equal to {1}, another card is drawn\n" +
                        "*******************************************************************************", player1.number, player2.number);
                    player1.number = player1threecards[0].number;
                    player2.number = player2threecards[0].number;
                    if ((int)player1.number > (int)player2.number)
                    {
                        Console.WriteLine("Since {0} is greater than {1}, Player 1 wins this round and gets the card \n" +
                            "*******************************************************************************", player1.number, player2.number);
                        player1deck.back_into_deck(player1, player2);
                    }
                    else if ((int)player1.number < (int)player2.number)
                    {
                        Console.WriteLine("Since {0} is greater than {1}, Player 2 wins this round and gets the card \n" +
                            "*******************************************************************************", player2.number, player1.number);
                        player2deck.back_into_deck(player1, player2);
                    }
                }

                Console.WriteLine("Press 'Enter' to play the next round of the game");
            }
        }
    }
}

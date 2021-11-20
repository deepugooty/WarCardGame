using System;
using System.Collections.Generic;

namespace WarCardGame
{
    public class Functionalities
    {
        public List<CardProperties> card_collection;

        public Functionalities()
        {
            this.card_collection = new List<CardProperties>();
        }

        public void shapenumbercombo()
        {
              for (int n = 1; n < 15; n++)
                {
                    for (int s = 1; s < 5; s++)
                    {
                        CardProperties mc = new CardProperties((ShapeEnum)s, (NumberEnum)n);
                        card_collection.Add(mc);
                    }
                }
        }
        public void shuffle()
        {
            Random random = new Random();

            for (int sh = card_collection.Count - 1; sh > 1; sh--)
            {
                int rand = random.Next(sh);
                CardProperties v = (CardProperties)card_collection[sh];
                card_collection[rand] = card_collection[sh];
                card_collection[sh] = v;

            }
        }
        public CardProperties pull_a_card()
        {
            CardProperties pull = (CardProperties)card_collection[0];
            card_collection.Remove(pull);
            return (pull);
        }

        public List<CardProperties> pull_three_cards()
        {
            List<CardProperties> ls = new List<CardProperties>();
            for(int p = 0; p < 3; p++)
            {
                CardProperties pull = (CardProperties)card_collection[p];
                card_collection.Remove(pull);
                ls.Add(pull);
            }
            return ls;
        }

        public void back_into_deck(CardProperties c1, CardProperties c2)
        {
            card_collection.Add(c1);
            card_collection.Add(c2);
            shuffle();
        }
        public bool isEmpty()
        {
            return (card_collection.Count <= 0);
        }
    }
}

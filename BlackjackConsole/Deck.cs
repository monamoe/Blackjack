using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BlackjackEngine
{
    class Deck
    {
        List<Card> cards = new List<Card>();

        public void Init()
        {
            foreach (Suit s in Enum.GetValues(typeof(Suit))){
                for (int i = 1; i <= 13; i++)
                {
                    Card c = new Card(i, s);
                    cards.Add(c);
                }
            }

            // Shuffle Algorithm
            /*
             * Repeat 1 million times:
             *    1. Generate 2 random vars x and y between 1 and 52
             *    2. Swap cards[x] with cards[y]
             */ 

            //Show();
        }

        public Card GetOneCard()
        {
            // Return the first card from the list
            Card c = cards[0];
            cards.RemoveAt(0);
            return c;
        }

        public void Show()
        {
            foreach(Card c in cards)
            {
                Console.WriteLine(c.GetName());
            }
        }

    }
}

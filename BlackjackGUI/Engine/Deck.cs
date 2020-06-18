using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
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


            Random rand = new Random();
            Card temp;
            for (int i=0; i< 52; i++)
            {
                int v1 = rand.Next()  % 52;
                temp = cards[v1];
                cards[v1] = cards[i];
                cards[i] = temp;
            }


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

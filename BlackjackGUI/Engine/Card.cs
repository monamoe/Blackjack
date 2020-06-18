using System;
using System.Collections.Generic;
using System.Text;

namespace BlackjackEngine
{
    class Card
    {
        public int Rank;   // 1 means Ace, 2 means 2, ...., 10 means 10, 11 means J, 12 means Q, 13 means K
        public Suit Suit;

        public Card(int rank, Suit suit)
        {
            Rank = rank;
            Suit = suit;
        }

        public String GetName()
        {
            return Rank + " of " + Suit;
        }

        public String GetFilename()
        {
            String rankStr = Rank.ToString();
            if (Rank == 1) rankStr = "ace";
            if (Rank == 11) rankStr = "jack";
            if (Rank == 12) rankStr = "queen";
            if (Rank == 13) rankStr = "king";

            String suitStr = Suit.ToString().ToLower();

            return rankStr + "_of_" + suitStr + ".png";
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace BlackjackEngine
{
    class Blackjack
    {
        private Deck deck;
        private List<Card> playerCards = new List<Card>();
        private List<Card> dealerCards = new List<Card>();

        public void Init()
        {
            deck = new Deck();
            deck.Init();
        }

        public Card GetPlayerLastCard()
        {
            if (playerCards.Count < 1)
                return null;
            return playerCards[playerCards.Count - 1];
        }

        public Card GetDealerLastCard()
        {
            if (dealerCards.Count < 1)
                return null;
            return dealerCards[dealerCards.Count - 1];
        }

        public bool Stand()
        {
            // if the dealer busted
            if (IsBusted(dealerCards))
            {
                // player wins
                return true;
            }

            //if the dealer wins
            if(GetDealerSum() > GetPlayerSum())
            {
                return false;
            }
            //if the player wins
            return true;
        }




        internal bool IsPlayerBusted()
        {
            return IsBusted(playerCards);
        }


        //public void Play()
        //{
        //    // Deal initial cards (2 for player, and 2 for dealer)
        //    DealToPlayer();
        //    DealToDealer();
        //    DealToPlayer();
        //    DealToDealer();

        //    Show();

        //    // Handle player's turns
        //    while (true)
        //    {
        //        Console.Write("Type H to hit and S to Stand: ");
        //        ConsoleKeyInfo key = Console.ReadKey();
        //        if (key.Key == ConsoleKey.S)
        //        {
        //            break;
        //        }

        //        DealToPlayer();
        //        Show();

        //        if (IsBusted(playerCards))
        //        {
        //            Console.WriteLine("Busted. Game over!");
        //            Console.WriteLine("Press any key to continue...");
        //            Console.ReadKey();
        //            Environment.Exit(0);
        //        }
        //    }


        //    // Handle the dealer's turn\
        //    //IsBusted(dealerCards);
        //    //GetSum(dealerCards);

        //    // Decide winner

        //}



        private Boolean IsBusted(List<Card> list)
        {
            return GetSum(list) > 21;
        }

        private int GetPlayerSum()
        {
            return GetSum(playerCards);
        }

        private int GetDealerSum()
        {
            return GetSum(dealerCards);
        }

        private int GetSum(List<Card> list)
        {
            int sum = 0;
            foreach(Card c in list)
            {
                sum += GetBlackjackValue(c);
            }
            return sum;
        }

        //private void Show()
        //{
        //    Console.WriteLine();
        //    Console.WriteLine("Player: " + GetPlayerSum());
        //    foreach (Card c in playerCards)
        //    {
        //        Console.WriteLine(c.GetName());
        //    }
        //    Console.WriteLine("Dealer: " + GetDealerSum());
        //    foreach (Card c in dealerCards)
        //    {
        //        Console.WriteLine(c.GetName());
        //    }
        //}

        public void DealToPlayer()
        {
            playerCards.Add(deck.GetOneCard());
        }

        public void DealToDealer()
        {
            dealerCards.Add(deck.GetOneCard());
        }

        public int GetBlackjackValue(Card c)
        {
            if (c.Rank < 10)
            {
                return c.Rank;
            }

            return 10;
        }
    }
}
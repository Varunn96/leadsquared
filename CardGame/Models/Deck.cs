using System;
using System.Linq;
using System.Collections.Generic;

namespace CardGame.Models
{
    class Deck
    {
        // 52 Cards in a deck
        public List<Card> Cards { get; set; }

        public Deck()
        {
            Cards = InitializeDeck();
        }

        /// <summary>
        /// Initializes a deck with 52 cards, 4 suits of 13 cards each
        /// </summary>
        /// <returns>List of 52 cards in a deck</returns>
        private List<Card> InitializeDeck()
        {
            Cards = new List<Card>();

            // Adding Clubs
            Cards.AddRange(new Suit(Constants.Suit.Club).Cards);

            // Adding Diamonds
            Cards.AddRange(new Suit(Constants.Suit.Diamond).Cards);

            // Adding Hearts
            Cards.AddRange(new Suit(Constants.Suit.Heart).Cards);

            // Adding Spades
            Cards.AddRange(new Suit(Constants.Suit.Spade).Cards);

            // Initial shuffle of deck
            ShuffleDeck();

            return Cards;
        }

        /// <summary>
        /// Randomly shuffles the deck
        /// </summary>
        /// <returns>List of 52 cards, randomly shuffled</returns>
        public List<Card> ShuffleDeck()
        {
            Random randomGenerator = new Random();

            int n = Cards.Count;
            while (n > 1)
            {
                n--;
                int k = randomGenerator.Next(n + 1);
                var value = Cards[k];
                Cards[k] = Cards[n];
                Cards[n] = value;
            }
         
            return Cards;
        }

        public Card PlayCard()
        {
            Card drawnCard = null;

            if (Cards.Count > 0)
            {
                drawnCard = Cards.First();
                Cards.RemoveAt(0);
            }

            return drawnCard;
        }
    }
}
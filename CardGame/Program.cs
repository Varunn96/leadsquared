using System;
using CardGame.Models;

namespace CardGame
{
    class DeckOfCards
    {
        static void Main(string[] args)
        {
            DeckOfCards deckOfCards = new DeckOfCards();
            deckOfCards.Play();
        }

        /// <summary>
        /// Creates a new deck, and interatively allows the user to play a card, shuffle existing deck or restart with a new deck
        /// </summary>
        public void Play()
        {
            Deck deck = new Deck();

            string status = "";

            while (true)
            {
                Console.WriteLine("Press 1 to play a card, 2 to shuffle deck, 3 to restart");
                status = Console.ReadLine();
                switch (status)
                {
                    case "1":
                        Card card = deck.PlayCard();
                        if (card == null)
                            Console.WriteLine($"You have no more cards to play! Press 3 to restart");
                        else
                            Console.WriteLine($"You played {card.Rank} of {card.Suit}s");
                        break;
                    case "2":
                        deck.ShuffleDeck();
                        Console.WriteLine("Deck shuffled");
                        break;
                    case "3":
                        deck = new Deck();
                        Console.WriteLine("Deck reset");
                        break;
                    default:
                        Console.WriteLine("Please enter valid input");
                        break;
                }

                Console.WriteLine($"Cards left in hand: {deck.Cards.Count}\n");
            }
        }
    }
}
using System.Collections.Generic;

namespace CardGame.Models
{
    class Suit
    {
        // 13 Cards of a Suit
        public List<Card> Cards { get; set; }

        public Suit(Constants.Suit suit)
        {
            Cards = InitializeSuit(suit);
        }

        /// <summary>
        /// Initializes a suit with 13 cards belonging to given suit
        /// </summary>
        /// <param name="suit">Name of Suit</param>
        /// <returns>List of 13 cards belonging to given suit</returns>
        private List<Card> InitializeSuit(Constants.Suit suit)
        {
            // Adding non-numeric cards (A, J, Q, K)
            Cards = new List<Card>
            {
                new Card(suit, Constants.Card.Ace),
                new Card(suit, Constants.Card.King),
                new Card(suit, Constants.Card.Queen),
                new Card(suit, Constants.Card.Jack)
            };

            // Adding numeric cards (2, 3, 4, 5, 6, 7, 8, 9, 10)
            for (int i = Constants.Card.IntegerLowerLimit; i <= Constants.Card.IntegerUpperLimit; i++)
            {
                Cards.Add(new Card(suit, i.ToString()));
            }

            return Cards;
        }
    }
}
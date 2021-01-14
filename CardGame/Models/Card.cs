namespace CardGame.Models
{
    public class Card
    {
        // Club/Heart/Spade/Diamond
        public Constants.Suit Suit { get; set; }

        // A/1/2/3/4/5/6/7/8/9/10/J/Q/K
        public string Rank { get; set; }

        public Card(Constants.Suit suit, string rank)
        {
            Suit = suit;
            Rank = rank;
        }
    }
}
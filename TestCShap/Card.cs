namespace TestCShap
{
    public class Card
    {
        public readonly Suit suit;
        public readonly Rank rank;

        public Card(Suit newSuit, Rank newRank)
        {
            suit = newSuit;
            rank = newRank;
        }

        private Card()
        {
            
        }

        public override string ToString()
        {
            return "The " + rank + "of"+ suit + "s";
        }

            
    }
}
using System;

namespace TestCShap
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck myDeck = new Deck();
            myDeck.Shuffle();
            Card temCard;
            for (int i = 0; i < 52; i++)
            {
                temCard = myDeck.GetCard(i);
                Console.Write(temCard.ToString());
                if (i != 51)
                {
                    Console.Write(",");
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
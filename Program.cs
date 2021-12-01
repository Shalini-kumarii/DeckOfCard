using System;

namespace DeckOfCard
{
    class Program
    {
        static void Main(string[] args)
        {
           Deck deck = new Deck ();

            Player riker = new Player("Riker");

            deck.Shuffle();

            deck.ReadDeck();

            riker.Draw(deck, riker);
            riker.Draw(deck, riker);
            riker.Draw(deck, riker);
            riker.Draw(deck, riker);
            riker.Draw(deck, riker);

            System.Console.WriteLine(riker.Hand);
            deck.ReadDeck();
        }
    }
}

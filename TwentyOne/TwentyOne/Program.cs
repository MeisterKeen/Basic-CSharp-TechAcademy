using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {

            Game game = new Game();
            game.Dealer = "Keen";
            game.Name = "TwentyOne";

            Deck deck = new Deck(); // instantiating deck object (should have 52 cards in it, per 'Deck' class)
            deck.Shuffle(3);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();

        }
        // Easy way to instantiate an object:
        //Card card = new Card() { Face = "King", Suit = "Spades" };

        //// CREATING A PUBLIC METHOD:
        //// public: accessible anytime from any other program in this namespace
        //// static: "because we don't want to create an object program before calling this"
        //// returning a "Deck" type (can be a string or int or void)
        //// method is named "Shuffle()"
        //// The Deck is referred to as "deck" within the method
        //public static Deck Shuffle(Deck deck, out int timesShuffled, int times = 1)
        //{
        //    timesShuffled = 0;
        //    for (int i = 0; i < times; i++) // how many times do we want to shuffle? User can define "times" to be more that 1.
        //    {
        //        timesShuffled++;
        //        List<Card> TempList = new List<Card>(); // create a temporary (currently empty) list of Cards
        //        Random random = new Random(); // calling a Random() method to generate a random(ish) number

        //        while (deck.Cards.Count > 0) // deck.Cards starts with 52 items, we're handling (removing) them one by one
        //        {
        //            int randomIndex = random.Next(0, deck.Cards.Count); // we generate a random number for randomIndex
        //                                                                // between 0 and the number of cards still in the deck
        //            TempList.Add(deck.Cards[randomIndex]); // then we just add that random card to the next index in TempList.
        //            deck.Cards.RemoveAt(randomIndex); // we finish by removing that same card from that index location in the deck.
        //        }
        //        deck.Cards = TempList; // Now we dump the TempList back into our deck list,
        //    }

        //    return deck;           // and return the deck list of card objects right back to the program.

        //}

        // Deprecated: instead of overloading (defining multiple methods), we added the loop to the original Shuffle().
        //public static Deck Shuffle(Deck deck, int times)
        //{
        //    for (int i = 0; i < times; i++)
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;
        //}

    }
}

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

            Deck deck = new Deck(); // instantiating deck object (should have 52 cards in it, per 'Deck' class)
            deck = Shuffle(deck); // calling our public Shuffle() method from below!

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }

            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();


        }
        // CREATING A PUBLIC METHOD:
        // public: accessible anytime from any other program in this namespace
        // static: "because we don't want to create an object program before calling this"
        // returning a "Deck" type
        // method is named "Shuffle()"
        // The Deck is referred to as "deck" within the method
        public static Deck Shuffle(Deck deck)
        {
            List<Card> TempList = new List<Card>(); // create a temporary (currently empty) list of Cards
            Random random = new Random(); // calling a Random() method to generate a random(ish) number

            while (deck.Cards.Count > 0) // deck.Cards starts with 52 items, we're handling (removing) them one by one
            {
                int randomIndex = random.Next(0, deck.Cards.Count); // we generate a random number for randomIndex
                                                                    // between 0 and the number of cards still in the deck
                TempList.Add(deck.Cards[randomIndex]); // then we just add that random card to the next index in TempList.
                deck.Cards.RemoveAt(randomIndex); // we finish by removing that same card from that index location in the deck.
            }
            deck.Cards = TempList; // Now we dump the TempList back into our deck list,
            return deck;           // and return the deck list of card objects right back to the program.

        }

    }
}

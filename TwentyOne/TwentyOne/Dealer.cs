using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Dealer
    {
        // inheritance is an "is a" relationship, properties are a "has a" relationship.
        // Dealer HAS a name, HAS a deck, and HAS a balance.
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }
        
        // Dealer can deal cards!
        public void Deal(List<Card> Hand) // we pass in an argument: it is a list of Cards, called "Hand"
        {
            Hand.Add(Deck.Cards.First());                                   // Take first (index 0) card off the Deck
            Console.WriteLine(Deck.Cards.First().ToString() + "\n");        // Write to console, just to confirm...
            Deck.Cards.RemoveAt(0);                                         // Remove the card that in now in Hand from the Deck.
        }
    }
}

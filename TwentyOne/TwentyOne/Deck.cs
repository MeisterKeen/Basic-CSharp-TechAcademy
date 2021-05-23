using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Deck
    {
        public Deck()
        {

            Cards = new List<Card>(); // instantiate an empty list of "Cards"

            List<string> Suits = new List<string>() 
            {
                "Clubs", "Hearts", "Diamonds", "Spades" 
            };

            List<string> Faces = new List<string>()
            {
                "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            };

            foreach (string face in Faces)
            {
                foreach (string suit in Suits)
                {
                    Card card = new Card();
                    card.Suit = suit;
                    card.Face = face;
                    Cards.Add(card);
                }
            }

        }
        public List<Card> Cards { get; set; }

        public void Shuffle(int times = 1)
        {
            for (int i = 0; i < times; i++) // how many times do we want to shuffle? User can define "times" to be more that 1.
            {
                List<Card> TempList = new List<Card>(); // create a temporary (currently empty) list of Cards
                Random random = new Random(); // calling a Random() method to generate a random(ish) number

                while (Cards.Count > 0) // deck.Cards starts with 52 items, we're handling (removing) them one by one
                {
                    int randomIndex = random.Next(0, Cards.Count); // we generate a random number for randomIndex
                                                                        // between 0 and the number of cards still in the deck
                    TempList.Add(Cards[randomIndex]); // then we just add that random card to the next index in TempList.
                    Cards.RemoveAt(randomIndex); // we finish by removing that same card from that index location in the deck.
                }
                Cards = TempList; // Now we dump the TempList back into our deck list,
            }
        }
    }
}

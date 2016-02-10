using System;
using System.Collections.Generic;
using System.Text;

namespace CardConcepts
{
    public class Deck
    {
        private List<Card> d;  // the list of cards still in the deck
        private List<Card> discards = new List<Card>(); // random number generator used to select a random card from the deck:
        private Random R = new Random();

        public Deck()
        {
            d = new List<Card>(); // generate all combinations of Suits and Counts:
            foreach (Suit s in Enum.GetValues(typeof(Suit)))
            {
                foreach (Count c in Enum.GetValues(typeof(Count)))
                {
                    d.Add(new Card(c, s));
                }
            }
        }

        // returns a card randomly selected and removed from the deck
        public Card deal()
        {
            if (d.Count > 0)
            {
                int index = R.Next(0, d.Count);
                Card ans = d[index];
                d.RemoveAt(index);
                return ans;
            }
            else
            {
                for (int m = 0; m < discards.Count; m++)
                {
                    int var = R.Next(0, discards.Count);
                    d.Add(discards[m]);
                    discards.RemoveAt(m);
                }
                
                return deal();  //throw new Exception(); }
            }
        }

        public void acceptDiscards(List<Card> w)
        {
            foreach (Card c in w)
            {
                discards.Add(c);
            }
        }
    }
}

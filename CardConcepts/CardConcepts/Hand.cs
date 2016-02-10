using System;
using System.Collections.Generic;
using System.Text;

namespace CardConcepts
{
	public class Hand
	{
        private List<Card> h;  // the cards in the hand

        public Hand() { h = new List<Card>(); }

        // adds Card c to the hand
        public void add(Card c) { h.Add(c); }

        // removes the Card with Suit s and Count c from the hand (if it's there).
        // returns whether or not the card was found and successfully removed
        public bool remove(Count c, Suit s)
        {
            bool ok = false;
            foreach (Card cd in h)
            {
                if (cd.count == c && cd.suit == s)
                {
                    h.Remove(cd); ok = true;
                    break;
                }
            }
            return ok;
        }

        // returns the count of how many cards are in the hand
        public int howManyCards() { return h.Count; }

        // returns the Blackjack score of the hand
        public int BJscore()
        {
            int score = 0;
            foreach (Card c in h)
            {
                score = score + c.BJvalue();
                if (c.count == Count.Ace)
                {
                    if (score <= 21)
                    {
                        score += 10;
                        if (score > 21)
                        {
                            score = score - 10;
                        }
                    }
                        /*    else
                        {
                            score -= 10;
                        } */
                }
            }
            //score = score + c.BJvalue();
            //Console.WriteLine(score);
            return score;
            //Console.WriteLine("method BJscore not implemented"); 
            //return -1;
        }
        public List<Card> surrendCards()
        {
            List<Card> temp = new List<Card>();
            foreach (Card c in h)
            {
                temp.Add(c);
            }
            h = new List<Card>();
            return temp;
        }

        // returns a string that lists the cards in the hahd
        public override string ToString()
        {
            string ans = "";
            foreach (Card c in h)
            {
                ans = ans + c.ToString() + "\n";
            }
            return ans;
        }
	}
}

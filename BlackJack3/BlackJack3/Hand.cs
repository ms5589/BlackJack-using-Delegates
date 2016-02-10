/* Hand.cs
 * Author: Sagar Mehta (CIS 501) (TR: 1:00-2:15)
 * BlackJack3
 */
using System;
using System.Collections.Generic;
using System.Text;
using CardConcepts;

namespace BlackJack3
{
	public class Hand
	{
		List<Card> h= new List<Card>();
        
		public string getData()
		{
			throw new NotImplementedException();
		}

		public void update()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// With this method Players will be able to surrend the card.
		/// </summary>
		/// <returns></returns>
        public List<Card> surrenderCards()
        {
            List<Card> temp = new List<Card>();
            foreach (Card c in h)
            {
                temp.Add(c);
            }
            h = new List<Card>();
            return temp;
        }

		/// <summary>
		/// This method will add cards to the hand.
		/// </summary>
		/// <param name="c"></param>
        public void add(Card c)
        { 
            h.Add(c); 
        }

        /// <summary>
        /// This method will calculate the Score of hand.
        /// </summary>
        /// <returns></returns>
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
                }//throw new NotImplementedException();
            }
            return score;
        }

        /// <summary>
        /// Override ToString method to give the ans.
        /// </summary>
        /// <returns></returns>
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
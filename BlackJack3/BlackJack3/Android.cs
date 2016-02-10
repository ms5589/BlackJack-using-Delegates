/* Android.cs
 * Author: Sagar Mehta (CIS 501) (TR: 1:00-2:15)
 * BlackJack3
 */
using System;
using System.Collections.Generic;
using System.Text;
using CardConcepts;
using System.Threading;

namespace BlackJack3
{
    public class Android
	{
		Hand h;
        private int rounds;
        private int wins;
        private string n;

        /// <summary>
        /// Constructor for Android(Human Player)
        /// </summary>
        /// <param name="name"></param>
		public Android(string name)
		{
            n = name;
            h = new Hand();
            //formAndroid = new HouseForm(h);
            //throw new NotImplementedException();
		}
        
        /// <summary>
        /// Method that will decide if the houseplayer wants more card or not
        /// </summary>
        /// <returns></returns>
		public bool wantsCard()
		{
            Thread.Sleep(556);
            if (h.BJscore() <= 17)
            {
                return true;
            }
            else
            {
                return false;
            } //throw new NotImplementedException();
		}
        
        /// <summary>
        /// Method that will add card to House Player's hand.
        /// </summary>
        /// <param name="c"></param>
		public void getsCard(Card c)
		{
            h.add(c);
		}

        /// <summary>
        /// Method that will return the Hand of House player.
        /// </summary>
        /// <returns></returns>
		public Hand showHand()
		{
            return h;
		}
        
        /// <summary>
        /// Method that will keep track of number of rounds and wins.
        /// </summary>
        /// <param name="result"></param>
        public void outcomeOfRound(Outcome result)
        {
            rounds++;
            if (result == Outcome.Win)
            {
                wins = wins + 1;
            }
        } 
    }
}
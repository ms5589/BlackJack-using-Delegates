/* Human.cs
 * Author: Sagar Mehta (CIS 501) (TR: 1:00-2:15)
 * BlackJack3
 */
using System;
using System.Collections.Generic;
using System.Text;
using CardConcepts;
using System.Windows.Forms;

namespace BlackJack3
{
	public class Human
	{
        Hand h;
        public bool check;
        private int rounds=1;
        private int wins=0;
        public string n;
        
        /// <summary>
        /// Constructor for Human class.
        /// </summary>
        /// <param name="name"></param>
        public Human(string name)
		{
            n = name;
            h = new Hand(); //formHuman = new InputViewForm(ih, h);
		}

        public void wantsCard()
		{
            
		}

        /// <summary>
        /// Method to add card to Human player's hand.
        /// </summary>
        /// <param name="c"></param>
		public void getsCard(Card c)
		{
            
            h.add(c);  //throw new NotImplementedException();
		}

		/// <summary>
		/// Method will return Human Player's hand.
		/// </summary>
		/// <returns></returns>
        public Hand showHand()
		{
            return h; 
		}

        /// <summary>
        ///  Method that will keep track of number of rounds and wins.
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
        
        /// <summary>
        /// Method to keep track of rounds.
        /// </summary>
        /// <returns></returns>
        public int checkRound()
        {
            //rounds++;
            return rounds;
        }
        
        /// <summary>
        /// Method returns an integer and keeps track of wins for Human player. 
        /// </summary>
        /// <returns></returns>
        public int checkWin()
        {
            return wins;
        }
    }
}
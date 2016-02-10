/* Dealer.cs
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
	public class Dealer
	{
		public Deck d;
        public Hand h;
        private List<Observer> obseveres = new List<Observer>();  // Add methods to the list
        Human guestPlayer; 
        bool flag = true;                                         // Flag that will check if the calculations are done or not.                       
        Android housePlayer; 
        int round = 1;                                            // Number of rounds played.
        int win = 0;                                              // Numbers of wins for Human Player.
        
        /// <summary>
        /// Constructor for a Dealer Class(Controller)
        /// </summary>
        /// <param name="h"></param>
        /// <param name="a"></param>
        public Dealer(Human h, Android a)
        {
            this.guestPlayer = h; this.housePlayer = a;
        }
		
        /// <summary>
        /// Method that adds methods to the delegate(list)
        /// </summary>
        /// <param name="x"></param>
        public void register(Observer x)
		{
            obseveres.Add(x); //throw new NotImplementedException();
		}
        
        /// <summary>
        /// Method that will handle the operation for click event, which adds card.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        internal void handle(object sender, EventArgs e)
        {
            if (guestPlayer.showHand().BJscore() == 21)
            {
                flag = false;
                guestPlayer.outcomeOfRound(Outcome.NotWin);
                housePlayer.outcomeOfRound(Outcome.Win);
                housePlayer.showHand();
                MessageBox.Show("BlackJacK! You Win!");
            }
            if (housePlayer.showHand().BJscore() == 21)
            {
                win++;
                flag = false;
                guestPlayer.outcomeOfRound(Outcome.Win);
                housePlayer.outcomeOfRound(Outcome.NotWin);
                MessageBox.Show("BlackJack!!! You  Win!!");
                housePlayer.showHand();
            }
            guestPlayer.getsCard(d.deal());
            foreach (Observer y in obseveres)
            {
                y();
            }   
        }
        
        /// <summary>
        /// Method that will handle the operations for button, Hold
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        internal void handleTwo(object sender, EventArgs e)
        {       
                while (housePlayer.wantsCard())
                {
                    housePlayer.getsCard(d.deal());
                }

                foreach (Observer x in obseveres)
                {
                    x();
                }
                if (flag == true)
                {
                    if (guestPlayer.showHand().BJscore() > 21)
                    {
                        guestPlayer.outcomeOfRound(Outcome.NotWin);
                        housePlayer.outcomeOfRound(Outcome.Win);
                        MessageBox.Show("YOU LOST!");
                        housePlayer.showHand();
                    }
                    else if (guestPlayer.showHand().BJscore() == housePlayer.showHand().BJscore())
                    {
                        guestPlayer.outcomeOfRound(Outcome.NotWin);
                        housePlayer.outcomeOfRound(Outcome.NotWin);
                        MessageBox.Show("Scores are TIED!");
                        housePlayer.showHand();
                    }
                    else if (housePlayer.showHand().BJscore() > 21 && guestPlayer.showHand().BJscore() < 22)
                    {
                        win++;
                        guestPlayer.outcomeOfRound(Outcome.Win);
                        housePlayer.outcomeOfRound(Outcome.NotWin);
                        MessageBox.Show("YOU WIN!!");
                        housePlayer.showHand();
                    }
                    else if (guestPlayer.showHand().BJscore() > housePlayer.showHand().BJscore())
                    {
                        win++;
                        guestPlayer.outcomeOfRound(Outcome.Win);
                        housePlayer.outcomeOfRound(Outcome.NotWin);
                        MessageBox.Show("YOU WIN!");
                        housePlayer.showHand();
                    }
                    else
                    {
                        guestPlayer.outcomeOfRound(Outcome.NotWin);
                        housePlayer.outcomeOfRound(Outcome.Win);
                        MessageBox.Show("YOU LOST!");
                        housePlayer.showHand();
                    }
                }
            }
        
        /// <summary>
        /// Method that will handle the operations for button New Round.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        internal void handleThree(object sender, EventArgs e)
        {
            round++;
            playRound();
        } 
        
        /// <summary>
        /// Method that return an int and keeps track of numbers of win.
        /// </summary>
        /// <returns></returns>
        public int countRound()
        {
            return round++;
        }
        
        /// <summary>
        /// Method that basically plays round for both players.
        /// </summary>
        public void playRound()
         {
             d = new Deck();
             guestPlayer.checkRound();
             if ((housePlayer.showHand().BJscore()) > 0) // Checking if new Round
             {
                 guestPlayer.showHand().surrenderCards();
                 housePlayer.showHand().surrenderCards();
             }
             
                 housePlayer.getsCard(d.deal());
                 guestPlayer.getsCard(d.deal()); guestPlayer.getsCard(d.deal());
                 guestPlayer.showHand().ToString();
                 if (guestPlayer.showHand().BJscore() == 21)
                 {
                     win++;
                     MessageBox.Show("BlackJack!");
                 }
                 foreach (Observer x in obseveres)
                 {
                     x();
                 }
             
                if (housePlayer.showHand().BJscore() == 21) //checking for BlackJack
                {
                     housePlayer.outcomeOfRound(Outcome.Win);
                    MessageBox.Show("HousePlayer holds a BlackJack and Wins!!!");
                } 
          }
        
        /// <summary>
        /// Method that will return an integer and also keep track of number of wins.
        /// </summary>
        /// <param name="w"></param>
        /// <returns></returns>
        public int checkWin(int w)
         {
             this.win = w;
             return w;
         }
    }
}
/* OutputViewForm.cs
 * Author: Sagar Mehta (CIS 501) (TR: 1:00-2:15)
 * BlackJack3
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BlackJack3
{
    public partial class OutputViewForm : Form
    {   
        public Label labelRound = new Label();
        Human h;
        /// <summary>
        /// Constructor for ScoreCard form.
        /// </summary>
        /// <param name="h"></param>
        public OutputViewForm(Human h)
        {
            this.h = h;
            InitializeComponent();
        }
        
        /// <summary>
        /// Method that will show the BlackJack score for Human player in form
        /// </summary>
        public void showScore()
        {
            label1.Text = "Score = " + h.showHand().BJscore()+"\nRound: "+h.checkRound()+"\nWins: "+h.checkWin();
            Refresh();
        }
       
        /// <summary>
        /// Method that will count number of win that human player holds!
        /// </summary>
        /// <param name="w"></param>
        public void printWin(int w)
        {
            labelRound.Text = "Wins: " + w;
        }
    }
}
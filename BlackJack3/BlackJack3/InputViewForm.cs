/* InputViewForm.cs
 * Author: Sagar Mehta (CIS 501) (TR: 1:00-2:15)
 * BlackJack3
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CardConcepts;
using System.Threading;

namespace BlackJack3
{
    public partial class InputViewForm : Form
    {
        Human h;
        InputHandler x; InputHandlerTwo y; InputHandlerThree z;
        Deck d = new Deck();
        
        /// <summary>
        /// Constructor for Inputview form.
        /// </summary>
        /// <param name="add"></param>
        /// <param name="hold"></param>
        /// <param name="restart"></param>
        /// <param name="h"></param>
        public InputViewForm(InputHandler add, InputHandlerTwo hold, InputHandlerThree restart, Human h)
        {
            InitializeComponent();
            x = add;
            y = hold;
            z = restart;
            this.h = h;
            button2.Enabled = false;
        }

        /// <summary>
        /// Eventhandler for New Card button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            buttonHold.Enabled = true;
            x(sender, e);
            if (h.showHand().BJscore() >= 21)
            {
               button1.Enabled = false;
               //buttonHold.Enabled = false;
            }  
        }
        
        /// <summary>
        /// Method will show the cards in form for human player.
        /// </summary>
        public void showCards()
        {
            //labelButton.Text += "Round: \n" + round;
            labelButton.Text = "My Hand: \n" + h.showHand().ToString();
            Refresh();
        }

        /// <summary>
        /// Eventhandler for button New Round.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;
            //if (buttonHold.Enabled == false) { y(sender, e); }
            z(sender, e);
            button1.Enabled = true;
            buttonHold.Enabled = true;
            //Application.Restart();
        }

        /// <summary>
        /// Eventhandler to hold button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonHold_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            buttonHold.Enabled = false;
            button2.Enabled = true;
            y(sender, e);
        }
    }
}
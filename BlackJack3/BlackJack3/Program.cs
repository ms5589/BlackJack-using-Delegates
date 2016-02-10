/* Program.cs
 * Author: Sagar Mehta (CIS 501) (TR: 1:00-2:15)
 * BlackJack3
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CardConcepts;

namespace BlackJack3
{
    static class Program
    {
        public static int round = 0;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            Human humanPlayer = new Human("You");
            Android housePlayer = new Android("House");
            Deck d = new Deck();
            Hand h = new Hand();
            Dealer dlr = new Dealer(humanPlayer, housePlayer);
            
            InputViewForm i = new InputViewForm(dlr.handle,dlr.handleTwo,dlr.handleThree,humanPlayer);  // recall that  c.handle  has type InputHandler
            OutputViewForm o = new OutputViewForm(humanPlayer);
            HouseForm houseForm = new HouseForm(housePlayer);

            o.Show();
            houseForm.Show();
            i.Show();
            
            dlr.register(i.showCards);  // C# requires that you tell an output form to show itself
            dlr.register(o.showScore);
            dlr.register(houseForm.showInfo);
            dlr.playRound();
            Application.Run(i);
        }
    }
}
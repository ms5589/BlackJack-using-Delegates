using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJack3;
using CardConcepts;

namespace UnitTestBJ3
{
    class Program
    {
        
        static void Main(string[] args)
        {
            try
            {
                testHuman();
                testAndroid();
                testDealer();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Test cases aborted due to some error");
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
        static void testAndroid()
        {
            BlackJack3.Deck d = new BlackJack3.Deck();
            Android aroid = new Android("Android");
            Console.WriteLine("Testing Human.cs.....\n");
            aroid.getsCard(d.deal());
            Console.WriteLine("Android's card is: " + aroid.showHand().ToString());
        }
        static void testDealer()
        {
            Human gP = new Human("Human");
            Android hP = new Android("House");
            Dealer dl = new Dealer(gP, hP);
            dl.playRound();
            Console.WriteLine("Testing Dealer.cs.....\n");
        }
        static void testHuman()
        {
            BlackJack3.Deck d = new BlackJack3.Deck();
            Human hm = new Human("Human");
            Console.WriteLine("Testing Human.cs.....\n");
            hm.getsCard(d.deal());
            Console.WriteLine("Human's card is: " + hm.showHand().ToString());
        }
    }
    
}
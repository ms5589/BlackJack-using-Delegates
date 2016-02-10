using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CardConcepts;  // ADD ME and remember to "Add Reference" CardConcepts

namespace UnitTests {
  class Program {

    // executes unit tests of the classes in CardConcepts
    public static void Main() {
      try
      {
          testCard();
          testDeck();
          testHand();

          // insert more test cases here...
      }
      catch (Exception ex)
      {   Console.WriteLine("Test cases aborted due to error");
          Console.WriteLine(ex.Message);
      }
      Console.ReadLine();
    }

    // executes a unit test of class Card
    static void testCard() {
      Console.WriteLine("test card--------");
      Card c1 = new Card(Count.Ace, Suit.Hearts);
      Console.WriteLine("card {0} has value {1}",
                        c1.ToString(), c1.BJvalue());
    }

    static void testDeck() {
        Console.WriteLine("test deck------");
        Deck d1 = new Deck();
        for (int i = 0; i <10; i++) {
            Console.WriteLine("Deck has {0}", d1.deal().ToString()); 
        }
    }

    static void testHand() {
        Console.WriteLine("test hand------");
        Deck d2 = new Deck();
        Hand h1 = new Hand();
        for (int i = 0; i < 5; i++) {
            h1.add(d2.deal());
        }
        Console.WriteLine(h1);
    }
    /* static void testBJ() {
        int score = 0;
        Deck d2 = new Deck();
        Hand h1 = new Hand();
        for (int i = 0; i < 5; i++)
        {
            h1.add(d2.deal());
        }
        foreach(Card c in h1)
        score = score + c.BJvalue();
        Console.WriteLine(score);
        //return score;
    } */
  }
}

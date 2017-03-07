using System;
namespace CardGame {
    class Program {
        static void Main (string [] args) {
            Deck myDeck = new Deck();
            Console.WriteLine( myDeck.ToString());
            myDeck.shuffle();
            Console.WriteLine( myDeck.ToString());
            Console.ReadLine();
        }
    }
}
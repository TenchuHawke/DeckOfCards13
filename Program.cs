using System;
using System.Collections.Generic;
namespace CardGame {
    class Program {
        static void Main (string [] args) {
            Deck myDeck = new Deck();
            System.Console.WriteLine( myDeck.ToString());
            myDeck.shuffle();
            System.Console.WriteLine( myDeck.ToString());
        }
    }
}
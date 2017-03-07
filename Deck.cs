using System;
using System.Collections.Generic;
namespace CardGame {
    public class Deck {
        private List<object> cards = new List<object> ();
        public void shuffle () {
            Random rand = new Random ();
            for (int i = 0; i < cards.Count; i++) {
                object temp = cards[i];
                int newLocation = (rand.Next (0, 51));
                cards[i] = cards[newLocation];
                cards[newLocation] = temp;
            }
        }
        public object deal () {
            int topCardIndex = cards.Count;
            if (topCardIndex == 0) {
                System.Console.WriteLine ("Out of cards");
                return null;
            }
            object topCard = cards[topCardIndex];
            return topCard;
        }
        public void reset () {
            cards.Clear ();
            for (int i = 0; i < 54; i++) {
                cards.Add (new Card (i));
            }
        }
        public override string ToString () {
            string info = "";
            foreach (Card card in cards) {
                info += card + "\n";
            }
            return info;
        }
        public Deck () {
            reset ();
        }
    }
}
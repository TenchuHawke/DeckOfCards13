namespace CardGame {
    public class Card {
        public string stringVal
        // when you get string value it calculates based upon card value, there is no 'set' method.
        {
            get {
                switch (val) {
                    case (1):
                        return "Ace";
                        break;
                    case (2):
                    case (3):
                    case (4):
                    case (5):
                    case (6):
                    case (7):
                    case (8):
                    case (9):
                    case (10):
                        return val.ToString ();
                        break;
                    case (11):
                        return "Jack";
                        break;
                    case (12):
                        return "Queen";
                        break;
                    case (13):
                        return "King";
                        break;
                    default:
                        return "Card definition error.";
                        break;
                }
            }
        }
        // val is used to track the actual number of the card (from 1 to 13). Used in ToString for console writes, and for card calculations. 
        public int val;
        // suit is which suit the card belongs to.  Used in ToString for console writes.
        public string suit;
        // created an override for ToString so it converts the value of a card properly showing it as the X of Y (ace of hearts, etc.)
        public override string ToString () {
            // If card is a joker, only return Joker, not X of Y.
            if (suit == "Joker") {
                return "Joker";
            }
            // Else return X of Y.
            return stringVal + " of " + suit;
        }
        // card constructor.  value is derived from CardNumber (1-52) % 13 +1 giving each card a value from 1-13.  Suit is derived from cardnumber / 13 ()
        public Card (int CardNumber) {
            val = (CardNumber % 13) + 1;
            switch (CardNumber / 13) {
                case 0:
                    suit = "Spades";
                    break;
                case 1:
                    suit = "Diamonds";
                    break;
                case 2:
                    suit = "Clubs";
                    break;
                case 3:
                    suit = "Hearts";
                    break;
                default:
                    suit = "Joker";
                    break;
            }
        }
    }
}
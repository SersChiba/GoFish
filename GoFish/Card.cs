using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFish
{
    public class Card
    {
        public Suits Suit { get; private set; }
        public Values Value { get; private set; }
        public string Name { get { return Value + " of " + Suit; } }
        public Card(Suits suit, Values value)
        {
            Suit = suit;
            Value = value;
        }
        public override string ToString()
        {
            return Name;
        }

        public static bool DoesCardMatch(Card cardToCheck, Suits suit)
        {
            if (cardToCheck.Suit == suit)
                return true;
            else return false;
        }

        public static bool DoesCardMatch(Card cardToCheck, Values value)
        {
            if (cardToCheck.Value == value)
                return true;
            else return false;
        }

        public string GetCardNames()
        {
            return "test";
        }
    }
    public enum Suits
    {
        Spades, Clubs, Diamonds, Hearts,
    }
    public enum Values
    {
        Ace = 1, Two = 2, Three = 3, Four = 4, Five = 5, Six = 6, Seven = 7, Eight = 8, Nine = 9, Ten = 10, Jack = 11, Queen = 12, King = 13,
    }

    class CardComparer_byValue : IComparer<Card>
    {
        public int Compare(Card x, Card y)
        {

            if (x.Value < y.Value)
                return -1;
            if (x.Value > y.Value)
                return 1;
            if (x.Suit < y.Suit)
                return -1;
            if (x.Suit > y.Suit)
                return 1;
            return 0;
        }
    }
    class CardComparer_bySuit : IComparer<Card>
    {
        public int Compare(Card x, Card y)
        {
            if (x.Suit < y.Suit)
                return -1;
            if (x.Suit > y.Suit)
                return 1;
            if (x.Value < y.Value)
                return -1;
            if (x.Value > y.Value)
                return 1;            
            return 0;
        }
    }
}

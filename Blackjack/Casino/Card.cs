using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    //nothing inheriting from Card and don't need to change values of Card once created
    public struct Card //recipe
    {
        //public Card() //constructor creates object at time of class creation
        //{
        //    Suit = "Spades";
        //    Face = "Two";
        //}
        public Suit Suit { get; set; }
        public Face Face { get; set; }

        //when calling Card.ToString() returns {Face} of {Suit}
        public override string ToString()
        {
            return string.Format("{0} of {1}", Face, Suit);
        }
    }

    public enum Suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }

    public enum Face
    {
        Two, 
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
}

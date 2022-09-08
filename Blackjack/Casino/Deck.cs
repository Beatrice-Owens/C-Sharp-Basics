using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class Deck //class
    {
        public Deck() //constructor (always has same name as class; a method called as soon as the class is created
        {
            //must have a list created to hold objects
            Cards = new List<Card>(); //Cards is the Deck property created with all of the possible card objects from Card Class

            //Card props are enum, which have underlying int values (kind of indices) used to iterarate through
            //Cards is list of type Card that has 2 props: Face and Suit
            //first for every i under 13, go through every j under 4 and create a new card each time
            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Card card = new Card();
                    card.Face = (Face)i; //i is currently an int, cast it to type Face (enum) value at that spot
                    card.Suit = (Suit)j; //j is currently an int, cast it to type Suit (enum) value at that spot
                    Cards.Add(card); //add that card to the Cards list
                }
            }

            /* former way of creating card objects before using enum in Card class
            List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" };
            List<string> Faces = new List<string>()
            {
                "Two", "Three", "Four", "Five", "Six", "Seven",
                "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace" 
            };

            foreach (string face in Faces) //take every face element in Faces list and 
            {
                foreach (string suit in Suits) //add every suit to each of those face elements
                {
                    Card card = new Card(); //new object from the Card Class which has 2 properties: Suit & Face
                    //once this loop ends the var card ceases to exists and can be recreated anew during each foreach loop
                    card.Suit = suit;
                    card.Face = face;
                    Cards.Add(card); //new card added to Cards list after Suit and Face assigned
                }
            }
            */

            
        }

        

        //PROPERTIES
        public List<Card> Cards { get; set; } //property of Deck (deck is made up of all possible cards)

        //METHODS
        //method creation - must be part of a class
        //public: available everywhere
        //static: doesn't require an object Program b4 calling; Without static it just operates on the object in which it exists
        //void: doesn't return a value
        //Deck: type of data its returning
        //(Deck deck): takes a parameter of type Deck with var name "deck" when referring to it later
        //out -> parameter -> throws value out to a var that's already defined
        public void Shuffle(int times = 1)
        {
            for (int i = 0; i < times; i++) //cycle through the method i number of "times"
            {
                
                //temporary list in this method to store card from class Card (they have suit & face)
                List<Card> TempList = new List<Card>();
                //new object "random" from class "Random"
                Random random = new Random();

                while (Cards.Count > 0) //as long as there are still elements in Cards object list from class Deck
                {
                    int randomIndex = random.Next(0, Cards.Count); //choose a random index b/w 0 - deck count
                    TempList.Add(Cards[randomIndex]); //add the random card to the TempList
                    Cards.RemoveAt(randomIndex); //then remove that card from the deck so it doesn't repeat
                }
                Cards = TempList; //operating on its own class's objects; also "this.Cards = TempList;"
            }
            
        }
    }
}

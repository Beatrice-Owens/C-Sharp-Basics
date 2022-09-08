using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    //add a <T> after Player -> Player<T>: allows generic type
    public class Player
    {
        //constructor chainging override: takes in name & passes name and default value 100 to 
        //next Player constructor - prevents repeating code 
        public Player(string name) : this(name, 100)
        {
        }
        public Player(string name, int beginningBalance)
        {
            Hand = new List<Card>();
            Balance = beginningBalance;
            Name = name;
        }

        //instan. list so one always exists for Hand property reference 
        private List<Card> _hand = new List<Card>();

        //change list type to <T> allows generic type (List<T> hand ...)
        //if another game that doesn't use cards (ie. roulette, etc.) change list type to T
        public List<Card> Hand { get { return _hand; } set { _hand = value; } }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }
        public Guid Id { get; set; }
        public bool Stay { get; set; } 
        //normally this would be part of a TwentyOnePlayer class that inherits from Player
        //since it is specific to BlackJack
        

        public bool Bet(int amount)
        {
            if (Balance - amount < 0)
            {
                Console.WriteLine("You do not have enough to place a bet that size.");
                return false;
            }
            else
            {
                Balance -= amount;
                return true;
            }
        }

        //type Game operator+ ; takes in Game type game & Player type player; returning a Game
        //overloading operators 
        //type Game not specifically TwentyOneGame means this overload will work on any derived class of the Game class
        public static Game operator+ (Game game, Player player)
        {
            //Players is type list, which must first be instantiated b4 adding to it, so make sure
            game.Players.Add(player); //add to the game-class-property Players that was passed in to operator+
            return game; // return back updated game that was passed in
        }

        public static Game operator- (Game game, Player player)
        {
            game.Players.Remove(player);
            return game;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    //abstract - no instance/object of this class should ever be created
    //NEVER. This is a base class - inherited FROM
    public abstract class Game
    {
        //need to instan. this list in order for other classes to acces the Players property
        //Players will now AT LEAST always = an empty list
        //best way to protect against a null list
        private List<Player> _players = new List<Player>();
        //same for dict
        private Dictionary<Player, int> _bets = new Dictionary<Player, int>();

        //properties (state)
        //players, one game name, one dealer
        //public prop exposes certain way to acces the underlying value (_players list)
        //get is returning something; set the underlying value (whatever the other classes set it as)
        public List<Player> Players { get { return _players; } set { _players = value; } } //always need to make sure this list is instan. (otherwise error) ^^
        public string Name { get; set; }
        //dict. - collection of key/value pairs: key is player, value is int
        //same issue as Players list
        public Dictionary<Player, int> Bets { get { return _bets; } set { _bets = value; } } 

        //methods (behavior)
        //abstract method() = only exist inside abstract class
        //contains NO IMPLEMENTATION
        //any other class inheriting this Game class must implement this Play() method
        //contract b/w base class and inheriting class
        public abstract void Play();

        //virtual allows methods WITH IMPLEMENTATION in a base class to be overridden 
        //display the names of all players, void b/c no return
        public virtual void ListPlayers()
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player.Name);
            }
        }
    }
}

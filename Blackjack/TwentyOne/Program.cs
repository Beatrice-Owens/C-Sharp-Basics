using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using Casino; //shifted non-main files to a custom library for reference
using Casino.TwentyOne;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            const string casinoName = "Grand Hotel and Casino";

            Console.WriteLine("Welcome to the {0}. Let's start by telling me your name.", casinoName);
            string playerName = Console.ReadLine();
            if (playerName.ToLower() == "admin")
            {
                List<ExceptionEntity> Exceptions = ReadExceptions();
                foreach (var exception in Exceptions)
                {
                    Console.Write(exception.Id + " | ");
                    Console.Write(exception.ExceptionType + " | ");
                    Console.Write(exception.ExceptionMessage + " | ");
                    Console.Write(exception.TimeStamp + " | ");
                    Console.WriteLine();
                }
                Console.Read();
                return;
            }
            bool validAnswer = false;
            int bank = 0;
            while (!validAnswer)
            {
                Console.WriteLine("And how much money did you bring today?");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                if (!validAnswer) Console.WriteLine("Please enter digits only, no decimals.");
            }

            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now? Enter \"yes\" or \"no\".", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer =="ya")
            {
                Player player = new Player(playerName, bank);
                player.Id = Guid.NewGuid();
                //log the player.Id at b4 start of game in file @path 
                using (StreamWriter file = new StreamWriter(@"C:\Users\point\Logs\log.txt", true)) 
                {
                    file.WriteLine(player.Id); //write guid
                }
                Game game = new TwentyOneGame();
                game += player; //adding player to the game
                player.isActivelyPlaying = true;

                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    try
                    {
                        game.Play();
                    }
                    catch (FraudException ex)
                    {
                        Console.WriteLine(ex.Message);
                        UpdateDbWithException(ex);
                        Console.ReadLine();
                        return;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error occurred. Please contact your system administrator.");
                        UpdateDbWithException(ex);
                        Console.ReadLine();
                        return;
                    }
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            //else (not yes): 
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.Read();

            /* Intro Examples
            Deck deck = new Deck();
            deck.Shuffle(3);
            //taking the values in ^^deck, shuffling them and reassigning them back to the same deck
            //^^ using the optional param instead of the overload method
            //out param takes value from the method not a return to "deck, but sending it out of deck to timesShuffled
            //or
            //named param
            //deck = Shuffle(deck: deck, times: 1);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
            */
            //deck.Cards = new List<Card>();

            //Card cardOne = new Card();
            //cardOne.Face = "Queen";
            //cardOne.Suit = "Spades";

            //deck.Cards.Add(cardOne);

            //Console.WriteLine(deck.Cards[0].Face + " of " + deck.Cards[0].Suit);
            //Console.ReadLine();

            /* STRUCT
            //create new card1 obj; set card2 = card1; card2 now references the memory space allocated to 
            //card1. Changing the value of card1 changes that of card2, but changing card2 also changes
            //card1. WriteLine will display "King" because classes in c# are reference types
            //change Card from class to struct and WriteLine prints Eight
            Card card1 = new Card();
            Card card2 = card1;
            card1.Face = Face.Eight;
            card2.Face = Face.King;

            Console.WriteLine(card1.Face);
            */

            /* Lambda functions 
            int counter = 0;
            foreach (Card card in deck.Cards)
            {
                if (card.Face == Face.Ace)
                {
                    counter++;
                }
            }
            //^^ converted to lambda function
            //using Lambda functions
            //lambda method Count on list deck.Cards doesn't require anything in (), but 
            //further specs can be added
            //"x" can have any name & represents each item in the list
            //=> means map following expression to the x item (each item is list deck.Cards
            //so: foreach x in deck.Cards count how many have the Face property Ace
            int count = deck.Cards.Count(x => x.Face == Face.Ace);

            //take the list of cards and find where the Face is King and map to the list
            List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList();

            List<int> numberList = new List<int>() { 1, 2, 3, 535, 342, 23 };

            //lambda method for finding the sum of all items in integer lists with empty ()
            //or add some arithmetic: for each x item, add 5 to it, them take the sum of those values
            int sum = numberList.Sum(x => x + 5);
            int max = numberList.Max();
            int min = numberList.Min();
            //combine different functions: where makes a list of items over 20 that will be added together
            int whereSum = numberList.Where(x => x > 20).Sum();

            Console.WriteLine(counter);
            */
        }

        private static void UpdateDbWithException(Exception ex) //exception also calls FraudException (polymorphism)
        {
            //connection string - r-click DB name + properties + scroll down
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TwentyOneGame;
                                        Integrated Security=True;Connect Timeout=30;Encrypt=False;
                                        TrustServerCertificate=False;ApplicationIntent=ReadWrite;
                                        MultiSubnetFailover=False";
            //SQL query - put in table Exceptoins (column names), with values (parameterized queries, aka placeholders)
            //ado.net will map in parameter values & protects SQL injection
            string queryString = @"INSERT INTO Exceptions (ExceptionType, ExceptionMessage, TimeStamp) VALUES 
                                    (@ExceptionType, @ExceptionMessage, @TimeStamp)";

            //using = way of controlling unused code; different from "using" at top of cs file
            //managing and controlling memory when dealing w/external resources
            //open SQL connection to external DB
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //creating new command while passing queryString & connection
                SqlCommand command = new SqlCommand(queryString, connection);
                //add data type of parameters; naming dt protects agains sql injectino
                command.Parameters.Add("@ExceptionType", SqlDbType.VarChar);
                command.Parameters.Add("@ExceptionMessage", SqlDbType.VarChar);
                command.Parameters.Add("@TimeStamp", SqlDbType.DateTime);

                //add values to specified parameters; GetType() needs converted to string
                command.Parameters["@ExceptionType"].Value = ex.GetType().ToString();
                command.Parameters["@ExceptionMessage"].Value = ex.Message; //already returns a str
                command.Parameters["@TimeStamp"].Value = DateTime.Now;

                //open connection
                connection.Open();
                //query would be a select statement, eg. querying the DB;
                //this is an INSERT statement, so non-query
                command.ExecuteNonQuery();
                //close connection
                connection.Close();
            }
        }
        //method to create a list of type ExceptionEntity
        private static List<ExceptionEntity> ReadExceptions()
        {
            //many times the connectionString will actually be located in the configuration file - easier to change
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TwentyOneGame;
                                        Integrated Security=True;Connect Timeout=30;Encrypt=False;
                                        TrustServerCertificate=False;ApplicationIntent=ReadWrite;
                                        MultiSubnetFailover=False";
            //select these values from these columns
            string queryString = @"Select Id, ExceptionType, ExceptionMessage, TimeStamp From Exceptions";
            //create empty list of ExceptionEntity typed Exceptions
            List<ExceptionEntity> Exceptions = new List<ExceptionEntity>();
            //using statement so everything is closed out after last bracket
            //new sqlconnection obj
            //curly bracket indicates everything that will happen while the sql connection is connected (open)
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //new sqlcommand obj; passing queryString, connection; not a parameterized query (eg. where Id > @number which could be passed in)
                SqlCommand command = new SqlCommand(queryString, connection);
                //open connection
                connection.Open();
                //create sqldatareader obj that is result of executereader method on command obj; just reading
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read()) //while reader is open: loop through each record we're getting back 
                {
                    //for each record we get back, create a new ExceptionEntity obj
                    //then map wehat we get back to our obj, which can be painstaking and tedious with larger tables
                    ExceptionEntity exception = new ExceptionEntity();
                    //sql reader object -> [id] field; also, getting sql, so must convert to approp. datatype 
                    //& assign to exception obj prop
                    //using ado.net vs can't use intellisense to ensure column names aren't incorrect, doublecheck 
                    exception.Id = Convert.ToInt32(reader["Id"]);
                    exception.ExceptionType = reader["ExceptionType"].ToString();
                    exception.ExceptionMessage = reader["ExceptionMessage"].ToString();
                    exception.TimeStamp = Convert.ToDateTime(reader["TimeStamp"]);
                    //once filled up obj properties, must assign to the list Exceptions since exception obj is local
                    Exceptions.Add(exception);
                }
                connection.Close();
            }
            //returns list of ExceptionEntities to list obj Exceptions
            return Exceptions;
        }


        /*
        //assigning var an enum value
        DaysOfTheWeek day = DaysOfTheWeek.Friday;
        //example of enum -> constants
        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        */

        /*
        //using the overloaded operators from Player class
        Game game = new TwentyOneGame();
        game.Players = new List<Player>();
        Player player = new Player();
        player.Name = "Jesse";
        //game = game + player; //b/c of operator+ -> makes it easy to add to Player class/property of Game 
        game += player; //shorthand for ^^ (game + player)
        //game = game - player; //b/c of operator- -> remove player from Player list property of Game
        game -= player;
        */

        /*
        //inst. game object from TwentyOneGame; Adding player names as list to Players prop of game obj
        //then using virtual ListPlayers() method
        TwentyOneGame game = new TwentyOneGame();
        game.Players = new List<string>() { "Jesse", "Bill", "Bob" };
        game.ListPlayers();
        Console.ReadLine();
        */

        /* Example on polymorphism (before abstraction of Game
        TwentyOneGame game = new TwentyOneGame(); //inst. game object from class
        game.Players = new List<string>() { "Jesse", "Bill", "Joe" }; //example creation of class object players property
        game.ListPlayers(); //method from superclass Game available to TwentyOneGames class since inheritance
        game.Play(); //only available to TwentyOneGame class not Game class
        Console.ReadLine();
        */

        //method creation - must be part of a class
        //public: available everywhere
        //static: doesn't require an object Program b4 calling
        //Deck: type of data its returning
        //(Deck deck): takes a parameter of type Deck with var name "deck" when referring to it later
        //out -> parameter -> throws value out to a var that's already defined
        /* This is too much code and overly complicated. Instead place this method in the Decks class 
         * which contains the only information that the Shuffle() method needs to interact with
        public static Deck Shuffle(Deck deck, out int timesShuffled, int times = 1)
        {
            timesShuffled = 0;
            for (int i = 0; i < times; i++) //cycle through the method i number of "times"
            {
                //increment timesShuffled to keep track of how many times the method cycles
                timesShuffled++;
                //temporary list in this method to store card from class Card (they have suit & face)
                List<Card> TempList = new List<Card>();
                //new object "random" from class "Random"
                Random random = new Random();

                while (deck.Cards.Count > 0) //as long as there are still elements in Cards object list from class Deck
                {
                    int randomIndex = random.Next(0, deck.Cards.Count); //choose a random index b/w 0 - deck count
                    TempList.Add(deck.Cards[randomIndex]); //add the random card to the TempList
                    deck.Cards.RemoveAt(randomIndex); //then remove that card from the deck so it doesn't repeat
                }
                deck.Cards = TempList;
            }
            return deck;
        }
        */

        //instead of adding this second method, just add in the times param
        //public static Deck Shuffle(Deck deck, int times)
        //{
        //    for (int i = 0; i < times; i++)
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;
        //}
    }
}

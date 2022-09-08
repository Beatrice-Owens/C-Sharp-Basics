using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Casino.Interfaces;

namespace Casino.TwentyOne 
{
    //class TwentyOneGame inherits the class Game b/c TwentyOneGame IS a type of Game
    public class TwentyOneGame : Game, IWalkAway
    {
        public TwentyOneDealer Dealer { get; set; }

        //"override" to implement Play() abstract method from Game class
        //MUST be implemented b/c of contract with abstract Game Class
        public override void Play()
        {
            Dealer = new TwentyOneDealer();
            foreach (Player player in Players)
            {
                player.Hand = new List<Card>();
                player.Stay = false;
            }
            //instan.
            Dealer.Hand = new List<Card>();
            Dealer.Stay = false;
            Dealer.Deck = new Deck();
            Dealer.Deck.Shuffle();

            foreach (Player player in Players)
            {
                //checking to make sure the user input for bet is acceptable type
                bool validAnswer = false;
                int bet = 0;
                while (!validAnswer)
                {
                    Console.WriteLine("Place your bet!");
                    validAnswer = int.TryParse(Console.ReadLine(), out bet);
                    if (!validAnswer) Console.WriteLine("Please enter digits only, no decimals.");
                }
                //prevent negative bets
                if (bet < 0)
                {
                    throw new FraudException("Security! Kick this person out.");
                }

                bool successfullyBet = player.Bet(bet);
                if (!successfullyBet)
                {
                    return; //in void method; so return just ends the method & goes back to while loop in Program.cs
                }
                Bets[player] = bet; //player is key & value is set to bet
            }
            //give everyone a card and then one more
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Dealing...");
                foreach (Player player in Players)
                {
                    Console.Write("{0}: ", player.Name);
                    Dealer.Deal(player.Hand);
                    if (i == 1) //when the second card is dealt to a player: check for blackjack
                    {
                        //bool value = method from rules with passed arg Hand
                        bool blackJack = TwentyOneRules.CheckForBlackJack(player.Hand);
                        if (blackJack) //player instantly wins and get credited
                        {
                            Console.WriteLine("Blackjack! {0} wins {1}", player.Name, Bets[player]);
                            //crediting player's winnings to their balance (blackjack returns 1.5x bet placed on win)
                            player.Balance += Convert.ToInt32((Bets[player] * 1.5) + Bets[player]);
                            //if there were more players, then remove from Bets table to prevent further payout in a single round
                            //Bets.Remove(player);
                            return; //just end round; there's only 1 player besides dealer

                        }
                    }
                }
                Console.Write("Dealer: ");
                Dealer.Deal(Dealer.Hand);
                if (i == 1)
                {
                    //check dealer for blackjack
                    bool blackJack = TwentyOneRules.CheckForBlackJack(Dealer.Hand);
                    if (blackJack)
                    {
                        Console.WriteLine("Dealer has BlackJack! Everyone loses!");
                        foreach (KeyValuePair<Player, int> entry in Bets)
                        {
                            Dealer.Balance += entry.Value;
                        }
                        return;
                    }
                }
            }
            foreach (Player player in Players)
            {
                while (!player.Stay)
                {
                    Console.WriteLine("Your cards are: ");
                    foreach (Card card in player.Hand) //showing the player their hand
                    {
                        Console.Write("{0} ", card.ToString());
                    }
                    Console.WriteLine("\n\nHit or stay?");
                    string answer = Console.ReadLine().ToLower();
                    //if stay then assign player propery Stay = true
                    //if hit then deal that player another card
                    if (answer == "stay")
                    {
                        player.Stay = true;
                        break;
                    }
                    else if (answer == "hit")
                    {
                        Dealer.Deal(player.Hand); //passing in the hand to receive a card
                    }
                    //check for busted
                    bool busted = TwentyOneRules.IsBusted(player.Hand);
                    if (busted)
                    {
                        //add the player's bet to the dealer's balance
                        Dealer.Balance += Bets[player];
                        Console.WriteLine("{0} busted! You lose your bet of {1}. Your balance is now {2}.", player.Name, Bets[player], player.Balance);
                        Console.WriteLine("Do you want to play again?");
                        answer = Console.ReadLine().ToLower();
                        //isActivelyPlaying must == true for the game.Play() to continue
                        if (answer == "yes" || answer == "yeah")
                        {
                            player.isActivelyPlaying = true;
                            return; //ends void function
                        }
                        else
                        {
                            player.isActivelyPlaying = false;
                            return;
                        }
                    }

                }
            }
            //does dealer bust & does dealer stay
            Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);
            Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
            //while both are false: deal to dealer hand, check again for bust & if dealer stays
            while (!Dealer.Stay && !Dealer.isBusted)
            {
                Console.WriteLine("Dealer is hitting...");
                Dealer.Deal(Dealer.Hand);
                Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);
                Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
            }
            //dealer stays
            if (Dealer.Stay)
            {
                Console.WriteLine("Dealer is staying.");
            }
            //dealer busts
            if (Dealer.isBusted)
            {
                Console.WriteLine("Dealer busted!");
                foreach (KeyValuePair<Player, int> entry in Bets)
                {
                    //redistribution of wealth
                    Console.WriteLine("{0} won {1}!", entry.Key.Name, entry.Value);
                    //lambda() in list Players, where the name of the item == key.name in entry list Bets, add the value from entry * 2 to balance
                    //.Where produces a list, so use .First to grab that player and their balance then arithmetic 
                    Players.Where(x => x.Name == entry.Key.Name).First().Balance += (entry.Value * 2);
                    Dealer.Balance -= entry.Value; //dealer loses money
                }
                return; //ends the round
            }
            //dealer & player stay and no one busts: neeed to compare player's hand to dealer's
            //three possibilities -> player's hand is >; dealer's hand is >; or dealer's hand == player's hand
            foreach (Player player in Players)
            {
                bool? playerWon = TwentyOneRules.CompareHands(player.Hand, Dealer.Hand);
                if (playerWon == null)
                {
                    Console.WriteLine("Push! No one wins.");
                    player.Balance += Bets[player]; //crediting the player's bet back to their working balance
                    //don't need to remove it from the Bets table since this table is reset before each round
                    //but if it did need to be removed, it would be like this:
                    //Bets.Remove(player);
                }
                else if (playerWon == true)
                {
                    Console.WriteLine("{0} won {1}!", player.Name, Bets[player]);
                    player.Balance += (Bets[player] * 2); // player credited 2x amount wagered
                    Dealer.Balance -= Bets[player];
                }
                else
                {
                    Console.WriteLine("Dealer wins {0}!", Bets[player]);
                    Dealer.Balance += Bets[player];
                }
                //still in for loop to ask each player if they want to continue playing
                Console.WriteLine("Play again?");
                string answer = Console.ReadLine().ToLower();
                if (answer == "yes" || answer == "yeah")
                {
                    player.isActivelyPlaying = true;
                }
                else
                {
                    player.isActivelyPlaying = false;
                }
            }
            
        }

        //override virtual method from base class
        //virtual method has implementation (unlike abstract)
        public override void ListPlayers()
        {
            Console.WriteLine("21 Players: ");
            base.ListPlayers(); //same as content of ListPlayers() in Game class
        }

        //method that must be included b/c of inherited IWalkAway interface
        //must have same data type as that of original method in base interface
        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }
    }
}

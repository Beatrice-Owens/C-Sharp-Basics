using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Casino
{
    public class Dealer
    {
        public string Name { get; set; }
        //deck is a property rather than Dealer inheriting from Deck b/c Dealer IS NOT a type of deck
        //the Dealer HAS/POSSESSES a deck object
        public Deck Deck { get; set; } 
        public int Balance { get; set; }

        //Deal method; must take in existing Hands
        public void Deal(List<Card> Hand)
        {
            //add the first card in the deck list (which is composed of cards - a property of Deck)
            //to the Hand that was passed in to the method
            Hand.Add(Deck.Cards.First()); //built in method for dealing with lists
            string card = string.Format(Deck.Cards.First().ToString() + "\n"); //for logging purposes
            Console.WriteLine(card); //writing the result of the .Add() to console
            using (StreamWriter file = new StreamWriter(@"C:\Users\point\Logs\log.txt", true)) //true (i do want to append)
            {
                file.WriteLine(DateTime.Now); //write time when log entry is added
                file.WriteLine(card); //write card to the path listed in StreamWriter
            } //once this brace is hit, this is cleaned out by the memory manager to stop constant mem usage
            Deck.Cards.RemoveAt(0); //remove the card in deck list at index 0 (the .First() just added to hand

        }
    }
}

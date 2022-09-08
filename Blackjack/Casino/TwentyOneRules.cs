using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.TwentyOne 
{
    public class TwentyOneRules
    {
        //static: don't have to create an object for twentyonerules b4 use of dictionary
        //have to assign each face a number value for 21 
        //private naming conventions: always add underscore _ b4 name = _privateName
        //can't use enum b/c when assigning the same value to multiple entries, a conflict will occur
        private static Dictionary<Face, int> _cardValues = new Dictionary<Face, int>()
        {
            [Face.Two] = 2,
            [Face.Three] = 3,
            [Face.Four] = 4,
            [Face.Five] = 5,
            [Face.Six] = 6,
            [Face.Seven] = 7,
            [Face.Eight] = 8,
            [Face.Nine] = 9,
            [Face.Ten] = 10,
            [Face.Jack] = 10,
            [Face.Queen] = 10,
            [Face.King] = 10,
            [Face.Ace] = 1 //ace can have value of 1 or 11 depending on player choice; will add this option later using logic
        };
        //int array
        private static int[] GetAllPossibleHandValues(List<Card> Hand)
        {
            int aceCount = Hand.Count(x => x.Face == Face.Ace); //how many aces are in the hand
            int[] result = new int[aceCount + 1]; //result array's element = adds 1 to amount of aces: if aces, num > 1; no aces == 1
            int value = Hand.Sum(x => _cardValues[x.Face]); //take the sum of each x item in _cardValues based on its face value
            //value is lowest possible value ~ all the aces = 1
            result[0] = value; //assign value to first entry in result array
            //don't need {} if return is only one line; 
            //only aces have >1 value, so no need for more logic if no aces are involved
            if (result.Length == 1) return result;
            //no need for else statment since all other possibilities lead to this outcome and must use this code
            //i starts at 1 since [0] was used to assign value var earlier (step 351)
            //add elements to array starting at index i(1) 
            for (int i = 1; i < result.Length; i++)
            {
                value += (i * 10);
                result[i] = value;
            }
            return result;
        }


        //method to check for 21 value; passing in card type list called Hand
        public static bool CheckForBlackJack(List<Card> Hand)
        {
            //create int array that = previous int array
            //find max value among those in list
            //if that value = 21, return true, otherwise false
            int[] possibleValues = GetAllPossibleHandValues(Hand);
            int value = possibleValues.Max();
            if (value == 21) return true;
            else return false;
        }

        //checks if the player or dealer goes over 21
        //because aces can be 1 or 11, must check the min value in GAPHV()
        //true if busts; false if safe
        public static bool IsBusted(List<Card> Hand)
        {
            int value = GetAllPossibleHandValues(Hand).Min();
            if (value > 21) return true;
            else return false;
        }

        //if the dealer's hand value is > 16 and < 22, the dealer must stay
        public static bool ShouldDealerStay(List<Card> Hand)
        {
            //new int array to hold dealer's possible total hand value
            int[] possibleHandValues = GetAllPossibleHandValues(Hand);
            foreach (int value in possibleHandValues)
            {
                if (value > 16 && value < 22)
                {
                    return true;
                }
            }
            return false;
        }

        //create a bool output capable of 3, not 2, outcomes (incuding null)
        public static bool? CompareHands(List<Card> PlayerHand, List<Card> DealerHand)
        {
            //first - array containing all possible values of player hand then dealer hand
            int[] playerResults = GetAllPossibleHandValues(PlayerHand);
            int[] dealerResults = GetAllPossibleHandValues(DealerHand);

            //need to find the highest value that is < 21 for each array then compare
            //find the int value contained in the array^^ where item x in list is < 22
            //once we have all those values, get the highest one and assign that to the var
            int playerScore = playerResults.Where(x => x < 22).Max();
            int dealerScore = dealerResults.Where(x => x < 22).Max();

            if (playerScore > dealerScore) return true;
            else if (playerScore < dealerScore) return false;
            else return null;
        }
    }
}

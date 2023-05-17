using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    // Methods/Rules for BlackJack
    public class TwentyOneRules
    {
        // Create a dictionary  --  beware the Ace, need to add logic to it later
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
            [Face.Ace] = 1
        };

        private static int[] GetAllPossibleHandValues(List<Card> Hand)
        {
            // Method will return integer array of ALL the possible values  -- specifically dealing with the 2 possible values of the Ace in BJ
            int aceCount = Hand.Count(x => x.Face == Face.Ace);
            int[] result = new int[aceCount + 1];
            int value = Hand.Sum(x => _cardValues[x.Face]);
            result[0] = value;
            if (result.Length == 1)
            {
                return result;
            }
            for (int i = 1; i < result.Length; i++)
            {
                value += (i * 10);
                result[i] = value;
            }
            return result;
        }

        // Method checks for BJ which = 21
        public static bool CheckForBlackJack(List<Card> Hand)
        {
            int[] possibleValues = GetAllPossibleHandValues(Hand);
            // oops this code wasn't placed in a foreach loop! updated/fixed!
            //int value = possibleValues.Max();
            //if (value == 21) return true;
            //else return false;
            foreach (int x in possibleValues)
            {
                if (x == 21) return true;
            }
            return false;
        }

        // Method checks for a player Bust
        public static bool IsBusted(List<Card> Hand)
        {
            int value = GetAllPossibleHandValues(Hand).Min();
            if (value > 21) return true;
            else return false;
        }

        // Method checks for a dealer Bust -- i.e. does the dealer have any possible card values greater than 16 and less than 22, if so then they Stay
        public static bool ShouldDealerStay(List<Card> Hand)
        {
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

        // Method to return a 'Nullable boolean'
        public static bool? CompareHands(List<Card> PlayerHand, List<Card> DealerHand)
        {
            int[] playerResults = GetAllPossibleHandValues(PlayerHand);
            int[] dealerResults = GetAllPossibleHandValues(DealerHand);
            // I found an error with the below line and fixed it with a LINQ extension method ' .DefaultIfEmpty(0) '
            // I then discovered I did a silly and when I fixed the logic in the 'CheckForBlackJack' method I was then able to take the extension method out
            //int playerScore = playerResults.Where(x => x < 22).DefaultIfEmpty(0).Max();
            int playerScore = playerResults.Where(x => x < 22).Max();
            int dealerScore = dealerResults.Where(x => x < 22).Max();

            if (playerScore > dealerScore)
            {
                return true;
            }
            else if (playerScore < dealerScore)
            {
                return false;
            }
            else
            {
                return null;
            }
        }
    }
}
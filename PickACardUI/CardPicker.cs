using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickACardUI
{
    class CardPicker
    {   // Static field "Random()" used to generate random numbers.
        static Random random = new Random();
        public static string[] PickSomeCards(int numberOfCards)
        {
            string[] pickedCards = new string[numberOfCards];
            for (int i = 0; i < numberOfCards; i++)
            {
                pickedCards[i] = RandomValue() + " of " + RandomSuit();
            }
            return pickedCards;
        }

        private static string RandomSuit()
        {
            // Get a random number from 1 to 4.
            int value = random.Next(1, 5);
            // If it's 1, return the string Spades.
            if (value == 1) return "Spades";
            // if it's 2, return the string Hearts.
            if (value == 2) return "Hearts";
            // if it's 3, return the string Clubs.
            if (value == 3) return "Clubs";
            // If we haven't returned yet, return the string Diamonds.
            return "Diamonds";
        }

        private static string RandomValue()
        {
            // Get a random number from 1 to 14.
            int value = random.Next(1, 14);
            // If it's 1, return the string Ace.
            if (value == 1) return "Ace";
            // If it's 11, return the string Jack.
            if (value == 11) return "Jack";
            // If it's 12, return the string Queen.
            if (value == 12) return "Queen";
            // If it's 13, return the string King.
            if (value == 13) return "King";
            // Value is of int type so we need to convert to a string.
            return value.ToString();
        }
    }
}

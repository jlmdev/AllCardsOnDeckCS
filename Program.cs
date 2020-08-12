using System;
using System.Collections.Generic;
using System.Linq;

namespace AllCardsOnDeckCS
{
    class Program
    {
        static void Main(string[] args)
        {
            // AllCardsOnDeckCS

            // Create Deck List of 52 Cards
            var deck = new List<string>();

            // Assign Suit and Rank to cards
            // Define suits and ranks with arrays
            var suit = new string[] { "Clubs", "Diamonds", "Hearts", "Spades" };
            var rank = new string[] { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };



            // loops to assign card values

            for (var suitIndex = 0; suitIndex < suit.Length; suitIndex++)
            {
                for (var rankIndex = 0; rankIndex < rank.Length; rankIndex++)
                {
                    var cardSuit = suit[suitIndex];
                    var cardRank = rank[rankIndex];
                    deck.Add($"{cardRank} of {cardSuit}");
                }
            }

            // Shuffling Algorithm

            var numberOfCards = deck.Count();
            var randomNumberGenerator = new Random();

            for (var rightIndex = numberOfCards - 1; rightIndex > 0; rightIndex--)
            {
                var leftIndex = randomNumberGenerator.Next(rightIndex - 1);
                var leftCard = deck[rightIndex];
                var rightCard = deck[leftIndex];
                deck[rightIndex] = rightCard;
                deck[leftIndex] = leftCard;
            }

            // Display the top two cards
            var topCard = deck[0];
            var secondCard = deck[1];
            Console.WriteLine($"The top card is {topCard}.");
            Console.WriteLine($"The second card is {secondCard}.");

        }
    }
}

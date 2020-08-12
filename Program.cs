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

            // Determine the number of players

            Console.WriteLine("How many players? (1 or 2)");
            int numberOfPlayers = Convert.ToInt32(Console.ReadLine());
            var playerHand = new List<string>();
            var playerHand2 = new List<string>();
            switch (numberOfPlayers)
            {
                case 1:
                    // deal cards
                    playerHand.Add(deck[0]);
                    playerHand.Add(deck[1]);

                    // remove dealt cards from deck
                    deck.RemoveAt(0);
                    deck.RemoveAt(0);

                    // display playerHand contents
                    Console.WriteLine("Player Hand:");
                    foreach (var card in playerHand)
                    {
                        Console.WriteLine(card);
                    }
                    break;
                case 2:
                    // deal cards to both players
                    // deal to playerHand
                    playerHand.Add(deck[0]);
                    playerHand.Add(deck[1]);

                    // remove dealt cards from deck
                    deck.RemoveAt(0);
                    deck.RemoveAt(0);

                    // display playerHand contents
                    Console.WriteLine("Player 1 Hand:");
                    foreach (var card in playerHand)
                    {
                        Console.WriteLine(card);
                    }
                    // deal to playerHand2
                    playerHand2.Add(deck[0]);
                    playerHand2.Add(deck[1]);

                    // remove dealt cards from deck
                    deck.RemoveAt(0);
                    deck.RemoveAt(0);

                    // display playerHand contents
                    Console.WriteLine("Player 2 Hand:");
                    foreach (var card in playerHand2)
                    {
                        Console.WriteLine(card);
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice. 1 or 2 players only, please.");
                    break;
            }

        }
    }
}

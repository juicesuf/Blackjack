using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blackjack.Lib;

namespace Blackjack.UI
{
    class Programm
    {
        static void Main(string[] args)
        {
            CardStack cardStack = new CardStack();
            Hand playerHand = new Hand();
            Hand dealerHand = new Hand();

            playerHand.AddCard(cardStack.DrawCard());
            playerHand.AddCard(cardStack.DrawCard());
            dealerHand.AddCard(cardStack.DrawCard());
            dealerHand.AddCard(cardStack.DrawCard());

            Console.WriteLine("=== Blackjack ===\n");

            while (true)
            {
                int playerValue = playerHand.CalculateValue();
                Console.WriteLine($"Deine Hand: {playerHand}");
                Console.WriteLine($"Dealer: {dealerHand.GetTheCardsOfTheHand[0]}");

                if (playerHand.Status == HandStatus.Busted)
                {
                    Console.WriteLine("Bust! Dealer gewinnt.");
                    break;
                }

                Console.Write("Hit (h) oder Stand (s)? ");
                string input = Console.ReadLine();

                if (input == "h")
                {
                    playerHand.AddCard(cardStack.DrawCard());
                }
                else if (input == "s")
                {
                    while (dealerHand.CalculateValue() < 17)
                    {
                        dealerHand.AddCard(cardStack.DrawCard());
                    }

                    int pVal = playerHand.CalculateValue();
                    int dVal = dealerHand.CalculateValue();

                    Console.WriteLine($"\nDeine Hand: {playerHand}");
                    Console.WriteLine($"Dealer Hand: {dealerHand}");

                    if (dealerHand.Status == HandStatus.Busted)
                        Console.WriteLine("Dealer Bust! Du gewinnst!");
                    else if (pVal > dVal)
                        Console.WriteLine("Du gewinnst!");
                    else if (dVal > pVal)
                        Console.WriteLine("Dealer gewinnt!");
                    else
                        Console.WriteLine("Unentschieden!");
                    break;
                }
            }
        }
    }
}


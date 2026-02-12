using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blackjack.Lib;

namespace Blackjack.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Card card = new Card(CardSuit.Spade, CardValue.Jack);

            Console.WriteLine(card.ToString());

            CardDeck cardDeck = new CardDeck();

            for (int i = 0; i < 52; i++)
            {
                Console.WriteLine(cardDeck.Cards[i].ToString());
            }

            Console.ReadKey();
        }
    }
}

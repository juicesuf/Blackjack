using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Lib
{
    public class CardDeck
    {
        Card[] cards = new Card[52];
        int counter=0;

        public Card[] Cards { get; }

        public CardDeck()
        {
            for (int colour = 0; colour <= 3; colour++)
            {
                for (int deckValue = 0; deckValue <= 12; deckValue++)
                {
                    CardSuit suit = (CardSuit)colour;
                    CardValue value = (CardValue)deckValue;

                    cards[counter++] = new Card(suit, value);
                }
            }
        }
    }
}

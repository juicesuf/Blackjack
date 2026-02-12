using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Lib
{
    public class CardDeck
    {
        const int _CardsInADeck = 52;  
        Card[] _cards = new Card[_CardsInADeck];  //Ein Kartendeck besteht aus 52 Karten//

        public Card[] Cards { get { return _cards; } }  //Array für den Deck//

        public CardDeck()
        //
        {
            int _counter = 0;
            for (int colour = 0; colour <= 3; colour++)
            {
                for (int deckValue = 0; deckValue <= 12; deckValue++)
                {
                    CardSuit suit = (CardSuit)colour;
                    CardValue value = (CardValue)deckValue;

                    _cards[_counter++] = new Card(suit, value);
                }
            }
        }
    }
}

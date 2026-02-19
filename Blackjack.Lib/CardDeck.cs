using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Lib
{
    /// <summary>
    /// Stellt ein Kartendeck mit 52 Karten dar.
    /// </summary>
    public class CardDeck
    {
        /// <summary>
        /// Anzahl der Karten im Deck.
        /// </summary>
        const int _CardsInADeck = 52;

        /// <summary>
        /// Enthält alle Karten des Decks.
        /// </summary>
        ICard[] _cards = new ICard[_CardsInADeck];

        /// <summary>
        /// Gibt alle Karten des Decks zurück.
        /// </summary>
        public ICard[] Cards
        {
            get { return _cards; }
        }

        /// <summary>
        /// Erstellt ein neues Kartendeck mit 52 Karten.
        /// </summary>
        public CardDeck()
        {
            int _counter = 0;

            for (int colour = 0; colour <= 3; colour++)
            {
                for (int deckValue = 0; deckValue <= 12; deckValue++)
                {
                    CardSuit suit = (CardSuit)colour;
                    CardValue value = (CardValue)deckValue;

                    _cards[_counter++] = Factory.CreateCard(suit, value);
                }
            }
        }
    }
}

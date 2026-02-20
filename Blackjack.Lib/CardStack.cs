using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Lib
{
    /// <summary>
    /// Stellt einen Kartenstapel aus mehreren Kartendecks dar.
    /// </summary>
    public class CardStack : ICardStack
    {
        /// <summary>
        /// Anzahl der verwendeten Kartendecks.
        /// </summary>
        private const int _NUMBER_OF_DECKS = 6;
        CardDeck deck = new CardDeck();

        /// <summary>
        /// Enthält alle Karten im Stapel.
        /// </summary>
        public List<ICard> Cards { get; }

        /// <summary>
        /// Erstellt einen neuen Kartenstapel mit mehreren Kartendecks.
        /// </summary>
        /// <param name="deck">Ein Kartendeck.</param>
        public CardStack()
        {
            Cards = new List<ICard>();

            for (int i = 0; i < _NUMBER_OF_DECKS; i++)
            {
                deck = new CardDeck();

                for (int j = 0; j < deck.Cards.Length; j++)
                {
                    Cards.Add(deck.Cards[j]);
                }
            }

            Shuffle(5);
        }

        /// <summary>
        /// Mischt die Karten im Stapel.
        /// </summary>
        /// <param name="numberOfShuffles">Wie oft gemischt wird.</param>
        public void Shuffle(int numberOfShuffles)
        {
            Random random = new Random();

            for (int i = 0; i < numberOfShuffles; i++)
            {
                for (int j = 0; j < Cards.Count; j++)
                {
                    int randomIndex = random.Next(Cards.Count);

                    ICard temp = Cards[j];
                    Cards[j] = Cards[randomIndex];
                    Cards[randomIndex] = temp;
                }
            }
        }

        /// <summary>
        /// Zieht eine Karte vom Stapel.
        /// </summary>
        /// <returns>
        /// Die gezogene Karte oder null, wenn keine Karten mehr da sind.
        /// </returns>
        public ICard DrawCard()
        {
            if (Cards.Count == 0)
                return null;

            ICard card = Cards[0];
            Cards.RemoveAt(0);
            return card;
        }
    }

}

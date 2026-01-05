using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Lib
{
    public class CardStack
    {
        private const int _NUMBER_OF_DECKS = 6;
        public List<Card> Cards { get; }

        public CardStack(CardDeck deck)
        {
            Cards = new List<Card>();

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

        public void Shuffle(int numberOfShuffles)
        {
            Random random = new Random();

            for (int i = 0; i < numberOfShuffles; i++)
            {
                for (int j = 0; j < Cards.Count; j++)
                {
                    int randomIndex = random.Next(Cards.Count);

                    Card temp = Cards[j];
                    Cards[j] = Cards[randomIndex];
                    Cards[randomIndex] = temp;
                }
            }
        }

        public Card DrawCard()
        {
            if (Cards.Count == 0)
                return null;

            Card card = Cards[0];
            Cards.RemoveAt(0);
            return card;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Lib
{
    /// <summary>
    /// Stellt eine Kartenhand dar.
    /// </summary>
    public partial class Hand
    {
        public IEnumerable<ICard> GetCards { get; }
        /// <summary>
        /// Enthält alle Karten der Hand.
        /// </summary>
        private List<ICard> _cards = new List<ICard>();


        public List<ICard> GetTheCardsOfTheHand { get { return _cards;} }
        /// <summary>
        /// Aktueller Status der Hand.
        /// </summary>
        public HandStatus Status { get; private set; }

        /// <summary>
        /// Erstellt eine neue leere Hand.
        /// </summary>
        public Hand()
        {
            CalculateValue();
        }

        /// <summary>
        /// Fügt der Hand eine Karte hinzu.
        /// </summary>
        /// <param name="card">Die hinzuzufügende Karte.</param>
        public void AddCard(ICard card)
        {
            _cards.Add(card);

            // Nach jeder neuen Karte wird der Wert neu berechnet
            CalculateValue();
        }

        /// <summary>
        /// Berechnet den Gesamtwert der Hand nach Blackjack-Regeln.
        /// </summary>
        /// <returns>Der aktuelle Handwert.</returns>
        public int CalculateValue()
        {
            int value = 0;   // Gesamtwert der Hand
            int aces = 0;    // Anzahl der Asse (werden zuerst als 11 gezählt)

            // Alle Karten der Hand durchgehen
            foreach (ICard currentCard in _cards)
            {
                // Ass: zuerst als 11 zählen
                if (currentCard.Value == CardValue.Ace)
                {
                    aces++;
                    value += 11;
                    continue; // Nächste Karte
                }

                // Bildkarten (Bube, Dame, König) zählen immer 10
                if (currentCard.Value >= CardValue.Jack)
                {
                    value += 10;
                }
                else
                {
                    // Zahlenkarten zählen ihren Zahlenwert
                    value += (int)currentCard.Value;
                    value++;
                }
            }

            // Falls der Wert über 21 liegt, wird ein Ass von 11 auf 1 reduziert
            while (value > 21 && aces > 0)
            {
                value -= 10;
                aces--;
            }

            // Status der Hand anhand des berechneten Werts setzen
            SetHandStatus(value);

            return value;
        }

        /// <summary>
        /// Bestimmt den Status der Hand (z. B. Blackjack oder Busted).
        /// </summary>
        /// <param name="value">Der berechnete Handwert.</param>
        void SetHandStatus(int value)
        {
            int cardCount = _cards.Count; // Anzahl der Karten in der Hand

            // Hand ist überkauft
            if (value > 21)
            {
                Status = HandStatus.Busted;
                return;
            }

            // Sonderfälle bei genau 21 Punkten
            if (value == 21)
            {
                // Blackjack: genau 2 Karten
                if (cardCount == 2)
                {
                    Status = HandStatus.BlackJack;
                }
                // Triple Seven: 3 Karten und alle sind Sieben
                else if (cardCount == 3 && _cards.All(card => card.Value == CardValue.Seven))
                {
                    Status = HandStatus.TripleSeven;
                }
                // Five Card Charlie: 5 Karten mit Wert 21
                else if (cardCount == 5)
                {
                    Status = HandStatus.FiveCardCharlie;
                }
                else
                {
                    Status = HandStatus.Safe;
                }

                return;
            }

            // Kein Sonderfall, dann ist Hand sicher
            Status = HandStatus.Safe;
        }
    }


}
        


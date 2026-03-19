using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Lib
{
    /// <summary>
    /// Stellt eine Spielkarte dar.
    /// </summary>
    public class Card : ICard
    {
        /// <summary>
        /// Die Farbe der Karte.
        /// </summary>
        public CardSuit Suit { get; }

        /// <summary>
        /// Der Wert der Karte.<
        /// </summary>
        public CardValue Value { get; }

        /// <summary>
        /// Erstellt eine neue Karte.
        /// </summary>
        /// <param name="suit">Die Kartenfarbe.</param>
        /// <param name="value">Der Kartenwert.</param>
        public Card(CardSuit suit, CardValue value)
        {
            Suit = suit;
            Value = value;
        }

        /// <summary>
        /// Gibt die Karte als Text zurück.
        /// </summary>
        /// <returns>Text mit Farbe und Wert der Karte.</returns>
        public override string ToString()
        {
            return $"Kartentyp : {Suit} ; Kartenwert : {Value}";
        }
    }
}

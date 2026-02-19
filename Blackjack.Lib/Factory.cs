using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Lib
{
    /// <summary>
    /// Erstellt Kartenobjekte.
    /// </summary>
    public class Factory
    {
        /// <summary>
        /// Erstellt eine neue Karte.
        /// </summary>
        /// <param name="suit">Die Kartenfarbe.</param>
        /// <param name="value">Der Kartenwert.</param>
        /// <returns>Eine neue Karte.</returns>
        public static ICard CreateCard(CardSuit suit, CardValue value)
        {
            return new Card(suit, value);
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Lib
{
    public class Dealer : AutoPlayer
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der Dealer-Klasse.
        /// </summary>
        /// <param name="name">Der Name des Dealers.</param>
        /// <param name="cardPool">Der Kartenstapel für das Spiel.</param>
        public Dealer(string name, ICardPool cardPool) : base(name, cardPool)
        {
        }

        /// <summary>
        /// Die erste Karte des Dealers.
        /// </summary>
        public ICard FirstCard { get; }

        /// <summary>
        /// Gibt eine Zeichenkettendarstellung des Dealers zurück.
        /// </summary>
        /// <param name="firstCardOnly">Wenn true, wird nur die erste Karte angezeigt; andernfalls alle Karten.</param>
        /// <returns>Eine Zeichenkettendarstellung des Dealers oder seiner Karten.</returns>
        public string ToString(bool firstCardOnly)
        {
            if (firstCardOnly)
            {
                ToString();
            }

            return firstCardOnly.ToString();
        }
    }
    
}

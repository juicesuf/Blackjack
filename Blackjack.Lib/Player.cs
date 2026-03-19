using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Lib
{
    public class Player : AbstractPlayer
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der Player-Klasse.
        /// </summary>
        /// <param name="name">Der Name des Spielers.</param>
        /// <param name="cardpool">Der Kartenstapel für das Spiel.</param>
        public Player(string name, ICardPool cardpool) : base(name, cardpool)
        {
            
        }


    }
}

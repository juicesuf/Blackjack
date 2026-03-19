using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Lib
{
    public abstract partial class AbstractPlayer
    {

        /// <summary>
        /// Der Name des Spielers.
        /// </summary>
        private string _name;

        /// <summary>
        /// Die aktuelle Hand des Spielers.
        /// </summary>
        protected Hand _hand;

        /// <summary>
        /// Der Kartenstapel, aus dem Karten gezogen werden.
        /// </summary>
        private ICardPool _cardPool;

        /// <summary>
        /// Die letzte Aktion, die der Spieler durchgeführt hat.
        /// </summary>
        public PlayerAction LastAction { get; }

        /// <summary>
        /// Gibt an, ob der Spieler sein Spiel beendet hat.
        /// </summary>
        public bool HasFinished { get; private set; }

        /// <summary>
        /// Initialisiert eine neue Instanz der AbstractPlayer-Klasse.
        /// </summary>
        /// <param name="name">Der Name des Spielers.</param>
        /// <param name="cardPool">Der Kartenstapel für das Spiel.</param>
        internal AbstractPlayer(string name, ICardPool cardPool)
        {
            _name = name;
            _cardPool = cardPool;
        }

        /// <summary>
        /// Führt eine Spieleraktion aus (z.B. Hit oder Stand).
        /// </summary>
        /// <param name="playeraction">Die Aktion, die der Spieler durchführen möchte.</param>
        public void PlayAction(PlayerAction playeraction)
        {
            if (HasFinished) return;

            if (LastAction == PlayerAction.Stand)
            {
                return;
            }

            else if (playeraction == PlayerAction.Hit)
            {
                _hand.AddCard(_cardPool.DrawCard());
                playeraction = PlayerAction.Hit;
            }
        }

        /// <summary>
        /// Wirft die Karten des Spielers weg und setzt das Spiel zurück.
        /// </summary>
        public void ThrowCards()
        {
            if (HasFinished)
            {
                _hand = new Hand();
                HasFinished = false;
            }
        }

        /// <summary>
        /// Gibt den Namen des Spielers zurück.
        /// </summary>
        /// <returns>Der Name des Spielers.</returns>
        public string GetName()
        {
            return _name;
        }

        /// <summary>
        /// Berechnet und gibt den aktuellen Wert der Hand des Spielers zurück.
        /// </summary>
        /// <returns>Der Wert der aktuellen Hand.</returns>
        public int GetHandValue()
        {
            return _hand.CalculateValue();
        }

        /// <summary>
        /// Gibt den aktuellen Status der Hand des Spielers zurück.
        /// </summary>
        /// <returns>Der Status der Hand (z.B. aktiv, Bust, Blackjack).</returns>
        public HandStatus GetHandStatus()
        {
            return _hand.Status;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Lib
{
    public abstract partial class AbstractPlayer
    {
        private string _name;

        protected Hand _hand;

        private ICardPool _cardPool;

        public PlayerAction LastAction { get; }

        public bool HasFinished { get; private set; }

        internal AbstractPlayer(string name, ICardPool cardPool)
        {
            _name = name;
            _cardPool = cardPool;
        }

        public void PlayAction(PlayerAction playeraction)
        {
            if (HasFinished) return;

            if(LastAction == PlayerAction.Stand)
            {
                return;
            }

            else if (playeraction == PlayerAction.Hit)
            {
                _hand.AddCard(_cardPool.DrawCard());
                playeraction = PlayerAction.Hit;
            }
        }

        public void ThrowCards()
        {
            if (HasFinished)
            {
                _hand = new Hand();
                HasFinished = false;
            }

       
        }

        public string GetName()
        {
            return _name;
        }

        public int GetHandValue()
        {
            return _hand.CalculateValue();
        }

        public HandStatus GetHandStatus()
        {
            return _hand.Status;
        }

    }
}

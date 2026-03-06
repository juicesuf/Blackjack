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

        public bool HasFinished { get; }

        internal AbstractPlayer(string name, ICardPool cardPool)
        {
            _name = name;
            _cardPool = cardPool;
        }

        public void PlayAction(PlayerAction playeraction)
        {

        }

        public void ThrowCards()
        {
            
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

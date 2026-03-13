using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Lib
{
    public class Dealer : AutoPlayer
    {
        public Dealer(string name, ICardPool cardPool) : base(name, cardPool)
        {
        }

        public ICard FirstCard { get; }

       
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Lib
{
    public class Dealer : AutoPlayer
    {
        public ICard FirstCard { get; }

        public Dealer()
        {

        }

        public string ToString(bool firstCardOnly)
        {
            return $"The first card is" + firstCardOnly;
        }
    }
}

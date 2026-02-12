using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Lib
{
    public interface ICard
    {
        CardSuit Suit { get; }
        CardValue Value { get; }

        string ToString();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Lib
{
    public class Factory
    {
        public static ICard CreateCard(CardSuit suit, CardValue value)
        {
            return new Card(suit, value);
        }

        public static ICardStack CreateCardStack(Creat)
        {
            return new Card(suit, value);
        }

    }
}

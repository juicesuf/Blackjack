using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Lib
{
    public class HandToString
    {
        public partial class Hand
        {
            public override string ToString()
            {
                StringBuilder handAsString = new StringBuilder();

                foreach (Card card in _cards)
                {
                    handAsString.Append(card.ToString());
                    handAsString.Append(", ");
                }
                if (handAsString.Length > 2)
                {
                    handAsString.Remove(handAsString.Length - 2, 2);
                }

                handAsString.Append(" (");
                handAsString.Append(CalculateValue());
                handAsString.Append("/");
                handAsString.Append(Status);
                handAsString.Append(")");

                return handAsString.ToString();

            }

        }
    }
}

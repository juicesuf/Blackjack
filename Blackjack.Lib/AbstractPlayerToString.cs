using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Lib
{
    partial class AbstractPlayer
    {

        public override string ToString()
        {
            StringBuilder playerStatus = new StringBuilder();

            playerStatus.Append(_hand);
            if (LastAction == PlayerAction.Stand)
            {
                playerStatus.Append(" (Stand)");
            }

            return $"{_name} : {playerStatus}";
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Lib
{
    public class ProgramSettings
    {
        private ProgramSettings()
        {
        }

        public static int NUMBER_OF_CARDS_IN_ONE_DECK { get; } = 52;

        public static int NUMBER_OF_DECKS { get; } = 6;

        public static int NUMBER_OF_SHUFFLES { get; } = 5;

        public static readonly ProgramSettings i = new ProgramSettings();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class GameStatistics
    {
        public int TotalGames { get; private set; }
        public int WinsX { get; private set; }
        public int WinsO { get; private set; }

        public void ResetStatistics()
        {
            TotalGames = 0;
            WinsX = 0;
            WinsO = 0;
        }

        public void UpdateStatistics(string winner)
        {
            TotalGames++;
            if (winner == "X")
                WinsX++;
            else if (winner == "O")
                WinsO++;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class GameModel
    {
        public GameSettings Settings { get; private set; }
        public GameStatistics Statistics { get; private set; }
        public GameLogic Logic { get; private set; }
        public string PlayerSymbol { get; private set; } // Символ игрока (X или O)

        public event Action GameOver;

        public GameModel(GameSettings settings, string playerSymbol)
        {
            if (playerSymbol != "X" && playerSymbol != "O")
                throw new ArgumentException("Player symbol must be 'X' or 'O'.");

            Settings = settings;
            PlayerSymbol = playerSymbol;
            Statistics = new GameStatistics();
            Logic = new GameLogic(Settings.GridSize);
        }

        // Метод для обработки хода игрока
        public bool MakeMove(int row, int col)
        {
            if (Logic.MakeMove(row, col))
            {
                if (Logic.CheckWinner(row, col))
                {
                    Statistics.UpdateStatistics(Logic.CurrentPlayer);
                    GameOver?.Invoke();
                    return true;
                }
                Logic.SwitchPlayer();
            }
            return false;
        }

        // Метод для сброса игры
        public void ResetGame()
        {
            Logic.ResetGame();
            Statistics.ResetStatistics();
        }

        // Метод для получения текущего состояния сетки
        public string[,] GetGrid()
        {
            return Logic.GetGrid();
        }

        // Метод для получения текущего игрока
        public string GetCurrentPlayer()
        {
            return Logic.CurrentPlayer;
        }

        // Метод для получения статистики игры
        public GameStatistics GetStatistics()
        {
            return Statistics;
        }
    }
}

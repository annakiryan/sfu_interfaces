using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class GameLogic
    {
        private string[,] Grid;
        public string CurrentPlayer { get; private set; }

        public GameLogic(int gridSize)
        {
            Grid = new string[gridSize, gridSize];
            CurrentPlayer = "X"; // Начинает X
        }

        public bool MakeMove(int row, int col)
        {
            if (Grid[row, col] == null) // Если клетка пуста
            {
                Grid[row, col] = CurrentPlayer;
                return true;
            }
            return false;
        }

        public void SwitchPlayer()
        {
            CurrentPlayer = (CurrentPlayer == "X") ? "O" : "X";
        }

        public bool CheckWinner(int row, int col)
        {
            return CheckLine(row, 0, 0, 1) || // Проверка строки
                   CheckLine(0, col, 1, 0) || // Проверка столбца
                   (row == col && CheckLine(0, 0, 1, 1)) || // Проверка диагонали
                   (row + col == Grid.GetLength(0) - 1 && CheckLine(0, Grid.GetLength(0) - 1, 1, -1)); // Обратная диагональ
        }

        private bool CheckLine(int startRow, int startCol, int rowStep, int colStep)
        {
            string player = Grid[startRow, startCol];
            for (int i = 1; i < Grid.GetLength(0); i++)
            {
                int row = startRow + i * rowStep;
                int col = startCol + i * colStep;
                if (row < 0 || row >= Grid.GetLength(0) || col < 0 || col >= Grid.GetLength(0) || Grid[row, col] != player)
                {
                    return false;
                }
            }
            return true;
        }

        public void ResetGame()
        {
            for (int i = 0; i < Grid.GetLength(0); i++)
            {
                for (int j = 0; j < Grid.GetLength(1); j++)
                {
                    Grid[i, j] = null;
                }
            }
            CurrentPlayer = "X";
        }

        public string[,] GetGrid()
        {
            return Grid;
        }
    }
}

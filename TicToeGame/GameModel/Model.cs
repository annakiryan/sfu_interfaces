using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameModel
{
    public class Model
    {
        private int[,] grid;
        private int gridSize = 10;
        private int currentPlayer = 1;
        private readonly int requiredInRow = 5;
        private int numOfFilledCells = 0;

        public event Action<int, int> GameResetedEvent;
        public event Action<int> GameOverEvent;
        public event Action GameOverWithDrawEvent;
        public event Action<int> SwitchedPlayerEvent;
        public event Action<int> StatisticsChangedEvent;

        public void ResetGame()
        {
            currentPlayer = 1;
            numOfFilledCells = 0;

            grid = new int[gridSize, gridSize];

            GameResetedEvent.Invoke(currentPlayer, gridSize);
        }

        public void ChangeGridSize(int gridSize)
        {
            this.gridSize = gridSize;
            ResetGame();
        }

        public void MakeMove(int row, int col)
        {
            numOfFilledCells += 1;

            grid[row, col] = currentPlayer;
            
            if (IsGameOver(grid, row, col, currentPlayer))
            {
                GameOverEvent.Invoke(currentPlayer);
                StatisticsChangedEvent.Invoke(currentPlayer);
            }
            else if (CheckIfDraw(numOfFilledCells, gridSize))
            {
                GameOverWithDrawEvent.Invoke();
                StatisticsChangedEvent.Invoke(0);
            }
            else
            {
                SwitchPlayer();
                SwitchedPlayerEvent.Invoke(currentPlayer);
            }
        }

        private void SwitchPlayer()
        {
            currentPlayer = currentPlayer == 1 ? 2 : 1;
        }

        private bool IsGameOver(int[,] grid, int row, int col, int player)
        {
            int gridSize = grid.GetLength(0);

            // Проверяем каждую линию, проходящую через текущую клетку
            // Вертикаль (вверх-вниз)
            if (CountConsecutive(grid, row, col, 0, 1, player, gridSize) +
                CountConsecutive(grid, row, col, 0, -1, player, gridSize) + 1 >= requiredInRow)
                return true;

            // Горизонталь (влево-вправо)
            if (CountConsecutive(grid, row, col, 1, 0, player, gridSize) +
                CountConsecutive(grid, row, col, -1, 0, player, gridSize) + 1 >= requiredInRow)
                return true;

            // Диагональ слева направо (\)
            if (CountConsecutive(grid, row, col, 1, 1, player, gridSize) +
                CountConsecutive(grid, row, col, -1, -1, player, gridSize) + 1 >= requiredInRow)
                return true;

            // Диагональ справа налево (/)
            if (CountConsecutive(grid, row, col, 1, -1, player, gridSize) +
                CountConsecutive(grid, row, col, -1, 1, player, gridSize) + 1 >= requiredInRow)
                return true;

            // Если ни одна линия не удовлетворяет условиям победы
            return false;
        }

        // Метод подсчета одинаковых фишек в одном направлении
        private int CountConsecutive(int[,] grid, int startRow, int startCol, int dRow, int dCol, int player, int gridSize)
        {
            int count = 0;

            // Начинаем движение от текущей клетки в указанном направлении
            int currentRow = startRow + dRow;
            int currentCol = startCol + dCol;

            // Пока находимся в пределах игрового поля и встречаем клетки текущего игрока
            while (currentRow >= 0 && currentRow < gridSize &&
                   currentCol >= 0 && currentCol < gridSize &&
                   grid[currentRow, currentCol] == player)
            {
                count++;
                currentRow += dRow;
                currentCol += dCol;
            }

            return count;
        }

        private bool CheckIfDraw(int numOfFilledCells, int gridSize)
        {
            if (numOfFilledCells == gridSize * gridSize) return true;
            return false;
        }
    }
}

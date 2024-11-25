using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class GameSettings
    {
        private int _gridSize;

        public int GridSize
        {
            get { return _gridSize; }
            set
            {
                if (value < 10 || value > 20)
                    throw new ArgumentOutOfRangeException("Сетка может быть размера не менее 10Х10 и не более 20Х20");
                _gridSize = value;
            }
        }

        public GameSettings(int gridSize)
        {
            GridSize = gridSize;
        }
    }
}

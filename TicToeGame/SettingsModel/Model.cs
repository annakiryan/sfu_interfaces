using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettingsModel
{
    public class Model
    {
        public event Action<int> ChangeFieldSizeEvent;
        public event Action<Exception> ErrorEvent;

        public void ChangeFieldSize(string size)
        {
            if (ValidateSize(size))
            {
                ChangeFieldSizeEvent.Invoke(int.Parse(size));
            }
            else
            {
                ErrorEvent.Invoke(new Exception("Допустимы только целые числа от 10 до 20"));
            }
            
        }

        private bool ValidateSize(string input)
        {
            if (!string.IsNullOrEmpty(input)  && input.All(char.IsDigit))
            {
                int number = int.Parse(input);
                return number >= 10 && number <= 20;
            }

            return false;

        }
    }
}

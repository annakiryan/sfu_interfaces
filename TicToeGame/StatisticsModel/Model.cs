using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dotenv.net;

namespace StatisticsModel
{
    public class Model
    {
        private string connectionString;
        private DAL dal;

        public event Action<(int, int, int, int)> StatisticsRequiredEvent;

        public Model()
        {
            DotEnv.Load();

            connectionString = Environment.GetEnvironmentVariable("CONNECTION_STRING");
            dal = new DAL(connectionString);
        }

        public void GetStatistics()
        {
            StatisticsRequiredEvent.Invoke(dal.GetStatistics());
        }

        public void UpdateStatistics(int winner)
        {
            dal.UpdateStatistics(winner);
        }
    }
}

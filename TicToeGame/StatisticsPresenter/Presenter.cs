using StatisticsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatisticsPresenter
{
    public class Presenter
    {
        StatisticsModel.Model model;
        StatisticsView.View view;

        public event Action CloseStatisticsPresenterEvent;

        public Presenter()
        {
            model = new StatisticsModel.Model();
            view = new StatisticsView.View();

            view.FormCloseEvent += CloseStatisticsPresenter;
            model.StatisticsRequiredEvent += ShowStatistics;
        }

        private void CloseStatisticsPresenter()
        {
            view.Close();
            CloseStatisticsPresenterEvent.Invoke();
        }

        public void OpenView()
        {
            model.GetStatistics();
            view.ShowDialog();
        }

        private void ShowStatistics((int totalGames, int totalXWins, int totalOWins, int totalOfDraws) statistics)
        {
            view.ShowStatistics(statistics);
        }

        public void UpdateStatistics(int winner)
        {
            model.UpdateStatistics(winner);
        }
    }
}

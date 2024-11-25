
using MenuView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MenuPresenter
{
    internal class Presenter
    {
        private View view;

        static private SettingsPresenter.Presenter settingsPresenter = new SettingsPresenter.Presenter();
        static private GamePresenter.Presenter gamePresenter = new GamePresenter.Presenter();
        static private StatisticsPresenter.Presenter statisticsPresenter = new StatisticsPresenter.Presenter();

        public event Action<int> NotifyGameEvent;
        public event Action NotifyStatisctics;


        public Presenter(View view)
        {
            this.view = view;

            view.OpenGame += OpenGamePresenter;
            view.OpenSettings += OpenSettingsPresenter;
            view.OpenStatistics += OpenStatisticsPresenter;

            SubscribeToEvents();
        }

        private void OpenGamePresenter()
        {
            view.Visible = false;

            gamePresenter.CloseGamePresenterEvent += OpenMenuPresenter;
            gamePresenter.OpenView();
        }

        private void OpenSettingsPresenter()
        {
            view.Visible = false;

            settingsPresenter.CloseSettingsPresenterEvent += OpenMenuPresenter;
            settingsPresenter.OpenView();
        }

        private void OpenStatisticsPresenter()
        {
            view.Visible = false;

            statisticsPresenter.CloseStatisticsPresenterEvent += OpenMenuPresenter;
            statisticsPresenter.OpenView();
        }

        private void OpenMenuPresenter()
        {
            view.Visible = true;
        }

        private void SubscribeToEvents()
        {
            settingsPresenter.NotifyGameAboutSettingsChangeEvent += (size) => { gamePresenter.ChangeGridSize(size); };
            gamePresenter.NotifyStatisticsAboutChangeEvent += (winner) => { statisticsPresenter.UpdateStatistics(winner); };
        }
    }
}

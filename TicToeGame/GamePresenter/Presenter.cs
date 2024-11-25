using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePresenter
{
    public class Presenter
    {
        GameModel.Model model;
        GameView.View view;

        public event Action CloseGamePresenterEvent;
        public event Action<int> NotifyStatisticsAboutChangeEvent;


        public Presenter()
        {
            model = new GameModel.Model();
            view = new GameView.View();

            model.GameResetedEvent += (currentPlayer, gridSize) => { view.ResetGame(currentPlayer, gridSize); };
            model.SwitchedPlayerEvent += (player) => { view.SwitchPlayer(player); };
            model.GameOverEvent += (winner) => { view.ShowWinner(winner); };
            model.GameOverWithDrawEvent += () => { view.ShowDraw(); };
            model.StatisticsChangedEvent += (winner) => { NotifyStatisticsAboutChangeEvent.Invoke(winner); };

            view.StartAgainEvent += ResetGame;
            view.MoveMadeEvent += (row, col) => { model.MakeMove(row, col); };
            view.CloseGameViewEvent += CloseGamePresenter;
        }

        public void OpenView()
        {
            ResetGame();
            view.ShowDialog();
        }

        public void ChangeGridSize(int size)
        {
            model.ChangeGridSize(size);
        }

        private void CloseGamePresenter()
        {
            view.Close();
            CloseGamePresenterEvent?.Invoke();
        }

        private void ResetGame()
        {
            model.ResetGame();
        }
    }
}

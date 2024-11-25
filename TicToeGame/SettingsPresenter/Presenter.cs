using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettingsPresenter
{
    public class Presenter
    {
        SettingsModel.Model model;
        SettingsView.View view;

        public event Action CloseSettingsPresenterEvent;
        public event Action<int> NotifyGameAboutSettingsChangeEvent;

        public Presenter()
        {
            view = new SettingsView.View();
            model = new SettingsModel.Model();

            view.CloseSettingsViewEvent += CloseSettingsPresenter;
            view.ChangeFieldSizeEvent += (size) => { model.ChangeFieldSize(size); };

            model.ChangeFieldSizeEvent += NotifyGameAboutSettingsChange;
            model.ErrorEvent += (ex) => { view.ShowError(ex); };
        }

        public void OpenView()
        {
            view.ShowDialog();
        }

        private void CloseSettingsPresenter()
        {
            view.Close();
            CloseSettingsPresenterEvent?.Invoke();
        }

        private void NotifyGameAboutSettingsChange(int size)
        {
            NotifyGameAboutSettingsChangeEvent.Invoke(size);
            CloseSettingsPresenter();
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuView
{
    public partial class View : Form
    {
        public event Action OpenSettings;
        public event Action OpenGame;
        public event Action OpenStatistics;

        public View()
        {
            InitializeComponent();
        }

        private void button_settings_Click(object sender, EventArgs e)
        {
            OpenSettings.Invoke();
        }

        private void button_play_Click(object sender, EventArgs e)
        {
            OpenGame.Invoke();
        }

        private void button_statistics_Click(object sender, EventArgs e)
        {
            OpenStatistics.Invoke();
        }
    }
}

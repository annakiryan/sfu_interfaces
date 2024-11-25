using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatisticsView
{
    public partial class View : Form
    {
        public event Action FormCloseEvent;

        public View()
        {
            InitializeComponent();
        }

        public void ShowStatistics((int totalGames, int totalXWins, int totalOWins, int totalOfDraws) statistics)
        {
            totalGames.Text = statistics.totalGames.ToString();
            totalXWins.Text = statistics.totalXWins.ToString();
            totalOWins.Text = statistics.totalOWins.ToString();
            totalOfDraws.Text = statistics.totalOfDraws.ToString();
        }

        private void onFormClose(object sender, FormClosedEventArgs e)
        {
            FormCloseEvent.Invoke();
        }
    }
}

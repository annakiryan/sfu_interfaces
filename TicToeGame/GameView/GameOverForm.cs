using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameView
{
    public partial class GameOverForm : Form
    {
        View view;
        private bool startAgainClicked;
        public GameOverForm(View view, bool win, string winner="")
        {
            InitializeComponent();
            
            this.view = view;

            CreateLabel(win, winner);
            
        }

        private void CreateLabel(bool win, string winner)
        {
            if (win)
            {
                resultLabel.Text = $"Выиграл игрок {winner}!";
            } 
            else
            {
                resultLabel.Text = $"Ничья!";
            }
        }

        private void buttonStartAgain_Click(object sender, EventArgs e)
        {
            startAgainClicked = true;
            view.StartAgain();
            Close();
        }

        private void buttonReturnToMenu_Click(object sender, EventArgs e)
        {
            view.CloseForm();
            Close();
        }

        private void onFormClose(object sender, FormClosedEventArgs e)
        {
            if (!startAgainClicked)
            {
                Close();
                view.CloseForm();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameView
{
    public partial class View : Form
    {
        private int _gridSize;
        private string _currentPlayer;
        private DataGridView _dataGridView;
        private Label _currentPlayerLabel;

        public event Action<int, int> MoveMadeEvent;
        public event Action CloseGameViewEvent;
        public event Action StartAgainEvent;

        public View()
        {
            InitializeComponent();
            MinimumSize = new Size(400, 400);
            InitializeControls();
        }

        public void SwitchPlayer(int currentPlayer)
        {
            _currentPlayer = RenderPlayerMarker(currentPlayer);
            _currentPlayerLabel.Text = $"Ходит {_currentPlayer}";
        }

        public void ResetGame(int currentPlayer, int gridsize)
        {
            SwitchPlayer(currentPlayer);

            _gridSize = gridsize;
            UpdateBoardSize(_gridSize);
        }

        public void ShowWinner(int winner)
        {
            GameOverForm form = new GameOverForm(this, true, RenderPlayerMarker(winner));
            form.ShowDialog();
        }

        public void ShowDraw()
        {
            GameOverForm form = new GameOverForm(this, false);
            form.ShowDialog();
        }

        private void OnCellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int col = e.ColumnIndex;

            if (IsCellEmpty(row, col))
            {
                ShowMove(row, col, _currentPlayer);
                MoveMadeEvent.Invoke(row, col);
            }
            else return;

        }
        private void onCloseForm(object sender, FormClosedEventArgs e)
        {
            CloseForm();
        }

        private void InitializeControls()
        {
            _currentPlayerLabel = new Label
            {
                Dock = DockStyle.Bottom,
                Font = new Font("Arial", 14, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                Height = 30
            };
            Controls.Add(_currentPlayerLabel);

            _dataGridView = new DataGridView
            {
                Dock = DockStyle.Fill,
                RowHeadersVisible = false,
                ColumnHeadersVisible = false,
                AllowUserToResizeColumns = false,
                AllowUserToResizeRows = false,
                AllowUserToAddRows = false,
                ReadOnly = true,
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.Fixed3D
            };

            _dataGridView.CellClick += OnCellClick;
            Controls.Add(_dataGridView);
        }

        private void UpdateBoardSize(int gridSize)
        {
            _gridSize = gridSize;

            _dataGridView.Rows.Clear();
            _dataGridView.Columns.Clear();

            for (int i = 0; i < _gridSize; i++)
            {
                var column = new DataGridViewTextBoxColumn
                {
                    Width = Math.Max(30, ClientSize.Width / _gridSize),
                    DefaultCellStyle = new DataGridViewCellStyle
                    {
                        Alignment = DataGridViewContentAlignment.MiddleCenter,
                        Font = new Font("Arial", 18, FontStyle.Bold)
                    }
                };
                _dataGridView.Columns.Add(column);
            }

            for (int i = 0; i < _gridSize; i++)
            {
                _dataGridView.Rows.Add();
                _dataGridView.Rows[i].Height = Math.Max(30, (ClientSize.Height - _currentPlayerLabel.Height) / _gridSize);
            }

            AdjustFormSize();
            _dataGridView.ClearSelection();
        }

        private void AdjustFormSize()
        {
            int gridWidth = _dataGridView.Columns[0].Width * _gridSize;
            int gridHeight = _dataGridView.Rows[0].Height * _gridSize;


            int windowWidth = Math.Max(ClientSize.Width, gridWidth);
            int windowHeight = Math.Max(ClientSize.Height, gridHeight + _currentPlayerLabel.Height);

            ClientSize = new Size(windowWidth, windowHeight); 
        }

        private void ShowMove(int row, int col, string currentPlayer)
        {
            _dataGridView.Rows[row].Cells[col].Value = currentPlayer;
            _dataGridView.Rows[row].Cells[col].Style.ForeColor = currentPlayer == "X" ? Color.Red : Color.Blue;
        }

        internal void CloseForm()
        {
            CloseGameViewEvent.Invoke();
        }


        internal void StartAgain()
        {
            StartAgainEvent.Invoke();
        }

        private string RenderPlayerMarker(int value)
        {
            switch (value)
            {
                case 1:
                    return "X";
                case 2:
                    return "O";
                default:
                    return "";
            }
        }

        private bool IsCellEmpty(int row, int col)
        {
            var cell = _dataGridView.Rows[row].Cells[col];
            return cell.Value == null || string.IsNullOrWhiteSpace(cell.Value.ToString());
        }
    }

}

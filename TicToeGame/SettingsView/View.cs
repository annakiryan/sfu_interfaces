using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SettingsView
{
    public partial class View : Form
    {
        public event Action CloseSettingsViewEvent;
        public event Action<string> ChangeFieldSizeEvent;

        public View()
        {
            InitializeComponent();
        }
        public void ShowError(Exception ex)
        {
            MessageBox.Show(ex.Message);
        }

        private void closeForm(object sender, FormClosedEventArgs e)
        {
            CloseSettingsViewEvent.Invoke();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            ChangeFieldSizeEvent.Invoke(textBox_size.Text);
        }
    }
}

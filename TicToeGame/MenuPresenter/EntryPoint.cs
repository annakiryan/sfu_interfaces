using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenuView;
using System.Windows.Forms;
using dotenv.net;


namespace MenuPresenter
{
    internal class EntryPoint
    {
        static void Main(string[] args)
        {

            MenuView.View view = new MenuView.View();
            new Presenter(view);
            Application.EnableVisualStyles();
            Application.Run(view);
            

        }
    }
}

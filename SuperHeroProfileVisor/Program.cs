using SuperHeroProfile.Model;
using SuperHeroProfile.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperHeroProfile
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //model
            HeroModel hero = new HeroModel();

            //view
            SuperHeroProfileView view = new SuperHeroProfileView();

            //presenter
            SuperHeroProfilePresenter presenter = new SuperHeroProfilePresenter(hero, view);

            Application.Run(view);
        }
    }
}

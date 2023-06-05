using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MatchesFirmDataBase
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*
             *  563736 shadow
             *  001D50 background
             *  151D39 title
             *  2B273B border
             *  FA6915 text
             *  white color as well 
             *  
             */

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginForm loginform = new LoginForm();
            Application.Run(loginform);
            if (loginform.isAuthenticated())
            {
                Application.Run(new Main_GUI());
            }

        }
    }
}

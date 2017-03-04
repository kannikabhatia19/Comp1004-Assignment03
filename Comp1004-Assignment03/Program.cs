/*
 App's Name: Movie Bonanza
 Author's Name: Kannika Bhatia
 Student ID: 200332992
 App's Creation Date: 4th March 2017
 App Description: Movie rental application that has the movie's selection form,
 order form, confirmation form
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comp1004_Assignment03
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
            Application.Run(new SplashScreen());
        }
    }
}

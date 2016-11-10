using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Sharp movie Bonanza
/// Created by David McNiven
/// Student # 200330143
/// Created on November 11th 2016
/// A simple multiform program that simulates the process of ordering a movie off of a streaming service
/// </summary>
namespace Sharp_Movie_Bonanza
{
    static class Program
    {
        public static String[] movie = new String[3];

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SplashForm());
        }
    }
}

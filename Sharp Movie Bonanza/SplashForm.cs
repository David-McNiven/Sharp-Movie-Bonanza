using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// moves to the selection form after 3 seconds and disables the timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            this.Hide();
            SelectionForm SelectionForm = new SelectionForm();
            SelectionForm.Show();
            SplashTimer.Enabled = false;
        }
    }
}

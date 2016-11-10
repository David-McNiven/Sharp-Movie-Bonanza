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
    public partial class StreamForm : Form
    {
        public StreamForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// exits application on click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OKButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// inserts the selected movie title and order grand total into existing labels
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StreamForm_Load(object sender, EventArgs e)
        {
            String[] movie = Program.movie;
            ChargedCostLabel.Text += movie[2];
            StreamingLabel.Text = String.Concat(movie[0], StreamingLabel.Text);
        }
    }
}

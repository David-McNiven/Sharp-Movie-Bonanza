using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sharp_Movie_Bonanza
{
    public partial class OrderForm : Form
    {
        public SelectionForm previousForm;

        public OrderForm()
        {
            InitializeComponent();
        }

        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            String[] movie = Program.movie;
            TitleTextBox.Text = movie[0];
            CategoryTextBox.Text = movie[1];
            CostTextBox.Text = movie[2];
            string imageString = Regex.Replace(TitleTextBox.Text, @"\s+", "");
            YourSelectionPictureBox.Image = (Image)Properties.Resources.ResourceManager.GetObject(imageString);
            YourSelectionPictureBox.Refresh();
        }

        private void StreamButton_Click(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.previousForm.Show();
            this.Close();
        }
    }
}

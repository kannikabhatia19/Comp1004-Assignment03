using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comp1004_Assignment03
{
    
    public partial class SelectionForm : Form
    {
        private Form _previousForm;
        private Dictionary<String, String> movieLists;
        private Dictionary<String, double> categoryPrice;

        public SelectionForm()
        {
            InitializeComponent();

            movieLists = new Dictionary<string, string>();
            categoryPrice = new Dictionary<string, double>();

            categoryPrice.Add("Comedy", 1.99);
            categoryPrice.Add("Drama", 1.99);
            categoryPrice.Add("Action", 2.99);
            categoryPrice.Add("Sci-Fi", 2.99);
            categoryPrice.Add("Horror", 2.99);
            categoryPrice.Add("Thriller", 1.99);
            categoryPrice.Add("Family", 0.99);
            categoryPrice.Add("New Release", 4.99);

            movieLists.Add("Season of the Witch", "Sci-Fi");
            movieLists.Add("The Green Hornet", "Action");
            movieLists.Add("The Dilemma", "Comedy");
            movieLists.Add("Death Race 2", "Action");
            movieLists.Add("Company Men", "Drama");
            movieLists.Add("No Strings Attached", "Comedy");
            movieLists.Add("The Way Back", "Drama");
            movieLists.Add("The Mechanic", "Action");
            movieLists.Add("The Rite", "Horror");
            movieLists.Add("Sanctum", "Action");
            movieLists.Add("The Other Woman", "Action");
            movieLists.Add("The Roommate", "Thriller");
            movieLists.Add("Waiting for Forever", "Drama");
            movieLists.Add("Cedar Rapids", "Comedy");
            movieLists.Add("Gnomeo and Juliet", "Family");
            movieLists.Add("Just Go With It", "Comedy");
            movieLists.Add("The Eagle", "Action");
            movieLists.Add("I am Number Four", "Sci-Fi");
            movieLists.Add("Footloose", "New Release");
            movieLists.Add("Real Steel", "New Release");

        }

        public Form PreviousForm
        {
            get
            {
                return _previousForm;
            }

            set
            {
                _previousForm = value;
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();
            orderForm.PreviousForm = this;
            orderForm.Show();
            this.Hide();
        }

        private void MoviesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.NextButton.Enabled = true;

            Movie.Title = this.MoviesListBox.SelectedItem.ToString();
            this.MovieTitleTextBox.Text = Movie.Title;

            Movie.Category = movieLists[Movie.Title];
            this.CategoryTextBox.Text = Movie.Category;

            Movie.Cost = categoryPrice[Movie.Category];
            this.CostTextBox.Text = Movie.Cost.ToString();
        }

        private void SelectionForm_Load(object sender, EventArgs e)
        {
            foreach (KeyValuePair<string, string> entry in movieLists)
            {
                MoviesListBox.Items.Add(entry.Key);
                // do something with entry.Value or entry.Key
            }
        }
    }
}

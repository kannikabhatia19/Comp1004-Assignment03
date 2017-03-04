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
    public partial class OrderForm : Form
    {
        private SelectionForm _previousForm;

        public OrderForm()
        {
            InitializeComponent();
        }

        public SelectionForm PreviousForm
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

        private void StreamButton_Click(object sender, EventArgs e)
        {
            StreamForm streamForm = new StreamForm();
            streamForm.PreviousForm = this;
            streamForm.Show();
            this.Hide();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.PreviousForm.Show();
            this.Hide();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            MovieTitleTextBox.Text = Movie.Title;
            MovieCategoryTextBox.Text = Movie.Category;
            MovieCostTextBox.Text = Movie.Cost.ToString();
            _costAdjusting();
        }

        private void _costAdjusting() {
            if (DVDCheckBox.Checked)
            {
                Movie.SubTotal = Movie.Cost + 10.00;
                SubTotalTextBox.Text = Movie.SubTotal.ToString();

            }
            else
            {
                Movie.SubTotal = Movie.Cost;
                SubTotalTextBox.Text = Movie.SubTotal.ToString();
            }

            Movie.SalesTax = Movie.SubTotal * 0.13;
            SalesTaxTextBox.Text = Movie.SalesTax.ToString();

            Movie.GrandTotal = Movie.SubTotal + Movie.SalesTax;
            GrandTotalTextBox.Text = Movie.GrandTotal.ToString();
        }

        private void DVDCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (DVDCheckBox.Checked)
            {
                DVDLabel.Visible = true;
                DVDTextBox.Visible = true;
                DVDTextBox.Text = "10.00";
            }
            else
            {
                DVDLabel.Visible = false;
                DVDTextBox.Visible = false;
            }
            _costAdjusting();
        }

        private void PrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your order form is printing...", "Print Preview", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to cancel?", "Cancel",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                this.PreviousForm.PreviousForm.Close();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}

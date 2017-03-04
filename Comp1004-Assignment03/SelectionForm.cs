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
        Movie movieSelected;

        public SelectionForm()
        {
            InitializeComponent();
            movieSelected = new Movie();
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
    }
}

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
    public partial class StreamForm : Form
    {
        private OrderForm _previousForm;

        public StreamForm()
        {
            InitializeComponent();
        }

        public OrderForm PreviousForm
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

        private void OKButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StreamForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure?", "Confirm", 
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                this.PreviousForm.PreviousForm.PreviousForm.Close();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void StreamForm_Load(object sender, EventArgs e)
        {
            DollarLabel.Text = Movie.GrandTotal.ToString();
            MovieLabel.Text = Movie.Title;
        }
    }
}

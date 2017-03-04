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
    }
}

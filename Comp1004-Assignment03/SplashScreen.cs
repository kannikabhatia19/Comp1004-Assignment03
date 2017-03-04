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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreenTimer_Tick(object sender, EventArgs e)
        {
            SelectionForm selectionForm = new SelectionForm();

            selectionForm.PreviousForm = this;

            this.SplashScreenTimer.Enabled = false;

            selectionForm.Show();

            this.Hide();
        }
    }
}

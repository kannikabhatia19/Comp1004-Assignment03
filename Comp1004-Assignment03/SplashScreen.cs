﻿/*
 App's Name: Movie Bonanza
 Author's Name: Kannika Bhatia
 Student ID: 200332992
 App's Creation Date: 4th March 2017
 App Description: Movie rental application that has the movie's selection form,
 order form, confirmation form
 */

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
        //CONSTRUCTOR+++++++++++++++++++++++++++++++++++++++++++++++++++++
        public SplashScreen()
        {
            InitializeComponent();
        }

        //EVENT HANDLERS++++++++++++++++++++++++++++++++++++++++
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

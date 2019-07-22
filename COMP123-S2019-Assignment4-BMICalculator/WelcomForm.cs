using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Assignment4_BMICalculator
{
    /// <summary>
    /// This form will be shown first when the user open this application with welcome message.
    /// After 3 seconds, this form will be hidden.
    /// </summary>
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// After interval done(3second), timer will be disabled
        /// and Welcome Form will be hidden, and BMI Calculator Form will be shown
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            SplashTimer.Enabled = false;
            Program.welcomeForm.Hide();
            Program.bMICalculator.Show();
        }

        /// <summary>
        /// when Welcome Form is loaded, timer will be on
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WelcomeForm_Load(object sender, EventArgs e)
        {
            SplashTimer.Enabled = true;
        }
    }
}

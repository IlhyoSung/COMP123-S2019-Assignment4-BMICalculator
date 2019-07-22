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
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            SplashTimer.Enabled = false;
            Program.welcomeForm.Hide();
            Program.bMICalculator.Show();
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {
            SplashTimer.Enabled = true;
        }
    }
}

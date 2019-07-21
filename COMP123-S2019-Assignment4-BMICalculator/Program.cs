﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

// Name: Ilhyo Sung
// Student number: 301001793
// Date last modified: 21/07/2019
// Program description: This program will accept weight, height from user and calculate user's BMI.
// Revision history
// 21/07/2019 Create UI

namespace COMP123_S2019_Assignment4_BMICalculator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BMICalculator());
        }
    }
}
